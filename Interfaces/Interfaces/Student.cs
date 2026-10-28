using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    // A class implementing multiple interfaces
    public class Student : IPrintable, ISaveable, IComparableByName
    {
        public string Name { get; set; }
        public int GPA { get; set; }

        public Student(string name, int gpa) { Name = name; GPA = gpa; }

        // IPrintable
        public void Print() => Console.WriteLine(GetSummary());
        public string GetSummary() => $"Student: {Name} | GPA: {GPA}";

        // ISaveable
        public void SaveToFile(string path) => File.WriteAllText(path, GetSummary());
        public bool LoadFromFile(string path)
        {
            if (!File.Exists(path)) return false;
            string data = File.ReadAllText(path);
            Console.WriteLine("Loaded: " + data);
            return true;
        }

        // IComparableByName
        public int CompareByName(object other)
        {
            if (other is Student s) return string.Compare(Name, s.Name);
            throw new ArgumentException("Not a Student");
        }

    }
}
