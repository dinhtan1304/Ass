namespace LINQ_Practice.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime HiredDate { get; set; }
        public int Status { get; set; } //1. isworking, 0. Isnotworking

        public int DepartmentId { get; set; }
        public List<ProgramingLanguage> ProgramingLanguages { get; set; }
        public Employee() { }

        public Employee(int employeeId, string employeeName, int age, string address, DateTime hiredDate, int status, int departmentId, List<ProgramingLanguage> programingLanguages)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Age = age;
            Address = address;
            HiredDate = hiredDate;
            Status = status;
            ProgramingLanguages = programingLanguages;
            DepartmentId = departmentId;
        }

        public override string? ToString()
        {
            return $"EmployeeId: {EmployeeId}, EmployeeName: {EmployeeName}, Age: {Age}, HireDate: {HiredDate}, Status: {Status}";
        }
    }
}
