namespace Final_1__Library
{
    partial class Report_Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fKBorrowBoIDBo30F848EDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library1010DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library1010DataSet = new Final_1__Library.library1010DataSet();
            this.dataSetBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBOOK = new Final_1__Library.DataSetBOOK();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bOOKSTableAdapter = new Final_1__Library.library1010DataSetTableAdapters.BOOKSTableAdapter();
            this.borrow_BookTableAdapter = new Final_1__Library.library1010DataSetTableAdapters.Borrow_BookTableAdapter();
            this.qLBrBook = new Final_1__Library.QLBrBook();
            this.qLBrBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_BookTableAdapter1 = new Final_1__Library.QLBrBookTableAdapters.Borrow_BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fKBorrowBoIDBo30F848EDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1010DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1010DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBOOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBrBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBrBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fKBorrowBoIDBo30F848EDBindingSource
            // 
            this.fKBorrowBoIDBo30F848EDBindingSource.DataMember = "FK__Borrow_Bo__ID_Bo__30F848ED";
            this.fKBorrowBoIDBo30F848EDBindingSource.DataSource = this.bOOKSBindingSource;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.library1010DataSetBindingSource;
            // 
            // library1010DataSetBindingSource
            // 
            this.library1010DataSetBindingSource.DataSource = this.library1010DataSet;
            this.library1010DataSetBindingSource.Position = 0;
            // 
            // library1010DataSet
            // 
            this.library1010DataSet.DataSetName = "library1010DataSet";
            this.library1010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBOOKBindingSource
            // 
            this.dataSetBOOKBindingSource.DataSource = this.dataSetBOOK;
            this.dataSetBOOKBindingSource.Position = 0;
            // 
            // dataSetBOOK
            // 
            this.dataSetBOOK.DataSetName = "DataSetBOOK";
            this.dataSetBOOK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.borrowBookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_1__Library.Borrowed_book.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // borrow_BookTableAdapter
            // 
            this.borrow_BookTableAdapter.ClearBeforeFill = true;
            // 
            // qLBrBook
            // 
            this.qLBrBook.DataSetName = "QLBrBook";
            this.qLBrBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBrBookBindingSource
            // 
            this.qLBrBookBindingSource.DataSource = this.qLBrBook;
            this.qLBrBookBindingSource.Position = 0;
            // 
            // borrowBookBindingSource
            // 
            this.borrowBookBindingSource.DataMember = "Borrow_Book";
            this.borrowBookBindingSource.DataSource = this.qLBrBookBindingSource;
            // 
            // borrow_BookTableAdapter1
            // 
            this.borrow_BookTableAdapter1.ClearBeforeFill = true;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Form";
            this.Text = "Report_Form";
            this.Load += new System.EventHandler(this.Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKBorrowBoIDBo30F848EDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1010DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library1010DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBOOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBrBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBrBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource library1010DataSetBindingSource;
        private library1010DataSet library1010DataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private library1010DataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.BindingSource dataSetBOOKBindingSource;
        private DataSetBOOK dataSetBOOK;
        private System.Windows.Forms.BindingSource fKBorrowBoIDBo30F848EDBindingSource;
        private library1010DataSetTableAdapters.Borrow_BookTableAdapter borrow_BookTableAdapter;
        private System.Windows.Forms.BindingSource qLBrBookBindingSource;
        private QLBrBook qLBrBook;
        private System.Windows.Forms.BindingSource borrowBookBindingSource;
        private QLBrBookTableAdapters.Borrow_BookTableAdapter borrow_BookTableAdapter1;
    }
}