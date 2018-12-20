using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MulDelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID=1,penColor=ConsoleColor.Blue};
            Student stu2 = new Student() { ID=2,penColor=ConsoleColor.DarkGreen};
            Student stu3 = new Student() { ID = 3, penColor = ConsoleColor.White };

            Action act1 = new Action(stu1.DoHomeWork);
            Action act2 = new Action(stu2.DoHomeWork);
            Action act3 = new Action(stu3.DoHomeWork);

            act1 += act2;
            act1 += act3;
            act1();
        }
    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor penColor { get; set; }

        public void DoHomeWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.penColor;
                Console.WriteLine("Studnet{0},do homework {1} hour(s)",this.ID,i);
                Thread.Sleep(1000);
            }
        }
    }
}
