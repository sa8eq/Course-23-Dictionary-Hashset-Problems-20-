using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> candidateSkills = new HashSet<string>(new[] { "C#", "SQL", "JavaScript" });
        HashSet<string> jobRequirements = new HashSet<string>(new[] { "C#", "JavaScript", "React" });
        Console.WriteLine($"Matching Skills: {string.Join(",", jobRequirements.Intersect(candidateSkills))}");
        
        
        //candidateSkills.IntersectWith(jobRequirements);
        //Console.WriteLine("Matching Skills: " + string.Join(", ", candidateSkills));
        //Console.ReadKey();
    }
}

