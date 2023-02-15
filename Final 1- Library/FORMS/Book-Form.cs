using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters;

using Final_1__Library.CLASSES;

namespace Final_1__Library.FORMS
{
    public partial class Book_Form : Form
    {
        bool AddTerm;
        //Image returnImage;
        BL_Book dbBo = new BL_Book();
        BL_BorrowedBook borrowedBook = new BL_BorrowedBook();
        public Book_Form()
        {
            InitializeComponent();
            //LoadData(0);
        }
        public void LoadData(int index)
        {
            try
            {

                // DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                DataTable dt = new DataTable();
                dt = dbBo.Take_Book();
                // Đưa dữ liệu lên DataGridView
                if (index == 0)
                {
                        dgvBOOK.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        dgvBOOK.RowTemplate.Height = 90;
                        dgvBOOK.DataSource = dbBo.Take_Book();
                        picCol = (DataGridViewImageColumn)dgvBOOK.Columns[9];
                        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    
                    //dgvBOOK.AutoResizeRows();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((int.Parse(dgvBOOK.Rows[i].Cells[7].Value.ToString())) == 0 && borrowedBook.GetObjectByIDBook((int.Parse(dgvBOOK.Rows[i].Cells[7].Value.ToString()))).Rows.Count == 0)
                        {
                            dbBo.Delete_Book(int.Parse(dgvBOOK.Rows[i].Cells[0].Value.ToString()));
                        }
                    }
                }
                if (index == 1)
                {
                    dgvBOOK.DataSource = dbBo.GetObjectByID(int.Parse(this.txt_Find.Text));
                    dgvBOOK.AutoResizeColumns();
                    dgvBOOK.AutoResizeRows();
                }
                if (index == 2)
                {
                    dgvBOOK.DataSource = dbBo.GetObjectByName(this.txt_Find.Text);
                    dgvBOOK.AutoResizeColumns();
                    dgvBOOK.AutoResizeRows();
                }
                if (index == 3)
                {
                    dgvBOOK.DataSource = dbBo.GetObjectByAuthor(int.Parse(this.txt_Find.Text));
                    dgvBOOK.AutoResizeColumns();
                    dgvBOOK.AutoResizeRows();
                }
                if (index == 4)
                {
                    dgvBOOK.DataSource = dbBo.GetObjectByPublisher(int.Parse(this.txt_Find.Text));
                    dgvBOOK.AutoResizeColumns();
                    dgvBOOK.AutoResizeRows();
                }
                if (index == 5)
                {
                    dgvBOOK.DataSource = dbBo.GetObjectByType(this.txt_Find.Text);
                    dgvBOOK.AutoResizeColumns();
                    dgvBOOK.AutoResizeRows();
                }
                //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                //picCol = (DataGridViewImageColumn)dgvBOOK.Columns[9];
                //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvBOOK.AllowUserToAddRows = false;
                // Thay đổi độ rộng cột
                //dgvBOOK.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_Idbook.ResetText();
                this.txt_Namebook .ResetText();
                this.txt_Publisher.ResetText();
                this.txt_Type.ResetText();
                this.txt_AuthorBook.ResetText();
                this.txt_nbook.ResetText();
                //this.Pic_Book.ResetText();
                this.Dtp_Updateday.ResetText();
                this.txt_Description.ResetText();
                this.txt_Pricebook.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_Save.Enabled = false;
                this.panel_Infor.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_Add.Enabled = true;
                this.btn_Edit.Enabled = true;
                this.btn_delete.Enabled = true;
                
                //
                //dgvBOOK_CellClick(null, null);
            }
            catch
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Can not take the data table. Error!!!");
            }
        }
       
        private void dgvBOOK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            //int r = dgvBOOK.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_Idbook.Text =
            dgvBOOK.CurrentRow.Cells[0].Value.ToString();
            this.txt_Namebook.Text =
           dgvBOOK.CurrentRow.Cells[1].Value.ToString();
            this.txt_Publisher.Text =
            dgvBOOK.CurrentRow.Cells[2].Value.ToString();
            this.txt_AuthorBook.Text =
            dgvBOOK.CurrentRow.Cells[3].Value.ToString();
            this.txt_Type.Text =
           dgvBOOK.CurrentRow.Cells[4].Value.ToString();
            this.txt_Description.Text =
           dgvBOOK.CurrentRow.Cells[5].Value.ToString();
            this.Dtp_Updateday.Text =
           dgvBOOK.CurrentRow.Cells[6].Value.ToString();
            this.txt_nbook.Text =
            dgvBOOK.CurrentRow.Cells[7].Value.ToString();
            this.txt_Pricebook.Text =
            dgvBOOK.CurrentRow.Cells[8].Value.ToString();
            if (dgvBOOK.CurrentRow.Cells[9].Value != System.DBNull.Value)
            {
                //Method 1:
                byte[] pic;
                pic = (byte[])dgvBOOK.CurrentRow.Cells[9].Value; // Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dgvBOOK.CurrentRow.Cells[9].Value))
                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
                Pb_bookpic.Image = x;
                //byte[] pic;
                //pic = (byte[])dgvBOOK.CurrentRow.Cells[9].Value;
                //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
                //Pb_bookpic.Image = byteArrayToImage((byte[])dgvBOOK.CurrentRow.Cells[9].Value);
                //Method 2 : 
                //MemoryStream ms = new MemoryStream((byte[])dgvBOOK.CurrentRow.Cells[9].Value);
                //Pb_bookpic.Image = Image.FromStream(ms);
                //Method 3 :
                //byte[] img = (byte[])dgvBOOK.CurrentRow.Cells[9].Value;
                //MemoryStream str = new MemoryStream();
                //str.Write(img, 0, img.Length);
                //Bitmap bit = new Bitmap(str);

                //Pb_bookpic.Image = bit;


            }
            else this.Pb_bookpic.Image = Image.FromFile("../../IMAGES/add-file.png");
        }
        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
           using(MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
         //----------------Image to Binary  ---------------------------
         byte[] convertImageToBinary (Image img)
         {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
         }
        private void Book_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library1012DataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.library1012DataSet2.BOOKS);
            // TODO: This line of code loads data into the 'library1012DataSet.BOOKS' table. You can move, or remove it, as needed.
           // this.bOOKSTableAdapter.Fill(this.library1012DataSet.BOOKS);

            this.btn_Bookheader.Image = Image.FromFile("../../IMAGES/bookshelf.png");
            btn_Add.Image = Image.FromFile("../../IMAGES/add-file.png");
            btn_Edit.Image = Image.FromFile("../../IMAGES/edit.png");
            btn_delete.Image = Image.FromFile("../../IMAGES/dustbin.png");
            btn_Save.Image = Image.FromFile("../../IMAGES/floppy-disk.png");
            btn_Back.Image = Image.FromFile("../../IMAGES/back.png");
            btn_PrintDT.Image = Image.FromFile("../../IMAGES/printer2.png");

            Lb_typeFind.Items.Add("ID Book");
            Lb_typeFind.Items.Add("Book Name");
            Lb_typeFind.Items.Add("ID Author");
            Lb_typeFind.Items.Add("Publisher");
            Lb_typeFind.Items.Add("Book type");

            LoadData(0);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddTerm = true;
            LoadData(0);
            // Xóa trống các đối tượng trong Panel
            this.txt_Idbook.ResetText();
            this.txt_Namebook.ResetText();
            this.txt_Publisher.ResetText();
            this.txt_Type.ResetText();
            this.txt_AuthorBook.ResetText();
            this.txt_nbook.ResetText();
            //this.Pic_Book.ResetText();
            this.Dtp_Updateday.ResetText();
            this.txt_Description.ResetText();
            this.txt_Pricebook.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.txt_Idbook.Enabled = true;
            this.panel_Infor.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_Idbook.Focus();
        }

        //private void btn_UploadImage_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog opf = new OpenFileDialog();
        //    opf.Filter = "Select Image(*.jpg;*.png;*.gif) |*.jpg;*.png;*gif";
        //    if ((opf.ShowDialog() == DialogResult.OK))
        //    {
        //        Pic_Book.Image = Image.FromFile(opf.FileName);
        //        Pic_Book.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            

            // Mở kết nối
            // Thêm dữ liệu
            if (AddTerm)
            {
                try
                {
                    // Thực hiện lệnh
                    
                    BL_Book dbBo = new BL_Book();
                    //byte[] bArr = ImageToArray(this.Pic_Book.Image, this.Pic_Book.Image.RawFormat);
                    //using (QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities())
                    //{
                    //    qltvEntity.BOOKS.Add(new BOOK() { ID_Book = int.Parse(this.txt_Idbook.Text), Name = this.txt_Namebook.Text, ID_publisher = int.Parse(this.txt_Publisher.Text), ID_author = int.Parse(this.txt_AuthorBook.Text), Type = this.txt_Type.Text, Description = this.txt_Description.Text, Update_day = this.Dtp_Updateday.Value, N_books = int.Parse(this.txt_nbook.Text), price = int.Parse(this.txt_Pricebook.Text), picture_book = ImageToArray(this.Pic_Book) });
                    //}
                    using(QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                    {
                        BOOK book = new BOOK()
                        {
                            ID_Book = int.Parse(txt_Idbook.Text),
                            Name = txt_Namebook.Text,
                            ID_publisher = int.Parse(txt_Publisher.Text),
                            ID_author = int.Parse(txt_AuthorBook.Text),
                            Type = txt_Type.Text,
                            Description = txt_Description.Text,
                            N_books = int.Parse(this.txt_nbook.Text),
                            Update_day = Dtp_Updateday.Value,
                            price = int.Parse(this.txt_Pricebook.Text),
                            Picture = convertImageToBinary(Pb_bookpic.Image),
                        };
                            db.BOOKS.Add(book);
                            //await db.SaveChangesAsync();
                            db.SaveChanges();
                        LoadData(0);
                            // Thông báo
                            MessageBox.Show("Added!");

                    }
                        
                 
                    //MemoryStream pic = new MemoryStream();
                    //Pb_bookpic.Image.Save(pic, Pb_bookpic.Image.RawFormat);
                    //dbBo.Add_Book(int.Parse(txt_Idbook.Text), txt_Namebook.Text, int.Parse(this.txt_Publisher.Text), int.Parse(txt_AuthorBook.Text), txt_Type.Text, txt_Description.Text, Dtp_Updateday.Value, int.Parse(this.txt_nbook.Text), int.Parse(this.txt_Pricebook.Text), pic) ;
                    // Load lại dữ liệu trên DataGridView
                    
                }
                catch
                {
                    MessageBox.Show("Can't add. Error!");
                }
            }
            else
            {
                // Thực hiện lệnh
                //MemoryStream pic = new MemoryStream();
                //Pb_bookpic.Image.Save(pic, Pb_bookpic.Image.RawFormat);
                BL_Book dbBo = new BL_Book();
                //byte[] bArr = ImageToArray(this.Pic_Book.Image, this.Pic_Book.Image.RawFormat);
                dbBo.Edit_Book(int.Parse(this.txt_Idbook.Text), this.txt_Namebook.Text, int.Parse(this.txt_Publisher.Text), int.Parse(this.txt_AuthorBook.Text), this.txt_Type.Text, this.txt_Description.Text, this.Dtp_Updateday.Value, int.Parse(this.txt_nbook.Text), int.Parse(this.txt_Pricebook.Text), convertImageToBinary(Pb_bookpic.Image));
                LoadData(0);
                // Thông báo
                MessageBox.Show("Fixed!");
            }
            // Đóng kết nối
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            AddTerm = false;
            LoadData(0);

            dgvBOOK_CellClick(null, null);
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btn_Save.Enabled = true;
            this.panel_Infor.Enabled = true;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_delete.Enabled = false;
            //
            this.txt_Idbook.Enabled = false;
            this.txt_Namebook.Focus();
        }

        private void dgvBOOK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBOOK_CellClick(null, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvBOOK.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strBOOK =
                dgvBOOK.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Are you sure to delete this Book?", "Answer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbBo.Delete_Book(int.Parse(strBOOK));
                    // Cập nhật lại DataGridView
                    LoadData(0);
                    // Thông báo
                    MessageBox.Show("Deleted a book!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Cannot delete this book!");
                }
            }
            catch
            {
                MessageBox.Show("Cannot delete this book. Error!");
            }
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (Lb_typeFind.Text == "ID Book")
            {
                LoadData(1);
            }
            if (this.Lb_typeFind.Text == "Book Name")
            {
                LoadData(2);
            }
               
            if (Lb_typeFind.Text == "ID Author")
            {
                LoadData(3);
            }
                
            if (Lb_typeFind.Text == "Publisher")
            {
                LoadData(4);
            }
               
            if (Lb_typeFind.Text == "Book type")
            {
                LoadData(5);
            }
                
            
        }
        //private byte[] ObjectToByteArray(object obj)
        //{
        //    if (obj == null)
        //        return null;
        //    BinaryFormatter bf = new BinaryFormatter();
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        bf.Serialize(ms, obj);
        //        return ms.ToArray();
        //    }
        //}
        private void btn_Back_Click(object sender, EventArgs e)
        {
            LoadData(0);
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.dgvBOOK.Width, this.dgvBOOK.Height, this.dgvBOOK.CreateGraphics());
            dgvBOOK.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvBOOK.Width, this.dgvBOOK.Height));
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

        private void btnpicbook_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                Pb_bookpic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKSTableAdapter.FillBy(this.library1012DataSet2.BOOKS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvBOOK_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
