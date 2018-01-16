using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd02
{
    class SayHi
    {

        public void show(SE se)
        {
            Console.WriteLine("---程序员：{0}---",se.Name);
            Console.WriteLine("基本工资：{0}",se.BasicMoney);
            Console.WriteLine("考核工资：{0}",se.CheckMoney);
            Console.WriteLine("合计：" + (se.BasicMoney + se.CheckMoney));
        }

        public void show(PM pm)
        {
            Console.WriteLine("---项目经理：{0}---",pm.Name);
            Console.WriteLine("基本工资：{0}",pm.BasicMoney);
            Console.WriteLine("项目奖金：{0}",pm.ItemsMoney);
            Console.WriteLine("分红：{0}",pm.Dividend);
            Console.WriteLine("合计：" + (pm.BasicMoney + pm.ItemsMoney + pm.Dividend));
        }
    }
}
