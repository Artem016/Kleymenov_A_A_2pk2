using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Проверять корректность вводимых данных
//Подсчитывает общую сумму созданных объектов комплексных чисел. Общее количество объектов

namespace Distant28._01
{
    internal class ComplexNumber
    {
        public int a;//действительная часть
        public int b;//мнимая часть
        public const char i = 'i';//констнта
        public static int count = 0;

        public ComplexNumber()
        {
            this.a = 0;
            this.b = 0;
            count++;
        }

        public ComplexNumber(int a, int b)
        {
            this.a = a;
            this.b = b;
            count++;
        }
        
        public static void PrintComplexNumber(ComplexNumber c_num)
        {
            Console.WriteLine($"Число: {c_num.a} + {c_num.b}{i}");
        }

        public static ComplexNumber GetMultiplicationByNumber(int natural_num, ComplexNumber c_num)
        {
            ComplexNumber time_c_num = new ComplexNumber();
            time_c_num.a = c_num.a * natural_num;
            time_c_num.b = c_num.b * natural_num;
            return time_c_num;
        }

        public static void ChangeComplexNumber(ComplexNumber userCNumber)
        {
            int time_a = 0;
            int time_b = 0;
            bool flag = true;

            Console.Write("Введите значение действительной части: ");
            while (flag)
            {
                try
                {
                    time_a = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректное значение действительной части.");
                }
            }
            Console.Write("Введите значение мнимой части: ");
            flag = true;
            while (flag)
            {
                try
                {
                    time_b = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректное значение мнимой части.");
                }
            }
            userCNumber.a = time_a;
            userCNumber.b = time_b;
             
        }

        public static int GetAmountComplexNumber()
        {
            return count;
        }
    }
}
