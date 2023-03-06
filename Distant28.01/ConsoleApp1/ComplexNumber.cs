using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pz24
{
    internal class ComplexNumber : ICloneable
    {
        const char i = 'i';
        public int a;
        public int b;

        public ComplexNumber()
        {
            a = 0;
            b = 0;
            Console.WriteLine($"Комплексное число: {a} + {b}{i}");
        }
        public ComplexNumber(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine($"Комплексное число: {a} + {b}{i}");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
