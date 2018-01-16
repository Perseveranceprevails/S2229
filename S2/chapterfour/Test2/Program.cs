using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Price = 100;
            b.BookName = "思绪飘零1";
            b.Name = "微冷的雨1";



            int price = 100;
            string BookName = "思绪飘零";
            string Name = "微冷的雨";
            Book b2 = new Book(price, BookName, Name);
            Console.WriteLine("{0},{1},{2}",b.Price,b.BookName,b.Name);
            Console.WriteLine("{0},{1},{2}",b2.Price,b2.BookName,b2.Name);
            Console.ReadLine();
            
        }
    }
}
