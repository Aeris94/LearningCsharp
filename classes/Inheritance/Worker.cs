using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Worker : Human<Worker>, IComparable<Worker>
    {
        private double wage;
        private int hoursWorked;

        public double Wage
        {
            get { return this.wage; }
            set { this.wage = value; }
        }

        public int HoursWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }

        public double CalcHourlyWAge
        {
            get { return wage / hoursWorked; }
        }

        public Worker(string firstName, string lastName, double wage, int hoursWorked) : 
                base(firstName, lastName )
        {
            this.wage = wage;
            this.hoursWorked = hoursWorked;
        }

        public int CompareTo(Worker w)
        {
            if (this.wage < w.wage)
                return -1;
            else if (this.wage > w.wage)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\nWage: {0} \nHours: {1} \nSalary per hour: {2}", this.wage, this.hoursWorked, this.CalcHourlyWAge);
        }
    }
}
