using System;
using System.Collections.Generic;
using System.Text;

namespace acces.Models
{
    public class Class1
    {
        public string Name { get; set; }
        internal string Name1 { get; set; }
        private string Name2 { get; set; }
        protected string Name3 { get; set; }
        private protected string Name4 { get; set; }
        protected internal string Name5 { get; set; }

        public void Set()
        {
            Name = "public";
            Name1 = "internal";
            Name2 = "private";
            Name3 = "private protected";
            Name5 = "protected internal";
        }


    }
}
