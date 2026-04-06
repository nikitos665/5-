using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace _5_лаб._2_задача
{
    internal class student
    {
        public string name;
        public string age;
       public student ()
        {
            name = "Иван";
            age = "18";
        }
        public student (string name) : this(name, "18")
        {

        }
        
        public student (string name, string age)
        {
            this.name = name;
            this.age = age;
        }
        public void printinfo()
        {
            System.Console.WriteLine($"Студент {name} {age} лет");
        }
    }
}
