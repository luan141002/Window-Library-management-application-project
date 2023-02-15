using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_1__Library.Report
{
    public partial class EmSaRecs : Form
    {
        public EmSaRecs()
        {
            InitializeComponent();
        }

        private void EmSaRecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBrBook.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter1.Fill(this.qLBrBook.EMPLOYEES);
            // TODO: This line of code loads data into the 'qLNV.EMPLOYEES' table. You can move, or remove it, as needed.

           // this.eMPLOYEESTableAdapter.Fill(this.qLNV.EMPLOYEES);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
