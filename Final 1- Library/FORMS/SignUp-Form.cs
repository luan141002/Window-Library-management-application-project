using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Final_1__Library.CLASSES;

namespace Final_1__Library.FORMS
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            BL_User dbUser = new BL_User();
            USER user = new USER();
            string userName = userNameText.Text;
            string password = passwordText.Text;
            string email = email_btn.Text;
            string verifypassword = verifiPassText.Text;
            if (!checkAccount(userName))
            {
                MessageBox.Show("Invalid username - include at least 10 characters and must have both word and number!", "Sign Up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!checkAccount(password))
            {
                MessageBox.Show("Invalid password - include at least 10 characters and must have both word and number!", "Sign Up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verifypassword != password)
            {
                MessageBox.Show("Confirm password is incorrect!", "Sign Up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (dbUser.AddUser(userName, password, email))
                {
                    MessageBox.Show("Your new account is ready!", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
