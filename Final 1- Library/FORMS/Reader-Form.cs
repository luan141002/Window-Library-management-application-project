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
    public partial class Reader_Form : Form
    {
        bool AddTerm;
        BL_Reader dbRe = new BL_Reader();
        string gender;
        public Reader_Form()
        {
            InitializeComponent();
        }
        public void LoadData(int index)
        {
            try
            {
                if (index == 0)
                {
                    dgvREADER.DataSource = dbRe.Take_Reader();
                    dgvREADER.AutoResizeColumns();
                    dgvREADER.AutoResizeRows();
                }
                if (index == 1)
                {
                    dgvREADER.DataSource = dbRe.GetObjectByID(int.Parse(this.txt_Find.Text));
                    dgvREADER.AutoResizeColumns();
                    dgvREADER.AutoResizeRows();
                }
                if (index == 2)
                {
                    dgvREADER.DataSource = dbRe.GetObjectByName(this.txt_Find.Text);
                    dgvREADER.AutoResizeColumns();
                    dgvREADER.AutoResizeRows();
                }
                if (index == 3)
                {
                    dgvREADER.DataSource = dbRe.GetObjectByCCCD(int.Parse(this.txt_Find.Text));
                    dgvREADER.AutoResizeColumns();
                    dgvREADER.AutoResizeRows();
                }
                //// Đưa dữ liệu lên DataGridView
                //dgvREADER.DataSource = dbRe.Take_Reader();
                //// Thay đổi độ rộng cột
                //dgvREADER.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_IDReader.ResetText();
                this.txt_NameReader.ResetText();
                this.Dtp_BirthdayReader.ResetText();
                this.Cb_Male.Checked = false;
                this.Cb_female.Checked = false;
                this.txt_CCCD.ResetText();
                this.txt_PhoneReader.ResetText();
                this.txt_AddressReader.ResetText();
                this.txt_Nbook.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_Save.Enabled = false;
                this.panel_infor.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_Add.Enabled = true;
                this.btn_Edit.Enabled = true;
                this.btn_delete.Enabled = true;
                //
                dgvREADER_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void dgvREADER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvREADER.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_IDReader.Text =
            dgvREADER.Rows[r].Cells[0].Value.ToString();
            this.txt_NameReader.Text =
            dgvREADER.Rows[r].Cells[1].Value.ToString().Trim();
            this.Dtp_BirthdayReader.Text =
            dgvREADER.Rows[r].Cells[2].Value.ToString();
            if (dgvREADER.Rows[r].Cells[3].Value.ToString() == "male")
            {
                this.Cb_Male.Checked = true;
                this.Cb_female.Checked = false;
            }
            else
            {
                this.Cb_Male.Checked = false;
                this.Cb_female.Checked = true;
            }     
            this.txt_CCCD.Text =
            dgvREADER.Rows[r].Cells[4].Value.ToString();
            this.txt_PhoneReader.Text =
            dgvREADER.Rows[r].Cells[5].Value.ToString();
            this.txt_AddressReader.Text =
            dgvREADER.Rows[r].Cells[6].Value.ToString();
            this.txt_Nbook.Text =
            dgvREADER.Rows[r].Cells[7].Value.ToString();

        }
        private void Reader_Form_Load(object sender, EventArgs e)
        {
            btn_Reader.Image = Image.FromFile("../../IMAGES/reading.png");
            btn_Add.Image = Image.FromFile("../../IMAGES/add-file.png");
            btn_Edit.Image = Image.FromFile("../../IMAGES/edit.png");
            btn_delete.Image = Image.FromFile("../../IMAGES/dustbin.png");
            btn_Save.Image = Image.FromFile("../../IMAGES/floppy-disk.png");
            btn_Back.Image = Image.FromFile("../../IMAGES/back.png");
            btn_PrintDT.Image = Image.FromFile("../../IMAGES/printer2.png");

            this.txt_Nbook.Enabled = false;

            Lb_typeFind.Items.Add("ID Reader");
            Lb_typeFind.Items.Add("Name");
            Lb_typeFind.Items.Add("Identify ID");
          

            LoadData(0);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTerm = true;
            LoadData(0);
            // Xóa trống các đối tượng trong Panel
            this.txt_IDReader.ResetText();
            this.txt_NameReader.ResetText();
            this.Dtp_BirthdayReader.ResetText();
            this.Cb_Male.Checked = false;
            this.Cb_female.Checked = false;
            this.txt_CCCD.ResetText();
            this.txt_PhoneReader.ResetText();
            this.txt_AddressReader.ResetText();
            this.txt_Nbook.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.txt_IDReader.Enabled = true;
            this.panel_infor.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDReader.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Cb_Male.Checked == true)
            {
                gender = "male";
            }
            else if (this.Cb_female.Checked == true)
            {
                gender = "female";
            }
            // Mở kết nối
            // Thêm dữ liệu
            if (AddTerm)
            {
                try
                {
                    
                    // Thực hiện lệnh
                    BL_Reader dbRe = new BL_Reader();
                    dbRe.Add_Reader(int.Parse(this.txt_IDReader.Text), this.txt_NameReader.Text, this.Dtp_BirthdayReader.Value,gender, int.Parse(this.txt_CCCD.Text), int.Parse(this.txt_PhoneReader.Text),this.txt_AddressReader.Text);
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
                BL_Reader dbRe = new BL_Reader();
                dbRe.Edit_Reader(int.Parse(this.txt_IDReader.Text), this.txt_NameReader.Text, this.Dtp_BirthdayReader.Value, gender, int.Parse(this.txt_CCCD.Text), int.Parse(this.txt_PhoneReader.Text), this.txt_AddressReader.Text, int.Parse(this.txt_Nbook.Text));
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
           
            this.panel_author.Enabled = true;
            this.dgvREADER_CellClick(null, null);
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;

            this.panel_infor.Enabled = true;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDReader.Enabled = false;
            this.txt_NameReader.Focus();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            try
            {

                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvREADER.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strREADER =
                 dgvREADER.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbRe.Delete_Reader(int.Parse(strREADER));
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

        private void dgvREADER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvREADER_CellClick(null, null);
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cb_Male.Checked == true)
            {
                gender = "male";
                this.Cb_female.Enabled = false;
            }
            else if (this.Cb_Male.Checked == false)
            {
                gender = "";
                this.Cb_female.Enabled = true;
            }

        }

        private void Cb_female_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cb_female.Checked == true)
            {
                gender = "female";
                this.Cb_Male.Enabled = false;
            }
            else if (this.Cb_female.Checked == false)
            {
                gender = "";
                this.Cb_Male.Enabled = true;
            }
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (Lb_typeFind.SelectedIndex ==0)
            {
                LoadData(1);
            }
            if (Lb_typeFind.SelectedIndex == 1)
            {
                LoadData(2);
            }
            if (Lb_typeFind.SelectedIndex == 2)
            {
                LoadData(3);
            }

        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.dgvREADER.Width, this.dgvREADER.Height, this.dgvREADER.CreateGraphics());
            dgvREADER.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvREADER.Width, this.dgvREADER.Height));
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
