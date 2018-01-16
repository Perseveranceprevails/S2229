using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jd04
{
    public partial class frmMain : Form
    {
        List<BankCard> list = new List<BankCard>();
        public frmMain()
        {
            InitializeComponent();
            this.lblSparmoney.Text = "";
            this.lblBankCard.Text = "";
            this.lblName.Text = "";
            this.btnSelect.Enabled = false;
            this.btnGetmoney.Enabled = false;
            this.btnPassmoney.Enabled = false;
            Init();
        }
        //初始化 创建对象
        public void Init() 
        {
            MyBank m = new MyBank(101,0,"小明",10000);
            MyBank m2 = new MyBank(102,0,"小红",10000);

            OtherBank o = new OtherBank(201,0,"小强",10000);
            list.Add(m);
            list.Add(m2);
            list.Add(o);

        }
        //插卡按钮
        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            InsertCard();
        }
        public void InsertCard() 
        {
            MessageBox.Show("111");
            bool flag = false; //登陆失败
            foreach (BankCard item in list)
            {

                if (item.Number.ToString() == this.txtBankCard.Text.Trim() && item.Password.ToString() == this.txtPwd.Text.Trim())
                {
                    this.btnSelect.Enabled = true;
                    this.btnGetmoney.Enabled = true;
                    this.btnPassmoney.Enabled = true;
                    this.lblBankCard.Text = item.Number.ToString();
                    this.lblName.Text = item.Name;
                    flag = true;
                    
                }
                //else if (item.Number.ToString() != this.txtBankCard.Text.Trim() || item.Password.ToString() != this.txtPwd.Text.Trim())
                //{
                //    MessageBox.Show("请输入正确的账号或密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.txtBankCard.Clear();
                //    this.txtPwd.Clear();
                //    break;
                //}
            }
            if (flag==false)
            {
                MessageBox.Show("请输入正确的账号或密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBankCard.Clear();
                this.txtPwd.Clear();
            }
        }
        //查询 余额
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectMoney();
        }
        //余额
        public void SelectMoney() 
        {
            for (int i = 0; i < list.Count;i++ )
            {
                if(list[i].Number.ToString()==this.txtBankCard.Text)
                {
                    this.lblSparmoney.Text = list[i].Banlance.ToString();
                }
            }
        }
        //取款
        private void btnGetmoney_Click(object sender, EventArgs e)
        {
            int money=Convert.ToInt32(this.txtGetmoney.Text);
           foreach(BankCard item in list)
           {
               if (item.Number.ToString() == this.txtBankCard.Text) 
               {
                   int Result = item.GetMoney(money);
                   this.lblSparmoney.Text = Result.ToString();
               }
               //if(item is MyBank)
               //{
               //    int Result=item.GetMoney(money);
               //    this.lblSparmoney.Text = Result.ToString();
               //}
               //if(item is OtherBank)
               //{
               //    int Result = item.GetMoney(money);
               //    this.lblSparmoney.Text = Result.ToString();
               //}
           }
        }
        //转账
        private void btnPassmoney_Click(object sender, EventArgs e)
        {
            GetMoney();
        }
        public void GetMoney() 
        {
            int Result=Convert.ToInt32(this.txtPassmoney.Text);
            foreach(BankCard item in list)
            {
                if(item.Number.ToString()==this.txtCard.Text)
                {
                    item.Banlance += Result;
                    
                }
                if(item.Number.ToString()==this.txtBankCard.Text)
                {
                    item.Banlance -= Result;
                    this.lblSparmoney.Text = item.Banlance.ToString();
                }
            }
        }
        //退卡
        private void btnrefund_Click(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = false;
            this.btnGetmoney.Enabled = false;
            this.btnPassmoney.Enabled = false;
            lblSparmoney.Text = "";
            lblBankCard.Text = "";
            lblName.Text = "";
            txtBankCard.Clear();
            txtPwd.Clear();
            txtPassmoney.Clear();
            txtCard.Clear();
        }
        //程序退出
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
