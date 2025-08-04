using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("----------------");

        Console.Write("Enter your numerical grade (0-100): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numericGrade))
        {
            Grade grade = new Grade(numericGrade);
            if (grade.IsValid())
            {
                Console.WriteLine($"Letter Grade: {grade.GetLetterGrade()}");
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}

class Grade
{
    private int numericGrade;

    public Grade(int grade)
    {
        numericGrade = grade;
    }

    public bool IsValid()
    {
        return numericGrade >= 0 && numericGrade <= 100;
    }

    public string GetLetterGrade()
    {
        if (numericGrade >= 90) return "A";
        if (numericGrade >= 80) return "B";
        if (numericGrade >= 70) return "C";
        if (numericGrade >= 60) return "D";
        return "F";
    }
}
