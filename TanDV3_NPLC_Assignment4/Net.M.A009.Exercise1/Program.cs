using System.Text.RegularExpressions;

public class Program
{
    private static void Main(string[] args)
    {
        FormatString(InputString());
    }
    /// <summary>
    /// Each word starts with upper case character, all following character(s) is lower case.
    /// </summary>
    /// <param name="input"></param>
    public static string FormatString(string input)
    {
        string fullName = Regex.Replace(input, "\\s+", " ").Trim();
        string finalName = default;
        string[] s = fullName.Split(' ');
        foreach (var item in s)
        {
            finalName += item.Substring(0, 1).ToUpper() + item.Substring(1, item.Length - 1).ToLower() + " ";
        }
        Console.WriteLine(finalName);
        return finalName;
    }
    /// <summary>
    /// Check input stirng not null or null
    /// </summary>
    /// <returns>inputString</returns>
    public static string InputString()
    {
        string inputString;
        bool check = default;
        do
        {
            // enter string
            Console.Write("Enter Full Name: ");

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
                Console.WriteLine("Not Empty and do not contain numbers! Plese Again!");
            }
            //if null -> re-enter 
        } while (!check);
        return inputString;
    }
    /// <summary>
    /// check input string contain number or not
    /// </summary>
    /// <param name="input">input</param>
    /// <returns>checkresuls</returns>
    public static bool CheckString(string input) 
    {
        bool checkResult = default;
        //check string null or not null
        if (checkResult= string.IsNullOrEmpty(input))
        {
            checkResult = false;
        }
        else
        {
            //check string contain number or not
            checkResult = Regex.IsMatch(input, @"[a-zA-Z]+");
            foreach (Char c in input)
            {
                if (Char.IsDigit(c))
                {
                    checkResult = false;
                }
            }

        }
        return checkResult;
    }
}