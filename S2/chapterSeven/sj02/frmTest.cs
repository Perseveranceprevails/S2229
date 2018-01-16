using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj02
{
    public partial class frmTest : Form
    {
        public TestJob tj;
        public frmTest(TestJob t)
        {
            InitializeComponent();
            tj = t;
        }
        //提交按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tj.CaseNum =Convert.ToInt32(this.txtLines.Text);
            tj.FindBugs = Convert.ToInt32(this.txtBugs.Text);
            tj.WorkDay = Convert.ToInt32(this.txtDays.Text);
        }
    }
}
