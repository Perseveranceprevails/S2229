using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj02
{
   public class Employee
    {
        public string  Name { get; set; }
        public Employee() { }
        public Employee(string name)
        {
            this.Name = name;
        }
        public List<Job> WorkList { get; set; }
        public virtual string kList() 
        {
            return "";
        }
    }
}
