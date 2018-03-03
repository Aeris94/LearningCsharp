using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cat : Animal
    {
        public Cat(string name, int age, bool male) : base(name, age, male)
        { }

        public Cat(string name, bool male) : base(name, male)
        { }

        public Cat(bool male) : base(male)
        { }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\n{0} says: Miauuu!", this.Name);
        }
    }
}
