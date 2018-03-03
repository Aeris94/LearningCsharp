using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Animal
    {
        protected string name;
        protected int? age;
        protected bool male;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public bool Male
        {
            get { return this.male; }
            set { this.male = value; }
        }

        public Animal(bool male) : this("Unknown", null, male)
        { }

        public Animal(string name, bool male) : this(name, null, male)
        { }

        public Animal(string name, int? age, bool male)
        {
            this.name = name;
            this.age = age;
            this.male = male;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1} \nMale: {2}", this.name, this.age, this.male);
        }
    }
}
