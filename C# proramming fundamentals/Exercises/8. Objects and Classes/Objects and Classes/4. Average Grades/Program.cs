using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> ourClass = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                Students student = new Students();
                student.Name = command[0];
                command.RemoveAt(0);
                student.Grades = command.Select(double.Parse).ToList();
                ourClass.Add(student); 
            }
            foreach (var person in ourClass.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                Console.WriteLine("{0} -> {1:F2}", person.Name, person.Average);
            }
        }
    }
    class Students
    {
        public string Name;
        public List<double> Grades = new List<double>();
        public double Average { get { return Grades.Average(); } }

    }
}