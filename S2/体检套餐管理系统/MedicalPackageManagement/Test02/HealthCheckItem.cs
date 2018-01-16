using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    //项目类
   public class HealthCheckItem
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public HealthCheckItem(string name, int price, string description) 
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
    }
}
