using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age, bool male) : base(name, age, male)
        { }

        public Tomcat(string name, bool male) : base(name, male)
        { }

        public Tomcat(bool male) : base(male)
        { }
    }
}
