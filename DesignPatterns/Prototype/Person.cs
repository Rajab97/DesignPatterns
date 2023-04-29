using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public abstract class Person : ICloneable<Person>,IDeepCloneable<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public abstract Person Clone();

        public abstract Person DeepClone();
    }
}
