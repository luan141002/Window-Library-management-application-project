using Final_1__Library.CLASSES;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Final_1__Library.FORMS
{
    public partial class Borrow_Form : Form
    {
        bool AddTerm;
        bool Lost ;
        bool Fixed ;
        bool returnterm;
        BL_BorrowedBook dbHi = new BL_BorrowedBook();
        public Borrow_Form()
        {
            InitializeComponent();
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadData(int index)
        {
            try
            {
                if (index == 0)
                {
                    dgvHISTORY.DataSource = dbHi.Take_BorrowedBook();
                    dgvHISTORY.AutoResizeColumns();
                    dgvHISTORY.AutoResizeRows();
                }
                if (index == 1)
                {
                    dgvHISTORY.DataSource = dbHi.GetObjectByIDReader(int.Parse(this.txt_Find.Text));
                    dgvHISTORY.AutoResizeColumns();
                    dgvHISTORY.AutoResizeRows();
                }
                if (index == 2)
                {
                    dgvHISTORY.DataSource = dbHi.GetObjectByIDBook(int.Parse(this.txt_Find.Text));
                    dgvHISTORY.AutoResizeColumns();
                    dgvHISTORY.AutoResizeRows();
                }
                if (index == 3)
                {
                    dgvHISTORY.DataSource = dbHi.Take_BorrowedBook();
                    dgvHISTORY.AutoResizeColumns();
                    dgvHISTORY.AutoResizeRows();
                    this.pan_return.Visible = false;
                    this.btn_print.Visible = false;
                    this.btn_return.Enabled = false;
                }
                //// Đưa dữ liệu lên DataGridView
                //dgvHISTORY.DataSource = dbHi.Take_BorrowedBook();
                //// Thay đổi độ rộng cột
                //dgvHISTORY.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_IDReader.ResetText();
                this.txt_IDBook.ResetText();
                this.Dtp_BorrowDate.ResetText();
                this.Dtp_Estimate.ResetText();
                this.Dtp_ReturnDate.ResetText();
                this.txt_ExtraFee.ResetText();
                this.Cb_Origin.Checked = false;
                this.Cb_Fixed.Checked = false;
                this.Cb_NLost.Checked = false;
                this.Cb_Lost.Checked = false;
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_Save.Enabled = false;
                this.panel_infor.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_Add.Enabled = true;
                this.btn_Edit.Enabled = true;
                this.btn_delete.Enabled = true;
               
                //
                dgvHISTORY_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Can not take the data table. Error!!");
            }
        }
        private void dgvHISTORY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvHISTORY.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_IDReader.Text =
            dgvHISTORY.Rows[r].Cells[0].Value.ToString();
            this.txt_IDBook.Text =
            dgvHISTORY.Rows[r].Cells[1].Value.ToString();
            this.Dtp_BorrowDate.Text =
            dgvHISTORY.Rows[r].Cells[2].Value.ToString();
            this.Dtp_Estimate.Text =
            dgvHISTORY.Rows[r].Cells[3].Value.ToString();
            this.Dtp_ReturnDate.Text =
            dgvHISTORY.Rows[r].Cells[4].Value.ToString();
            this.txt_ExtraFee.Text =
            dgvHISTORY.Rows[r].Cells[5].Value.ToString();
            if (dgvHISTORY.Rows[r].Cells[6].Value.ToString() == "True")
            {
                this.Cb_Origin.Checked = true;
                this.Cb_Fixed.Checked = false;
            }
            else if (dgvHISTORY.Rows[r].Cells[6].Value.ToString() == "False")
            {
                this.Cb_Origin.Checked = false;
                this.Cb_Fixed.Checked = true;
            }
            if (dgvHISTORY.Rows[r].Cells[7].Value.ToString() == "True")
            {
                this.Cb_Lost.Checked = true;
                this.Cb_NLost.Checked = false;
            }
            else if (dgvHISTORY.Rows[r].Cells[7].Value.ToString() == "False")
            { 
                this.Cb_Lost.Checked = false;
                this.Cb_NLost.Checked = true;
            }
            
        }

        private void History_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library1012DataSet1.Borrow_Book' table. You can move, or remove it, as needed.
            this.borrow_BookTableAdapter.Fill(this.library1012DataSet1.Borrow_Book);
            // TODO: This line of code loads data into the 'library3DataSet2.HISTORY' table. You can move, or remove it, as needed.
            
            btn_Author.Image = Image.FromFile("../../IMAGES/history.png");
            btn_Add.Image = Image.FromFile("../../IMAGES/add-file.png");
            btn_Edit.Image = Image.FromFile("../../IMAGES/edit.png");
            btn_delete.Image = Image.FromFile("../../IMAGES/dustbin.png");
            btn_Save.Image = Image.FromFile("../../IMAGES/floppy-disk.png");
            btn_Back.Image = Image.FromFile("../../IMAGES/back.png");
            btn_PrintDT.Image = Image.FromFile("../../IMAGES/printer2.png");

            txt_Calborrow.Enabled = false;
            this.Dtp_ReturnDate.Enabled = false;
            this.txt_ExtraFee.Enabled = false;
            this.pan_return.Visible = false;
            this.btn_print.Visible = false;
            this.btn_return.Enabled = false;

            Lb_typeFind.Items.Add("ID Reader");
            Lb_typeFind.Items.Add("ID Book");

            LoadData(0);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTerm = true;
            LoadData(0);
            // Xóa trống các đối tượng trong Panel
            this.txt_IDReader.ResetText();
            this.txt_IDBook.ResetText();
            this.Dtp_BorrowDate.ResetText();
            this.Dtp_Estimate.ResetText();
            this.Dtp_ReturnDate.ResetText();
            this.txt_ExtraFee.ResetText();
            this.Cb_Origin.Checked = false;
            this.Cb_Fixed.Checked = false;
            this.Cb_NLost.Checked = false;
            this.Cb_Lost.Checked = false;
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
            // Mở kết nối
            // Thêm dữ liệu
            if (Cb_Lost.Checked == true && Cb_NLost.Checked == false) Lost = true;
            else if (Cb_Lost.Checked == false && Cb_NLost.Checked == true) Lost = false;
            if (Cb_Fixed.Checked == true && Cb_Origin.Checked == false) Fixed = true;
            else if (Cb_Fixed.Checked == false && Cb_Origin.Checked == true) Fixed = false;

            if (AddTerm)
            {
                try
                {
                    // Thực hiện lệnh
                    BL_BorrowedBook dbHi = new BL_BorrowedBook();
                    //using (QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities())
                    //{
                    //    qltvEntity.HISTORies.Add(new HISTORY() {ID_Rd = int.Parse(this.txt_IDReader.Text), ID_Book= int.Parse(this.txt_IDBook.Text),Borrowed_date =  this.Dtp_BorrowDate.Value,Returned_date =  this.Dtp_ReturnDate.Value, Extra_fee = int.Parse(this.txt_ExtraFee.Text) });
                    //}
                    if (Dtp_BorrowDate.Value > Dtp_Estimate.Value )
                    {
                        MessageBox.Show("The estimated day must after the borrowed day");
                        return;
                    }
                    dbHi.Add_BorrowedBooknotreturn(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value,this.Dtp_Estimate.Value);
                    // Load lại dữ liệu trên DataGridView
                    BL_Reader reader = new BL_Reader();
                    BL_Book book = new BL_Book();
                    reader.ChangeNBrBook(int.Parse(this.txt_IDReader.Text), 1);
                    book.Changenbook(int.Parse(this.txt_IDBook.Text), 2);
                    LoadData(3);
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
                BL_BorrowedBook dbHi = new BL_BorrowedBook();
                dbHi.Edit_BorrowedBook(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value, this.Dtp_Estimate.Value, this.Dtp_ReturnDate.Value, Lost, Fixed);
                // Load lại dữ liệu trên DataGridView
                LoadData(0);
               
                // Thông báo
                MessageBox.Show("Fixed!");
            }
            // Đóng kết nối 
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            AddTerm = false;
            
            this.panel_author.Enabled = true;
            this.dgvHISTORY_CellClick(null, null);
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.btn_return.Enabled = true;
            this.panel_infor.Enabled = true;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_IDReader.Enabled = false;
            this.txt_IDBook.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvHISTORY.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strHISTORY =
                dgvHISTORY.Rows[r].Cells[0].Value.ToString();
                string strHISTORY1 =
                dgvHISTORY.Rows[r].Cells[1].Value.ToString();
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
                    //dbHi.deleteAllId(int.Parse(strHISTORY1));
                    dbHi.Delete_BorrowedBook(int.Parse(strHISTORY), int.Parse(strHISTORY1));
                    BL_Reader reader = new BL_Reader();
                    BL_Book book = new BL_Book();
                    reader.ChangeNBrBook(int.Parse(this.txt_IDReader.Text), 2);
                    book.Changenbook(int.Parse(this.txt_IDBook.Text), 1);
                    // Cập nhật lại DataGridView
                    LoadData(0);
                    // Thông báo
                    MessageBox.Show("Deleted an object!!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Cannot delete this book!!");
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

        private void dgvHISTORY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHISTORY_CellClick(null, null);
            this.txt_Calborrow.Text = cal_BorrowBook(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value, this.Dtp_ReturnDate.Value, this.Dtp_Estimate.Value,this.Cb_Origin.Checked,this.Cb_Lost.Checked).ToString();
        }
        public int cal_BorrowBook(int id_re, int id_book,DateTime borrowday , DateTime returnday,DateTime estimateday,bool original,bool lost)
        {
            DataTable dt = new DataTable();
            BL_Book book = new BL_Book();
            int price = 0;
            dt = book.GetObjectByID(id_book);
            if (dt.Rows[0][8].ToString() == "")
            {
                price = 0;
            }
            else
            {
                price = int.Parse(dt.Rows[0][8].ToString());
            }
            
            int a = 0;
            
            try
            {
                if (returnday <= estimateday)
                {
                    a = (returnday - borrowday).Days * (price * (10/100));
                }
                if (returnday > estimateday)
                {
                    a = (estimateday - borrowday).Days * price + (returnday - estimateday).Days * 2;
                }
                if (original != true)
                {
                    a += a * (30 / 100);

                }
                if (lost == true )
                {
                    a = price;
                   // book.Changenbook(id_book,);
                }
                return a;
            }
            catch 
            {
                return 0;
            }

            
        }
       
        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (Lb_typeFind.Text == "ID Reader")
            {
                LoadData(1);
            }
            if (Lb_typeFind.Text == "ID Book")
            {
                LoadData(2);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Return now ??", "When the reader return book",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.Yes)
            {
                this.Dtp_ReturnDate.Value = DateTime.Now;
                // Cập nhật lại DataGridView
                // Thông báo
                MessageBox.Show("Return day is now");
                this.pan_return.Visible =true;
            }
            else
            {
                // Thông báo
                MessageBox.Show("Enter the return day!");
                this.Dtp_ReturnDate.Enabled = true;
                this.pan_return.Visible = true;
            }
            
            this.btn_print.Visible = true;
            
        }

        private void txt_Calborrow_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Reader_Form reader_Form = new Reader_Form();
            reader_Form.Show();
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.panel_infor.Width, this.panel_infor.Height, this.panel_infor.CreateGraphics());
            panel_infor.DrawToBitmap(bmp, new Rectangle(0, 0, this.panel_infor.Width, this.panel_infor.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            //LoadData(0);
            this.txt_ExtraFee.Text = dbHi.cal_ExtraFee(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value, this.Dtp_Estimate.Value, this.Dtp_ReturnDate.Value, this.Cb_Origin.Checked, this.Cb_Lost.Checked).ToString();
            this.txt_Calborrow.Text = cal_BorrowBook(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value, this.Dtp_ReturnDate.Value, this.Dtp_Estimate.Value, this.Cb_Origin.Checked, this.Cb_Lost.Checked).ToString();
            
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
            dbHi.Delete_BorrowedBook(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text));
            BL_Reader reader = new BL_Reader();
            BL_Book book = new BL_Book();
            reader.ChangeNBrBook(int.Parse(this.txt_IDReader.Text), 2);
            book.Changenbook(int.Parse(this.txt_IDBook.Text), 1);
            LoadData(3);
        }

        private void Cb_Origin_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Fixed.Checked == true)
            {
                Fixed = false;
                Cb_Origin.Checked = false;
            }
         
        }

        private void Cb_Fixed_CheckedChanged(object sender, EventArgs e)
            {
                if (Cb_Origin.Checked == true)
                {
                    Fixed = true;
                    Cb_Fixed.Checked = false;
                }
              
            }

        private void Cb_NLost_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Lost.Checked == true)
            {
               Lost = false;
               Cb_NLost.Checked = false;
            }
        }

        private void Cb_Lost_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_NLost.Checked == true)
            {
                Lost = true;
                Cb_Lost.Checked = false;
            }
        }
        private void doc_PrintPage2(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.dgvHISTORY.Width, this.dgvHISTORY.Height, this.dgvHISTORY.CreateGraphics());
            dgvHISTORY.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvHISTORY.Width, this.dgvHISTORY.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        private void btn_PrintDT_Click(object sender, EventArgs e)
        {

            LoadData(0);
            //this.txt_Calborrow.Text = cal_BorrowBook(int.Parse(this.txt_IDReader.Text), int.Parse(this.txt_IDBook.Text), this.Dtp_BorrowDate.Value, this.Dtp_ReturnDate.Value, this.Dtp_Estimate.Value, this.Cb_Origin.Checked, this.Cb_Lost.Checked).ToString();
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage2);
            doc.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Report_Form report_Form = new Report_Form();
            //report_Form.Show();
        }
    }
}
