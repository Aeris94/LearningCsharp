using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Human<Student>, IComparable<Student>
    {
        private int mark;

        public int Mark
        {
            get { return this.mark; }
            set { this.mark = value; }
        }

        public Student(string firstName, string lastName, int mark) : base(firstName, lastName)
        {
            this.mark = mark;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\nMark: {0}", this.mark);
        }

        public int CompareTo(Student s)
        {
            if (this.mark < s.mark)
                return -1;
            else if (this.mark > s.mark)
                return 1;
            else
                return 0;
        }
    }
}
