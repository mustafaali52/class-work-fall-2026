//Console.Write("Enter your marks (0-100): ");
//int marks = int.Parse(Console.ReadLine());

//string grade;
//string feedback;

//if (marks >= 90) {
//    grade = "A";
//    feedback = "Excellent work!";
//}
//else if (marks >= 80) {
//    grade = "B";
//    feedback = "Good job!";
//}
//else if (marks >= 70) {
//    grade = "C";
//    feedback = "Satisfactory.";
//}
//else if (marks >= 60) {
//    grade = "D";
//    feedback = "You passed, but try harder.";
//}
//else
//{
//    grade = "F";
//    feedback = "Failed. Please retake the exam.";
//}

//Console.WriteLine($"Grade: {grade}");
//Console.WriteLine($"Feedback: {feedback}");


Console.Write("Enter marks (0-100): ");
int marks = int.Parse(Console.ReadLine());

// Switch expression — notice => instead of : and no break needed
string grade = marks switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"   // _ is the default
};

Console.WriteLine($"Your grade is: {grade}");
