using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 90;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
        }
    }

    class Student
    {
        Dictionary<string, int> scoreDict = new Dictionary<string, int>();
        public int? this[string subject]      //int? 代表回传数据类型可以为null
        {
            get {
                    if (this.scoreDict.ContainsKey(subject))
                    {
                        return scoreDict[subject];
                    }
                    else
                    {
                        return null;   //没有科目对应的成绩 并不代表成绩为0 只是没有成绩 所以为null
                    }
                }
            set {
                    if (value.HasValue==false)
                    {
                        throw new Exception("Socre can not be null");   //字典里 成绩类型为int 不能将null值存入其中 先检验值是否为空
                    }
                    if (this.scoreDict.ContainsKey(subject))
                    {
                        scoreDict[subject] = value.Value;
                    }
                    else
                    {
                        scoreDict.Add(subject, value.Value);
                    }
                }
        }
    }
}
