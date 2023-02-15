using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using Final_1__Library.CLASSES;

namespace Final_1__Library.FORMS
{
    public partial class ForgetPassword : Form
    {
        Random rnd = new Random();
        public int code;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BL_User dbU = new BL_User();
            USER user = new USER();
            dt = dbU.CheckUser(userNameText.Text,email_box.Text);
            if ((dt.Rows.Count > 0))
            {
                if (NewPassText.Text == ConfirmPassText.Text)
                {
                    dbU.EditUser(userNameText.Text, NewPassText.Text);
                    MessageBox.Show("Password change succesfully!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Password!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("Invalid Username!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mail()
        {
            string email = "20110380@student.hcmute.edu.vn";
            string password = "Luan@14102002";
            string receiveEmail = email_box.Text;
            code = rnd.Next(123123, 999999);
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress(email);
            message.Sender = new MailAddress(email);
            message.IsBodyHtml = true;
            //Enter your email blow and also change in database too
            message.To.Add(receiveEmail);
            message.Subject = "change password";
            message.Body = "Write this given code on text box\n" + code + "\nThank you!";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(email, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.Send(message);
            MessageBox.Show("Email has been sent");
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            NewPassText.Visible = false;
            ConfirmPassText.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void sendmail_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BL_User dbU = new BL_User();
            dt = dbU.CheckUser(userNameText.Text,email_box.Text);
            if ((dt.Rows.Count > 0))
            {
                mail();
            }
            else
            {
                MessageBox.Show("This User name or email is not exisit in the given data", "Error email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verify_code_btn_Click(object sender, EventArgs e)
        {
            if (code.ToString() == code_box.Text)
            {
                MessageBox.Show("OK! Let's change your password now!");
                NewPassText.Visible = true;
                ConfirmPassText.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }

            else
            {
                MessageBox.Show("Code doesnot Match");
            }
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
