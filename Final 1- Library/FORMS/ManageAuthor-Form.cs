using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_1__Library.CLASSES;

namespace Final_1__Library.FORMS
{
    public partial class ManageAuthor_Form : Form
    {
        bool AddTerm;
        BL_Author dbAu = new BL_Author();
        public ManageAuthor_Form()
        {
            InitializeComponent();
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthor_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library3DataSet.AUTHOR' table. You can move, or remove it, as needed.
           // this.aUTHORTableAdapter.Fill(this.library3DataSet.AUTHOR);
            btn_Author.Image = Image.FromFile("../../IMAGES/Editor.png");
            btn_Add.Image = Image.FromFile("../../IMAGES/add-file.png");
            btn_Edit.Image = Image.FromFile("../../IMAGES/edit.png");
            btn_delete.Image = Image.FromFile("../../IMAGES/dustbin.png");
            btn_Save.Image = Image.FromFile("../../IMAGES/floppy-disk.png");
            btn_Back.Image = Image.FromFile("../../IMAGES/back.png");
            btn_PrintDT.Image = Image.FromFile("../../IMAGES/printer2.png");

            Lb_typeFind.Items.Add("ID Author");
            Lb_typeFind.Items.Add("Name");

            LoadData(0);
        }
        public void LoadData(int index)
        {
            try
            {
                if (index == 0)
                {
                    dgvAUTHOR.DataSource = dbAu.TakeAuthor();
                    dgvAUTHOR.AutoResizeColumns();
                    dgvAUTHOR.AutoResizeRows();
                }
                if (index == 1)
                {
                    dgvAUTHOR.DataSource = dbAu.GetObjectByID(int.Parse(this.txt_Find.Text));
                    dgvAUTHOR.AutoResizeColumns();
                    dgvAUTHOR.AutoResizeRows();
                }
                if (index == 2)
                {
                    dgvAUTHOR.DataSource = dbAu.GetObjectByName(this.txt_Find.Text);
                    dgvAUTHOR.AutoResizeColumns();
                    dgvAUTHOR.AutoResizeRows();
                }

                // Đưa dữ liệu lên DataGridView
                //dgvAUTHOR.DataSource = dbAu.TakeAuthor();
                //// Thay đổi độ rộng cột
                //dgvAUTHOR.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_ID.ResetText();
                this.txt_Name.ResetText();
                this.txt_Phone.ResetText();
                this.txt_Address.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_Save.Enabled = false;
                
                this.panel_infor.Enabled = false;
                
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_Add.Enabled = true;
                this.btn_Edit.Enabled = true;
                this.btn_delete.Enabled = true;
                //
                dgvAUTHOR_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void dgvAUTHOR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvAUTHOR.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_ID.Text =
            dgvAUTHOR.Rows[r].Cells[0].Value.ToString();
            this.txt_Name.Text =
            dgvAUTHOR.Rows[r].Cells[1].Value.ToString();
            this.txt_Phone.Text =
            dgvAUTHOR.Rows[r].Cells[2].Value.ToString();
            this.txt_Address.Text =
            dgvAUTHOR.Rows[r].Cells[3].Value.ToString();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTerm = true;
            LoadData(0);
            // Xóa trống các đối tượng trong Panel
            this.txt_ID.ResetText();
            this.txt_Name.ResetText();
            this.txt_Phone.ResetText();
            this.txt_Address.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.txt_ID.Enabled = true;
            this.panel_infor.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_ID.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (AddTerm)
            {
                try
                {
                    // Thực hiện lệnh
                    BL_Author blAu = new BL_Author();
                    blAu.AddAuthor(int.Parse(this.txt_ID.Text), this.txt_Name.Text, int.Parse(this.txt_Phone.Text), this.txt_Address.Text) ;
                    // Load lại dữ liệu trên DataGridView
                    LoadData(0);
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BL_Author blAu = new BL_Author();
                blAu.EditAuthor(int.Parse(this.txt_ID.Text), this.txt_Name.Text, int.Parse(this.txt_Phone.Text), this.txt_Address.Text);
                // Load lại dữ liệu trên DataGridView
                LoadData(0);
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            AddTerm = false;
            LoadData(0);
            this.panel_author.Enabled = true;
            this.dgvAUTHOR_CellClick(null, null);
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;

            this.panel_infor.Enabled = true;
            
            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_ID.Enabled = false;
            this.txt_Name.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvAUTHOR.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strAUTHOR =
                dgvAUTHOR.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Are you sure to delete this object??? , It will delete all infor relate to this object", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbAu.Delete_Author(int.Parse(strAUTHOR));
                    // Cập nhật lại DataGridView
                    LoadData(0);
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            LoadData(0);
        }

        private void dgvAUTHOR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAUTHOR_CellClick(null, null);
           
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (Lb_typeFind.Text == "ID Author")
            {
                LoadData(1);
            }
            if (Lb_typeFind.Text == "Name")
            {
                LoadData(2);
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb_typeFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.dgvAUTHOR.Width, this.dgvAUTHOR.Height, this.dgvAUTHOR.CreateGraphics());
            dgvAUTHOR.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvAUTHOR.Width, this.dgvAUTHOR.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        private void btn_PrintDT_Click(object sender, EventArgs e)
        {

            LoadData(0);
            //this.txt_Calborrow.Text = cal_BorrowBook(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value, this.Dtp_ReturnDate.Value, this.Dtp_Estimate.Value, this.Cb_Origin.Checked, this.Cb_Lost.Checked).ToString();
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }
    }
}
