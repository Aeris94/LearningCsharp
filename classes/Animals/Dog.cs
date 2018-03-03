using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        public Dog(string name, int age, bool male) : base(name, age, male)
        { }

        public Dog(string name, bool male) : base(name, male)
        { }

        public Dog(bool male) : base(male)
        { }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\n{0} says: Hauuu!", this.Name);
        }
    }
}
