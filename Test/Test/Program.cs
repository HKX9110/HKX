using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.Owner);
            
        }
    }

    class Vehicle
    {
        public string Owner { get; set; }
        public Vehicle()
        {
            this.Owner = "N/A";
        }
    }
    class Car:Vehicle
    {
        public Car()
        {
            this.Owner = "Car Owner";
        }
    }
    
}
