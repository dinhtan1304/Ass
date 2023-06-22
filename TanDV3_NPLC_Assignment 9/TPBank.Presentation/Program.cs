using TPBank.BusinessLogicLayer;
using TPBank.Entities;
using TPBank.Presentation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("================ TP Bank ==================");
        ManagerCustomer mc = new ManagerCustomer();
        if (mc.LoginScreen())
        {
            Console.WriteLine("Login Successfull!");
            int option;
            bool checkInput = false;
            while (true)
            {
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("---:::--- Main Menu ---:::---");
                    Console.WriteLine("1.  Add New Customer.");
                    Console.WriteLine("2.  Get All Existing Customer.");
                    Console.WriteLine("3.  Find Customer.");
                    Console.WriteLine("4.  Update Customer");
                    Console.WriteLine("5.  Delete Customer");
                    Console.WriteLine("6.  Exit.\n");
                    Console.Write("Enter Option: ");
                    checkInput = int.TryParse(Console.ReadLine(), out option);
                    if (checkInput == false || option < 1 || option > 6)
                    {
                        Console.WriteLine("Invalid option! Please try again!");
                    }
                } while (checkInput==false || option <1 || option >6);

                switch(option)
                {
                    case 1:
                        mc.AddCustomer();
                        break;
                    case 2:
                        mc.GetAllExistingCustomer();
                        break;
                    case 3:
                        mc.FindCustomer();
                        break;
                    case 4:
                        mc.UpdateCustomer();
                        break;
                    case 5:
                        mc.RemoveCustomer();
                        break;
                    default:
                        Console.WriteLine("---Exit----");
                        return;

                }
            }
        }
    }
}