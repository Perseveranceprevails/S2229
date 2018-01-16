using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj02
{
   public class TestJob:Job
    {
        //消息框
        public override string Show()
        {
            string str = string.Format("测试用例个数：{0}\n发现Bug数量：{1}\n所需工作日：{2}", CaseNum, FindBugs, WorkDay);
            return str;
        }
        //任务窗体
        public override void Execute()
        {
            frmTest t = new frmTest(this);
            t.ShowDialog();
        }

        //测试用例个数
        public int CaseNum { get; set; }
        //发现bug数量
        public int FindBugs { get; set; }
        //完成日期
        public int WorkDay { get; set; }

        public TestJob() { }
        public TestJob(string dec, string name, string type):base(dec,name,type) { }
    }
}
