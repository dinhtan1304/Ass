using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TPBank.Entities
{

    public static class Validate
    {
        /// <summary>
        /// checck giá trị của customerid
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public static bool IsValidCustomerId(this Guid customerId)
        {
            return customerId == Guid.Empty;
        }
        /// <summary>
        /// check điều kiện của customercode
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public static bool IsVaidCustomerCode(this long customerCode)
        {
            return customerCode > 0;
        }
        /// <summary>
        /// check điều kiện của customername
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns></returns>
        public static bool IsVaidCustomerName(this string customerName)
        {
            return !string.IsNullOrEmpty(customerName) && customerName.Length<40;
        }
        /// <summary>
        /// check điều kiện của moblie
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsValidPhone(this string mobile)
        {
            return !string.IsNullOrEmpty(mobile) && !string.IsNullOrWhiteSpace(mobile) && Regex.IsMatch(mobile, @"^[0-9]{10,12}$");
        }
        /// <summary>
        /// check trùng mobile hay ko
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="customers"></param>
        /// <returns></returns>
        public static bool IsValidUniqueMobile(this string mobile, List<Customer> customers)
        {
            return customers.FirstOrDefault(x => x.Mobile == mobile) != null;
        }
        /// <summary>
        /// check user
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool IsValidUserName(this string userName)
        {
            return !string.IsNullOrEmpty(userName) && !string.IsNullOrWhiteSpace(userName) && userName.Length > 0;
        }
        /// <summary>
        /// check password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(this string password)
        {
            return !string.IsNullOrEmpty(password) && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$");
        }
        /// <summary>
        /// Cho phép người dùng nhập lại nếu chuỗi nhập vào rỗng hoặc null
        /// </summary>
        /// <param name="mess"></param>
        /// <returns></returns>
        public static string GetStringInput(string mess)
        {
            string input = null;
            //string.IsNullOrEmpty để kiểm tra xem chuỗi nhập vào có rỗng hoặc null hay không
            while (string.IsNullOrEmpty(input))
            {
                Console.Write(mess);
                input = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("The input string is empty or null, please enter again: ");
            }
            return input;
        }

        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ
        /// </summary>
        /// <returns></returns>
        public static int GetIntInput(string mess)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input))
                {
                    return result;
                }
                Console.WriteLine("Invalid input, please enter again: ");
            }
        }
        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ
        /// </summary>
        /// <returns></returns>
        public static int GetIntInputOption(string mess, int min, int max)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input) && result >= min && result <= max)
                {
                    return result;
                }
                Console.WriteLine("Invalid number, please re-enter: ");
            }
        }
    }
}
