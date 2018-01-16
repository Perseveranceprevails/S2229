using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02
{
    public partial class frmMain : Form
    {
        //窗体中主要实现代码
        public frmMain()
        {
            InitializeComponent();
        }
        //用于保存单个项目
        HealthCheckItem h1, h2, h3, h4, h5, h6, h7, h8;
        //单个项目集合
        Dictionary<string, HealthCheckItem> allItem = new Dictionary<string, HealthCheckItem>();
        //一个套餐所包含的项目
        Dictionary<string, HealthCheckItem> items = new Dictionary<string, HealthCheckItem>(); 
        //套餐集合
        Dictionary<string, HealthCheckSet> allSet = new Dictionary<string, HealthCheckSet>();
        //定义一个初始化套餐
        HealthCheckSet set;
        //向初始化的套餐添加各个项目
        public void GetItems() 
        {
            h1 = new HealthCheckItem("身高",5,"用于检查身高");
            h2 = new HealthCheckItem("体重", 5, "用于检查体重");
            h3 = new HealthCheckItem("视力", 5, "用于检查视力");
            h4 = new HealthCheckItem("听力", 5, "用于检查听力");
            h5 = new HealthCheckItem("B超", 30, "用于检查B超");
            h6 = new HealthCheckItem("肝功能", 30, "用于检查肝功能");
            h7 = new HealthCheckItem("心电图", 50, "用于检查心电图");
            h8 = new HealthCheckItem("血常规", 50, "用于检查血常规");
            allItem.Add(h1.Name, h1);
            allItem.Add(h2.Name, h2);
            allItem.Add(h3.Name, h3);
            allItem.Add(h4.Name, h4);
            allItem.Add(h5.Name, h5);
            allItem.Add(h6.Name, h6);
            allItem.Add(h7.Name, h7);
            allItem.Add(h8.Name, h8);

        }
        //添加一个套餐
        public void GetSet() 
        {
            items.Add(h1.Name,h1);
            items.Add(h3.Name, h3);
            items.Add(h4.Name, h4);
            set = new HealthCheckSet("入学体检",items);
            set.GetPrice();
            allSet.Add("入学体检",set);
        }
        //绑定下拉框 
        public void GetCbo() 
        {
            cboSetList.Items.Clear();
            cboSetList.Items.Add("请选择");
            foreach (string a in allSet.Keys)
            {
                cboSetList.Items.Add(a);
            }
            this.cboSetList.SelectedIndex = 0;

            cbolitemsList.Items.Clear();
            cbolitemsList.Items.Add("请选择");
            foreach (string a in allItem.Keys)
            {
                cbolitemsList.Items.Add(a);
            }
            this.cbolitemsList.SelectedIndex = 0;
        }
        //窗体加载时调用各个方法
        private void frmMain_Load(object sender, EventArgs e)
        {

            GetItems();
            GetSet();
            GetCbo();
        }
        //更新DataGridView的值
        public void UpdateSet(HealthCheckSet set) 
        {
            this.dgvList.DataSource = new BindingList<HealthCheckItem>(set.Item.Values.ToList());
        }
        //
        private void cboSetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.cboSetList.Text;
            if(name=="请选择")
            {
                this.dgvList.DataSource=new BindingList<HealthCheckItem>();
                this.lblName.Text = "";
                this.lblPrice.Text = "";
                return;
            }
            this.lblName.Text = name;
            GetPrice();
            UpdateSet(allSet[name]);
        }
        //向套餐中添加项目
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if(this.cbolitemsList.SelectedIndex==0)
            {
                MessageBox.Show("请选择要添加的项目");
                return;
            }
            string name=this.cboSetList.Text;
            if(name=="请选择")
            {
                MessageBox.Show("请选择套餐");
                return;
            }
            if (!allSet[name].Item.Keys.ToList().Contains(this.cbolitemsList.Text))
            {
                allSet[name].Item.Add(this.cbolitemsList.Text, allItem[this.cbolitemsList.Text]);
                this.lblName.Text = name;
                GetPrice();
                UpdateSet(allSet[name]);
            }
            else 
            {
                MessageBox.Show("已有该项目");
            }
        }
        
        //添加套餐
        private void btnSetAdd_Click(object sender, EventArgs e)
        {
            string setName=this.txtSetName.Text;
            if (this.txtSetName.Text.Trim() != null && this.txtSetName.Text.Trim() != "")
            {
                HealthCheckSet set = new HealthCheckSet();
                allSet.Add(txtSetName.Text, set);
                
                GetCbo();
                this.cboSetList.SelectedIndex = allSet.Count();
                MessageBox.Show("添加成功");
            }
            else 
            {
                MessageBox.Show("请输入套餐名称");
            }
        }
       
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = this.dgvList.SelectedRows[0].Cells[0].Value.ToString();
            string Setname = this.cboSetList.Text;
            MessageBox.Show(string.Format("确定要删除"+name+"这一项吗？","提示"));
            allSet[Setname].Item.Remove(name);
            UpdateSet(allSet[Setname]);
        }
        //总价
        public void GetPrice()
        {
            int sum = 0;
            foreach (HealthCheckItem i in items.Values)
            {
                sum += i.Price;
            }
            lblPrice.Text = sum.ToString();
        }

       

        



        
    }
}
