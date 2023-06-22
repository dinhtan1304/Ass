namespace Net.M.A001.Exercise1;
public class Program
{
    //<summary>
    //Write code to get maximum and minimum of the inputted array.
    //</summary>
    static void Main(string[] args)
    {
        //khai báo mảng chứa phần tử
        int[] array = new int[] { 5, 8, 12, -10, 6, 4 };
        //khai báo giá trị max, min
        int max = 0,min = 0;
        //tìm max và min
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
            if (min > array[i])
            {
                min= array[i];
            }
        }
        Console.Write("Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] +" ");
        }
        //in ra giá trị max và min
        Console.WriteLine($"\nMaximum is: {max}");
        Console.WriteLine($"Mininum is: {min}");
    }
}