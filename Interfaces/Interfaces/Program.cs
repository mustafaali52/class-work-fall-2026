using Interfaces;
Student student1 = new Student("Alice", 3);

student1.Print();
student1.SaveToFile("C:\\Users\\mustafa.hassan\\OneDrive - 10Pearls\\Desktop\\Interface.txt");
student1.LoadFromFile("C:\\Users\\mustafa.hassan\\OneDrive - 10Pearls\\Desktop\\Interface.txt");

Student s2 = new Student("Bob", 4);
Console.WriteLine(s2.CompareByName(student1));

try {
    Test t1 = new Test("Test1");
    Console.WriteLine(s2.CompareByName(t1));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
public class Test { 
    public string Name { get;
        set;
    }
    public Test(string name)
    {
        Name = name;
    }
}