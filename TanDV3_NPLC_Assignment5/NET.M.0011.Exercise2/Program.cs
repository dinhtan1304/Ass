using NET.M._0011.Exercise2;

internal class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee();
        e.FirstName = "Tan";
        e.LastName = "Dinh";
        e.MonthlySalary = -1;
        Console.WriteLine(e.ToString());
    }
}