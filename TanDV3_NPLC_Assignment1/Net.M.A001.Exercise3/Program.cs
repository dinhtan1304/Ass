namespace Net.M.A001.Exercise3;
public class Program
{
    //<summary>
    //Write code to get greatest common divisor of an array.
    //</summary>
    //tìm ước chung của 2 số
    static int uc(int x, int y)
    {
        if (x == 0)
        {
            return y;
        }
        return uc(y % x, x);
    }
    //tìm ước chung của array
    static int findUCLN(int[] array, int n)
    {
        int uCLN = array[0];
        for (int i = 1; i < n; i++)
        {
            //tìm lần lượt các ước chung của các số trong array
            uCLN = uc(array[i], uCLN);
            if (uCLN == 1)
            {
                return 1;
            }
        }
        return uCLN;
    }
    static void Main(string[] args)
    {
        //khai báo array
        Console.WriteLine("Enter number of Array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = { 12, 18, 24 };
            //= new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Array[{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }
        //tìm và in a màn hình
        Console.WriteLine($"Greatest common divisor of array is {findUCLN(array, n)}");


    }
}

