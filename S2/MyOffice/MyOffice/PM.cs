using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
   public class PM
    {
    
        public int ID { get; set; }
  
        public int Age { get; set; }
       
        public string Name { get; set; }
    
        public string Sex { get; set; }
     
        public string Seniority { get; set; }
        public void Update(SE se,string Evaluation,string Scorce) 
        {
            se.Evaluation=Evaluation;
            se.Scorce = Convert.ToInt32(Scorce);
        }
    }
}
