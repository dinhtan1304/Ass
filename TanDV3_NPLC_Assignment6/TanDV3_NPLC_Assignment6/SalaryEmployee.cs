using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public class SalaryEmployee : Employee
    {
        public double CommissionRate { get; set; }
        public double GrossSale { get; set; }
        public double BasicSalary { get; set; }

        public SalaryEmployee()
        {
        }

        public SalaryEmployee(string ssn, string firstName, string lastName, string birthDate, string phone, string email, double commissionRate, double grossSale, double basicSalary)
            : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            CommissionRate = commissionRate;
            GrossSale= grossSale;
            BasicSalary= basicSalary;
        }

        public override string? ToString()
        {
            Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}{6,-15}{7,-15}{8,-15}", "SSN", "FirstName", "LastName", "BirthDate", "Phone", "Email", "CommissionRate", "GrossSale", "BasicSalary"));
            return string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}", Ssn, FirstName, LastName, BirthDate, Phone, Email, CommissionRate,GrossSale,BasicSalary);
        }
    }
}
