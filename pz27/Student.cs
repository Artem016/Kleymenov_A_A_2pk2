using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz27
{
    internal struct Student
    {
        public string name;
        public string group;
        public byte[] ses;
        public static void PrintBudStudent(Student[] student)
        {
            bool isBudStudent = false;
            Console.WriteLine("Фамилии студентов у которых есть оценки 2 или ниже:");
            for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < student[i].ses.Length; j++)
                {
                    if (student[i].ses[j] <= 2)
                    {
                        Console.WriteLine(student[i].name);
                        isBudStudent = true;
                        break;
                    }
                }
            }
            if (!isBudStudent)
            {
                Console.WriteLine("Все студенты молодцы...");
            }
        }
    }
}
