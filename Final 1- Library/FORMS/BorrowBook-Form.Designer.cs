namespace Final_1__Library.FORMS
{
    partial class Borrow_Form
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
            this.aUTHORTableAdapter = new Final_1__Library.library3DataSetTableAdapters.AUTHORTableAdapter();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Header = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDBook = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_IDReader = new System.Windows.Forms.TextBox();
            this.panel_infor = new System.Windows.Forms.Panel();
            this.pan_return = new System.Windows.Forms.Panel();
            this.Cb_Fixed = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cb_Origin = new System.Windows.Forms.CheckBox();
            this.txt_Calborrow = new System.Windows.Forms.TextBox();
            this.Cb_Lost = new System.Windows.Forms.CheckBox();
            this.Cb_NLost = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ExtraFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.Dtp_Estimate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_BorrowDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Author = new System.Windows.Forms.Button();
            this.Label_Close = new System.Windows.Forms.Label();
            this.panel_author = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_PrintDT = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.Lb_typeFind = new System.Windows.Forms.ComboBox();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvHISTORY = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.hISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORYTableAdapter = new Final_1__Library.library3DataSet2TableAdapters.HISTORYTableAdapter();
            this.library1012DataSet1 = new Final_1__Library.library1012DataSet1();
            this.borrowBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_BookTableAdapter = new Final_1__Library.library1012DataSet1TableAdapters.Borrow_BookTableAdapter();
            this.iDRdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borroweddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returneddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrafeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lossbookDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_infor.SuspendLayout();
            this.pan_return.SuspendLayout();
            this.panel_author.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHISTORY)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1012DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
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
            this.label_Header.Size = new System.Drawing.Size(1472, 137);
            this.label_Header.TabIndex = 4;
            this.label_Header.Text = "    Borrowed Book";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.UseWaitCursor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(23, 416);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Borrow Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID Book : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Reader : ";
            // 
            // txt_IDBook
            // 
            this.txt_IDBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDBook.Location = new System.Drawing.Point(171, 86);
            this.txt_IDBook.Multiline = true;
            this.txt_IDBook.Name = "txt_IDBook";
            this.txt_IDBook.Size = new System.Drawing.Size(390, 28);
            this.txt_IDBook.TabIndex = 13;
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
            this.panel2.Size = new System.Drawing.Size(222, 561);
            this.panel2.TabIndex = 5;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(13, 472);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(88, 74);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_IDReader
            // 
            this.txt_IDReader.BackColor = System.Drawing.Color.White;
            this.txt_IDReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDReader.Location = new System.Drawing.Point(171, 12);
            this.txt_IDReader.Multiline = true;
            this.txt_IDReader.Name = "txt_IDReader";
            this.txt_IDReader.Size = new System.Drawing.Size(387, 30);
            this.txt_IDReader.TabIndex = 10;
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.pan_return);
            this.panel_infor.Controls.Add(this.label11);
            this.panel_infor.Controls.Add(this.button1);
            this.panel_infor.Controls.Add(this.btn_return);
            this.panel_infor.Controls.Add(this.Dtp_Estimate);
            this.panel_infor.Controls.Add(this.label6);
            this.panel_infor.Controls.Add(this.Dtp_ReturnDate);
            this.panel_infor.Controls.Add(this.Dtp_BorrowDate);
            this.panel_infor.Controls.Add(this.label5);
            this.panel_infor.Controls.Add(this.label3);
            this.panel_infor.Controls.Add(this.label2);
            this.panel_infor.Controls.Add(this.label1);
            this.panel_infor.Controls.Add(this.txt_IDBook);
            this.panel_infor.Controls.Add(this.txt_IDReader);
            this.panel_infor.Location = new System.Drawing.Point(5, 14);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(563, 452);
            this.panel_infor.TabIndex = 11;
            // 
            // pan_return
            // 
            this.pan_return.Controls.Add(this.Cb_Fixed);
            this.pan_return.Controls.Add(this.label10);
            this.pan_return.Controls.Add(this.Cb_Origin);
            this.pan_return.Controls.Add(this.txt_Calborrow);
            this.pan_return.Controls.Add(this.Cb_Lost);
            this.pan_return.Controls.Add(this.Cb_NLost);
            this.pan_return.Controls.Add(this.label8);
            this.pan_return.Controls.Add(this.label7);
            this.pan_return.Controls.Add(this.label4);
            this.pan_return.Controls.Add(this.txt_ExtraFee);
            this.pan_return.Location = new System.Drawing.Point(0, 285);
            this.pan_return.Name = "pan_return";
            this.pan_return.Size = new System.Drawing.Size(558, 164);
            this.pan_return.TabIndex = 34;
            // 
            // Cb_Fixed
            // 
            this.Cb_Fixed.AutoSize = true;
            this.Cb_Fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Fixed.Location = new System.Drawing.Point(414, 48);
            this.Cb_Fixed.Name = "Cb_Fixed";
            this.Cb_Fixed.Size = new System.Drawing.Size(84, 24);
            this.Cb_Fixed.TabIndex = 38;
            this.Cb_Fixed.Text = "Hư Hại";
            this.Cb_Fixed.UseVisualStyleBackColor = true;
            this.Cb_Fixed.CheckedChanged += new System.EventHandler(this.Cb_Fixed_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Money need to pay :";
            // 
            // Cb_Origin
            // 
            this.Cb_Origin.AutoSize = true;
            this.Cb_Origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Origin.Location = new System.Drawing.Point(204, 48);
            this.Cb_Origin.Name = "Cb_Origin";
            this.Cb_Origin.Size = new System.Drawing.Size(122, 24);
            this.Cb_Origin.TabIndex = 37;
            this.Cb_Origin.Text = "Còn Nguyên";
            this.Cb_Origin.UseVisualStyleBackColor = true;
            this.Cb_Origin.CheckedChanged += new System.EventHandler(this.Cb_Origin_CheckedChanged);
            // 
            // txt_Calborrow
            // 
            this.txt_Calborrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Calborrow.Location = new System.Drawing.Point(250, 126);
            this.txt_Calborrow.Multiline = true;
            this.txt_Calborrow.Name = "txt_Calborrow";
            this.txt_Calborrow.Size = new System.Drawing.Size(263, 32);
            this.txt_Calborrow.TabIndex = 79;
            this.txt_Calborrow.TextChanged += new System.EventHandler(this.txt_Calborrow_TextChanged);
            // 
            // Cb_Lost
            // 
            this.Cb_Lost.AutoSize = true;
            this.Cb_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Lost.Location = new System.Drawing.Point(414, 89);
            this.Cb_Lost.Name = "Cb_Lost";
            this.Cb_Lost.Size = new System.Drawing.Size(64, 24);
            this.Cb_Lost.TabIndex = 36;
            this.Cb_Lost.Text = "Lost";
            this.Cb_Lost.UseVisualStyleBackColor = true;
            this.Cb_Lost.CheckedChanged += new System.EventHandler(this.Cb_Lost_CheckedChanged);
            // 
            // Cb_NLost
            // 
            this.Cb_NLost.AutoSize = true;
            this.Cb_NLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_NLost.Location = new System.Drawing.Point(204, 89);
            this.Cb_NLost.Name = "Cb_NLost";
            this.Cb_NLost.Size = new System.Drawing.Size(100, 24);
            this.Cb_NLost.TabIndex = 35;
            this.Cb_NLost.Text = "chưa mất";
            this.Cb_NLost.UseVisualStyleBackColor = true;
            this.Cb_NLost.CheckedChanged += new System.EventHandler(this.Cb_NLost_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Loss_book : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Current_status : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Extra Fee : ";
            // 
            // txt_ExtraFee
            // 
            this.txt_ExtraFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExtraFee.Location = new System.Drawing.Point(171, 10);
            this.txt_ExtraFee.Multiline = true;
            this.txt_ExtraFee.Name = "txt_ExtraFee";
            this.txt_ExtraFee.Size = new System.Drawing.Size(387, 32);
            this.txt_ExtraFee.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Do you have some trouble with id reader : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(434, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "Create new reader";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(7, 247);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(226, 35);
            this.btn_return.TabIndex = 31;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Dtp_Estimate
            // 
            this.Dtp_Estimate.Location = new System.Drawing.Point(250, 185);
            this.Dtp_Estimate.Name = "Dtp_Estimate";
            this.Dtp_Estimate.Size = new System.Drawing.Size(311, 22);
            this.Dtp_Estimate.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estimated Date : ";
            // 
            // Dtp_ReturnDate
            // 
            this.Dtp_ReturnDate.Location = new System.Drawing.Point(250, 224);
            this.Dtp_ReturnDate.Name = "Dtp_ReturnDate";
            this.Dtp_ReturnDate.Size = new System.Drawing.Size(311, 22);
            this.Dtp_ReturnDate.TabIndex = 20;
            // 
            // Dtp_BorrowDate
            // 
            this.Dtp_BorrowDate.Location = new System.Drawing.Point(250, 139);
            this.Dtp_BorrowDate.Name = "Dtp_BorrowDate";
            this.Dtp_BorrowDate.Size = new System.Drawing.Size(308, 22);
            this.Dtp_BorrowDate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Return Date ( optional) : ";
            // 
            // btn_Author
            // 
            this.btn_Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btn_Author.FlatAppearance.BorderSize = 0;
            this.btn_Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Author.Location = new System.Drawing.Point(11, 33);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Size = new System.Drawing.Size(78, 80);
            this.btn_Author.TabIndex = 7;
            this.btn_Author.UseVisualStyleBackColor = false;
            // 
            // Label_Close
            // 
            this.Label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(1382, 33);
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
            this.panel_author.Controls.Add(this.button3);
            this.panel_author.Controls.Add(this.btn_PrintDT);
            this.panel_author.Controls.Add(this.btn_print);
            this.panel_author.Controls.Add(this.Lb_typeFind);
            this.panel_author.Controls.Add(this.Btn_Find);
            this.panel_author.Controls.Add(this.txt_Find);
            this.panel_author.Controls.Add(this.label9);
            this.panel_author.Controls.Add(this.panel_infor);
            this.panel_author.Controls.Add(this.btn_Back);
            this.panel_author.Controls.Add(this.dgvHISTORY);
            this.panel_author.Location = new System.Drawing.Point(223, 140);
            this.panel_author.Name = "panel_author";
            this.panel_author.Size = new System.Drawing.Size(1246, 551);
            this.panel_author.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(389, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 33);
            this.button3.TabIndex = 87;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_PrintDT
            // 
            this.btn_PrintDT.Location = new System.Drawing.Point(1120, 448);
            this.btn_PrintDT.Name = "btn_PrintDT";
            this.btn_PrintDT.Size = new System.Drawing.Size(86, 81);
            this.btn_PrintDT.TabIndex = 86;
            this.btn_PrintDT.UseVisualStyleBackColor = true;
            this.btn_PrintDT.Click += new System.EventHandler(this.btn_PrintDT_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(171, 480);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(169, 49);
            this.btn_print.TabIndex = 81;
            this.btn_print.Text = "PRINT BILL";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Lb_typeFind
            // 
            this.Lb_typeFind.FormattingEnabled = true;
            this.Lb_typeFind.Location = new System.Drawing.Point(737, 11);
            this.Lb_typeFind.Name = "Lb_typeFind";
            this.Lb_typeFind.Size = new System.Drawing.Size(147, 24);
            this.Lb_typeFind.TabIndex = 78;
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(1099, 5);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(134, 37);
            this.Btn_Find.TabIndex = 77;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(889, 5);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Find.Multiline = true;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(205, 34);
            this.txt_Find.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(573, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "Find Brbook by  : ";
            // 
            // dgvHISTORY
            // 
            this.dgvHISTORY.AutoGenerateColumns = false;
            this.dgvHISTORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHISTORY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRdDataGridViewTextBoxColumn,
            this.iDBookDataGridViewTextBoxColumn,
            this.borroweddateDataGridViewTextBoxColumn,
            this.estimateddateDataGridViewTextBoxColumn,
            this.returneddateDataGridViewTextBoxColumn,
            this.extrafeeDataGridViewTextBoxColumn,
            this.currentstatusDataGridViewCheckBoxColumn,
            this.lossbookDataGridViewCheckBoxColumn});
            this.dgvHISTORY.DataSource = this.borrowBookBindingSource;
            this.dgvHISTORY.Location = new System.Drawing.Point(572, 44);
            this.dgvHISTORY.Name = "dgvHISTORY";
            this.dgvHISTORY.RowHeadersWidth = 51;
            this.dgvHISTORY.RowTemplate.Height = 24;
            this.dgvHISTORY.Size = new System.Drawing.Size(665, 393);
            this.dgvHISTORY.TabIndex = 0;
            this.dgvHISTORY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHISTORY_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_Author);
            this.panel1.Controls.Add(this.Label_Close);
            this.panel1.Controls.Add(this.panel_author);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 698);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 8);
            this.button2.TabIndex = 82;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // hISTORYTableAdapter
            // 
            this.hISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // library1012DataSet1
            // 
            this.library1012DataSet1.DataSetName = "library1012DataSet1";
            this.library1012DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowBookBindingSource
            // 
            this.borrowBookBindingSource.DataMember = "Borrow_Book";
            this.borrowBookBindingSource.DataSource = this.library1012DataSet1;
            // 
            // borrow_BookTableAdapter
            // 
            this.borrow_BookTableAdapter.ClearBeforeFill = true;
            // 
            // iDRdDataGridViewTextBoxColumn
            // 
            this.iDRdDataGridViewTextBoxColumn.DataPropertyName = "ID_Rd";
            this.iDRdDataGridViewTextBoxColumn.HeaderText = "ID_Rd";
            this.iDRdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRdDataGridViewTextBoxColumn.Name = "iDRdDataGridViewTextBoxColumn";
            this.iDRdDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDBookDataGridViewTextBoxColumn
            // 
            this.iDBookDataGridViewTextBoxColumn.DataPropertyName = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.HeaderText = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBookDataGridViewTextBoxColumn.Name = "iDBookDataGridViewTextBoxColumn";
            this.iDBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // borroweddateDataGridViewTextBoxColumn
            // 
            this.borroweddateDataGridViewTextBoxColumn.DataPropertyName = "Borrowed_date";
            this.borroweddateDataGridViewTextBoxColumn.HeaderText = "Borrowed_date";
            this.borroweddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borroweddateDataGridViewTextBoxColumn.Name = "borroweddateDataGridViewTextBoxColumn";
            this.borroweddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimateddateDataGridViewTextBoxColumn
            // 
            this.estimateddateDataGridViewTextBoxColumn.DataPropertyName = "Estimated_date";
            this.estimateddateDataGridViewTextBoxColumn.HeaderText = "Estimated_date";
            this.estimateddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimateddateDataGridViewTextBoxColumn.Name = "estimateddateDataGridViewTextBoxColumn";
            this.estimateddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // returneddateDataGridViewTextBoxColumn
            // 
            this.returneddateDataGridViewTextBoxColumn.DataPropertyName = "Returned_date";
            this.returneddateDataGridViewTextBoxColumn.HeaderText = "Returned_date";
            this.returneddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returneddateDataGridViewTextBoxColumn.Name = "returneddateDataGridViewTextBoxColumn";
            this.returneddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // extrafeeDataGridViewTextBoxColumn
            // 
            this.extrafeeDataGridViewTextBoxColumn.DataPropertyName = "Extra_fee";
            this.extrafeeDataGridViewTextBoxColumn.HeaderText = "Extra_fee";
            this.extrafeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.extrafeeDataGridViewTextBoxColumn.Name = "extrafeeDataGridViewTextBoxColumn";
            this.extrafeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentstatusDataGridViewCheckBoxColumn
            // 
            this.currentstatusDataGridViewCheckBoxColumn.DataPropertyName = "Current_status";
            this.currentstatusDataGridViewCheckBoxColumn.HeaderText = "Current_status";
            this.currentstatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.currentstatusDataGridViewCheckBoxColumn.Name = "currentstatusDataGridViewCheckBoxColumn";
            this.currentstatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // lossbookDataGridViewCheckBoxColumn
            // 
            this.lossbookDataGridViewCheckBoxColumn.DataPropertyName = "Loss_book";
            this.lossbookDataGridViewCheckBoxColumn.HeaderText = "Loss_book";
            this.lossbookDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lossbookDataGridViewCheckBoxColumn.Name = "lossbookDataGridViewCheckBoxColumn";
            this.lossbookDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Borrow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 698);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History_Form";
            this.Load += new System.EventHandler(this.History_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            this.pan_return.ResumeLayout(false);
            this.pan_return.PerformLayout();
            this.panel_author.ResumeLayout(false);
            this.panel_author.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHISTORY)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1012DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private library3DataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDBook;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_IDReader;
        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Panel panel_author;
        private System.Windows.Forms.DataGridView dgvHISTORY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Dtp_ReturnDate;
        private System.Windows.Forms.DateTimePicker Dtp_BorrowDate;
        private System.Windows.Forms.BindingSource hISTORYBindingSource;
        private library3DataSet2TableAdapters.HISTORYTableAdapter hISTORYTableAdapter;
        private System.Windows.Forms.DateTimePicker Dtp_Estimate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Lb_typeFind;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Calborrow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel pan_return;
        private System.Windows.Forms.CheckBox Cb_Fixed;
        private System.Windows.Forms.CheckBox Cb_Origin;
        private System.Windows.Forms.CheckBox Cb_Lost;
        private System.Windows.Forms.CheckBox Cb_NLost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ExtraFee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_PrintDT;
        private System.Windows.Forms.Button button3;
        private library1012DataSet1 library1012DataSet1;
        private System.Windows.Forms.BindingSource borrowBookBindingSource;
        private library1012DataSet1TableAdapters.Borrow_BookTableAdapter borrow_BookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borroweddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returneddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrafeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn currentstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lossbookDataGridViewCheckBoxColumn;
    }
}