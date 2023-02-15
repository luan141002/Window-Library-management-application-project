using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_1__Library
{
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBrBook.Borrow_Book' table. You can move, or remove it, as needed.
            this.borrow_BookTableAdapter1.Fill(this.qLBrBook.Borrow_Book);
            // TODO: This line of code loads data into the 'library1010DataSet.Borrow_Book' table. You can move, or remove it, as needed.
            this.borrow_BookTableAdapter.Fill(this.library1010DataSet.Borrow_Book);
            // TODO: This line of code loads data into the 'library1010DataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.library1010DataSet.BOOKS);

            this.reportViewer1.RefreshReport();
        }
    }
}
