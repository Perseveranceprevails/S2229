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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        DBhelper d = new DBhelper();
        //保存预订信息 确定按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断非空验证是否成立
            if (isNotNull())
            {
                //如果成立就提交信息
                GetAdd();
            }
            else 
            {
                //如果不成立就返回提示框
                MessageBox.Show("所以文本框不能为空,请认真填写");
            }
        }
        //非空验证
        public bool isNotNull() 
        {
            bool a = true;
            //判断预定日期文本框是否为空
            if(this.txtTime.Text==null || this.txtTime.Text=="")
            {
                return a = false;//如果为空就返回a=false
            }
            //判断会议室文本框是否为空
            if(this.txtRoom.Text==null || this.txtRoom.Text=="")
            {
                return a = false;//如果为空就返回a=false
            }
            //判断预定事由文本框是否为空
            if(this.txtShi.Text==null || this.txtShi.Text=="")
            {
                return a = false;//如果为空就返回a=false
            }
            //判断预定人文本框是否为空
            if(this.txtYuName.Text==null || this.txtYuName.Text=="")
            {
                return a = false;//如果为空就返回a=false
            }
            //判断录入人文本框是否为空
            if(this.txtluName.Text==null || this.txtluName.Text=="")
            {
                return a = false;//如果为空就返回a=false
            }
            return a;//返回a
        }
        //录入数据库方法
        public void GetAdd() 
        {
            string Time = this.txtTime.Text;//获取预定时间文本框的值
            string Yname = this.txtYuName.Text;//获取预定人文本框的值
            string Shi = this.txtShi.Text;//获取预定事由文本框的值
            string Room = this.txtRoom.Text;//获取会议室文本框的值
            string lu = this.txtluName.Text;//获取录入人文本框的值
            try
            {
                //添加语句
                string Sql = string.Format(@"insert dbo.DestineRecord(DestineDate,DestineMan,DestineReason,BoardroomName,NoteMan)
                                             values ('{0}','{1}','{2}','{3}','{4}')", Time, Yname, Shi, Room, lu);
                //调用SqlCommand对象
                SqlCommand com = new SqlCommand(Sql, d.Con);
                //打开数据库连接
                d.OpenSql();
                //用int类型的变量接收SqlCommand对象点ExecuteNonQuery方法的返回值
                int count = com.ExecuteNonQuery();
                //判断接收的返回值是否大于1
                if (count > 0)
                {
                    //如果大于1就提交成功
                    MessageBox.Show("提交成功", "提示");
                }
                else
                {
                    //反之就提交失败
                    MessageBox.Show("提交失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //关闭数据库连接
                d.CloseSql();
            }
        }
        //清空按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            IsNull();//调用清空方法
        }
        //清空方法
        public void IsNull() 
        {
            //清空每项文本框的所以内容
            //清空预定时间文本框的值
            this.txtTime.Clear();
            //清空会议室文本框的值
            this.txtRoom.Clear();
            //清空预定事由文本框的值
            this.txtShi.Clear();
            //清空预定人文本框的值
            this.txtYuName.Clear();
            //清空录入人文本框的值
            this.txtluName.Clear();
        }
        //取消按钮
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭本窗体
        }
    }
}
