using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public class Employee : IInterface
    {

        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Employee()
        {
        }

        public Employee(string ssn, string firstName, string lastName, string birthDate, string phone, string email)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        }

        public override string? ToString()
        {
            Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}","SSN","FirstName","LastName","BirthDate","Phone","Email"));
            return string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}",Ssn,FirstName,LastName,BirthDate,Phone,Email);
        }
        public void Display(Employee e)
        {
            Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}", "SSN", "FirstName", "LastName", "BirthDate", "Phone", "Email"));
            Console.WriteLine( string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}", e.Ssn, e.FirstName, e.LastName, e.BirthDate, e.Phone, e.Email));
        }

        public double GetPaymentAmout()
        {
            return 0.1;
        }
    }
}
