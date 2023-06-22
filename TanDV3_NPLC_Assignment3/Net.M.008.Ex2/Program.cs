using System.Globalization;

public class Program
{
    private static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Input dateString: ");
            string dateString = Console.ReadLine();
            //// Sử dụng ParseExact để phân tích một String thành DateTime.
            try
            {
                DateTime dateTime = DateTime.ParseExact(dateString, "MMM/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = 0;
                int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
                for (int i = 1; i <= days; i++)
                {
                    DateTime day = new DateTime(dateTime.Year, dateTime.Month, i);
                    if ((day.DayOfWeek != DayOfWeek.Sunday) && (day.DayOfWeek != DayOfWeek.Saturday))
                    {
                        daysInMonth++;
                    }
                }
                Console.WriteLine($"Input is {dateTime.ToString("MMM/yyyy")} should return {daysInMonth}");
                break;
            }
            catch (Exception)
            {

                Console.WriteLine("Invaild Date! Enter Agian!");
            }
        } while (true);
    }
}