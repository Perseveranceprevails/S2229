using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_One
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //打开预定窗口
        private void 预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd();
            f.MdiParent = this;//以本窗体为父窗体打开
            f.Show(); //打开预定窗口
        }
        //打开查询窗口
        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelect f = new frmSelect();
            f.MdiParent = this;//以本窗体为父窗体打开
            f.Show();//打开查询窗口
        }
        //退出程序
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //推出整个程序
            Application.Exit();
        }
        
      
    }
}
