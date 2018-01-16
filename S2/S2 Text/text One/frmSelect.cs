using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_One
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }
        DBhelper d = new DBhelper();
        DataSet set = new DataSet();
        //窗体运行时
        private void frmSelect_Load(object sender, EventArgs e)
        {
            GetRoom();//在本窗体运行时调用方法
        }
        //获取信息
        public void GetRoom() 
        {
            try 
            {
                //查询语句
                string Sql=@"select ID,DestineDate,BoardroomName,DestineReason,DestineMan,NoteMan
                            from dbo.DestineRecord";
                //调用SqlDataAdapter对象以便向DataSet数据集中传数据
                SqlDataAdapter adapter = new SqlDataAdapter(Sql, d.Con);
                //判断数据集中是否为空
                if (set.Tables["DestineRecord"]!=null)
                {
                    //如果不为空就清空数据集
                    set.Tables["DestineRecord"].Clear();
                }
                //向数据集中填充数据
                adapter.Fill(set, "DestineRecord");
                //向dataGridView绑定数据源
                this.dgvRoom.DataSource = set.Tables["DestineRecord"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
