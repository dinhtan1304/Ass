namespace Net.M.A005.Exercise2;
public class Program
{
    /// <summary>
    /// Write code to list out first n number of Fibonacci array. Each number is printed in 1 line.
    /// </summary>
    /// <returns></returns>
    public static int CheckInput()
    {
        int input;
        do
        {
            try
            {
                Console.Write("Enter number: ");
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
    /// find fibonacci number
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static int fibonacci_numbers(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else if (number == 1)
        {
            return 1;
        }
        else
        {
            return fibonacci_numbers(number - 2) + fibonacci_numbers(number - 1);
        }
    }
    /// <summary>
    /// display các số fibonacci
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int n = CheckInput();  
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{fibonacci_numbers(i)}\n");
        }
    }
}

