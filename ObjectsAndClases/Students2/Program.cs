using Students2;
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

            while (input[0] != "end")
            {

                Students student = new Students();

                if (IsStudentExsist(students, input[0], input[1]))
                {
                    student = GetStudent(students, input[0], input[1]);
                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Age = int.Parse(input[2]);
                    student.Town = input[3];
                }
                else
                {



                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Age = int.Parse(input[2]);
                    student.Town = input[3];

                    students.Add(student);
                }

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

        private static Students GetStudent(List<Students> students, string v1, string v2)
        {
            Students theStudent = null;
            foreach (Students item in students)
            {
                if (item.FirstName== v1&&item.LastName==v2)
                {
                    theStudent = item;
                }
            }
            return theStudent;
        }

        private static bool IsStudentExsist(List<Students> students, string v1, string v2)
        {
            foreach (Students student in students)
            {
                if (student.FirstName== v1&& student.LastName==v2)

                {
                    return true;
                }
            }
            return false;
        }
    }
}
