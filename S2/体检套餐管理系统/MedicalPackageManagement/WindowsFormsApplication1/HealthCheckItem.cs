using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class HealthCheckItem
    {
      
        //项目描述
        private string description;
        //项目名称
        private string name;
        //项目价格
        private int price;
        public string Description 
        {
            get { return description; }
            set { description = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
        public HealthCheckItem() 
        {
            
        }
       
    }
}
