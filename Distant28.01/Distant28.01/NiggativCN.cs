using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz23
{
    internal class NiggativCN : ComplexNumber
    {
        //public override void changecomplexnumber()
        //{
        //    int time_a = 0;
        //    int time_b = 0;
        //    bool flag = true;

        //    console.write("введите значение действительной части: ");
        //    while (flag)
        //    {
        //        try
        //        {
        //            time_a = int.parse(console.readline());
        //            time_a = time_a > 0 ? -time_a : time_a;
        //            flag = false;
        //        }
        //        catch (exception)
        //        {
        //            console.writeline("некорректное значение действительной части.");
        //        }
        //    }
        //    console.write("введите значение мнимой части: ");
        //    flag = true;
        //    while (flag)
        //    {
        //        try
        //        {
        //            time_b = int.parse(console.readline());
        //            time_b = time_b > 0 ? -time_b : time_b;
        //            flag = false;
        //        }
        //        catch (exception)
        //        {
        //            console.writeline("некорректное значение мнимой части.");
        //        }
        //    }
        //    usercnumber.a = time_a;
        //    usercnumber.b = time_b;
        //}

        public override ComplexNumber GhangeCN()
        {
            ComplexNumber timeCN = new ComplexNumber();
            timeCN.a = int.Parse(Console.ReadLine());
            timeCN.a = timeCN.a > 0 ? -timeCN.a : timeCN.a;
            timeCN.b = int.Parse(Console.ReadLine());
            timeCN.b = timeCN.b > 0 ? -timeCN.b : timeCN.b;
            return timeCN;
        }
    }
}
