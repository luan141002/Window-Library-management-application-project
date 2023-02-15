namespace Final_1__Library.FORMS
{
    partial class ManageAuthor_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Author = new System.Windows.Forms.Button();
            this.Label_Close = new System.Windows.Forms.Label();
            this.panel_author = new System.Windows.Forms.Panel();
            this.Lb_typeFind = new System.Windows.Forms.ComboBox();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_infor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgvAUTHOR = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_Header = new System.Windows.Forms.Label();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library3DataSet = new Final_1__Library.library3DataSet();
            this.aUTHORTableAdapter = new Final_1__Library.library3DataSetTableAdapters.AUTHORTableAdapter();
            this.btn_PrintDT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_author.SuspendLayout();
            this.panel_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAUTHOR)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btn_Author);
            this.panel1.Controls.Add(this.Label_Close);
            this.panel1.Controls.Add(this.panel_author);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 694);
            this.panel1.TabIndex = 0;
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
            this.Label_Close.Location = new System.Drawing.Point(1362, 9);
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
            this.panel_author.Controls.Add(this.label6);
            this.panel_author.Controls.Add(this.panel_infor);
            this.panel_author.Controls.Add(this.btn_Back);
            this.panel_author.Controls.Add(this.dgvAUTHOR);
            this.panel_author.Location = new System.Drawing.Point(223, 140);
            this.panel_author.Name = "panel_author";
            this.panel_author.Size = new System.Drawing.Size(1208, 551);
            this.panel_author.TabIndex = 6;
            // 
            // Lb_typeFind
            // 
            this.Lb_typeFind.FormattingEnabled = true;
            this.Lb_typeFind.Location = new System.Drawing.Point(667, 20);
            this.Lb_typeFind.Name = "Lb_typeFind";
            this.Lb_typeFind.Size = new System.Drawing.Size(147, 24);
            this.Lb_typeFind.TabIndex = 74;
            this.Lb_typeFind.SelectedIndexChanged += new System.EventHandler(this.Lb_typeFind_SelectedIndexChanged);
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(1055, 14);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(134, 39);
            this.Btn_Find.TabIndex = 73;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(828, 14);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Find.Multiline = true;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(205, 36);
            this.txt_Find.TabIndex = 72;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(529, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 71;
            this.label6.Text = "Find book by  : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.label4);
            this.panel_infor.Controls.Add(this.label3);
            this.panel_infor.Controls.Add(this.label2);
            this.panel_infor.Controls.Add(this.label1);
            this.panel_infor.Controls.Add(this.txt_Name);
            this.panel_infor.Controls.Add(this.txt_Phone);
            this.panel_infor.Controls.Add(this.txt_Address);
            this.panel_infor.Controls.Add(this.txt_ID);
            this.panel_infor.Location = new System.Drawing.Point(5, 14);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(520, 423);
            this.panel_infor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID : ";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Location = new System.Drawing.Point(152, 124);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(355, 42);
            this.txt_Name.TabIndex = 13;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Location = new System.Drawing.Point(152, 190);
            this.txt_Phone.Multiline = true;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(287, 42);
            this.txt_Phone.TabIndex = 12;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Location = new System.Drawing.Point(158, 279);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(309, 95);
            this.txt_Address.TabIndex = 11;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Location = new System.Drawing.Point(152, 56);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(283, 42);
            this.txt_ID.TabIndex = 10;
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
            // dgvAUTHOR
            // 
            this.dgvAUTHOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAUTHOR.Location = new System.Drawing.Point(531, 62);
            this.dgvAUTHOR.Name = "dgvAUTHOR";
            this.dgvAUTHOR.RowHeadersWidth = 51;
            this.dgvAUTHOR.RowTemplate.Height = 24;
            this.dgvAUTHOR.Size = new System.Drawing.Size(665, 375);
            this.dgvAUTHOR.TabIndex = 0;
            this.dgvAUTHOR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAUTHOR_CellContentClick);
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
            this.panel2.Size = new System.Drawing.Size(222, 557);
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
            this.label_Header.Size = new System.Drawing.Size(1434, 137);
            this.label_Header.TabIndex = 4;
            this.label_Header.Text = "    Authors";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.UseWaitCursor = true;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.library3DataSet;
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
            // btn_PrintDT
            // 
            this.btn_PrintDT.Location = new System.Drawing.Point(1081, 461);
            this.btn_PrintDT.Name = "btn_PrintDT";
            this.btn_PrintDT.Size = new System.Drawing.Size(86, 81);
            this.btn_PrintDT.TabIndex = 86;
            this.btn_PrintDT.UseVisualStyleBackColor = true;
            this.btn_PrintDT.Click += new System.EventHandler(this.btn_PrintDT_Click);
            // 
            // ManageAuthor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 694);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAuthor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthor_Form";
            this.Load += new System.EventHandler(this.ManageAuthor_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel_author.ResumeLayout(false);
            this.panel_author.PerformLayout();
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAUTHOR)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel_author;
        private System.Windows.Forms.DataGridView dgvAUTHOR;
        private library3DataSet library3DataSet;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private library3DataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox Lb_typeFind;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PrintDT;
    }
}