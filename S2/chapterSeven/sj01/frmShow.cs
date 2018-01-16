using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj01
{
    public partial class frmShow : Form
    {
        frmMain m;
        public frmShow(frmMain M)
        {
            InitializeComponent();
            m = M;
            //演奏者名字
            string name= m.dgvSElist.SelectedRows[0].Cells[1].Value.ToString();
            this.gbShow.Text = name + "开始演奏";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Instrument it = null;
            if(this.rbtnPiano.Checked)
            {
                it = new Piano();
                MessageBox.Show(it.Play(),"信息！");
            }
            if(this.rbtnSach.Checked)
            {
                it = new Sachs();
                MessageBox.Show(it.Play(),"信息!");
            }
            if(this.rbtnViolin.Checked)
            {
                it = new Violin();
                MessageBox.Show(it.Play(), "信息!");
            }
        }
        
       
    }
}
