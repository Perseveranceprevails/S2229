using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj02
{
   public class CodeJob:Job
    {
        //消息框
        public override string Show()
        {
            string str = string.Format("有效编码行数：{0}\n遗留问题：{1}\n所需工作日：{2}",CodingLines,Bugs,WorkDay);
            return str;
        }
        //任务窗体
        public override void Execute()
        {
            frmCode c = new frmCode(this);
            c.ShowDialog();
        }

        //剩余bug数量
        public int Bugs { get; set; }
        //有效代码行
        public int CodingLines { get; set; }
        //剩余工作天数
        public int WorkDay { get; set; }
        public CodeJob() { }

        public CodeJob(string dec, string name, string type) : base(dec, name, type) { }
    }
}
