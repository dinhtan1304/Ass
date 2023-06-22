using Exercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        // input data
        var student = new Student(
        name: "John Doe",
        @class: "Math",
        gender: "Male",
        age: 18,
        address: "123 Main St",
        mark: 35m
);

        // Call the Graduate method with and without a parameter
        // sets grade to "B" since gradePoint is 0
        Student.GradePoint(); 
         // sets grade to "A"
        Student.GradePoint(4.0);

        // Call the ToString method with and without a parameter\
        // returns "Name: John Doe\nGrade: B\n"
        Console.WriteLine(student.ToString()); 
        Console.WriteLine(student.ToString("name, class, mark"));
    }
}