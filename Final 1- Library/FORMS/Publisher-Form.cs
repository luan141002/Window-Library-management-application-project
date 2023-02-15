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
    public partial class Publisher_Form : Form
    {
        bool AddTerm;
        BL_Publisher dbPu = new BL_Publisher();
        public Publisher_Form()
        {
            InitializeComponent();
        }
        public void LoadData(int index)
        {
            try
            {
                if (index == 0)
                {
                    dgvPUBLISHER.DataSource = dbPu.Take_Publisher();
                    dgvPUBLISHER.AutoResizeColumns();
                    dgvPUBLISHER.AutoResizeRows();
                }
                if (index == 1)
                {
                    dgvPUBLISHER.DataSource = dbPu.GetObjectByID(int.Parse(this.txt_Find.Text));
                    dgvPUBLISHER.AutoResizeColumns();
                    dgvPUBLISHER.AutoResizeRows();
                }
                if (index == 2)
                {
                    dgvPUBLISHER.DataSource = dbPu.GetObjectByName(this.txt_Find.Text);
                    dgvPUBLISHER.AutoResizeColumns();
                    dgvPUBLISHER.AutoResizeRows();
                }
                //    // Đưa dữ liệu lên DataGridView
                //    dgvPUBLISHER.DataSource = dbPu.Take_Publisher();
                //// Thay đổi độ rộng cột
                //dgvPUBLISHER.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_IDPub.ResetText();
                this.txt_NamePub.ResetText();
                this.txt_PhonePub.ResetText();
                this.txt_EmailPub.ResetText();
                this.txt_AddressPub.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_Save.Enabled = false;
                this.panel_infor.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_Add.Enabled = true;
                this.btn_Edit.Enabled = true;
                this.btn_delete.Enabled = true;
                //
               dgvPUBLISHER_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void dgvPUBLISHER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvPUBLISHER.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_IDPub.Text =
            dgvPUBLISHER.Rows[r].Cells[0].Value.ToString();
            this.txt_NamePub.Text =
            dgvPUBLISHER.Rows[r].Cells[1].Value.ToString();
            this.txt_PhonePub.Text =
            dgvPUBLISHER.Rows[r].Cells[2].Value.ToString();
            this.txt_EmailPub.Text =
            dgvPUBLISHER.Rows[r].Cells[3].Value.ToString();
            this.txt_AddressPub.Text =
            dgvPUBLISHER.Rows[r].Cells[4].Value.ToString();
        }
        private void Publisher_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library3DataSet1.PUBLISHER' table. You can move, or remove it, as needed.
            //this.pUBLISHERTableAdapter.Fill(this.library3DataSet1.PUBLISHER);
            btn_Publisher.Image = Image.FromFile("../../IMAGES/publishing.png");
            btn_Add.Image = Image.FromFile("../../IMAGES/add-file.png");
            btn_Edit.Image = Image.FromFile("../../IMAGES/edit.png");
            btn_delete.Image = Image.FromFile("../../IMAGES/dustbin.png");
            btn_Save.Image = Image.FromFile("../../IMAGES/floppy-disk.png");
            btn_Back.Image = Image.FromFile("../../IMAGES/back.png");
            btn_PrintDT.Image = Image.FromFile("../../IMAGES/printer2.png");

            Lb_typeFind.Items.Add("ID Publisher");
            Lb_typeFind.Items.Add("Name");

            LoadData(0);
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTerm = true;
            LoadData(0);
            // Xóa trống các đối tượng trong Panel
            this.txt_IDPub.ResetText();
            this.txt_NamePub.ResetText();
            this.txt_PhonePub.ResetText();
            this.txt_EmailPub.ResetText();
            this.txt_AddressPub.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.txt_IDPub.Enabled = true;
            this.panel_infor.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDPub.Focus();
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
                    BL_Publisher dbPu = new BL_Publisher();
                    dbPu.Add_Publisher(int.Parse(this.txt_IDPub.Text), this.txt_NamePub.Text, int.Parse(this.txt_PhonePub.Text),this.txt_EmailPub.Text, this.txt_AddressPub.Text);
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
                BL_Publisher dbPu = new BL_Publisher();
                dbPu.Edit_Publisher(int.Parse(this.txt_IDPub.Text), this.txt_NamePub.Text, int.Parse(this.txt_PhonePub.Text), this.txt_EmailPub.Text, this.txt_AddressPub.Text);
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
            this.dgvPUBLISHER_CellClick(null, null);
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;

            this.panel_infor.Enabled = true;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDPub.Enabled = false;
            this.txt_NamePub.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvPUBLISHER.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strPUBLISHER =
                dgvPUBLISHER.Rows[r].Cells[0].Value.ToString();
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
                    dbPu.Delete_Publisher(int.Parse(strPUBLISHER));
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

        private void dgvPUBLISHER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPUBLISHER_CellClick(null, null);
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (Lb_typeFind.Text == "ID Publisher" )
            {
                LoadData(1);
            }
            if (Lb_typeFind.Text == "Name")
            {
                LoadData(2);
            }
            
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.dgvPUBLISHER.Width, this.dgvPUBLISHER.Height, this.dgvPUBLISHER.CreateGraphics());
            dgvPUBLISHER.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvPUBLISHER.Width, this.dgvPUBLISHER.Height));
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
