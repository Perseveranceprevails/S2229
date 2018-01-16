using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Init();
        }

        List<Employee> list=new List<Employee>();
        Job a, b;
        public void Init() 
        {
            List<Job> jobList = new List<Job>();
            jobList.Add(a=new Job("编码","购物车板块"));
            jobList.Add(b=new Job("测试","给购物车板块做测试"));
            SE se = new SE(23,Gender.男,"101","艾编程",100,jobList);

            PM pm = new PM(23,Gender.男,"102","Boos",1000,jobList);
            list.Add(se);
            list.Add(pm);
        }
        private void btnJob_Click(object sender, EventArgs e)
        {
            foreach(Employee item in list)
            {
              
                //if(item is SE)
                //{
                   
                //    SE se2 =(SE)item;
                //    MessageBox.Show(se2.DoWork(),"汇报");
                //}
                //if(item is PM)
                //{
                //    PM pm2 = (PM)item;
                //    MessageBox.Show(pm2.DoWork(),"汇报");
                //}
                MessageBox.Show(item.DoWork());
            }
        }

    }
}
