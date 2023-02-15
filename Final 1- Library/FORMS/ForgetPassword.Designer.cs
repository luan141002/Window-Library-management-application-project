namespace Final_1__Library.FORMS
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.verify_code_btn = new System.Windows.Forms.Button();
            this.sendmail_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.code_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPassText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verify_code_btn
            // 
            this.verify_code_btn.BackColor = System.Drawing.Color.Lime;
            this.verify_code_btn.Location = new System.Drawing.Point(333, 270);
            this.verify_code_btn.Margin = new System.Windows.Forms.Padding(4);
            this.verify_code_btn.Name = "verify_code_btn";
            this.verify_code_btn.Size = new System.Drawing.Size(228, 42);
            this.verify_code_btn.TabIndex = 30;
            this.verify_code_btn.Text = "Verify";
            this.verify_code_btn.UseVisualStyleBackColor = false;
            this.verify_code_btn.Click += new System.EventHandler(this.verify_code_btn_Click);
            // 
            // sendmail_btn
            // 
            this.sendmail_btn.BackColor = System.Drawing.Color.Lime;
            this.sendmail_btn.Location = new System.Drawing.Point(596, 169);
            this.sendmail_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sendmail_btn.Name = "sendmail_btn";
            this.sendmail_btn.Size = new System.Drawing.Size(94, 42);
            this.sendmail_btn.TabIndex = 29;
            this.sendmail_btn.Text = "Send";
            this.sendmail_btn.UseVisualStyleBackColor = false;
            this.sendmail_btn.Click += new System.EventHandler(this.sendmail_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Goldenrod;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(126, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Code:";
            // 
            // code_box
            // 
            this.code_box.Location = new System.Drawing.Point(333, 224);
            this.code_box.Margin = new System.Windows.Forms.Padding(4);
            this.code_box.Name = "code_box";
            this.code_box.Size = new System.Drawing.Size(226, 22);
            this.code_box.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(125, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email:";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(333, 176);
            this.email_box.Margin = new System.Windows.Forms.Padding(4);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(226, 22);
            this.email_box.TabIndex = 25;
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoSize = true;
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(154, 480);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(88, 32);
            this.ResetBtn.TabIndex = 24;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitBtn.Location = new System.Drawing.Point(439, 480);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(62, 32);
            this.ExitBtn.TabIndex = 23;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(111, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Confirm Password:";
            // 
            // ConfirmPassText
            // 
            this.ConfirmPassText.Location = new System.Drawing.Point(333, 393);
            this.ConfirmPassText.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPassText.Name = "ConfirmPassText";
            this.ConfirmPassText.PasswordChar = '*';
            this.ConfirmPassText.Size = new System.Drawing.Size(226, 22);
            this.ConfirmPassText.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(111, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Password:";
            // 
            // NewPassText
            // 
            this.NewPassText.Location = new System.Drawing.Point(333, 337);
            this.NewPassText.Margin = new System.Windows.Forms.Padding(4);
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.PasswordChar = '*';
            this.NewPassText.Size = new System.Drawing.Size(226, 22);
            this.NewPassText.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(125, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Name:";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(333, 120);
            this.userNameText.Margin = new System.Windows.Forms.Padding(4);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(226, 22);
            this.userNameText.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reset Your Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Close
            // 
            this.Label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(643, 9);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(47, 43);
            this.Label_Close.TabIndex = 31;
            this.Label_Close.Text = "X";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(708, 574);
            this.Controls.Add(this.Label_Close);
            this.Controls.Add(this.verify_code_btn);
            this.Controls.Add(this.sendmail_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.code_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmPassText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPassText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verify_code_btn;
        private System.Windows.Forms.Button sendmail_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox code_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label ResetBtn;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmPassText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPassText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Close;
    }
}