using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Data;
            int[] Num = { 5, 10, 8, 3, 6, 12};

            // Query
            IEnumerable<int> SoNum = from a in Num
                                     where a%2 == 0
                                     orderby a
                                     select a;
            //IEnumerable<int> numQuery2 = Num.Where(num => num % 2 == 0).OrderBy(n => n);
            var numQuery2 = Num.Where(num => num % 2 == 0).OrderBy(n => n);
            // Execute
            foreach (var item in SoNum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in numQuery2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
