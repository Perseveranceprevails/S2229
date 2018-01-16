using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj04
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            GetAdd();
            this.cboType.SelectedIndex = 0;
        }
        Operation o;
        public void GetAdd() 
        {
            this.cboType.Items.Add("+");
            this.cboType.Items.Add("-");
            this.cboType.Items.Add("*");
            this.cboType.Items.Add("/");
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            //if(IsNotNull())
            //{
                GetResult();
            //}
            //MessageBox.Show("请输入正确的操作数");
        }
        public bool IsNotNull() 
        {
            bool a = true;
            if(this.txtNum1.Text.Trim()=="" && this.txtNum1.Text.Trim()==null)
            {
                return a = false;
            }
            if(this.txtNum2.Text.Trim()=="" && this.txtNum2.Text.Trim()==null)
            {
                return a = false;
            }
            return a;
        }
        public void GetResult()
        {  
            switch(this.cboType.Text)
            {
                case "+":
                    o = new GetAdd();
                    
                        break;
                case "-":
                        o = new GetReduce();
                        
                        break;
                case "*":
                        o = new GetRide();
                        
                        break;
                case "/":
                        o = new GetExcept();
                        
                        break;
            }
            o.num1 = double.Parse(this.txtNum1.Text);
            o.num2 = double.Parse(this.txtNum2.Text);
            this.lblSum.Text = o.GetResult().ToString();
        }
    }
}
