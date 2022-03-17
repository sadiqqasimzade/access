using System;
using System.Collections.Generic;
using System.Text;

namespace acces.Models
{
    internal class ChildClass1:Class1
    {
        public void ShowInfo() //oz classinda istenilen modify ile her yanda el catandi
        {
            Console.WriteLine(name);             //public   
            Console.WriteLine(name1);            //internal  
            /*Console.WriteLine(name2);  */      //private   
            Console.WriteLine(name3);            //protected 
            Console.WriteLine(name4);            //private    protected  
            Console.WriteLine(name5);            //protected  internal 
        } 
    }
}
