using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice.Models
{
    public class DataContext
    {

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<ProgramingLanguage> ProgramingLanguages { get; set; }
        public DataContext()
        {
            Employees = new List<Employee>()
            {
                new Employee
                {
                    EmployeeId= 1,
                    EmployeeName = "Dinh Van Tan",
                    Address = "Ha Noi",
                    Age= 22,
                    HiredDate= DateTime.Now,
                    Status = 1,
                    DepartmentId = 2,
                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        new ProgramingLanguage
                        {
                            languageName = "English"
                        },
                        new ProgramingLanguage
                        {
                            languageName = "Japanese"
                        }
                    }
                },
                new Employee
                {
                    EmployeeId= 2,
                    EmployeeName = "Tran Van Tuan",
                    Address = "Ha Noi",
                    Age= 22,
                    HiredDate= DateTime.Now,
                    Status = 1,
                    DepartmentId = 1,
                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        new ProgramingLanguage
                        {
                            languageName = "English"
                        },
                        new ProgramingLanguage
                        {
                            languageName = "Korean"
                        }
                    }
                },
                new Employee
                {
                    EmployeeId= 3,
                    EmployeeName = "Tran Huy Anh",
                    Address = "Ha Noi",
                    Age= 22,
                    HiredDate= DateTime.Now,
                    Status = 0,
                    DepartmentId = 3,
                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        new ProgramingLanguage
                        {
                            languageName = "English"
                        },
                        new ProgramingLanguage
                        {
                            languageName = "Chinese"
                        }
                    }
                },
                new Employee
                {
                    EmployeeId= 4,
                    EmployeeName = "Vu Nhat Anh",
                    Address = "Ha Noi",
                    Age= 22,
                    HiredDate= DateTime.Now,
                    Status = 0,
                    DepartmentId = 2,
                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        new ProgramingLanguage
                        {
                            languageName = "Chinese"
                        },
                        new ProgramingLanguage
                        {
                            languageName = "Japanese"
                        }
                    }
                }
            };
            Departments = new List<Department>()
            {
                new Department
                {
                    DepartmentId= 1,
                    DepartmentName = "Phong Hanh Chinh"
                },
                new Department
                {
                    DepartmentId= 2,
                    DepartmentName = "Phong Cong Nghe"
                },
               new Department
                {
                    DepartmentId= 3,
                    DepartmentName = "Phong Tuyen Dung"
                }
            };
        }
    }
}
