using System;
using System.Numerics;
using System.Xml.Linq;

namespace Constructor
{
    public class InheritConstructor
    {
        public InheritConstructor(string Name) : this(Name, 23)
        {

        }
        public InheritConstructor(string Name, int Age)
        {
            Name = Name;
            Age = Age;
        }




    }
}