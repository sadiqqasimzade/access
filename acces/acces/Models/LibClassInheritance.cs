using System;
using System.Collections.Generic;
using System.Text;

namespace acces.Models
{
    internal class LibClassInheritance:Lib.LibClass
    {


        public void ShowInfo()
        {
            Lib.LibClass libClass = new Lib.LibClass();
            Console.WriteLine(libClass.name);               //public   
            Console.WriteLine(libClass.name1);              //internal  
            Console.WriteLine(libClass.name2);              //private   
            Console.WriteLine(libClass.name3);              //protected 
            Console.WriteLine(libClass.name4);              //private    protected 
            Console.WriteLine(libClass.name5);              //protected  internal 
        }
    }
}
