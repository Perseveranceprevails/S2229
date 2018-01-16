using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd01
{
    class SE
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public void Show(string Id, string name, int age, string Sex)
        {
            Console.WriteLine("大家好,我叫：{0},我的工号是：{1},今年{2}岁,性别{3}", name, Id, age, Sex);
        }
    }
}
