using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Car Owner");
            Console.WriteLine(car.Owner);
            car.ShowOwner();
        }
    }

    class Vehicle
    {
        public string Owner { get; set; }
        public Vehicle(string owner)
        {
        }
    }
    class Car:Vehicle       //派生类其实将基类的所有成员都继承下来了
    {
        public Car(string owner)
        {
            this.Owner = owner;
        }

        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);
        }
    }
}
