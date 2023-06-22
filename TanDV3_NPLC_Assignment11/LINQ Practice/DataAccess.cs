using LINQ_Practice.Models;
using System.Collections.Generic;

namespace LINQ_Practice
{
    public class DataAccess
    {
        private readonly DataContext context;
        public DataAccess() 
        {
            context = new DataContext();
        }
        private readonly List<Department> departments = new List<Department>();
        private readonly List<Employee> employees = new List<Employee>();

        // Method 1
        /// <summary>
        /// Returns departments which have >= numberOfEmployee employees.
        /// </summary>
        /// <param name="numberOfEmployees"></param>
        /// <returns></returns>
        public ICollection<Department> GetDepartments(int numberOfEmployees)
        {
            var departments = context.Departments
                .Join(context.Employees, d => d.DepartmentId, e => e.DepartmentId, (d, e) => d)
                .GroupBy(d => d)
                .Where(g => g.Count() >= numberOfEmployees)
                .Select(d => d.Key);
            return departments.ToList();               
        }

        // Method 2
        /// <summary>
        /// Return list all employees are working.
        /// </summary>
        /// <returns></returns>
        public ICollection<Employee> GetEmployeesWorking()
        {
            return context.Employees
                .Where(e => e.Status == 1)
                .ToList();
        }

        // Method 3
        /// <summary>
        /// returns list all employees know languageName.
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        public ICollection<Employee> GetEmployees(string languageName)
        {
            return context.Employees
                .Where(e => e.ProgramingLanguages.Any(pl => pl.languageName.ToLower() == languageName))
                .ToList();
        }

        // Method 4
        /// <summary>
        /// returns programing languages which employee has employeeId know.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public ICollection<ProgramingLanguage> GetLanguages(int employeeId)
        {
            return context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .SelectMany(e => e.ProgramingLanguages)
                .Distinct()
                .ToList();
        }

        // Method 5
        /// <summary>
        /// returns employees who know multiple programming languages.
        /// </summary>
        /// <returns></returns>
        public ICollection<Employee> GetSeniorEmployee()
        {
            return context.Employees.Where(e => e.ProgramingLanguages.Count > 1).ToList();
        }

        // Method 6
        /// <summary>
        /// returns list of employees where pageIndex is the current
        ///page, pageSize is the size of the page, employeeName is employee’s name want to
        ///search and order=”ASC” or “DESC” that return the list of employees was ordered
        ///ascending or descending.
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="employeeName"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public ICollection<Employee> GetEmployeePaging(int pageIndex = 1, int pageSize = 10, string employeeName = null, string order = "ASC")
        {
            int startIndex = (pageIndex - 1) * pageSize;
            var employees = context.Employees
                .Where(e => employeeName == null || e.EmployeeName.ToLower().Contains(employeeName))
                .OrderBy(e => order == "ASC" ? e.EmployeeName : "")
                .ThenByDescending(e => order == "DESC" ? e.EmployeeName : "")
                .Skip(startIndex)
                .Take(pageSize)
                .ToList();
            return employees;
        }

        // Method 7
        /// <summary>
        /// returns all departments including employees that belong to each department.
        /// </summary>
        /// <returns></returns>
        public ICollection<Department> GetDepartments()
        {
            var departments = (
                                from d in context.Departments
                                join e in context.Employees on d.DepartmentId equals e.DepartmentId
                                group e by d into g
                                select new Department()
                                {
                                    DepartmentId = g.Key.DepartmentId,
                                    DepartmentName = g.Key.DepartmentName,
                                    Employees = g.ToList()
                                }).ToList();

            return departments;
        }
    }
}
