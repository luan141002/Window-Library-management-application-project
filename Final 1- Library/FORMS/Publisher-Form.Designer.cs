namespace Final_1__Library.FORMS
{
    partial class Publisher_Form
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
            this.library3DataSet = new Final_1__Library.library3DataSet();
            this.label_Header = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NamePub = new System.Windows.Forms.TextBox();
            this.txt_PhonePub = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_AddressPub = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_IDPub = new System.Windows.Forms.TextBox();
            this.panel_infor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EmailPub = new System.Windows.Forms.TextBox();
            this.btn_Publisher = new System.Windows.Forms.Button();
            this.Label_Close = new System.Windows.Forms.Label();
            this.panel_author = new System.Windows.Forms.Panel();
            this.Lb_typeFind = new System.Windows.Forms.ComboBox();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPUBLISHER = new System.Windows.Forms.DataGridView();
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library3DataSet1 = new Final_1__Library.library3DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pUBLISHERTableAdapter = new Final_1__Library.library3DataSet1TableAdapters.PUBLISHERTableAdapter();
            this.btn_PrintDT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_infor.SuspendLayout();
            this.panel_author.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPUBLISHER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // library3DataSet
            // 
            this.library3DataSet.DataSetName = "library3DataSet";
            this.library3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label_Header.Size = new System.Drawing.Size(1427, 137);
            this.label_Header.TabIndex = 4;
            this.label_Header.Text = "    Publisher";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.UseWaitCursor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 190);
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
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID : ";
            // 
            // txt_NamePub
            // 
            this.txt_NamePub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NamePub.Location = new System.Drawing.Point(160, 111);
            this.txt_NamePub.Multiline = true;
            this.txt_NamePub.Name = "txt_NamePub";
            this.txt_NamePub.Size = new System.Drawing.Size(355, 42);
            this.txt_NamePub.TabIndex = 13;
            // 
            // txt_PhonePub
            // 
            this.txt_PhonePub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhonePub.Location = new System.Drawing.Point(160, 183);
            this.txt_PhonePub.Multiline = true;
            this.txt_PhonePub.Name = "txt_PhonePub";
            this.txt_PhonePub.Size = new System.Drawing.Size(287, 42);
            this.txt_PhonePub.TabIndex = 12;
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
            this.panel2.Size = new System.Drawing.Size(222, 569);
            this.panel2.TabIndex = 5;
            // 
            // txt_AddressPub
            // 
            this.txt_AddressPub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AddressPub.Location = new System.Drawing.Point(160, 312);
            this.txt_AddressPub.Multiline = true;
            this.txt_AddressPub.Name = "txt_AddressPub";
            this.txt_AddressPub.Size = new System.Drawing.Size(309, 95);
            this.txt_AddressPub.TabIndex = 11;
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
            // txt_IDPub
            // 
            this.txt_IDPub.BackColor = System.Drawing.Color.White;
            this.txt_IDPub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDPub.Location = new System.Drawing.Point(160, 43);
            this.txt_IDPub.Multiline = true;
            this.txt_IDPub.Name = "txt_IDPub";
            this.txt_IDPub.Size = new System.Drawing.Size(283, 42);
            this.txt_IDPub.TabIndex = 10;
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.label5);
            this.panel_infor.Controls.Add(this.txt_EmailPub);
            this.panel_infor.Controls.Add(this.label4);
            this.panel_infor.Controls.Add(this.label3);
            this.panel_infor.Controls.Add(this.label2);
            this.panel_infor.Controls.Add(this.label1);
            this.panel_infor.Controls.Add(this.txt_NamePub);
            this.panel_infor.Controls.Add(this.txt_PhonePub);
            this.panel_infor.Controls.Add(this.txt_AddressPub);
            this.panel_infor.Controls.Add(this.txt_IDPub);
            this.panel_infor.Location = new System.Drawing.Point(5, 14);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(520, 423);
            this.panel_infor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email : ";
            // 
            // txt_EmailPub
            // 
            this.txt_EmailPub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmailPub.Location = new System.Drawing.Point(160, 239);
            this.txt_EmailPub.Multiline = true;
            this.txt_EmailPub.Name = "txt_EmailPub";
            this.txt_EmailPub.Size = new System.Drawing.Size(287, 42);
            this.txt_EmailPub.TabIndex = 18;
            // 
            // btn_Publisher
            // 
            this.btn_Publisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btn_Publisher.FlatAppearance.BorderSize = 0;
            this.btn_Publisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Publisher.Location = new System.Drawing.Point(11, 33);
            this.btn_Publisher.Name = "btn_Publisher";
            this.btn_Publisher.Size = new System.Drawing.Size(78, 80);
            this.btn_Publisher.TabIndex = 7;
            this.btn_Publisher.UseVisualStyleBackColor = false;
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
            this.panel_author.Controls.Add(this.label6);
            this.panel_author.Controls.Add(this.panel_infor);
            this.panel_author.Controls.Add(this.btn_Back);
            this.panel_author.Controls.Add(this.dgvPUBLISHER);
            this.panel_author.Location = new System.Drawing.Point(223, 140);
            this.panel_author.Name = "panel_author";
            this.panel_author.Size = new System.Drawing.Size(1208, 551);
            this.panel_author.TabIndex = 6;
            // 
            // Lb_typeFind
            // 
            this.Lb_typeFind.FormattingEnabled = true;
            this.Lb_typeFind.Location = new System.Drawing.Point(673, 20);
            this.Lb_typeFind.Name = "Lb_typeFind";
            this.Lb_typeFind.Size = new System.Drawing.Size(147, 24);
            this.Lb_typeFind.TabIndex = 70;
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(1061, 14);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(134, 39);
            this.Btn_Find.TabIndex = 69;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(834, 14);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Find.Multiline = true;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(205, 36);
            this.txt_Find.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(535, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "Find book by  : ";
            // 
            // dgvPUBLISHER
            // 
            this.dgvPUBLISHER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPUBLISHER.Location = new System.Drawing.Point(527, 57);
            this.dgvPUBLISHER.Name = "dgvPUBLISHER";
            this.dgvPUBLISHER.RowHeadersWidth = 51;
            this.dgvPUBLISHER.RowTemplate.Height = 24;
            this.dgvPUBLISHER.Size = new System.Drawing.Size(674, 380);
            this.dgvPUBLISHER.TabIndex = 0;
            this.dgvPUBLISHER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPUBLISHER_CellClick);
            this.dgvPUBLISHER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPUBLISHER_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btn_Publisher);
            this.panel1.Controls.Add(this.Label_Close);
            this.panel1.Controls.Add(this.panel_author);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 706);
            this.panel1.TabIndex = 1;
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // btn_PrintDT
            // 
            this.btn_PrintDT.Location = new System.Drawing.Point(1061, 461);
            this.btn_PrintDT.Name = "btn_PrintDT";
            this.btn_PrintDT.Size = new System.Drawing.Size(86, 81);
            this.btn_PrintDT.TabIndex = 87;
            this.btn_PrintDT.UseVisualStyleBackColor = true;
            this.btn_PrintDT.Click += new System.EventHandler(this.btn_PrintDT_Click);
            // 
            // Publisher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 706);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Publisher_Form";
            this.Text = "Publisher_Form";
            this.Load += new System.EventHandler(this.Publisher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            this.panel_author.ResumeLayout(false);
            this.panel_author.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPUBLISHER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library3DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private library3DataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private library3DataSet library3DataSet;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NamePub;
        private System.Windows.Forms.TextBox txt_PhonePub;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_AddressPub;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_IDPub;
        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EmailPub;
        private System.Windows.Forms.Button btn_Publisher;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Panel panel_author;
        private System.Windows.Forms.DataGridView dgvPUBLISHER;
        private System.Windows.Forms.Panel panel1;
        private library3DataSet1 library3DataSet1;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private library3DataSet1TableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private System.Windows.Forms.ComboBox Lb_typeFind;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PrintDT;
    }
}