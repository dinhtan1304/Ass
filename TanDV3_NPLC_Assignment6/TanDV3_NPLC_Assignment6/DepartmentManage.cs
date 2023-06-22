using TanDV3_NPLC_Assignment6;

public class DepartmentManage
{
    private static void Main(string[] args)
    {
        List<Department> department = new List<Department>();
        List<Employee> employee = new List<Employee>();
        Manage manage = new Manage(employee, department);

        List<Employee> employee1 = new List<Employee>();
        employee1.Add(new Employee("1", "Dinh", "Tan", "13/04/2001", "0987654321", "tandv@gmail.com"));
        department.Add(new Department("C#", employee1));

        List<Employee> employees2 = new List<Employee>();
        employees2.Add(new Employee("2", "Tran", "Huy", "12/09/2001", "0987654321", "anhth@gmail.com"));
        department.Add(new Department("Java", employees2));

        List<Employee> employee3 = new List<Employee>();
        employee3.Add(new Employee("3", "Dao", "Nguyet", "04/03/2000", "0987654321", "nguyetdm@gmail.com"));
        department.Add(new Department("Python", employee3));

        List<Employee> employee4 = new List<Employee>();
        employee4.Add(new Employee("4", "Tran", "Tuan", "13/02/2001", "0987654321", "tuantv@gmail.com"));
        department.Add(new Department("C#", employee4));

        List<Employee> employee5 = new List<Employee>();
        employee5.Add(new Employee("5", "Le", "Viet", "05/06/2001", "0987654321", "vietld@gmail.com"));
        department.Add(new Department("Java", employee5));

        List<Employee> employee6 = new List<Employee>();
        employee6.Add(new Employee("6", "Phung", "Long", "12/07/2002", "0987654321", "longpp@gmail.com"));
        department.Add(new Department("Python", employee6));


        while (true)
        {
            int key;
            do
            {
                Console.WriteLine("-------------------------MENU--------------------------");
                Console.WriteLine("  1. Input Employee.");
                Console.WriteLine("  2. Display Employees.");
                Console.WriteLine("  3. Classify employeesls.");
                Console.WriteLine("  4. Employee Search.");
                Console.WriteLine("  5. Report.");
                Console.WriteLine("  0. Exit.");
                Console.WriteLine("-------------------------------------------------------");
                Console.Write("Choose Option: ");
                if (!int.TryParse(Console.ReadLine(), out key))
                {
                    Console.WriteLine("Enter Number! Enter again!");
                    continue;
                }
                else if (key < 0 || key > 6)
                {
                    Console.WriteLine("Please enter the correct number[0-5]!");
                }

                switch (key)
                {
                    case 1:
                        manage.InputDataFromTheKeyboard(department);
                        break;
                    case 2:
                        manage.DisplayEmployees(department);
                        break;
                    case 3:
                        manage.ClassifyEmploees(department);
                        break;
                    case 4:
                        manage.EmployeeSearch(department);
                        break;
                    case 5:
                        manage.Report(department);
                        break;
                    case 0:
                        Console.WriteLine("\nYou exited!");
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }

}
