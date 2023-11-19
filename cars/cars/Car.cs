using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace xf_2023
{
    internal class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;

        public Car(string nameName, string colortheme, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colortheme;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }
        public Car(string nameName)
        {
            name = nameName;
        }

        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of" + maxSpeed);

        }
    }
}
