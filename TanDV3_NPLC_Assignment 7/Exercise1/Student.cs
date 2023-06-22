using Microsoft.VisualBasic;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Exercise1
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string RelationShip { get; set; }

        public DateTime EntryDate { get; set; }

        public int Age { get; set; }
        public string Address { get; set; }

        private decimal mark;

        public decimal Mark
        {
            get { return mark; }
            set
            {
                mark = value;
                if (value >= 85m)
                {
                    GradePoint(4);
                }
                else if (value >= 80m)
                {
                    GradePoint(3.7);
                }
                else if (value >= 75m)
                {
                    GradePoint(3.3);
                }
                else if (value >= 70m)
                {
                    GradePoint(3.0);
                }
                else if (value >= 65m)
                {
                    GradePoint(2.7);
                }
                else if (value >= 60m)
                {
                    GradePoint(2.3);
                }
                else if (value >= 55m)
                {
                    GradePoint(2.0);
                }
                else if (value >= 50m)
                {
                    GradePoint(1);
                }
                else
                {
                    GradePoint(0);
                }
            }
        }


        public string Grade { get; set; }

        public Student()
        {

        }

        public Student(string name, string @class, string gender, int age, string address,
            DateTime? entryDate = null, string relationShip = "Single", decimal mark = 0, string grade = "F")
        {
            Name = name;
            Class = @class;
            Gender = gender;
            RelationShip = relationShip;
            EntryDate = entryDate ?? DateTime.Now;
            Age = age;
            Address = address;
            Mark = mark;
            Grade = grade;
        }
        /// <summary>
        /// Graduate method construction has parameter of gradePoint, default value is 0.
        /// </summary>
        /// <param name="gradePoints"></param>
        public static void GradePoint(double gradePoints = 0)
        {
            string grades = "";
            string numbericalScaleOfGrades = "";

            if (gradePoints == 0)
            {
                grades = "F";
                numbericalScaleOfGrades = "0%-49%%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 1 && gradePoints < 2)
            {
                grades = "D";
                numbericalScaleOfGrades = "50%-54%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 2 && gradePoints < 2.3)
            {
                grades = "C";
                numbericalScaleOfGrades = "55%-59%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 2.3 && gradePoints < 2.7)
            {
                grades = "C+";
                numbericalScaleOfGrades = "60%-64%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 2.7 && gradePoints < 3)
            {
                grades = "B-";
                numbericalScaleOfGrades = "65%-69%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 3 && gradePoints < 3.3)
            {
                grades = "B";
                numbericalScaleOfGrades = "70%-74%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 3.3 && gradePoints < 3.7)
            {
                grades = "B+";
                numbericalScaleOfGrades = "75%-79%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 3.7 && gradePoints < 4)
            {
                grades = "A-";
                numbericalScaleOfGrades = "80%-84%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints == 4)
            {
                grades = "A+";
                numbericalScaleOfGrades = "85%-100%";
                //Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }
        }
        /// <summary>
        /// the default value is "name, grade". Returns the formated string of information based on the passed parameter.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return Name + "\t" + Grade;
        }
        /// <summary>
        /// The implementation calls the ToString method in both cases: there is a transmission parameter, no parameter transmission.
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public string ToString(string formatString = "name, grade")
        {
            string result = "";
            var formatStrings = formatString.Split(',', StringSplitOptions.TrimEntries);

            foreach (var format in formatStrings)
            {
                switch (format.ToLower())
                {
                    case "name":
                        result += $"Name: {Name}\n";
                        break;
                    case "class":
                        result += $"Class: {Class}\n";
                        break;
                    case "gender":
                        result += $"Gender: {Gender}\n";
                        break;
                    case "relationship":
                        result += $"Relationship: {RelationShip}\n";
                        break;
                    case "entrydate":
                        result += $"Entry Date: {EntryDate}\n";
                        break;
                    case "age":
                        result += $"Age: {Age}\n";
                        break;
                    case "address":
                        result += $"Address: {Address}\n";
                        break;
                    case "mark":
                        result += $"Mark: {Mark}\n";
                        break;
                    case "grade":
                        result += $"Grade: {Grade}\n";
                        break;
                    default:
                        throw new ArgumentException($"Invalid format string '{format}'");
                }
            }

            return result;
        }

    }
}
