using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class PM:Employee
    {
        public int YearOfExperience { get; set; }

        public override string DoWork() 
        {
            string test =this.Name+":管理员工作完成工作内容！";
            return test;
        }

        public PM(int age,Gender Gender,string ID,string Name,int yearPfExperience,List<Job> list):
            base(age,Gender, ID, Name, list) 
        {
            this.YearOfExperience = yearPfExperience;
        }
        

    }
}
