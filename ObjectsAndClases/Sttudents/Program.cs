using System;
using System.Collections.Generic;
using System.Linq;

namespace Sttudents1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Students> students = new List<Students>();

            while (input[0] !="end")
            {
                Students student = new Students();

                student.FirstName = input[0];
                student.LastName = input[1];
                student.Age = int.Parse(input[2]);
                student.Town = input[3];

                students.Add(student);

                input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();


            }
            string comand = Console.ReadLine();

            List<Students> toPrintList = students
                .Where(s => s.Town == comand)
                .ToList();
            foreach (Students item in toPrintList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}
