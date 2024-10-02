/*
class Program
{
    static void Main(string[] args)
    {
        AvgGradeError avgGradeError = new AvgGradeError(); // Create a pointer to my class
        double averageGrade = avgGradeError.CalculateAverageGrade();
        Console.WriteLine("Average grade: " + averageGrade);
    }
}

public class AvgGradeError
{
    List<int> grades = new List<int> { 4, 7, 2, 0, 10, 4, 12 };

    int GetGrade(int courseID)
    {
        if (courseID < 0 || courseID >= grades.Count)
        {
            throw new IndexOutOfRangeException("Invalid course ID");
        }

        return grades[courseID];
    }

    public double CalculateAverageGrade()
    {
        int sum = 0;
        int count = 0;

        for (int i = 0; i < grades.Count; i++)
        {
            int grade = GetGrade(i);
            
            if (grade >= 2) 
            {
                sum += grade;
                count++;
            }
            else
            {
                Console.WriteLine($"Ignoring failed grades: {grade}");
            }
        }

        return count > 0 ? (double)sum / count : 0;
    }
}
*/