using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace _5_лаб._3_задача
{
    internal class car
    {
        public string brand = "Unkown";
        public string model = "Unkown";
        public string year = "2000";
        public car() { }
        public void getinfo() { Console.WriteLine($"{this.brand} {this.model} {this.year}"); }

    }
}
