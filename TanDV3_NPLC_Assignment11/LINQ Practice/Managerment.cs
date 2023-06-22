using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    public class Managerment
    {
        private readonly DataAccess dataAccess;
        public Managerment()
        {
            dataAccess = new DataAccess();
        }
        public void Manager()
        {
            while (true)
            {
                int option;
                bool checkInput = false;
                Console.WriteLine("\n\n\n\t --------------------- CHUONG TRINH ASSIGNMENT 11 ----------------------");
                Console.WriteLine("\t\t 1. Return departments which have >= numberOfEmployee employees.");
                Console.WriteLine("\t\t 2. Return employees has been working.");
                Console.WriteLine("\t\t 3. Return list all employees know languageName.");
                Console.WriteLine("\t\t 4. Return programing languages which employee has employeeId");
                Console.WriteLine("\t\t 5. Returns employees who know multiple programming languages.");
                Console.WriteLine("\t\t 6. Returns List of Employees with pageIndex, pageSize employeeName, order=”ASC” or “DESC” ");
                Console.WriteLine("\t\t 7. Return all departments including employees that belong to each department.");
                Console.WriteLine("\t\t 8. Exit.\n");
                do
                {
                    Console.Write("\n\n Enter option in (1,2,3,4,5,6,7,8) to execute these functions: ");
                    checkInput = int.TryParse(Console.ReadLine(), out option);
                    if (checkInput == false || option <= 0 || option > 8)
                    {
                        Console.WriteLine("\t --> The option must be positive int and in [1,8]. Please try again!");
                    }
                } while (checkInput == false || option <= 0 || option > 8);
                switch (option)
                {
                    case 1:
                        GetDepartments();
                        break;
                    case 2:
                        GetEmployeesWorking();
                        break;
                    case 3:
                        GetEmployees();
                        break;
                    case 4:
                        GetLanguages();
                        break;
                    case 5:
                        GetSeniorEmployees();
                        break;
                    case 6:
                        GetEmployeesByName();
                        break;
                    case 7:
                        GetDepartmentss();
                        break;
                    default:
                        Console.WriteLine("\n\n\t\t ----------------- EXIT PROGRAM ---------------");
                        break;
                }
                if (option == 8)
                    break;
            }
        }
        /// <summary>
        /// get employeesbyname
        /// </summary>
        private void GetEmployeesByName()
        {
            int pageIndex = 1;
            bool checkInput;
            Console.WriteLine("Input Employee Name: ");
            string employeeNameInput = Console.ReadLine();
            Console.WriteLine("1. Order ascending\n2. Order descending");
            Console.WriteLine("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            GetEmployeesPaging(pageIndex: pageIndex, employeeName: employeeNameInput, order: choice == 1 ? "ASC" : "DESC");
        }
        /// <summary>
        /// Return a paginated list of employees (Page {pageIndex}, Page Size {pageSize}, Employee Name {employeeName}, Order {order})
        /// </summary>
        private void GetEmployeesPaging(int pageIndex = 1, int pageSize = 10, string employeeName = null, string order = "ASC")
        {
            Console.WriteLine($"\n  Return a paginated list of employees (Page {pageIndex}, Page Size {pageSize}, Employee Name {employeeName}, Order {order}):");

            // Get the employees that match the specified search criteria
            var employees = dataAccess.GetEmployeePaging(pageIndex, pageSize, employeeName, order);

            // Check if there are any employees to display
            if (employees.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no employees!");
            }
            else
            {
                // Display the employees
                employees.ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        /// <summary>
        /// Returns all departments including employees that belong to each department:\
        /// </summary>
        private void GetDepartmentss()
        {
            Console.WriteLine($"\n Returns all departments including employees that belong to each department: ");

            var departments = dataAccess.GetDepartments();

            if (departments.Count == 0)
            {
                Console.WriteLine("\n\t --> Do not have departments including employees that belong to each department!");
            }
            else
            {
                var query = from department in departments
                            select new
                            {
                                department.DepartmentName,
                                Employees = department.Employees.Select(e => e.EmployeeName)
                            };

                foreach (var result in query)
                {
                    Console.WriteLine($"\n\t {result.DepartmentName}:");
                    foreach (var employeeName in result.Employees)
                    {
                        Console.WriteLine($"\t\t - {employeeName}");
                    }
                }
            }
        }
        /// <summary>
        /// Returns employees who know multiple programming languages
        /// </summary>
        private void GetSeniorEmployees()
        {
            Console.WriteLine($"\n Returns employees who know multiple programming languages: ");

            var departments = dataAccess.GetSeniorEmployee();

            if (departments.Count == 0)
            {
                Console.WriteLine("\n\t --> Do not have employees who know multiple programming languages!");
            }
            else
            {
                departments.ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        /// <summary>
        /// Return programing languages which have >= {employeeId} employees
        /// </summary>
        private void GetLanguages()
        {
            int employeeId;
            bool checkInput = false;
            do
            {
                Console.Write("\n Enter the employee id: ");
                checkInput = int.TryParse(Console.ReadLine(), out employeeId);
                if (checkInput == false || employeeId < 0)
                {
                    Console.WriteLine("   --> The number must be positive int. Please try again!");
                }
            } while (checkInput == false || employeeId < 0);


            Console.WriteLine($"\n Return programing languages which have >= {employeeId} employees: ");

            var departments = dataAccess.GetLanguages(employeeId);

            if (departments.Count == 0)
                Console.WriteLine("\n\t --> Do not have any employee!");
            else
            {
                departments.ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        /// <summary>
        /// Returns list all employees know programing language
        /// </summary>
        private void GetEmployees()
        {
            string languageName;
            bool checkinput = false;
            do
            {
                Console.Write("\n Enter the name of programing language of employee: ");
                languageName = Console.ReadLine();
                checkinput  = string.IsNullOrEmpty(languageName);
                if (checkinput == true)
                {
                    Console.WriteLine("   --> The name of programing language is not null. Please try again!");
                }
            } while (checkinput == true);


            Console.WriteLine($"\n Returns list all employees know programing language: ");

            var departments = dataAccess.GetEmployees(languageName);

            if (departments.Count == 0)
                Console.WriteLine("\n\t --> Do not have any employee!");
            else
            {
                departments.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        /// <summary>
        /// Display all departments that has employees >= numberOfEmployee
        /// </summary>
        private void GetDepartments()
        {
            int numberOfEmployee;
            bool checkInput = false;
            do
            {
                Console.Write("\n Enter the number of employee: ");
                checkInput = int.TryParse(Console.ReadLine(), out numberOfEmployee);
                if (checkInput == false || numberOfEmployee < 0)
                {
                    Console.WriteLine("   --> The number must be positive int. Please try again!");
                }
            } while (checkInput == false || numberOfEmployee < 0);


            Console.WriteLine($"\n Return departments which have >= {numberOfEmployee} employees: ");

            var departments = dataAccess.GetDepartments(numberOfEmployee);

            if (departments.Count == 0)
                Console.WriteLine("\n\t --> Do not have any department!");
            else
            {
                departments.ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        /// <summary>
        /// Return list all employees are working
        /// </summary>
        private void GetEmployeesWorking()
        {
            Console.WriteLine($"\n Return list all employees are working: ");

            var departments = dataAccess.GetEmployeesWorking();

            if (departments.Count == 0)
            {
                Console.WriteLine("\n\t --> Do not have employee working!");               
            }             
            else
            {            
                departments.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

    }
}
