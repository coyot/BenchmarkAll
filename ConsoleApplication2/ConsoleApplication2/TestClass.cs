using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class TestClass
    {
        private const int N = 90000;
        private IEnumerable<int> list;


        public TestClass()
        {
            list = Enumerable.Range(0, N);
        }

        [Benchmark]
        public bool All()
        {
            return list.All(i => i != 0);
        }

        [Benchmark]
        public bool NotAny()
        {
            return !list.Any(i => i == 0);
        }
    }
}
