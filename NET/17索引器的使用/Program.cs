using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17索引器的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };
            Console.WriteLine(number[2]);

           // Dictionary<string, int> dic = new Dictionary<string, int>();
           // dic.Add("张三", 50);
           // dic.Add("李四", 60);

           //int a = dic["李四"];
           //Console.WriteLine(a);
            Person p = new Person();
           // p.Numbers = new int[] { 1, 2, 3, 4, 5 };
            p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            p[3] = 4;

            p["张三"] = "学生";
            p["李四"] = "老师";
            p["王五"] = "校长";
        }
    }
    class Person
    {
        private int[] numbers = new int[5];
        private Dictionary<string, string> dic = new Dictionary<string, string>();

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        //索引器 让对象以索引的方式操作数组
        public int this[int index]
        {
            get { return numbers[index];}
            set { numbers[index] = value; }
        }

        public string this[string index]
        {
            get { return dic[index];}
            set { dic[index] = value; }
        }
    }
}
