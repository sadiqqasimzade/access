using System;
using System.Collections.Generic;
using System.Text;
using Lib;
namespace acces.Models
{
    public class Inheritence : LibClass
    {
        public void ShowInfo()
        {

            Name = "public";
            //Name1 = "internal";
            //Name2 = "private";
            Name3 = "private protected";
            Name5 = "protected internal";



        }
    }
}
