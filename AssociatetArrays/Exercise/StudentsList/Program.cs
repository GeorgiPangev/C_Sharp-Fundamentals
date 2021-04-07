using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsList
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>(); 

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(student))
                {
                    students[student][0] += grade;
                    students[student][1]++;

                }
                else if (students.ContainsKey(student)== false)
                {
                    students.Add(student, new List<double> { grade, 1 });
                }


               

            }
            foreach (var stud in students)
            {
                if (stud.Value[1]>1)
                {
                    stud.Value[0] = stud.Value[0] / stud.Value[1];
                    stud.Value.Remove(stud.Value[1]);
                }
            }

           // students = students.Select(x => x.Value[0] >= 4.50);
            
            //Dictionary<string, List<double>> exl = students.OrderBy(x => x.Value)
            //      .Where(g => g.Value[0] >= 4.5)
            //      .ToDictionary(z => z.Key, z => z.Value);

            foreach (var st in students.OrderByDescending(z=>z.Value[0]))
            {
                if (st.Value[0] >= 4.50)
                {


                    Console.WriteLine($"{st.Key} -> {st.Value[0]:F2}");
                }
            }

            //Console.WriteLine($"{string.Join(Environment.NewLine, exl.Keys)}" +
            //    $" -> {string.Join(Environment.NewLine, exl.Values)}");
        }
    }
}
