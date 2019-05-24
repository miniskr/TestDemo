using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Delegate
    {

    }

    class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature { get; set; }

        public void OnTemperatureChange(float newTemperature)
        {
            if(newTemperature < Temperature)
            {
                System.Console.WriteLine("Cooler: On");
            }
            else
            {

            }
        }
    }
}
