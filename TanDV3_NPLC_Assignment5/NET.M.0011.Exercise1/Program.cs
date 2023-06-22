using NET.M._0011.Exercise1;

public class Program
{
    private static void Main(string[] args)
    {
        Book b = new Book()
        {
            BookName = "Code dao",
            ISBN = "123456789",
            AthurName = "FA",
            Publisher = "FS",
        };
        Console.WriteLine(b.ShowInformationBook());
    }
}