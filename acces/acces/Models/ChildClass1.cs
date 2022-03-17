using System;
using System.Collections.Generic;
using System.Text;

namespace acces.Models
{
    internal class ChildClass1 : Class1
    {

        public void Set()
        {
            Name = "public";
            Name1 = "internal";
            //Name2 = "private";
            Name3 = "private protected";
            Name5 = "protected internal";
        }

    }
}
