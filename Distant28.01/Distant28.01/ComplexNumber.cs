﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Проверять корректность вводимых данных
//Подсчитывает общую сумму созданных объектов комплексных чисел. Общее количество объектов

namespace pz23
{
    internal class ComplexNumber
    {
        public int a;//действительная часть
        public int b;//мнимая часть
        public const char i = 'i';//констнта
        public static int count = 0;

        public ComplexNumber()
        {
            a = 0;
            b = 0;
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

        public virtual ComplexNumber GhangeCN()
        {
            ComplexNumber timeCN = new ComplexNumber();
            timeCN.a = int.Parse(Console.ReadLine());
            timeCN.b = int.Parse(Console.ReadLine());
            return timeCN;
        }
    }
}
