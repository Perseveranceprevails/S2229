using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class HealthCheckSet
    {
        frmMain f=new frmMain();
        //单个项目集合
        List<HealthCheckItem> list = new List<HealthCheckItem>();
        //套餐 集合
        private List<HealthCheckItem> items;
        //套餐价格
        private int price;
        //套餐名称
        private string name;
        public List<HealthCheckItem> Items 
        {
            get { return items; }
            set { items = value; }
        }
        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public HealthCheckSet() 
        {
            //f.Items = this.Items;
            //f.list = this.list;
            //f.set = this;
        }
        //套餐总和
        public void CalcPrice() 
        {
            int sum = 0;
            foreach(HealthCheckItem items in Items)
            {
                sum += items.Price;
            }
            this.price = sum;
        }
    }
}
