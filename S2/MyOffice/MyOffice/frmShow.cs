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
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
            Office();
            GetLV();
        }
        public SE[] se = new SE[3];
        public void Office()
        {
            se[0] = new SE();
            se[0].ID = 101;
            se[0].Name = "王小毛";
            se[0].Scorce = 0;
            se[0].Evaluation = "未评价";
            se[1] = new SE();
            se[1].ID = 102;
            se[1].Name = "周新宇";
            se[1].Scorce = 0;
            se[1].Evaluation = "未评价";
            se[2] = new SE();
            se[2].ID = 103;
            se[2].Name = "张烨";
            se[2].Evaluation = "未评价";
            se[2].Scorce = 0;
            
        }
        public void GetLV()
        {
            lvOffice.Items.Clear();
            for (int i = 0; i < se.Length; i++)
            {
                ListViewItem item = new ListViewItem(se[i].ID.ToString());
                item.SubItems.Add(se[i].Name);
                item.SubItems.Add(se[i].Age.ToString());
                item.SubItems.Add(se[i].Evaluation);
                item.SubItems.Add(se[i].Scorce.ToString());
                this.lvOffice.Items.Add(item);
            }

        }

        private void lvOffice_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(this.lvOffice.SelectedItems[0].SubItems[0].Text);
            int index=0;
            for (int a = 0; a < se.Length;a++ )
            {
                if(se[a].ID==Convert.ToInt32(this.lvOffice.SelectedItems[0].Text))
                {
                    index =a;
                    break;
                }
            }
   
            frmJudge k = new frmJudge(this,index);
            k.Show();
        }
    }
}
