using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Frog : Animal
    {
        public Frog(string name, int age, bool male) : base(name, age, male)
        { }

        public Frog(string name, bool male) : base(name, male)
        { }

        public Frog(bool male) : base(male)
        { }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\n{0} says: Guebec!", this.Name);
        }
    }
}
