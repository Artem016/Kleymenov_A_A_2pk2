using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Wait
    {
        public int wait_value;

        public Wait(int value)
        {
            wait_value = value;
        }

        public void WaitValue(int number ,Wait wait)
        {
            if(number == wait.wait_value)
            {
                Console.WriteLine($"Наконец появилость число {wait.wait_value}...");
            }
        }
    }
}
