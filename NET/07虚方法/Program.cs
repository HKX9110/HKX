using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            ////e.Daka();
            //Manager m = new Manager();
            ////m.Daka();
            //Programmmer p = new Programmmer();
            ////p.Daka();

            //Employee[] emps = { e, m, p };
            //for (int i = 0; i < emps.Length; i++)
            //{
            //    //if(emps[i] is Manager)
            //    //{
            //    //    ((Manager)emps[i]).Daka();
            //    //}
            //    //else if(emps[i] is Programmmer)
            //    //{
            //    //    ((Programmmer)emps[i]).Daka();
            //    //}
            //    //else
            //    //{
            //    //    emps[i].Daka();
            //    //}
            //    emps[i].Daka();

            Employee e = new Programmmer();
            e.Daka();
			}
        
    }
    class Employee
    {
        public virtual void Daka()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
    class Manager:Employee
    {
        public override void Daka()
        {
            Console.WriteLine("经理11点打卡");
        }
    }
    class Programmmer:Employee
    {
        public override void Daka()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}

