using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant28._01
{
    internal class ComplexNumber
    {
        public int a;//действительная часть
        public int b;//мнимая часть
        public const char i = 'i';//констнта
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
    }
}
