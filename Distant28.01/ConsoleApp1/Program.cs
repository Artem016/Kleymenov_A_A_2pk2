using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cm1 = new ComplexNumber();
            ComplexNumber cm2 = new ComplexNumber(3, 4);
            cm1 = (ComplexNumber)cm2.Clone();
            Console.WriteLine(cm1.a);
            Console.ReadLine();
        }
    }
}
