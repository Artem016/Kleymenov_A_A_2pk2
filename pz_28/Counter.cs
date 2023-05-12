using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Counter
    {
        public void CountToThousand(Wait wait)
        {
            Console.WriteLine("Жестоко перебирает числа от одного до тысячи");
            for (int i = 1; i <= 1000; i++)
            {
                wait.WaitValue(i, wait);
            }
        } 
    }
}
