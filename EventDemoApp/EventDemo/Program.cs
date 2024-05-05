using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Caculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudent("Dakoda Berg").PrintToConsole();
            history.SignUpStudent("John Berg").PrintToConsole();
            history.SignUpStudent("Ryan Berg").PrintToConsole();
            history.SignUpStudent("Megan Berg").PrintToConsole();
            history.SignUpStudent("Crystal Berg").PrintToConsole();
            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Megan Berg").PrintToConsole();
            math.SignUpStudent("Crystal Berg").PrintToConsole();
            math.SignUpStudent("Dakoda Berg").PrintToConsole();



            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;
            Console.WriteLine($"{model.CoureseTitle}: Full");
            //or
            //Console.WriteLine(e);
        }
    }

    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }

    public class CollegeClassModel
    {
        public event EventHandler<string> EnrollmentFull;

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CoureseTitle { get; private set; }
        public int MaximumStudents { get; private set; }


        public CollegeClassModel(string title, int maximumStudents)
        {
            CoureseTitle = title;
            MaximumStudents = maximumStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";
            if (enrolledStudents.Count < MaximumStudents)
            //check to see if maxed out
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CoureseTitle}";
                if (enrolledStudents.Count == MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{CoureseTitle} enrollment is now full.");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to wait list in {CoureseTitle}";
            }
            return output;
        }
    }
}
