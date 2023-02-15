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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox_User.Image = Image.FromFile("../../IMAGES/user.png");
            pictureBox_Pass.Image = Image.FromFile("../../IMAGES/Pass.png");
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Close_MouseEnter(object sender, EventArgs e)
        {
            Label_Close.ForeColor = Color.Black;
        }

        private void Label_Close_MouseLeave(object sender, EventArgs e)
        {
            Label_Close.ForeColor = Color.White;
        }
        //MAINIPULATE THE DASHBOARD FORM THE LOGIN
        private Dashboard_Form dashF = null;
        public Login_Form (Dashboard_Form SourceForm)
        {
            
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }
        //THE LOGIN BUTTON
        private void btn_Login_Click(object sender, EventArgs e)
        {
            BL_User Login = new BL_User();
            bool a = false;
            a = Login.CompareUser(txt_User.Text.ToString(), txt_Pass.Text.ToString());
            
                if (a==true)
                {
                    dashF.Enabled = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!",
                    "Thông báo");
                    txt_User.Focus();
                }
            
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            this.txt_Pass.PasswordChar = '*';
        }

        private void Btn_forget_Click(object sender, EventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();
            forget.Show();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp_Form signUp_Form = new SignUp_Form();
            signUp_Form.Show();
        }
    }
}
