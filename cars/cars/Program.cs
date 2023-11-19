using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xf_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120);
            Car Volvo = new Car("Model", "red", 2022, 110);

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Ford.fullThrottle();
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.color);
            Opel.fullThrottle();
            Console.WriteLine(Volvo.name);
            Console.WriteLine(Volvo.year);
            Console.WriteLine(Volvo.color);
            Volvo.fullThrottle();
            Console.ReadKey();
        }
    }
}