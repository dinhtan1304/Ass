
public class Program
{
    private static void Main(string[] args)
    {
        ResultsAfterSort();
    }
    public static void ResultsAfterSort()
    {
        string[] listUser = { "Tony Stark", "Steve Rogers", "Bruce Banner", "Thor", "Natasha Romanoff", "Clint Barton", "James Rhodes", "Scott Lang", "Doctor Strange", "Carol Danvers", "Peter Parker" };
        listUser = SortList(listUser);
        foreach (var item in listUser)
        {
            Console.Write($"{item}, ");
        }
    }

    public static string[] SortList(string[] listUser)
    {
        string temp = "";
        for (int i = 0; i < listUser.Length; i++)
        {
            for (int j = i; j < listUser.Length; j++)
            {
                if (GetLastName(listUser[i]).CompareTo(GetLastName(listUser[j])) > 0)
                {
                    temp = listUser[i];
                    listUser[i] = listUser[j];
                    listUser[j] = temp;
                }
            }
        }
        return listUser;
    }

    public static string GetLastName(string name)
    {
        string[] arr = name.Split(" ");
        return arr[arr.Length - 1];
    }
}