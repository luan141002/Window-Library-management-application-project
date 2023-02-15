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
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            pictureBox_Logo.Image = Image.FromFile("../../IMAGES/book2.png");
            btn_Books.Image = Image.FromFile("../../IMAGES/book_button_official.png");
            btn_Author.Image = Image.FromFile("../../IMAGES/Author_button_official.png");
            btn_Genres.Image = Image.FromFile("../../IMAGES/Genres_button_official.png");
            btn_Circulation.Image = Image.FromFile("../../IMAGES/Circulation_button_official.png");
            btn_Users.Image = Image.FromFile("../../IMAGES/user_button_official.png");
            btn_Employees.Image = Image.FromFile("../../IMAGES/Employee_button.png");

            QuanLyThuVienEntities myDB = new QuanLyThuVienEntities();
            DataTable dtBo = new DataTable();
            DataTable dtAu = new DataTable();
            DataTable dtRe = new DataTable();
            DataTable dtEm = new DataTable();


            BL_Book myBook = new BL_Book();
            dtBo = myBook.Take_Book();
            Lb_Books.Text = myBook.CountBookinLi().ToString();

            BL_Author myAuthor = new BL_Author();
            dtAu = myAuthor.TakeAuthor();
            Lb_Author.Text = dtAu.Rows.Count.ToString();

            BL_Reader myReader = new BL_Reader();
            dtRe = myReader.Take_Reader();
            Lb_Reader.Text = dtRe.Rows.Count.ToString();

            BL_Employee myEmployee = new BL_Employee();
            dtEm = myEmployee.Take_Employee();
            Lb_Employee.Text = dtEm.Rows.Count.ToString();


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            // show the login form
            Login_Form login_Form = new Login_Form(this);
            login_Form.Show();
        }

        private void btn_Genres_Click(object sender, EventArgs e)
        {

            // show the management of the Genre form
            Publisher_Form publisher_Form = new Publisher_Form();

            publisher_Form.Show();
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            // show the management of the Author
            ManageAuthor_Form mngAuthorForm = new ManageAuthor_Form();
            mngAuthorForm.Show();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            Book_Form mngBookForm = new Book_Form();
            mngBookForm.Show();
        }

        private void btn_Circulation_Click(object sender, EventArgs e)
        {
            Borrow_Form borrow_Book_form = new Borrow_Form();
            borrow_Book_form.Show();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Reader_Form reader_Form = new Reader_Form();
            reader_Form.Show();
        }

        private void btn_Employees_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void btn_Employees_MouseHover_1(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            Employee_Form employee_Form = new Employee_Form();
            employee_Form.Show();
        }
    }
}
