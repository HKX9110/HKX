using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 11, 12, 13, 14, 15 };
            bool b = myArray.Any(i => i > 14);
            Console.WriteLine(b);
           
        }
       
    }
    
   
}
