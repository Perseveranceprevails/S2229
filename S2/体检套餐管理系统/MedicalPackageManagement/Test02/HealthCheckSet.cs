using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    //套餐类
   public class HealthCheckSet
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

        private Dictionary<string, HealthCheckItem> item;

        public Dictionary<string, HealthCheckItem> Item
        {
            get { return item; }
            set { item = value; }
        }

        public HealthCheckSet() 
        {
            item = new Dictionary<string, HealthCheckItem>();
        }

        public HealthCheckSet(string name,Dictionary<string,HealthCheckItem> item) 
        {
            this.Name = name;
            this.Item = item;
        }

        public void GetPrice() 
        {
            int sum = 0;
            foreach (HealthCheckItem i in item.Values)
            {
                sum += i.Price;
            }
            this.price = sum;
        }
    }
}
