using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var r1 = !list.Any(t => t == 0);
            var r2 = list.All(t => t != 0);

            var summary = BenchmarkRunner.Run<TestClass>();
        }
    }
}
