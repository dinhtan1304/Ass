using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public class Validation
    {
        public static bool CheckIdExist(List<Employee> employees, string ssn)
        {
            foreach (Employee employee in employees)
            {
                if (ssn.Contains(employee.Ssn))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValiString(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input.Length > 0;
            }
            return false;
        }
        public static bool IsValiDouble(string input) 
        {
            if (double.TryParse(input, out double result))
            {
                return result > 0.0;
            }
            return false;
        }
        public static bool IsValiDate(string birthDate)
        {
            bool isValiDate = DateTime.TryParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out DateTime result);
            return isValiDate & result < DateTime.Now;
        }
        public static bool IsVaidPhone(string phone)
        {
            if (phone.Length >= 7)
            {
                return Int32.TryParse(phone, out int result) && result > 0;
            }
            return false;
        }
        public static bool IsVaidEmail(string email)
        {
            return email.Contains("@") && email.Length > 5;
        }
    }
}
