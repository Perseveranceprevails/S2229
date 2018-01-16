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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public LoginInfo[] array;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            array = new LoginInfo[10];
            LoginInfo i = new LoginInfo();
            i.Name = "赵昌平";
            i.ID = "123456";
            i.Email = "123@qq.com";
            i.Password = "123";
            array[0] = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNotNull())
            {
                Getshow();
            }
            else 
            {
                MessageBox.Show("请输入所以文本框信息");
            }
        }
        public bool IsNotNull() 
        {
            bool a = true;
            if(this.txtEmail.Text==null||this.txtEmail.Text=="")
            {
                return a = false;
            }
            if(this.txtPwd.Text==null||this.txtPwd.Text=="")
            {
                return a = false;
            }
            return a;
        }
        public void Getshow() 
        {
            string Email = this.txtEmail.Text;
            string Pwd = this.txtPwd.Text;
            foreach (LoginInfo a in array)
            {
                if(a!=null)
                {
                    if(a.Email==Email && a.Password==Pwd)
                    {
                        frmMain f = new frmMain();
                        f.lblName.Text = "欢迎你："+a.Name;
                        f.Show();
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            frmRegist f = new frmRegist(this);
            f.Show();
        }
    }
}
