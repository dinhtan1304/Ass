using System.Globalization;
using System;
using System.Data;

public class Program
{
    /// <summary>
    /// Write code to check string is correct date format dd/MM/yyyy. If yes, convert string to datetime value then get
    ///the first day of the month.
    /// </summary>
    /// <param name="args">Ngày nhập vào</param>
    /// <returns>Ngày đầu tiên trong tháng</returns>
    private static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Input dateString: ");
            string dateString = Console.ReadLine();
            //// Sử dụng ParseExact để phân tích một String thành DateTime.
            try
            {
                DateTime dateTime = DateTime.ParseExact(dateString, "dd/MM/yyyy", null);
                bool successful = DateTime.TryParseExact(dateString, "dd/MM/yyyy", null,
                         System.Globalization.DateTimeStyles.AllowLeadingWhite,
                         out dateTime);
                Console.WriteLine("Can Parse? :" + successful);

                if (successful)
                {
                    DateTime fisrtDate = dateTime.AddDays((-dateTime.Day) + 1);
                    Console.WriteLine(dateTime.ToString("dd/MM/yyyy") + " is correct and the first day of the month is " + fisrtDate.ToString("dd/MM/yyyy"));
                    break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invaild Date! Enter Agian!");
            }
        } while (true);

    }
}