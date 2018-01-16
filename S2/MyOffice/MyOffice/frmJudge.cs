using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class frmJudge : Form
    {
        public SE se1;
        public frmShow show;
        public int index;
        public frmJudge(frmShow show1,int index)
        {
            InitializeComponent();
            this.show = show1;
            this.se1 = this.show.se[index];
            index = this.index;
        }

        private void frmJudge_Load(object sender, EventArgs e)
        {
            this.txtName.Text = se1.Name;
            this.txtEvaluation.Text = se1.Evaluation;
            this.txtScore.Text = se1.Scorce.ToString();
        }

        private void btnEvaluation_Click(object sender, EventArgs e)
        {
            PM p = new PM();
            p.Update(this.se1, txtEvaluation.Text,txtScore.Text);
            show.GetLV();
        }
    }
}
