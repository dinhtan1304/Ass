using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.M._0011.Exercise2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private double _salary;
        /// <summary>
        /// check salary > 0 if not set value of salary = 0
        /// </summary>
        public double MonthlySalary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    _salary = 0.0;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Employee() { }
        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        public override string? ToString()
        {
            return "FirstName: " + FirstName + "\n" +
                    "LastNaem: " + LastName + "\n" +
                    "MonthlySalary: " + MonthlySalary;
        }
    }
}
