using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> stud = new List<Students>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine()
                    .Split()
                    .ToArray();
               //double gr = double.Parse(input[2])
                Students student = new Students(comand[0], 
                    comand[1], double.Parse(comand[2]));
                stud.Add(student);


            }
            stud = stud.OrderByDescending(x => x.Grade).ToList();

            foreach (Students student in stud)
            {
                Console.WriteLine(student);
            }


        }
    }
    class Students
    {
        public Students(string first, string last, double x)
        {
            FirstName = first;
            LastName = last;
            Grade = x;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Grade:F2}";
        }
    }
}
