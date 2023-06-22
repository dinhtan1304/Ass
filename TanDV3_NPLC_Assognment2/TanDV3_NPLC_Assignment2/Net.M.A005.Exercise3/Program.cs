namespace Net.M.A005.Exercise3;
public class Program
{
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
    static void Main(string[] args)
    {
        int number = CheckInput();
        bool isPrime = true;
        //check number < 2, if number < 2 is not prime
        if (number < 2)
        {
            isPrime = false;
        }
        //if number > 2, check number
        //for (int i = 2; i <= number/2; i++)
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{number} Is Prime Number!");
        }
        else { Console.WriteLine($"{number} Is Not Prime Number!"); }
    }
}
