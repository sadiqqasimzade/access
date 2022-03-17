using System;
using System.Collections.Generic;
using System.Text;

namespace acces.Models
{
    internal class Class1
    {
        public   string name = "Sadiq";
        internal string name1 = "Sadiq";
        private  string name2 = "Sadiq";
        protected string name3 = "Sadiq";
        private   protected string name4 = "Sadiq";
        protected internal string name5 = "Sadiq";


        public void ShowInfo() //oz classinda istenilen modify ile her yanda el catandi
        {
            Console.WriteLine(name);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
        }

    }
}
