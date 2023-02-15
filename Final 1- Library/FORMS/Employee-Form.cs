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
    public partial class Employee_Form : Form
    {
        bool AddTerm;
        BL_Employee dbEm = new BL_Employee();
        string gender;
        string position;
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library1010DataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.library1010DataSet.EMPLOYEES);
            btn_Employee.Image = Image.FromFile("../../IMAGES/Employee_button - Copy.png");
            btn_Add.Image = Image.FromFile("../../IMAGES/add-file.png");
            btn_Edit.Image = Image.FromFile("../../IMAGES/edit.png");
            btn_delete.Image = Image.FromFile("../../IMAGES/dustbin.png");
            btn_Save.Image = Image.FromFile("../../IMAGES/floppy-disk.png");
            btn_Back.Image = Image.FromFile("../../IMAGES/back.png");
            btn_PrintDT.Image = Image.FromFile("../../IMAGES/printer2.png");

            cmb_Position.Items.Add("Accountant");
            cmb_Position.Items.Add("Cashier");
            cmb_Position.Items.Add("Guard");


            Lb_typeFind.Items.Add("ID Employee");
            Lb_typeFind.Items.Add("Name");
            Lb_typeFind.Items.Add("Identify ID");
            Lb_typeFind.Items.Add("Position");
            


            LoadData(0);
        }
        public void LoadData(int index)
        {
            try
            {
                if (index == 0)
                {
                    dgvEMPLOYEE.DataSource = dbEm.Take_Employee();
                   // dgvEMPLOYEE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEMPLOYEE.AutoResizeColumns();
                    dgvEMPLOYEE.AutoResizeRows();
                }
                if (index == 1)
                {
                    dgvEMPLOYEE.DataSource = dbEm.GetObjectByID(int.Parse(this.txt_IDEm.Text));
                    dgvEMPLOYEE.AutoResizeColumns();
                    dgvEMPLOYEE.AutoResizeRows();
                }
                if (index == 2)
                {
                    dgvEMPLOYEE.DataSource = dbEm.GetObjectByName(this.txt_NameEm.Text.Trim());
                    dgvEMPLOYEE.AutoResizeColumns();
                    dgvEMPLOYEE.AutoResizeRows();
                }
                if (index == 3)
                {
                    dgvEMPLOYEE.DataSource = dbEm.GetObjectByCCCD(int.Parse(this.txt_CCCD.Text));
                    dgvEMPLOYEE.AutoResizeColumns();
                    dgvEMPLOYEE.AutoResizeRows();
                }
                if (index == 4)
                {
                    dgvEMPLOYEE.DataSource = dbEm.GetObjectByPosition(this.position.Trim());
                    dgvEMPLOYEE.AutoResizeColumns();
                    dgvEMPLOYEE.AutoResizeRows();
                }
                // Đưa dữ liệu lên DataGridView
                //dgvEMPLOYEE.DataSource = dbEm.Take_Employee();
                //// Thay đổi độ rộng cột
                //dgvEMPLOYEE.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_IDEm.ResetText();
                this.txt_NameEm.ResetText();
                this.Cb_Male.Checked = false;
                this.Cb_female.Checked = false;
                this.txt_CCCD.ResetText();
                this.txt_PhoneEm.ResetText();
                this.txt_AddressEm.ResetText();
                this.cmb_Position.ResetText();
                this.txt_WorkingTime.ResetText();
                this.txt_Extra.ResetText();
                this.Rb_Accountant.Enabled = false;
                this.Rb_Cashier.Enabled = false;
                this.Rb_Guard.Enabled = false;
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_Save.Enabled = false;
                this.txt_Salary.Enabled = false;
                this.panel_infor.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_Add.Enabled = true;
                this.btn_Edit.Enabled = true;
                this.btn_delete.Enabled = true;
                //
                dgvEMPLOYEE_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Can not take the data table. Error!!!");
            }
        }
        private void dgvEMPLOYEE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvEMPLOYEE.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_IDEm.Text =
            dgvEMPLOYEE.Rows[r].Cells[0].Value.ToString();
            this.txt_NameEm.Text =
            dgvEMPLOYEE.Rows[r].Cells[1].Value.ToString();
            string a = dgvEMPLOYEE.Rows[r].Cells[2].Value.ToString();
            if ( a.TrimEnd() == "male")
            {
                this.Cb_Male.Checked = true;
                this.Cb_female.Checked = false;
            }
            if (a.TrimEnd() == "female")
            {
                this.Cb_Male.Checked = false;
                this.Cb_female.Checked = true;
            }
            this.txt_CCCD.Text = 
            dgvEMPLOYEE.Rows[r].Cells[3].Value.ToString();
            this.txt_PhoneEm.Text =
            dgvEMPLOYEE.Rows[r].Cells[4].Value.ToString();
            this.txt_AddressEm.Text =
            dgvEMPLOYEE.Rows[r].Cells[5].Value.ToString();
            this.cmb_Position.Text =
            dgvEMPLOYEE.Rows[r].Cells[6].Value.ToString().TrimEnd();
            this.txt_Salary.Text =
            dgvEMPLOYEE.Rows[r].Cells[7].Value.ToString();
            this.txt_WorkingTime.Text =
            dgvEMPLOYEE.Rows[r].Cells[8].Value.ToString();
            this.txt_Extra.Text =
            dgvEMPLOYEE.Rows[r].Cells[9].Value.ToString();

        }
        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTerm = true;
            LoadData(0);
            // Xóa trống các đối tượng trong Panel
            this.txt_IDEm.ResetText();
            this.txt_NameEm.ResetText();
            this.Cb_Male.Checked = false;
            this.Cb_female.Checked = false;
            this.txt_CCCD.ResetText();
            this.txt_PhoneEm.ResetText();
            this.txt_AddressEm.ResetText();
            this.cmb_Position.ResetText();
            this.txt_WorkingTime.ResetText();
            this.txt_Extra.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.txt_IDEm.Enabled = true;
            this.txt_Salary.Enabled = false;
            this.panel_infor.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDEm.Focus();
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
                    BL_Employee dbEm = new BL_Employee();
                    dbEm.Add_Employee(int.Parse(this.txt_IDEm.Text), this.txt_NameEm.Text, gender, int.Parse(this.txt_CCCD.Text), int.Parse(this.txt_PhoneEm.Text), this.txt_AddressEm.Text, this.cmb_Position.Text, int.Parse(txt_WorkingTime.Text), int.Parse(txt_Extra.Text));
                    // Load lại dữ liệu trên DataGridView
                    LoadData(0);
                    // Thông báo
                    MessageBox.Show("Added!");
                }
                catch
                {
                    MessageBox.Show("Can't add. Error!!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BL_Employee dbEm = new BL_Employee();
                dbEm.Edit_Employee(int.Parse(this.txt_IDEm.Text), this.txt_NameEm.Text, gender, int.Parse(this.txt_CCCD.Text), int.Parse(this.txt_PhoneEm.Text), this.txt_AddressEm.Text, this.cmb_Position.Text, int.Parse(txt_WorkingTime.Text), int.Parse(txt_Extra.Text));
                // Load lại dữ liệu trên DataGridView
                LoadData(0);
                // Thông báo
                MessageBox.Show("Has Fixed!");
            }
            // Đóng kết nối 
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            AddTerm = false;
            LoadData(0);
            this.panel_author.Enabled = true;
            this.dgvEMPLOYEE_CellClick(null, null);
            this.txt_Salary.Enabled = false;
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;

            this.panel_infor.Enabled = true;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDEm.Enabled = false;
            this.txt_NameEm.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvEMPLOYEE.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strREADER =
                 dgvEMPLOYEE.Rows[r].Cells[0].Value.ToString();
                string strREADER1 =
                 dgvEMPLOYEE.Rows[r].Cells[1].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Are you sure to delete this Book?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbEm.Delete_Employee(int.Parse(strREADER), strREADER1);
                    // Cập nhật lại DataGridView
                    LoadData(0);
                    // Thông báo
                    MessageBox.Show("Deleted an object!!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Cannot delete this book. Error!!");
                }

            }
            catch
            {
                MessageBox.Show("Cannot delete this book. Error!!");
            }
        }
      
        private void btn_Back_Click(object sender, EventArgs e)
        {
            LoadData(0);
        }

        private void dgvEMPLOYEE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEMPLOYEE_CellClick(null, null);
        }

        private void Cb_female_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Cb_female.Checked == true)
            {
                gender = "female";
                this.Cb_Male.Enabled = false;
            }
            else if (this.Cb_female.Checked == false)
            {
                gender = "male";
                this.Cb_Male.Enabled = true;
            }
        }

        private void Cb_Male_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Cb_Male.Checked == true)
            {
                gender = "male";
                this.Cb_female.Enabled = false;
            }
            else if (this.Cb_Male.Checked == false)
            {
                gender = "female";
                this.Cb_female.Enabled = true;
            }
        }

        private void Lb_typeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lb_typeFind.SelectedIndex == 3)
            {
                this.Rb_Accountant.Enabled = true;
                this.Rb_Cashier.Enabled = true;
                this.Rb_Guard.Enabled = true;

            }
        }

        private void Rb_Cashier_CheckedChanged(object sender, EventArgs e)
        {
            if(Rb_Cashier.Checked == true)
            {
                position = "Cashier";
                this.Rb_Guard.Checked = false;
                this.Rb_Accountant.Checked = false;
            }
        }

        private void Rb_Guard_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Cashier.Checked == true)
            {
                position = "Guard";
                this.Rb_Guard.Checked = false;
                this.Rb_Accountant.Checked = false;
            }
        }

        private void Rb_Accountant_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Accountant.Checked == true)
            {
                position = "Accountant";
                this.Rb_Guard.Checked = false;
                this.Rb_Cashier.Checked = false;
            }
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if(Lb_typeFind.SelectedIndex == 0 )
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
            if (Lb_typeFind.SelectedIndex == 3)
            {
                LoadData(4);
            }
        }

        private void txt_Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Report.EmSaRecs emSaRecs = new Report.EmSaRecs();
            emSaRecs.Show();
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.dgvEMPLOYEE.Width, this.dgvEMPLOYEE.Height, this.dgvEMPLOYEE.CreateGraphics());
            dgvEMPLOYEE.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvEMPLOYEE.Width, this.dgvEMPLOYEE.Height));
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
