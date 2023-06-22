using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanDV3_NPLC_Assignment6
{
    public interface IDepartmentManage
    {
        public void InputDataFromTheKeyboard();
        public void DisplayEmployees();
        public void ClassifyEmploees();
        public void EmployeeSearch(string ssn);
        public void Report(Department department);
        HourlyEmployee GetInputHourtyEmployee();
        SalaryEmployee GetInputSalariedEmployee();
    }
}
