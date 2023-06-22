using System.Text.RegularExpressions;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsValidEmail(InputString()));
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9!#$%&'*+/=?^_{|}~]+([.][a-zA-Z0-9!#$%&'*+/=?^_{|}~]+)*" +
                         "@[a-zA-Z0-9]+([-][a-zA-Z0-9]+)*([.][a-zA-Z0-9]+([-][a-zA-Z0-9]+)*)*$";
        return Regex.IsMatch(email, pattern);
    }
    public static string InputString()
    {
        string inputString;
        bool check = default;
        do
        {
            // enter string
            Console.Write("Enter Email: ");

            inputString = Console.ReadLine();
            //check string 
            check = CheckString(inputString);

            //if not null -> return inputstring
            if (check)
            {
                return inputString;
            }
            else
            {
                Console.WriteLine("Not Empty ! Plese Again!");
            }
            //if null -> re-enter 
        } while (!check);
        return inputString;
    }
    public static bool CheckString(string input)
    {
        bool checkResult = string.IsNullOrEmpty(input);
        //check string null or not null
        if (checkResult)
        {
            return false;
        }
        return true;
    }
}
