using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Employee
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string ID{ get; set; }
        public string  Name { get; set; }
        public List<Job> WorkList { get; set; }
        public Employee() 
        {

        }
        public virtual string DoWork() 
        {
            string message = "大家好";
            return message;
        }
        public Employee(int age,Gender gender,string id,string name,List<Job> Work)
        {
            this.Age = age;
            this.Gender = gender;
            this.ID = id;
            this.Name = name;
            this.WorkList = Work;
        }
    }
}
