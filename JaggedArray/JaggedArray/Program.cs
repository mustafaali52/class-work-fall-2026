//Console.WriteLine("Hello, World!");
//int[][] semesterCourseMarks = new int[4][];
//for (int i = 0; i < semesterCourseMarks.Length; i++)
//{
//    Console.WriteLine($"Enter the number of courses for semester {i + 1}:");
//    int courseCount = int.Parse(Console.ReadLine());
//    semesterCourseMarks[i] = new int[courseCount];
//    for (int j = 0; j < courseCount; j++)
//    {
//        Console.WriteLine($"Enter marks for course {j + 1} in semester {i + 1}:");
//        semesterCourseMarks[i][j] = int.Parse(Console.ReadLine());
//    }
//}


//int[] numbers = { 42, 7, 18, 3, 99, 25 };

//Console.WriteLine("Before sort: " + string.Join(", ", numbers));

//Array.Sort(numbers);
//Console.WriteLine("After sort:  " + string.Join(", ", numbers));

//Array.Reverse(numbers);
//Console.WriteLine("Reversed:    " + string.Join(", ", numbers));

//int idx = Array.IndexOf(numbers, 18);
//Console.WriteLine($"Index of 18: {idx}");

// Create a list of strings
List<string> fruits = new List<string>();

//// .NET 10 — collection expression
//List<string> veggies = ["Carrot", "Pea", "Spinach"];

//// Adding elements
//fruits.Add("Apple");
//fruits.Add("Banana");
//fruits.Add("Mango");
//fruits.Insert(1, "Cherry");   // insert at index 1

//// Removing elements
//fruits.Remove("Banana");      // remove by value
//fruits.RemoveAt(0);           // remove by index

//// Searching
//bool hasMango = fruits.Contains("Mango");
//int idx = fruits.IndexOf("Mango");

//// Iterating
//Console.WriteLine("Fruits:");
//foreach (string f in fruits)
//    Console.WriteLine("  " + f);

//Console.WriteLine($"Count: {fruits.Count}");


//List<string> students = new List<string>();
//string choice;

//do
//{
//    Console.WriteLine("\n1. Add student  2. Remove  3. Show all  4. Exit");
//    Console.Write("Choice: ");
//    choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1":
//            Console.Write("Name: ");
//            students.Add(Console.ReadLine());
//            Console.WriteLine("Added.");
//            break;
//        case "2":
//            Console.Write("Name to remove: ");
//            string toRemove = Console.ReadLine();
//            if (students.Remove(toRemove))
//                Console.WriteLine("Removed.");
//            else
//                Console.WriteLine("Not found.");
//            break;
//        case "3":
//            Console.WriteLine($"Students ({students.Count}):");
//            for (int i = 0; i < students.Count; i++)
//                Console.WriteLine($"  {i + 1}. {students[i]}");
//            break;
//        case "4":
//            Console.WriteLine("Goodbye!");
//            break;
//        default:
//            Console.WriteLine("Invalid choice.");
//            break;
//    }
//} while (choice != "4");

// Key: student ID (int), Value: name (string)
Dictionary<int, string> students = new Dictionary<int, string>();

// Adding entries
students.Add(101, "Ali Hassan");
students.Add(101, "Sara Ahmed");
students[103] = "Omar Sheikh";   // alternative syntax

// Looking up
Console.WriteLine(students[105]);  // Ali Hassan

// Safe lookup — avoid KeyNotFoundException
if (students.TryGetValue(104, out string name))
    Console.WriteLine(name);
else
    Console.WriteLine("ID 104 not found.");

// Check existence
Console.WriteLine(students.ContainsKey(102));   // True
Console.WriteLine(students.ContainsValue("Sara Ahmed")); // True

// Remove an entry
students.Remove(102);

// Iterate all entries
foreach (KeyValuePair<int, string> entry in students)
{
    Console.WriteLine($"ID {entry.Key}: {entry.Value}");
}

Console.WriteLine($"Total: {students.Count}");
