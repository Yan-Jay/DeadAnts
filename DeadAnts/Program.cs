using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new kata();
            var input = "antant";
            Console.WriteLine(test.DeadAntCount(input));
            //var input = "antzy";
            //var ans = 0;
            //var test = input.Replace("ant", "");
            //foreach (var a in test)
            //{
            //    Console.WriteLine(a);
            //}

            //Console.WriteLine("input: " + input);
            //Console.WriteLine("ans: " + ans);
            Console.ReadKey();
        }
    }
}
