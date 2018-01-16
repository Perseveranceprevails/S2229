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
        }
        //添加，删除
        List<HealthCheckItem> listAdd = new List<HealthCheckItem>();
        //单个项目集合
        public List<HealthCheckItem> list=new List<HealthCheckItem>();
        //套餐集合
        public List<HealthCheckItem> Items=new List<HealthCheckItem>();

        public  HealthCheckSet set;

        public HealthCheckItem hi3=new HealthCheckItem();
        //窗体加载时
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            GetItems();
            cboSetList.SelectedIndex = 1;
            GetSet();
        }
        //向Items集合中添加体检套餐
        public void GetItems() 
        {
            //体检套餐类
            HealthCheckItem hi = new HealthCheckItem();
            hi.Name = "入学体检";
            //体检套餐类
            HealthCheckItem hi2 = new HealthCheckItem(); 
            hi2.Name = "老年体检";
            cboSetList.Items.Add("请选择");
            Items.Add(hi);
            Items.Add(hi2);
            for (int i= 0;i< Items.Count ; i++)
			{
                this.cboSetList.Items.Add(Items[i].Name);
			}
        }
        //向list集合中添加体检项目
        public void GetSet() 
        {
            //检查项目类
            hi3 = new HealthCheckItem();
            hi3.Name = "身高";
            hi3.Description = "用于检查身高";
            hi3.Price = 5;
            list.Add(hi3);
            HealthCheckItem hi4 = new HealthCheckItem();
            hi4.Name = "体重";
            hi4.Description = "用于检查体重";
            hi4.Price = 5;
            list.Add(hi4);
            HealthCheckItem hi5 = new HealthCheckItem();
            hi5.Name = "视力";
            hi5.Description = "用于检查视力";
            hi5.Price = 30;
            list.Add(hi5);
            HealthCheckItem hi6 = new HealthCheckItem();
            hi6.Name = "听力";
            hi6.Description = "用于检查听力";
            hi6.Price = 20;
            list.Add(hi6);
            HealthCheckItem hi7 = new HealthCheckItem();
            hi7.Name = "肝功能";
            hi7.Description = "用于检查肝功能";
            hi7.Price = 50;
            list.Add(hi7);
            HealthCheckItem hi8 = new HealthCheckItem();
            hi8.Name = "心电图";
            hi8.Description = "用于检查心脏";
            hi8.Price = 50;
            list.Add(hi8);
            for (int a = 0; a < list.Count;a++ )
            {
                cbolitemsList.Items.Add(list[a].Name);
            }
            
        }
        //添加按钮
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            //调用添加方法
            GetAdd();  
        }
        //添加方法
        public void GetAdd() 
        {
            string name = this.cbolitemsList.Text;
            //循环遍历
            for (int b = 0; b < listAdd.Count;b++ )
            {
                //判断是否存在
                if (listAdd[b].Name.Equals(name))
                {
                    MessageBox.Show("该项目已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            //添加到集合
            listAdd.Add(list[cbolitemsList.SelectedIndex]);
            GetPrice();
            //MessageBox.Show("添加成功");
            //绑定数据源
            dgvList.DataSource = new BindingList<HealthCheckItem>(listAdd);
        }
        //删除按钮 删除检查项目
        private void btnDelete_Click(object sender, EventArgs e)
        {
            GetDelete();
        }
        //删除方法
        public void GetDelete() 
        {
            //获取要删除
            string listName = this.dgvList.SelectedRows[0].Cells[1].Value.ToString();
            //MessageBox.Show(listName);
            for (int c = 0; c < listAdd.Count;c++ )
            {
                if(listAdd[c].Name.Equals(listName))
                {
                    listAdd.Remove(listAdd[c]);
                    MessageBox.Show(string.Format("确定要删除{0}这一项吗？",listName,"提示",MessageBoxButtons.OK,MessageBoxIcon.Question));
                    GetPrice();
                }
            }
            dgvList.DataSource = new BindingList<HealthCheckItem>(listAdd);
        }
        //添加按钮  添加套餐名称
        private void btnSetAdd_Click(object sender, EventArgs e)
        {
            GetSetAdd();
        }
        public void GetSetAdd() 
        {
            
            string SetName = txtSetName.Text;
            for (int d = 0; d < Items.Count; d++)
            {
                if (!Items[d].Name.Equals(SetName))
                {
                    Items[d].Name = SetName;
                    cboSetList.Items.Add(SetName);
                    MessageBox.Show("添加成功");
                    break;
                }
                else 
                {
                     MessageBox.Show("该套餐已存在", "提示");
                     break;
                }
            }
        }
        //套餐名
        private void cboSetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetList.SelectedIndex != 0)
            {
                lblName.Text = cboSetList.Text;
            }
            else 
            {
                lblName.Text = "xxx";
            }
        }
        //总钱数
        public void GetPrice() 
        {
            int sum = 0;
            for (int i = 0; i < listAdd.Count;i++ )
            {
                sum += listAdhd[i].Price;
            }
            lblPrice.Text = sum.ToString();
        }
        

    }
}
