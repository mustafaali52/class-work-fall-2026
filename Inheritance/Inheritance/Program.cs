using Inheritance;

Shape[] shapes = {
            new Rectangle(5, 3, "Red"),
            new Circle(4, "Blue"),
            new Square(6, "Green"),
        };

foreach (Shape s in shapes)
{
    // Each shape uses its own Area() — polymorphism at work
    Console.WriteLine(s.Describe());
}
