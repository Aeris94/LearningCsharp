using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Human<T> where T: IComparable<T>
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("First name: {0} \nLast name: {1}", this.firstName, this.lastName);
        }

        static public void SortDesc(T []array)
        {
            T temp;
            T max;
            int index =0;
            int stop = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                    break;
                stop++;
            }

            for(int i =0; i < stop -1; i++)
            {
                max = array[i];
                for(int j = i+1; j< stop; j++)
                {
                    if(max.CompareTo(array[j]) < 0)
                    {
                        max = array[j];
                        index = j;
                    }
                }
                if(max.CompareTo(array[i]) != 0)
                {
                    temp = array[i];
                    array[i] = max;
                    array[index] = temp;
                }
            }
        }
    }
}
