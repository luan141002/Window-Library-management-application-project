namespace Final_1__Library.FORMS
{
    partial class Reader_Form
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
            this.pUBLISHERTableAdapter = new Final_1__Library.library3DataSet1TableAdapters.PUBLISHERTableAdapter();
            this.library3DataSet1 = new Final_1__Library.library3DataSet1();
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvREADER = new System.Windows.Forms.DataGridView();
            this.btn_Reader = new System.Windows.Forms.Button();
            this.Label_Close = new System.Windows.Forms.Label();
            this.panel_author = new System.Windows.Forms.Panel();
            this.Lb_typeFind = new System.Windows.Forms.ComboBox();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_infor = new System.Windows.Forms.Panel();
            this.Dtp_BirthdayReader = new System.Windows.Forms.DateTimePicker();
            this.Cb_female = new System.Windows.Forms.CheckBox();
            this.Cb_Male = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nbook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NameReader = new System.Windows.Forms.TextBox();
            this.txt_PhoneReader = new System.Windows.Forms.TextBox();
            this.txt_AddressReader = new System.Windows.Forms.TextBox();
            this.txt_IDReader = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_Header = new System.Windows.Forms.Label();
            this.library3DataSet = new Final_1__Library.library3DataSet();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new Final_1__Library.library3DataSetTableAdapters.AUTHORTableAdapter();
            this.btn_PrintDT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvREADER)).BeginInit();
            this.panel_author.SuspendLayout();
            this.panel_infor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // library3DataSet1
            // 
            this.library3DataSet1.DataSetName = "library3DataSet1";
            this.library3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLISHERBindingSource
            // 
            this.pUBLISHERBindingSource.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource.DataSource = this.library3DataSet1;
            // 
            // dgvREADER
            // 
            this.dgvREADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvREADER.Location = new System.Drawing.Point(550, 52);
            this.dgvREADER.Name = "dgvREADER";
            this.dgvREADER.RowHeadersWidth = 51;
            this.dgvREADER.RowTemplate.Height = 24;
            this.dgvREADER.Size = new System.Drawing.Size(665, 410);
            this.dgvREADER.TabIndex = 0;
            this.dgvREADER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvREADER_CellContentClick);
            // 
            // btn_Reader
            // 
            this.btn_Reader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btn_Reader.FlatAppearance.BorderSize = 0;
            this.btn_Reader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reader.Location = new System.Drawing.Point(11, 33);
            this.btn_Reader.Name = "btn_Reader";
            this.btn_Reader.Size = new System.Drawing.Size(78, 80);
            this.btn_Reader.TabIndex = 7;
            this.btn_Reader.UseVisualStyleBackColor = false;
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
            this.panel_author.Controls.Add(this.Lb_typeFind);
            this.panel_author.Controls.Add(this.Btn_Find);
            this.panel_author.Controls.Add(this.txt_Find);
            this.panel_author.Controls.Add(this.label9);
            this.panel_author.Controls.Add(this.panel_infor);
            this.panel_author.Controls.Add(this.btn_Back);
            this.panel_author.Controls.Add(this.dgvREADER);
            this.panel_author.Location = new System.Drawing.Point(223, 140);
            this.panel_author.Name = "panel_author";
            this.panel_author.Size = new System.Drawing.Size(1224, 564);
            this.panel_author.TabIndex = 6;
            // 
            // Lb_typeFind
            // 
            this.Lb_typeFind.FormattingEnabled = true;
            this.Lb_typeFind.Location = new System.Drawing.Point(689, 13);
            this.Lb_typeFind.Name = "Lb_typeFind";
            this.Lb_typeFind.Size = new System.Drawing.Size(147, 24);
            this.Lb_typeFind.TabIndex = 70;
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(1081, 7);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(134, 39);
            this.Btn_Find.TabIndex = 69;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(850, 7);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Find.Multiline = true;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(205, 36);
            this.txt_Find.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(551, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "Find book by  : ";
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.Dtp_BirthdayReader);
            this.panel_infor.Controls.Add(this.Cb_female);
            this.panel_infor.Controls.Add(this.Cb_Male);
            this.panel_infor.Controls.Add(this.label8);
            this.panel_infor.Controls.Add(this.label7);
            this.panel_infor.Controls.Add(this.txt_Nbook);
            this.panel_infor.Controls.Add(this.label6);
            this.panel_infor.Controls.Add(this.label5);
            this.panel_infor.Controls.Add(this.txt_CCCD);
            this.panel_infor.Controls.Add(this.label4);
            this.panel_infor.Controls.Add(this.label3);
            this.panel_infor.Controls.Add(this.label2);
            this.panel_infor.Controls.Add(this.label1);
            this.panel_infor.Controls.Add(this.txt_NameReader);
            this.panel_infor.Controls.Add(this.txt_PhoneReader);
            this.panel_infor.Controls.Add(this.txt_AddressReader);
            this.panel_infor.Controls.Add(this.txt_IDReader);
            this.panel_infor.Location = new System.Drawing.Point(5, 14);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(539, 448);
            this.panel_infor.TabIndex = 11;
            // 
            // Dtp_BirthdayReader
            // 
            this.Dtp_BirthdayReader.Location = new System.Drawing.Point(235, 126);
            this.Dtp_BirthdayReader.Name = "Dtp_BirthdayReader";
            this.Dtp_BirthdayReader.Size = new System.Drawing.Size(269, 22);
            this.Dtp_BirthdayReader.TabIndex = 28;
            // 
            // Cb_female
            // 
            this.Cb_female.AutoSize = true;
            this.Cb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_female.Location = new System.Drawing.Point(426, 173);
            this.Cb_female.Name = "Cb_female";
            this.Cb_female.Size = new System.Drawing.Size(92, 24);
            this.Cb_female.TabIndex = 27;
            this.Cb_female.Text = "Female";
            this.Cb_female.UseVisualStyleBackColor = true;
            this.Cb_female.CheckedChanged += new System.EventHandler(this.Cb_female_CheckedChanged);
            // 
            // Cb_Male
            // 
            this.Cb_Male.AutoSize = true;
            this.Cb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Male.Location = new System.Drawing.Point(252, 174);
            this.Cb_Male.Name = "Cb_Male";
            this.Cb_Male.Size = new System.Drawing.Size(71, 24);
            this.Cb_Male.TabIndex = 26;
            this.Cb_Male.Text = "Male";
            this.Cb_Male.UseVisualStyleBackColor = true;
            this.Cb_Male.CheckedChanged += new System.EventHandler(this.Cb_Male_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gender : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Number of books : ";
            // 
            // txt_Nbook
            // 
            this.txt_Nbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nbook.Location = new System.Drawing.Point(271, 400);
            this.txt_Nbook.Multiline = true;
            this.txt_Nbook.Name = "txt_Nbook";
            this.txt_Nbook.Size = new System.Drawing.Size(259, 32);
            this.txt_Nbook.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Birthday : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Identify ID : ";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Location = new System.Drawing.Point(189, 222);
            this.txt_CCCD.Multiline = true;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(341, 32);
            this.txt_CCCD.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID : ";
            // 
            // txt_NameReader
            // 
            this.txt_NameReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameReader.Location = new System.Drawing.Point(189, 66);
            this.txt_NameReader.Multiline = true;
            this.txt_NameReader.Name = "txt_NameReader";
            this.txt_NameReader.Size = new System.Drawing.Size(346, 32);
            this.txt_NameReader.TabIndex = 13;
            // 
            // txt_PhoneReader
            // 
            this.txt_PhoneReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhoneReader.Location = new System.Drawing.Point(189, 276);
            this.txt_PhoneReader.Multiline = true;
            this.txt_PhoneReader.Name = "txt_PhoneReader";
            this.txt_PhoneReader.Size = new System.Drawing.Size(341, 32);
            this.txt_PhoneReader.TabIndex = 12;
            // 
            // txt_AddressReader
            // 
            this.txt_AddressReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AddressReader.Location = new System.Drawing.Point(189, 330);
            this.txt_AddressReader.Multiline = true;
            this.txt_AddressReader.Name = "txt_AddressReader";
            this.txt_AddressReader.Size = new System.Drawing.Size(341, 60);
            this.txt_AddressReader.TabIndex = 11;
            // 
            // txt_IDReader
            // 
            this.txt_IDReader.BackColor = System.Drawing.Color.White;
            this.txt_IDReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDReader.Location = new System.Drawing.Point(189, 11);
            this.txt_IDReader.Multiline = true;
            this.txt_IDReader.Name = "txt_IDReader";
            this.txt_IDReader.Size = new System.Drawing.Size(346, 32);
            this.txt_IDReader.TabIndex = 10;
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
            this.panel1.Controls.Add(this.btn_Reader);
            this.panel1.Controls.Add(this.Label_Close);
            this.panel1.Controls.Add(this.panel_author);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 716);
            this.panel1.TabIndex = 2;
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
            this.panel2.Size = new System.Drawing.Size(222, 579);
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
            this.label_Header.Size = new System.Drawing.Size(1450, 137);
            this.label_Header.TabIndex = 4;
            this.label_Header.Text = "    Reader";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.UseWaitCursor = true;
            // 
            // library3DataSet
            // 
            this.library3DataSet.DataSetName = "library3DataSet";
            this.library3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.library3DataSet;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // btn_PrintDT
            // 
            this.btn_PrintDT.Location = new System.Drawing.Point(1081, 468);
            this.btn_PrintDT.Name = "btn_PrintDT";
            this.btn_PrintDT.Size = new System.Drawing.Size(86, 81);
            this.btn_PrintDT.TabIndex = 87;
            this.btn_PrintDT.UseVisualStyleBackColor = true;
            this.btn_PrintDT.Click += new System.EventHandler(this.btn_PrintDT_Click);
            // 
            // Reader_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 716);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reader_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader_Form";
            this.Load += new System.EventHandler(this.Reader_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvREADER)).EndInit();
            this.panel_author.ResumeLayout(false);
            this.panel_author.PerformLayout();
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private library3DataSet1TableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private library3DataSet1 library3DataSet1;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private System.Windows.Forms.DataGridView dgvREADER;
        private System.Windows.Forms.Button btn_Reader;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Panel panel_author;
        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NameReader;
        private System.Windows.Forms.TextBox txt_PhoneReader;
        private System.Windows.Forms.TextBox txt_AddressReader;
        private System.Windows.Forms.TextBox txt_IDReader;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label_Header;
        private library3DataSet library3DataSet;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private library3DataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.CheckBox Cb_female;
        private System.Windows.Forms.CheckBox Cb_Male;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nbook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtp_BirthdayReader;
        private System.Windows.Forms.ComboBox Lb_typeFind;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_PrintDT;
    }
}