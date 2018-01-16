using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class frmOffice : Form
    {
        
        public frmOffice()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd();
            f.o = this;
            f.li = list;
          
            f.Show();
        }
        public List<SE> list = new List<SE>();
        public void GetList(List<SE> list1) 
        {
            this.dgvOffice.AutoGenerateColumns = false;
            this.dgvOffice.DataSource = new BindingList<SE>(list);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            GetSelect();
        }
        public void GetSelect() 
        {
            List<SE> li = new List<SE>();
            foreach(SE i in list)
            {
                if(i.ID.ToString().IndexOf(txtId.Text)!=-1)
                {
                    li.Add(i);
                }
            }
            this.dgvOffice.DataSource =new  BindingList<SE>(li);
        }
    }
}
