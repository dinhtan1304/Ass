Console.Write("Enter x = ");
int number = int.Parse(Console.ReadLine());
int x = number;
float value = (float)(2 * (x * x * x) - 6 * (x * x) + 2 * x - 1);
Console.WriteLine($"Y = {value}");
