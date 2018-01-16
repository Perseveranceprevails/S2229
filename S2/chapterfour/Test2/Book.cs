using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Book
    {
        public int Price { get; set; }
        public string BookName { get; set; }
        public string Name { get; set; }
       
        //有参构造函数
        public Book(int Price,string BookName,string Name) 
        {
            this.Price = Price;
            this.BookName = BookName;
            this.Name = Name;
        } 
        //无参构造函数
        public Book()
        {
            this.Price = 100;
            this.BookName = "思绪飘零";
            this.Name = "微冷的雨";
        }
    }
}
