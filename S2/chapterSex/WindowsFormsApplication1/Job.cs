using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Job
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public Job(string description,string name) 
        {
            this.Description = description;
            this.Name = name;
        }

    }
}
