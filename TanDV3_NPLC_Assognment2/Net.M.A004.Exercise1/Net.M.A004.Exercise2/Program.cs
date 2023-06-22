namespace Net.M.A004.Exercire2;

public class Program
{
    static int horner(int[] poly, int n, int x)
    {
        int result = poly[0];
        // sử dụng Horner's method
        for (int i = 1; i < n; i++)
            result = result * x + poly[i];
        return result;
    }
    public static void Main()
    {
        //EX: 2x3 - 6x2 + 2x - 1 for x = 3
        //nhập số phân tử x0,x1,x2,....xn
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] poly = new int[n];
        // nhập các giá trị cho biến x
        Console.WriteLine("Enter number of x: ");
        //{ 2, -6, 2, -1 };
        for (int i = 0; i < poly.Length; i++)
        {
            Console.Write($"x[{i}] = ");
            poly[i] = int.Parse(Console.ReadLine()); 
        }
        // nhập giá trị cho x
        Console.Write("Enter x:");
        int x = int.Parse(Console.ReadLine());
        //in ra kết quả của biểu thức
        Console.Write($"Value of polynomial is { horner(poly, n, x)}");
    }
}


