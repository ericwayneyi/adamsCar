using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamsCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car adamsCar = new Car("red", 5000, 10000);
            adamsCar.Drive(100);
            Console.WriteLine("Adam's car is now worth: {0}", adamsCar.Value);
            adamsCar.Drive(5000);
            Console.WriteLine("Adam's car is now worth: {0}", adamsCar.Value);

            adamsCar.Paint("beige");
            Console.WriteLine("Adam's car is now worth: {0}", adamsCar.Value);

            adamsCar.Drive(5000);
            Console.WriteLine("Adam's car is now worth: {0}", adamsCar.Value);

            adamsCar.Paint("red");
            Console.WriteLine("Adam's car is now worth: {0}", adamsCar.Value);

            string currentColor = adamsCar.Color;

        }
    }
}
