using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public class Manage
    {
        static List<Department> departments = new List<Department>();
        static List<Employee> employees = new List<Employee>();
        public Manage(List<Employee> employee, List<Department> department)
        {
            employees = employee;
            departments = department;
        }

        public Manage()
        {
        }
        /// <summary>
        /// ClassifyEmploees
        /// </summary>
        public void ClassifyEmploees(List<Department> department)
        {
            int chosse;
            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Display Data for Employee!");
                Console.WriteLine("1.Salaried Employee. ");
                Console.WriteLine("2.HourlyEmployee.");
                Console.WriteLine("0.Return!");
                Console.Write("Chosse Option: ");
                if (!int.TryParse(Console.ReadLine(), out chosse))
                {
                    Console.WriteLine("Enter Number! Enter again!");
                    continue;
                }
                else if (chosse < 0 || chosse > 3)
                {
                    Console.WriteLine("Please enter the correct number[0-2].");
                }
                switch (chosse)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            Console.WriteLine("-------Salaried Employee---------");
                            // Duyệt toàn bộ danh sách các phòng ban
                            foreach (Department d in departments)     
                            {
                                // Duyệt danh sách các nhân viên
                                foreach (Employee employee in d.Employee)       
                                {
                                    //danh sách nhân viên có kiểu salaried 
                                    if (employee.GetType() == typeof(SalaryEmployee))     
                                    {
                                        Console.WriteLine();
                                        employee.Display(employee);
                                    }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("----------HourlyEmployee----------");
                            // Duyệt toàn bộ danh sách các phòng ban
                            foreach (Department d in departments)     
                            {
                                // Duyệt danh sách các nhân viên
                                foreach (Employee employee in d.Employee)        
                                {
                                    // danh sách nhân viên có kiểu hourly 
                                    if (employee.GetType() == typeof(HourlyEmployee))     
                                    {
                                        Console.WriteLine();      
                                        employee.Display(employee);
                                    }
                                }
                            }
                            break;
                        }
                    default:
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// DisplayEmployees
        /// </summary>
        public void DisplayEmployees(List<Department> department)
        {
            Console.WriteLine("----------------------Display All Employeee--------------------------");
            Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}", "SSN", "FirstName", "LastName", "BirthDate", "Phone", "Email"));
            foreach (var d in departments)
            {
                foreach (var employee in d.Employee)
                {
                    Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-15}{3,-15}{4,-15}{5,-25}", employee.Ssn, employee.FirstName, employee.LastName, employee.BirthDate, employee.Phone, employee.Email));
                }
            }
        }
        /// <summary>
        /// EmployeeSearch
        /// </summary>
        /// <param name="ssn"></param>
        public void EmployeeSearch(List<Department> departments)
        {
            int chosse;
            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Search Data for Employee!");
                Console.WriteLine("1.Search employees by name department. ");
                Console.WriteLine("2.Search employees by name Employee.");
                Console.WriteLine("0.Return!");
                Console.Write("Chosse Option: ");
                if (!int.TryParse(Console.ReadLine(), out chosse))
                {
                    Console.WriteLine("Enter Number! Enter again!");
                    continue;
                }
                else if (chosse < 0 || chosse > 3)
                {
                    Console.WriteLine("Please enter the correct number[0-2].");
                }
                switch (chosse)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            Console.Write("Enter Department Name: ");
                            string inputname = Console.ReadLine();
                            //Duyệt list Department
                            foreach (Department department in departments)
                            {
                                // Tìm phong ban
                                if (department.DepartmentName.Equals(inputname))
                                {
                                    // Hiển thị nhân viên có kiểu Salaried
                                    Console.Write($"Department: {department.DepartmentName}");
                                    foreach (Employee employee in department.Employee)
                                    {
                                        if (employee.GetType() == new SalaryEmployee().GetType())
                                        {
                                            Console.WriteLine();
                                            employee.Display(employee);
                                        }
                                        // Hiển thị nhân viên có kiểu Hourly
                                        else
                                        {
                                            Console.WriteLine();
                                            employee.Display(employee);
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter Employee Name: ");
                            string inputnameEmployee = Console.ReadLine();
                            // Tìm nhân viên theo tên và hiển thị
                            foreach (Department department in departments)
                            {
                                foreach (Employee employee in department.Employee)
                                {
                                    if (employee.LastName.ToLower().Equals(inputnameEmployee))
                                    {
                                        employee.Display(employee);
                                    }
                                }
                            }
                            break;
                        }
                    default:
                        break;
                }
            } while (chosse >= 0 || chosse < 3);
        }
        /// <summary>
        /// InputDataFromTheKeyboard
        /// </summary>
        public void InputDataFromTheKeyboard(List<Department> departments)
        {
            int chosse;
            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Input Data for Employee Of Department:");
                Console.WriteLine("1.Salaried Employee. ");
                Console.WriteLine("2.HourlyEmployee.");
                Console.WriteLine("0.Return!");
                Console.Write("Chosse Option: ");
                if (!int.TryParse(Console.ReadLine(), out chosse))
                {
                    Console.WriteLine("Enter Number! Enter again!");
                    continue;
                }
                else if (chosse < 0 || chosse > 2)
                {
                    Console.WriteLine("Please enter the correct number [0-2].");
                }
                switch (chosse)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            SalaryEmployee inputSalariedEmployee = GetInputSalariedEmployee(employees);
                            EnterDepartment(departments, inputSalariedEmployee);
                            break;
                        }
                    case 2:
                        {
                            HourlyEmployee inputHourtyEmployee = GetInputHourtyEmployee(employees);
                            EnterDepartment(departments, inputHourtyEmployee);
                            break;
                        }

                    default:
                        break;
                }
            } while (chosse >= 0 || chosse < 3);
        }
        /// <summary>
        /// FindDepartmentName
        /// </summary>
        /// <param name="department"></param>
        /// <param name="name"></param>
        /// <returns>DepartmentName</returns>
        public static bool FindDepartmentName(List<Department> department, string name)
        {
            foreach (Department d in department)
            {
                // Tìm thấy phòng ban đã có trong list
                if (d.DepartmentName == name)
                    return true;
            }

            return false;
        }
        /// <summary>
        /// EnterDepartment
        /// </summary>
        /// <param name="department"></param>
        /// <param name="inputSalaryEmployee"></param>
        public static void EnterDepartment(List<Department> department, SalaryEmployee inputSalaryEmployee)
        {
            string inputstr;
            Console.Write("Enter Employee Department: ");
            inputstr = Convert.ToString(Console.ReadLine());
            //kiem tra xem department ton tai hay ko?
            if (!FindDepartmentName(department, inputstr))
            {
                //chua tồn tại thì tạo mới or not
                Console.WriteLine("Employee Department does not exist !   \n Create Department {0} ?\n 1 : Yes \n 2 : No and Exit", inputstr);
                int key;
                if (int.TryParse(Console.ReadLine(), out key) && key == 1)
                {
                    Department newDepartment = new Department();
                    List<Employee> listEmployee = new List<Employee>();
                    listEmployee.Add(inputSalaryEmployee);
                    newDepartment.DepartmentName = inputstr;
                    newDepartment.Employee = listEmployee;
                    department.Add(newDepartment);
                }
            }
            // Thêm nhân viên vào phòng ban đã tồn tại
            else
            {
                Department newDepartment = new Department();
                List<Employee> listEmployee = new List<Employee>();
                listEmployee.Add(inputSalaryEmployee);
                newDepartment.DepartmentName = inputstr;
                newDepartment.Employee = listEmployee;
                department.Add(newDepartment);
            }

            Console.WriteLine("Enter Salaried Employee succerfull ! ");
        }
        /// <summary>
        /// EnterDepartment
        /// </summary>
        /// <param name="department"></param>
        /// <param name="inputHourlyEmployee"></param>
        public static void EnterDepartment(List<Department> department, HourlyEmployee inputHourlyEmployee)
        {
            string inputstr;
            Console.Write("Enter Employee Department: ");
            inputstr = Convert.ToString(Console.ReadLine());
            //kiem tra xem department ton tai hay ko?
            if (!FindDepartmentName(department, inputstr))
            {
                Console.WriteLine("Employee Department does not exist !   \n Create Department {0} ?\n 1 : Yes \n Any key : No and Exit", inputstr);
                int key;
                if (int.TryParse(Console.ReadLine(), out key) && key == 1)
                {
                    Department newDepartment = new Department();
                    List<Employee> listEmployee = new List<Employee>();
                    listEmployee.Add(inputHourlyEmployee);
                    newDepartment.DepartmentName = inputstr;
                    newDepartment.Employee = listEmployee;
                    department.Add(newDepartment);
                }
            }
            // Thêm  nhân viên vào phòng ban đã tồn tại
            else
            {
                Department newDepartment = new Department();
                List<Employee> listEmployee = new List<Employee>();
                listEmployee.Add(inputHourlyEmployee);
                newDepartment.DepartmentName = inputstr;
                newDepartment.Employee = listEmployee;
                department.Add(newDepartment);
            }
            Console.WriteLine("Enter Hourty Employee succerfull ! ");

        }
        /// <summary>
        /// Report
        /// </summary>
        public void Report(List<Department> department)
        {
            Console.WriteLine(string.Format("{0,-10}{1,35}", "Department Name", "Total number of employees"));
            foreach (Department d in departments)
            {
                Console.WriteLine(string.Format("{0,-10}{1,35}", d.DepartmentName, d.Employee.Count()));
            }
        }
        /// <summary>
        /// InputHourtyEmployee
        /// </summary>
        /// <returns>HourlyEmployee</returns>
        public static HourlyEmployee GetInputHourtyEmployee(List<Employee> employee)
        {
            {
                HourlyEmployee hourlyEmployee = new HourlyEmployee();
                do
                {
                    Console.Write("Enter Snn Of Employee: ");
                    hourlyEmployee.Ssn = Console.ReadLine();
                    if (Validation.IsValiString(hourlyEmployee.Ssn) == false)
                    {
                        Console.WriteLine("Not Empty! Enter again!");
                    }
                    //if (Validation.CheckIdExist(employee,hourlyEmployee.Ssn) == true)
                    //{
                    //    Console.WriteLine("Ssn already exists");
                    //}
                    else break;
                } while (true);
                do
                {
                    Console.Write("Enter FirstName Of Employee: ");
                    hourlyEmployee.FirstName = Console.ReadLine();
                    if (Validation.IsValiString(hourlyEmployee.FirstName) == false)
                    {
                        Console.WriteLine("Not Empty! Enter again!");
                    }
                    else break;
                } while (true);
                do
                {
                    Console.Write("Enter LastName Of Employee: ");
                    hourlyEmployee.LastName = Console.ReadLine();
                    if (Validation.IsValiString(hourlyEmployee.LastName) == false)
                    {
                        Console.WriteLine("Not Empty! Enter again!");
                    }
                    else break;
                } while (true);
                do
                {
                    Console.Write("Enter BirthDate Of Employee: ");
                    hourlyEmployee.BirthDate = Console.ReadLine();
                    if (Validation.IsValiDate(hourlyEmployee.BirthDate) == false)
                    {
                        Console.WriteLine("Please try agian! Birthday is invalis!!");
                    }
                    else break;
                } while (true);
                do
                {
                    Console.Write("Enter Phone Of Employee: ");
                    hourlyEmployee.Phone = Console.ReadLine();
                    if (Validation.IsVaidPhone(hourlyEmployee.Phone) == false)
                    {
                        Console.WriteLine("Please try agian! Phone is invalis!!");
                    }
                    else break;
                } while (true);
                do
                {
                    Console.Write("Enter Email Of Employee: ");
                    hourlyEmployee.Email = Console.ReadLine();
                    if (Validation.IsVaidEmail(hourlyEmployee.Email) == false)
                    {
                        Console.WriteLine("Please try agian! Email is invalis!!");
                    }
                    else break;
                } while (true);
                string input;
                double wage;
                do
                {
                    Console.Write("Enter Wage Of Employee: ");
                    input = Console.ReadLine();
                    if (Validation.IsValiDouble(input) == false)
                    {
                        Console.WriteLine("Please try agian! Wage is invalis!!");
                    }
                    else
                    {
                        double.TryParse(input, out wage);
                        hourlyEmployee.Wage = wage;
                        break;
                    }

                } while (true);
                double workingHours;
                do
                {
                    Console.Write("Enter WorkingHours Of Employee: ");
                    input = Console.ReadLine();
                    if (Validation.IsValiDouble(input) == false)
                    {
                        Console.WriteLine("Please try agian! WorkingHours is invalis!!");
                    }
                    else
                    {
                        double.TryParse(input, out workingHours);
                        hourlyEmployee.WorkingHours = workingHours;
                        break;
                    }
                } while (true);
                return hourlyEmployee;
            }
        }
        /// <summary>
        /// InputSalariedEmployee
        /// </summary>
        /// <returns>SalaryEmployee</returns>
        public static SalaryEmployee GetInputSalariedEmployee(List<Employee> employee)
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee();
            do
            {
                Console.Write("Enter Snn Of Employee: ");
                salaryEmployee.Ssn = Console.ReadLine();
                if (Validation.IsValiString(salaryEmployee.Ssn) == false)
                {
                    Console.WriteLine("Not Empty! Enter again!");
                }
                else if (Validation.CheckIdExist(employee, salaryEmployee.Ssn) == true)
                {
                    Console.WriteLine("Ssn already exists");
                }
                else break;
            } while (true);
            do
            {
                Console.Write("Enter FirstName Of Employee: ");
                salaryEmployee.FirstName = Console.ReadLine();
                if (Validation.IsValiString(salaryEmployee.FirstName) == false)
                {
                    Console.WriteLine("Not Empty! Enter again!");
                }
                else break;
            } while (true);
            do
            {
                Console.Write("Enter LastName Of Employee: ");
                salaryEmployee.LastName = Console.ReadLine();
                if (Validation.IsValiString(salaryEmployee.LastName) == false)
                {
                    Console.WriteLine("Not Empty! Enter again!");
                }
                else break;
            } while (true);
            do
            {
                Console.Write("Enter BirthDate Of Employee: ");
                salaryEmployee.BirthDate = Console.ReadLine();
                if (Validation.IsValiDate(salaryEmployee.BirthDate) == false)
                {
                    Console.WriteLine("Please try agian! Birthday is invalis!!");
                }
                else break;
            } while (true);
            do
            {
                Console.Write("Enter Phone Of Employee: ");
                salaryEmployee.Phone = Console.ReadLine();
                if (Validation.IsVaidPhone(salaryEmployee.Phone) == false)
                {
                    Console.WriteLine("Please try agian! Phone is invalis!!");
                }
                else break;
            } while (true);
            do
            {
                Console.Write("Enter Email Of Employee: ");
                salaryEmployee.Email = Console.ReadLine();
                if (Validation.IsVaidEmail(salaryEmployee.Email) == false)
                {
                    Console.WriteLine("Please try agian! Email is invalis!!");
                }
                else break;
            } while (true);
            string input;
            double commissionRate;
            do
            {
                Console.Write("Enter CommissionRate Of Employee: ");
                input = Console.ReadLine();
                if (Validation.IsValiDouble(input) == false)
                {
                    Console.WriteLine("Please try agian! CommissionRate is invalis!!");
                }
                else
                {
                    double.TryParse(input, out commissionRate);
                    salaryEmployee.CommissionRate = commissionRate;
                    break;
                }

            } while (true);
            double grossSale;
            do
            {
                Console.Write("Enter GrossSale Of Employee: ");
                input = Console.ReadLine();
                if (Validation.IsValiDouble(input) == false)
                {
                    Console.WriteLine("Please try agian! GrossSale is invalis!!");
                }
                else
                {
                    double.TryParse(input, out grossSale);
                    salaryEmployee.GrossSale = grossSale;
                    break;
                }
            } while (true);
            double basicSalary;
            do
            {
                Console.Write("Enter BasicSalary Of Employee: ");
                input = Console.ReadLine();
                if (Validation.IsValiDouble(input) == false)
                {
                    Console.WriteLine("Please try agian! BasicSalary is invalis!!");
                }
                else
                {
                    double.TryParse(input, out basicSalary);
                    salaryEmployee.BasicSalary = basicSalary;
                    break;
                }
            } while (true);
            return salaryEmployee;
        }
    }
}
