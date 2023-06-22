namespace LINQ_Practice.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
        public Department() { }

        public Department(int departmentId, string departmentName, List<Employee> employees)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            Employees = employees;
        }
        public override string? ToString()
        {
            return $"\tDepartmentId: {DepartmentId}, DepartmentName: {DepartmentName}, \n\t{Employees}";
        }
    }
}
