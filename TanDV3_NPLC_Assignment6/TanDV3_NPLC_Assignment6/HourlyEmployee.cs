using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; }
        public double WorkingHours { get; set; }

        public HourlyEmployee()
        {

        }

        public HourlyEmployee(string ssn, string firstName, string lastName, string birthDate, string phone, string email, double wage, double workingHours) : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            Wage= wage;
            WorkingHours= workingHours;
        }

        public override string? ToString()
        {
            Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}{6,-15}{7,-15}", "SSN", "FirstName", "LastName", "BirthDate", "Phone", "Email", "wage", "workingHours"));
            return string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}", Ssn, FirstName, LastName, BirthDate, Phone, Email,Wage,WorkingHours);
        }
    }
}
