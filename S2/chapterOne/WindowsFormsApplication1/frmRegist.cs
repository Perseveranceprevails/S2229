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
    public partial class frmRegist : Form
    {
        public frmLogin fll;
        public frmRegist(frmLogin FL)
        {
            InitializeComponent();
            fll = FL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNotNull())
            {
                if (this.txtEmail.Text == this.txtEmail2.Text && this.txtPwd.Text == this.txtPwd2.Text)
                {
                    Getshow();
                }
                else 
                {
                    MessageBox.Show("请检查再次输入的邮箱或密码是否一致");
                }
                
            }
            else 
            {
                MessageBox.Show("请输入所有文本框的信息");
            }
        }
        //非空验证
        public bool IsNotNull() 
        {
            bool a = true;
            if(this.txtName.Text==null || this.txtName.Text=="")
            {
                return a = false;
            }
            if (this.txtNumber.Text == null || this.txtNumber.Text == "")
            {
                return a = false;
            }
            if (this.txtEmail.Text == null || this.txtEmail.Text == "")
            {
                return a = false;
            }
            if (this.txtEmail2.Text == null || this.txtEmail2.Text == "")
            {
                return a = false;
            }
            if (this.txtPwd.Text == null || this.txtPwd.Text == "")
            {
                return a = false;
            }
            if (this.txtPwd2.Text == null || this.txtPwd2.Text == "")
            {
                return a = false;
            }
            return a;
        }
        public void Getshow()
        {
            string Name = this.txtName.Text;
            string Number = this.txtNumber.Text;
            string Email = this.txtEmail.Text;
            string Pwd = this.txtPwd.Text;
            MessageBox.Show("通过注册验证");
            for (int a = 0; a < fll.array.Length;a++ )
            {
                if (fll.array[a] == null)
                {
                    LoginInfo i = new LoginInfo();
                    i.Name = Name;
                    i.ID = Number;
                    i.Email = Email;
                    i.Password = Pwd;
                    fll.array[a] = i;
                    break;
                }
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
