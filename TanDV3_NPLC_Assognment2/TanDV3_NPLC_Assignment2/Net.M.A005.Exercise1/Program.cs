using System.Runtime.CompilerServices;

namespace Net.M.A005.Exercise1;
public class Program
{
    /// <summary>
    /// Convert natural number to binary number then print result
    /// </summary>
    /// <param name="number">natural number</param>
    public static void NaturalNumberConvertToBinaryNumber(int number)
    {
        int[] binaryNum = new int[32];
        int i = 0;
        //loop to convert the natural number
        //convert matural nummber to array of binaries
        if (number == 0)
        {
            Console.Write("0");
            return;
        }
        while (number > 0)
        {
            binaryNum[i] = number % 2;
            number = number / 2;
            i++;
        }
        //viết lại số nhị phân
        for (int j = i - 1; j >= 0; j--)
            Console.Write(binaryNum[j]);
    }
    /// <summary>
    /// check number >0
    /// </summary>
    /// <returns>number</returns>
    public static int CheckInput()
    {
        int input;
        do
        {
            try
            {
                Console.WriteLine("Enter number: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter number > 0");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not vaild input! Enter agian!");
            }
        } while (true);
        return input;
    }
    /// <summary>
    /// Check input string to convert to natural number or not
    /// </summary>
    /// <param name="input">input string</param>
    /// <returns>true if natural number, other return false</returns>
    public static bool CheckNaturalNumber(string input)
    {
        //TODO: check number
        int number;
        //try to convert to int
        bool parseResult = int.TryParse(input, out number);
        if (parseResult)
        {
            //check is natual number or not
            return number >= 0;
        }
        // in case: cannot convert to int
        return false;
    }
    //check
    public static int InputNaturalNumber()
    {
        int naturalNumber = default;
        bool checkResult = default;
        do
        {
            // enter number/string
            Console.Write("Enter the natural number: ");

            string input = Console.ReadLine();
            //check number is natural
            checkResult = CheckNaturalNumber(input); 

            //if yes -> return number
            if (checkResult)
            {
                naturalNumber = int.Parse(input);
            }
            //if no -> re-enter number
            else
            {
                Console.WriteLine("Incorrect format of natural number. Plese enter agian! ");
            }
        } while (!checkResult);
        return naturalNumber;
    }
    static void Main(string[] args)
    {
        int number = InputNaturalNumber();
        Console.Write($"Binary of number {number} is: ");
        NaturalNumberConvertToBinaryNumber(number);
    }
    // cách dùng cmt TODO
    // cách viết code cho đúng format
    // cách cmt thuật toán
    // kiểm tra đầy đủ điều kiện
    //tách viết hàm
}
