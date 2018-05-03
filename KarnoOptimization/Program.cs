using KarnoOptimization.Karno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarnoOptimization
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new KMap(3, new HashSet<long>() { 4, 5, 6 }, new HashSet<long>() { });
            map.PrintCoverages(true);
            map.PrintTestResults();

            Console.ReadKey();
        }
    }
}
