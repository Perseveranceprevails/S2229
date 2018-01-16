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
    public partial class frmCode : Form
    {
        public CodeJob cj;
        public frmCode(CodeJob j)
        {
            InitializeComponent();
            cj = j;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cj.CodingLines =Convert.ToInt32(this.txtLines.Text);
            cj.Bugs =Convert.ToInt32(this.txtBugs.Text);
            cj.WorkDay =Convert.ToInt32(this.txtDays.Text);
            MessageBox.Show("提交成功");
            this.Close();
        }
    }
}
