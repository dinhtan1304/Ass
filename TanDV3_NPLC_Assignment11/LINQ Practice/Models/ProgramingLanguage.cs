namespace LINQ_Practice.Models
{
    public class ProgramingLanguage
    {
        public string languageName { get; set; }
        public List<Employee> Employees { get; set; }
        public ProgramingLanguage() { }

        public ProgramingLanguage(string languageName, List<Employee> employees)
        {
            this.languageName = languageName;
            Employees = employees;
        }

        public override string? ToString()
        {
            return $"Programing Language: {languageName}";
        }
    }
}
