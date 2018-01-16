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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Init();
        }
        //Employee employee;
        //初始化
        List<Job> list = new List<Job>();
        public void Init() 
        {
            
            list.Add(new CodeJob("登录代码","编码","编码"));
            list.Add(new CodeJob("购物车代码","编码","编码"));
            list.Add(new TestJob("测试购物车","测试","测试"));
            SE se = new SE("汪小麦");
            this.gbSE.Text = se.Name;

            this.dgvJobList.DataSource = new BindingList<Job>(list);
        }
        //打开任务窗体 执行
        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dgvJobList.CurrentRow.Index;
            list[index].Execute();
        }
        //打开消息框 完成情况
        private void 完成情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dgvJobList.CurrentRow.Index;
            string s=list[index].Show();
            MessageBox.Show(s,"指标完成情况");
        }

    }
}
