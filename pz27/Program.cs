using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stud1 = new Student[2];

            for (int i = 0; i < stud1.Length; i++)
            {
                Console.WriteLine($"Введите данные для студена {i+1}...");
                Console.Write("name: "); stud1[i].name = Console.ReadLine();
                Console.Write("group: "); stud1[i].group = Console.ReadLine();
                Console.Write("количество оценок: "); stud1[i].ses = new byte[byte.Parse(Console.ReadLine())];
                for (int j = 0; j < stud1[i].ses.Length; j++)
                {
                    Console.Write($"оценка {j + 1}: "); stud1[i].ses[j] = Convert.ToByte(Console.ReadLine());
                }
            }
            Student.PrintBudStudent(stud1);
            Console.ReadLine();
        }
    }
}
