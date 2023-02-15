namespace Final_1__Library.FORMS
{
    partial class Employee_Form
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
            this.components = new System.ComponentModel.Container();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.Label_Close = new System.Windows.Forms.Label();
            this.panel_author = new System.Windows.Forms.Panel();
            this.btn_PrintDT = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.Rb_Accountant = new System.Windows.Forms.RadioButton();
            this.Rb_Guard = new System.Windows.Forms.RadioButton();
            this.Rb_Cashier = new System.Windows.Forms.RadioButton();
            this.Lb_typeFind = new System.Windows.Forms.ComboBox();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.panel_infor = new System.Windows.Forms.Panel();
            this.Cb_female = new System.Windows.Forms.CheckBox();
            this.Cb_Male = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Extra = new System.Windows.Forms.TextBox();
            this.txt_WorkingTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Position = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NameEm = new System.Windows.Forms.TextBox();
            this.txt_PhoneEm = new System.Windows.Forms.TextBox();
            this.txt_AddressEm = new System.Windows.Forms.TextBox();
            this.txt_IDEm = new System.Windows.Forms.TextBox();
            this.dgvEMPLOYEE = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_Header = new System.Windows.Forms.Label();
            this.library3DataSet = new Final_1__Library.library3DataSet();
            this.aUTHORTableAdapter = new Final_1__Library.library3DataSetTableAdapters.AUTHORTableAdapter();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library3DataSet1 = new Final_1__Library.library3DataSet1();
            this.pUBLISHERTableAdapter = new Final_1__Library.library3DataSet1TableAdapters.PUBLISHERTableAdapter();
            this.library1010DataSet = new Final_1__Library.library1010DataSet();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Final_1__Library.library1010DataSetTableAdapters.EMPLOYEESTableAdapter();
            this.panel1.SuspendLayout();
            this.panel_author.SuspendLayout();
            this.panel_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1010DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(5, 468);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(88, 74);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btn_Employee);
            this.panel1.Controls.Add(this.Label_Close);
            this.panel1.Controls.Add(this.panel_author);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1593, 705);
            this.panel1.TabIndex = 3;
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btn_Employee.FlatAppearance.BorderSize = 0;
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.Location = new System.Drawing.Point(11, 33);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(78, 80);
            this.btn_Employee.TabIndex = 7;
            this.btn_Employee.UseVisualStyleBackColor = false;
            // 
            // Label_Close
            // 
            this.Label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(1368, 48);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(47, 43);
            this.Label_Close.TabIndex = 4;
            this.Label_Close.Text = "X";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            // 
            // panel_author
            // 
            this.panel_author.BackColor = System.Drawing.Color.White;
            this.panel_author.Controls.Add(this.btn_PrintDT);
            this.panel_author.Controls.Add(this.btn_report);
            this.panel_author.Controls.Add(this.Rb_Accountant);
            this.panel_author.Controls.Add(this.Rb_Guard);
            this.panel_author.Controls.Add(this.Rb_Cashier);
            this.panel_author.Controls.Add(this.Lb_typeFind);
            this.panel_author.Controls.Add(this.Btn_Find);
            this.panel_author.Controls.Add(this.txt_Find);
            this.panel_author.Controls.Add(this.label11);
            this.panel_author.Controls.Add(this.label10);
            this.panel_author.Controls.Add(this.txt_Salary);
            this.panel_author.Controls.Add(this.panel_infor);
            this.panel_author.Controls.Add(this.btn_Back);
            this.panel_author.Controls.Add(this.dgvEMPLOYEE);
            this.panel_author.Location = new System.Drawing.Point(223, 140);
            this.panel_author.Name = "panel_author";
            this.panel_author.Size = new System.Drawing.Size(1367, 564);
            this.panel_author.TabIndex = 6;
            // 
            // btn_PrintDT
            // 
            this.btn_PrintDT.Location = new System.Drawing.Point(1079, 468);
            this.btn_PrintDT.Name = "btn_PrintDT";
            this.btn_PrintDT.Size = new System.Drawing.Size(86, 81);
            this.btn_PrintDT.TabIndex = 85;
            this.btn_PrintDT.UseVisualStyleBackColor = true;
            this.btn_PrintDT.Click += new System.EventHandler(this.btn_PrintDT_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(672, 486);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(142, 56);
            this.btn_report.TabIndex = 74;
            this.btn_report.Text = "Print report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Rb_Accountant
            // 
            this.Rb_Accountant.AutoSize = true;
            this.Rb_Accountant.Location = new System.Drawing.Point(743, 32);
            this.Rb_Accountant.Name = "Rb_Accountant";
            this.Rb_Accountant.Size = new System.Drawing.Size(94, 20);
            this.Rb_Accountant.TabIndex = 73;
            this.Rb_Accountant.TabStop = true;
            this.Rb_Accountant.Text = "Accountant";
            this.Rb_Accountant.UseVisualStyleBackColor = true;
            this.Rb_Accountant.CheckedChanged += new System.EventHandler(this.Rb_Accountant_CheckedChanged);
            // 
            // Rb_Guard
            // 
            this.Rb_Guard.AutoSize = true;
            this.Rb_Guard.Location = new System.Drawing.Point(652, 32);
            this.Rb_Guard.Name = "Rb_Guard";
            this.Rb_Guard.Size = new System.Drawing.Size(65, 20);
            this.Rb_Guard.TabIndex = 72;
            this.Rb_Guard.TabStop = true;
            this.Rb_Guard.Text = "Guard";
            this.Rb_Guard.UseVisualStyleBackColor = true;
            this.Rb_Guard.CheckedChanged += new System.EventHandler(this.Rb_Guard_CheckedChanged);
            // 
            // Rb_Cashier
            // 
            this.Rb_Cashier.AutoSize = true;
            this.Rb_Cashier.Location = new System.Drawing.Point(546, 32);
            this.Rb_Cashier.Name = "Rb_Cashier";
            this.Rb_Cashier.Size = new System.Drawing.Size(74, 20);
            this.Rb_Cashier.TabIndex = 71;
            this.Rb_Cashier.TabStop = true;
            this.Rb_Cashier.Text = "Cashier";
            this.Rb_Cashier.UseVisualStyleBackColor = true;
            this.Rb_Cashier.CheckedChanged += new System.EventHandler(this.Rb_Cashier_CheckedChanged);
            // 
            // Lb_typeFind
            // 
            this.Lb_typeFind.FormattingEnabled = true;
            this.Lb_typeFind.Location = new System.Drawing.Point(707, 2);
            this.Lb_typeFind.Name = "Lb_typeFind";
            this.Lb_typeFind.Size = new System.Drawing.Size(147, 24);
            this.Lb_typeFind.TabIndex = 70;
            this.Lb_typeFind.SelectedIndexChanged += new System.EventHandler(this.Lb_typeFind_SelectedIndexChanged);
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(1224, 6);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(134, 39);
            this.Btn_Find.TabIndex = 69;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(883, 9);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Find.Multiline = true;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(309, 36);
            this.txt_Find.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(553, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 19);
            this.label11.TabIndex = 67;
            this.label11.Text = "Find book by  : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Salary : ";
            // 
            // txt_Salary
            // 
            this.txt_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Salary.Location = new System.Drawing.Point(235, 495);
            this.txt_Salary.Multiline = true;
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(320, 32);
            this.txt_Salary.TabIndex = 32;
            this.txt_Salary.TextChanged += new System.EventHandler(this.txt_Salary_TextChanged);
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.Cb_female);
            this.panel_infor.Controls.Add(this.Cb_Male);
            this.panel_infor.Controls.Add(this.label9);
            this.panel_infor.Controls.Add(this.txt_Extra);
            this.panel_infor.Controls.Add(this.txt_WorkingTime);
            this.panel_infor.Controls.Add(this.label6);
            this.panel_infor.Controls.Add(this.cmb_Position);
            this.panel_infor.Controls.Add(this.label8);
            this.panel_infor.Controls.Add(this.label7);
            this.panel_infor.Controls.Add(this.label5);
            this.panel_infor.Controls.Add(this.txt_CCCD);
            this.panel_infor.Controls.Add(this.label4);
            this.panel_infor.Controls.Add(this.label3);
            this.panel_infor.Controls.Add(this.label2);
            this.panel_infor.Controls.Add(this.label1);
            this.panel_infor.Controls.Add(this.txt_NameEm);
            this.panel_infor.Controls.Add(this.txt_PhoneEm);
            this.panel_infor.Controls.Add(this.txt_AddressEm);
            this.panel_infor.Controls.Add(this.txt_IDEm);
            this.panel_infor.Location = new System.Drawing.Point(5, 14);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(539, 448);
            this.panel_infor.TabIndex = 11;
            // 
            // Cb_female
            // 
            this.Cb_female.AutoSize = true;
            this.Cb_female.Location = new System.Drawing.Point(383, 122);
            this.Cb_female.Name = "Cb_female";
            this.Cb_female.Size = new System.Drawing.Size(75, 20);
            this.Cb_female.TabIndex = 35;
            this.Cb_female.Text = "Female";
            this.Cb_female.UseVisualStyleBackColor = true;
            this.Cb_female.CheckedChanged += new System.EventHandler(this.Cb_female_CheckedChanged_1);
            // 
            // Cb_Male
            // 
            this.Cb_Male.AutoSize = true;
            this.Cb_Male.Location = new System.Drawing.Point(230, 122);
            this.Cb_Male.Name = "Cb_Male";
            this.Cb_Male.Size = new System.Drawing.Size(59, 20);
            this.Cb_Male.TabIndex = 34;
            this.Cb_Male.Text = "Male";
            this.Cb_Male.UseVisualStyleBackColor = true;
            this.Cb_Male.CheckedChanged += new System.EventHandler(this.Cb_Male_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Extra : ";
            // 
            // txt_Extra
            // 
            this.txt_Extra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Extra.Location = new System.Drawing.Point(219, 407);
            this.txt_Extra.Multiline = true;
            this.txt_Extra.Name = "txt_Extra";
            this.txt_Extra.Size = new System.Drawing.Size(320, 32);
            this.txt_Extra.TabIndex = 32;
            // 
            // txt_WorkingTime
            // 
            this.txt_WorkingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WorkingTime.Location = new System.Drawing.Point(219, 366);
            this.txt_WorkingTime.Multiline = true;
            this.txt_WorkingTime.Name = "txt_WorkingTime";
            this.txt_WorkingTime.Size = new System.Drawing.Size(320, 32);
            this.txt_WorkingTime.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Working Time(hours) : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmb_Position
            // 
            this.cmb_Position.FormattingEnabled = true;
            this.cmb_Position.Location = new System.Drawing.Point(219, 336);
            this.cmb_Position.Name = "cmb_Position";
            this.cmb_Position.Size = new System.Drawing.Size(320, 24);
            this.cmb_Position.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gender : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Position : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Identify ID : ";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Location = new System.Drawing.Point(198, 160);
            this.txt_CCCD.Multiline = true;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(341, 32);
            this.txt_CCCD.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID : ";
            // 
            // txt_NameEm
            // 
            this.txt_NameEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameEm.Location = new System.Drawing.Point(189, 66);
            this.txt_NameEm.Multiline = true;
            this.txt_NameEm.Name = "txt_NameEm";
            this.txt_NameEm.Size = new System.Drawing.Size(346, 32);
            this.txt_NameEm.TabIndex = 13;
            // 
            // txt_PhoneEm
            // 
            this.txt_PhoneEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhoneEm.Location = new System.Drawing.Point(198, 211);
            this.txt_PhoneEm.Multiline = true;
            this.txt_PhoneEm.Name = "txt_PhoneEm";
            this.txt_PhoneEm.Size = new System.Drawing.Size(341, 32);
            this.txt_PhoneEm.TabIndex = 12;
            // 
            // txt_AddressEm
            // 
            this.txt_AddressEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AddressEm.Location = new System.Drawing.Point(198, 259);
            this.txt_AddressEm.Multiline = true;
            this.txt_AddressEm.Name = "txt_AddressEm";
            this.txt_AddressEm.Size = new System.Drawing.Size(341, 70);
            this.txt_AddressEm.TabIndex = 11;
            // 
            // txt_IDEm
            // 
            this.txt_IDEm.BackColor = System.Drawing.Color.White;
            this.txt_IDEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDEm.Location = new System.Drawing.Point(189, 11);
            this.txt_IDEm.Multiline = true;
            this.txt_IDEm.Name = "txt_IDEm";
            this.txt_IDEm.Size = new System.Drawing.Size(346, 32);
            this.txt_IDEm.TabIndex = 10;
            // 
            // dgvEMPLOYEE
            // 
            this.dgvEMPLOYEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMPLOYEE.Location = new System.Drawing.Point(547, 61);
            this.dgvEMPLOYEE.Name = "dgvEMPLOYEE";
            this.dgvEMPLOYEE.RowHeadersWidth = 51;
            this.dgvEMPLOYEE.RowTemplate.Height = 24;
            this.dgvEMPLOYEE.Size = new System.Drawing.Size(817, 401);
            this.dgvEMPLOYEE.TabIndex = 0;
            this.dgvEMPLOYEE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEMPLOYEE_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 568);
            this.panel2.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(23, 166);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(177, 76);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(23, 302);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(177, 75);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(23, 436);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(177, 76);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(23, 28);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(177, 74);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label_Header
            // 
            this.label_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label_Header.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Header.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header.ForeColor = System.Drawing.Color.White;
            this.label_Header.Location = new System.Drawing.Point(0, 0);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(1593, 137);
            this.label_Header.TabIndex = 4;
            this.label_Header.Text = "    Employee";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.UseWaitCursor = true;
            // 
            // library3DataSet
            // 
            this.library3DataSet.DataSetName = "library3DataSet";
            this.library3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.library3DataSet;
            // 
            // pUBLISHERBindingSource
            // 
            this.pUBLISHERBindingSource.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource.DataSource = this.library3DataSet1;
            // 
            // library3DataSet1
            // 
            this.library3DataSet1.DataSetName = "library3DataSet1";
            this.library3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // library1010DataSet
            // 
            this.library1010DataSet.DataSetName = "library1010DataSet";
            this.library1010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.library1010DataSet;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 705);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Form";
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel_author.ResumeLayout(false);
            this.panel_author.PerformLayout();
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1010DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Panel panel_author;
        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NameEm;
        private System.Windows.Forms.TextBox txt_PhoneEm;
        private System.Windows.Forms.TextBox txt_AddressEm;
        private System.Windows.Forms.TextBox txt_IDEm;
        private System.Windows.Forms.DataGridView dgvEMPLOYEE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label_Header;
        private library3DataSet library3DataSet;
        private library3DataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private library3DataSet1 library3DataSet1;
        private library3DataSet1TableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private System.Windows.Forms.TextBox txt_WorkingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Extra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Salary;
        private library1010DataSet library1010DataSet;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private library1010DataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.CheckBox Cb_female;
        private System.Windows.Forms.CheckBox Cb_Male;
        private System.Windows.Forms.ComboBox Lb_typeFind;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton Rb_Accountant;
        private System.Windows.Forms.RadioButton Rb_Guard;
        private System.Windows.Forms.RadioButton Rb_Cashier;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_PrintDT;
    }
}