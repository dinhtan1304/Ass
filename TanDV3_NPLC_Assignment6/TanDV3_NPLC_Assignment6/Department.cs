using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employee { get; set; }
        public Department() { }
        public Department(string departmentName, List<Employee> employee)
        {
            DepartmentName = departmentName;
            Employee = employee;
        }

        public int CountOf<T>()
        {
            return Employee.Count;
        }
        public void GetEmployee<T>()
        {
            List<Employee> employee = Employee;
        }
    }
}
