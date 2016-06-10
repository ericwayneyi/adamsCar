using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamsCar
{
    class Car
    {

        public decimal Value { get; private set; }

        int Mileage;

        public Car(string color = "yellow", decimal value = 0, int mileage = 0)
        {
            Color = color;
            Value = value;
            Mileage = mileage;
        }

       
        public void Paint(string color)
        {
            Color = color;
            if(color == "red")
            {
                Value = Value * 1.5m;
            }
            else
            {
                Value = Value * 0.9m;
            }
        }

        public string Color { get; private set;}

        public void Drive(int miles)
        {
            Mileage += miles;
            if (miles > 100)
            {
                Value = Value * 0.99m;
            }
            //Do some code in here to drive the car
        }
    }
}
