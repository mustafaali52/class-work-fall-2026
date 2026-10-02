//string[] students = { "Ali", "Sara", "Ahmed", "Zara", "Omar" };

//Console.WriteLine("=== Student Roll Call ===");

//int number = 1;
//foreach (string student in students)
//{
//    Console.WriteLine($"{number}. {student}");
//    number++;
//}

//Console.WriteLine($"Total students: {students.Length}");


Console.Write("How many students? ");
int n = int.Parse(Console.ReadLine());

int[] marks = new int[n];

// Input
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter marks for Student {i + 1}: ");
    marks[i] = int.Parse(Console.ReadLine());
}

// Calculate sum, min, max
int sum = 0, min = marks[0], max = marks[0];

foreach (int m in marks)
{
    sum += m;
    if (m < min) min = m;
    if (m > max) max = m;
}

double average = (double)sum / n;

// Output
Console.WriteLine($"Sum:     {sum}");
Console.WriteLine($"Average: {average:F2}");
Console.WriteLine($"Highest: {max}");
Console.WriteLine($"Lowest:  {min}");
