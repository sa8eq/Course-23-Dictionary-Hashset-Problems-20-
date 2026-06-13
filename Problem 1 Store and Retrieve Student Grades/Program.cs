using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Store_and_Retrieve_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Sadeq",99);
            students.Add("Asmaa", 90);
            students.Add("emad", 94);
            students.Add("clara", 89);
            students.Add("Bob", 87);

            foreach(var i in students)
            {
                Console.WriteLine($"Name: {i.Key}, Grade: {i.Value}");
            }
        }
    }
}
