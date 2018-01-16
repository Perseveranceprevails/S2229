using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj02
{
   public abstract class Job
    {

       //显示消息框
       public abstract string Show();
       //打开任务窗体
       public abstract void Execute();
       //工作描述
        public string Description { get; set; }
       //工作名称
        public string  Name { get; set; }
       //工作类型
        public string Type { get; set; }

        public Job() { }
        public Job(string dec,string name,string type)
        {
            this.Description = dec;
            this.Name = name;
            this.Type = type;
        }
    }
}
