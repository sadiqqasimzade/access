using System;
using acces.Models;
using Lib;

namespace acces
{
    internal class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.Name);             //public   
            Console.WriteLine(class1.Name1);            //internal  
            /*Console.WriteLine(class1.name2);*/            //private   
            /*Console.WriteLine(class1.name3);*/            //protected 
            /*Console.WriteLine(class1.name4);*/            //private    protected  
            Console.WriteLine(class1.Name5);            //protected  internal 

            LibClass libClass = new LibClass
            {
                Name = "public"
            };

        }
    }
}
