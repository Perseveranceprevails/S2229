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
    public partial class frmAdd : Form
    {
        public frmOffice o;
        public List<SE> li;
        public frmAdd()
        {
            InitializeComponent();
           
            this.cboSex.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetAdd();
        }

        public void GetAdd() 
        {
            //List<SE> list = new List<SE>();
            SE se = new SE();
            se.ID =Convert.ToInt32(txtId.Text.Trim());
            se.Name = txtName.Text.Trim();
            se.Age =Convert.ToInt32(txtAge.Text.Trim());
            if (cboSex.Text == "男")
            {
                se.Sex = "男";
            }
            else 
            {
                se.Sex = "女";
            }
           
            li.Add(se);
            o.GetList(li);
            //list.Add(se);
            //o.dgvOffice.DataSource = new BindingList<SE>(list);
        }
        

    }
}
