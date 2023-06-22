namespace Exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double gradePoints;
            do
            {
                Console.Write("Enter Grade Points: ");
                if (!double.TryParse(Console.ReadLine(), out gradePoints))
                {
                    Console.WriteLine("Enter Double! Enter again!");
                    continue;
                }
                if (0 < gradePoints && gradePoints > 4)
                {
                    Console.WriteLine("Enter double ranger [0.0-4.0]: ");
                }
                GradePoint(gradePoints);
            } while (gradePoints >= 0 || gradePoints <= 4);


        }
        public static void GradePoint(double gradePoints = 0)
        {
            string grades = "";
            string numbericalScaleOfGrades = "";

            if (gradePoints == 0)
            {
                grades = "F";
                numbericalScaleOfGrades = "0%-49%%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 1 && gradePoints < 2)
            {
                grades = "D";
                numbericalScaleOfGrades = "50%-54%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 2 && gradePoints < 2.3)
            {
                grades = "C";
                numbericalScaleOfGrades = "55%-59%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 2.3 && gradePoints < 2.7)
            {
                grades = "C+";
                numbericalScaleOfGrades = "60%-64%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 2.7 && gradePoints < 3)
            {
                grades = "B-";
                numbericalScaleOfGrades = "65%-69%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 3 && gradePoints < 3.3)
            {
                grades = "B";
                numbericalScaleOfGrades = "70%-74%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 3.3 && gradePoints < 3.7)
            {
                grades = "B+";
                numbericalScaleOfGrades = "75%-79%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints >= 3.7 && gradePoints < 4)
            {
                grades = "A-";
                numbericalScaleOfGrades = "80%-84%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }

            if (gradePoints == 4)
            {
                grades = "A+";
                numbericalScaleOfGrades = "85%-100%";
                Console.WriteLine($"Grades: {grades}, GradePoints: {gradePoints}, NumbericalScaleOfGrades: {numbericalScaleOfGrades}");
            }
        }
    }
}