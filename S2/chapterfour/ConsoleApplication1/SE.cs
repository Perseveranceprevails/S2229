using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class SE
    {
       public int ID { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
       //在构造方法中可以给属性设置默认值
       public SE()
       {
           //this指代当前对象
           this.ID = 101;
           this.Name = "艾边成";
           this.Age = 18;
      }
    }
}
