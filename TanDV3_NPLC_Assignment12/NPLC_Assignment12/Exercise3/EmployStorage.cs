using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC_Assignment12.Exercise3
{
    public interface IEmployStorage
    {
        void DeleteEmployee(int id);
    }
    public class EmployStorage : IEmployStorage
    {
        private EmployeeContext _db;

        public EmployStorage()
        {
            _db = new EmployeeContext();
        }
        public void DeleteEmployee(int id)
        {
            var employee = _db.Employees.Find(id);
            if (employee is null) return;
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }
}
