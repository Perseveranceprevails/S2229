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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Init();
        }
        public void Init() 
        {
            List<SE> list = new List<SE>();
            list.Add(new SE(101,"王小猫",100));
            list.Add(new SE(102,"王大毛",100));
            list.Add(new SE(103,"王三毛",100));
            this.dgvSElist.DataSource=new BindingList<SE>(list);

        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShow s = new frmShow(this);
            s.ShowDialog();
            //DataGridViewRow dr = this.dgvSElist.CurrentRow;
            //if(dr==null)
            //{
            //    return;
            //}
            //string name = dr.Cells[1].Value.ToString();
            //s.Name = name + "开始演奏";
        }
    }
}
