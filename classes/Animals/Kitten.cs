using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, bool male) : base(name, age, male)
        { }

        public Kitten(string name, bool male) : base(name, male)
        { }

        public Kitten(bool male) : base(male)
        { }
    }
}
