using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz28._2
{
    internal class Thermometer
    {
        public int temperature = 0;

        public void TemperatureChange(int change)
        {
            while (temperature == temperature + change)
            {
                if (temperature < temperature + change)
                {
                    temperature++;
                    Console.WriteLine(temperature);
                }
                else if (temperature > temperature + change)
                {
                    temperature--;
                    Console.WriteLine(temperature);
                }
                Console.WriteLine("Тепература изменена...");
            }
        }
    }
}
