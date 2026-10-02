// Greet the user
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// Display personalised message
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");
Console.WriteLine($"In 5 years you will be {age + 5} years old.");
