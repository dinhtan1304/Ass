namespace Net.M.A001.Exercise2;
public class Program
{
    //<summary>
    //Write code to get greatest common divisor of 2 numbers.
    //</summary>
    static void Main(string[] args)
    {
        //khai báo cái giá trị
        int uCLN = 1;
        Console.WriteLine("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine());
        //gán temp = số nhỏ hơn trong 2 số
        int temp = Math.Min(number1, number2);
        //lặp xét giá trị i đến khi bằng temp
        for (int i = 1; i <= temp; i++)
            //chia đến khi tìm thấy UCLN
            if ((number1 % i == 0) && (number2 % i == 0))
            {
                uCLN = i;
            }
        //in ra màn hình
        Console.WriteLine($"Greatest common divisor of {number1} and {number2} is {uCLN}");
    }
}