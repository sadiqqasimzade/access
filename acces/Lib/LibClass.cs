using System;
namespace Lib
{
    public class LibClass
    {

        public string Name { get; set; }
        internal string Name1 { get; set; }
        private string Name2 { get; set; }
        protected string Name3 { get; set; }
        private protected string Name4 { get; set; }
        protected internal string Name5 { get; set; }


    }
}
