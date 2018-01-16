using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj03
{
    class Car
    {   
        //在一个类中，方法名相同，而参数列表和参数个数不同的构造函数和普通方法都称为重载
        public void Run(string name,string colour,string site) 
        {
            Console.WriteLine("我是一辆{0}车，颜色是{1}，产地是{2}！",name,colour,site);
        }
        public void Run(string name,string colour,string site,int speed) 
        {
            Console.WriteLine("我是一辆{0},颜色是{1}，产地是{2},最高时速{3}！",name,colour,site,speed);
        }
        public Car()
        {
            CarName = "奔驰";
            CarColour = "红色";
            CarSite = "德国";
            Console.WriteLine("我是一辆{0}车，颜色是{1}，产地是{2}！", CarColour, CarColour, CarSite);
        }
        public string CarName { get; set; }
        public string CarColour { get; set; }
        public string CarSite { get; set; }
    }
}
