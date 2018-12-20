using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14抽象类实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i = new son();
            i.test();
        }
    }

    abstract class Person:I1
    {

        public void test()
        {
            Console.WriteLine("抽象类实现接口");
        }
    }
    class son:Person
    {

    }
    interface I1
    {
        void test();
    }
}
