using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC_Assignment12.Exercise3
{
    public class Employee
    {
        private readonly IEmployStorage _storage;

        public Employee(IEmployStorage storage)
        {
            _storage = storage;
        }
        public ActionResult DeleteEmployee(int id)
        {
            _storage.DeleteEmployee(id);

            return RedirectToAction("Employees");
        }
        private ActionResult RedirectToAction(string actionName)
        {
            // Return a RedirectResult with the URL for the specified action
            return new RedirectResult(actionName);
        }
    }
    public class ActionResult { }

    public class RedirectResult : ActionResult
    {
        public string Url { get; }

        public RedirectResult(string url)
        {
            Url = url;

        }
    }
    public class Employees
    {

    }
    public class EmployeeContext
    {

        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

}
