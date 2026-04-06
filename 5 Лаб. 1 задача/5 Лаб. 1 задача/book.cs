using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Лаб._1_задача
{
    internal class book
    {
        public string title = "Неизвестно";
        public int pages;
        public void getinfo()
        {
            Console.WriteLine($"Книга {title} ( {pages} страниц)");
        }
    }
}
