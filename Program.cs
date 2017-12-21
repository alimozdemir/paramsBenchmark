using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;

namespace paramsBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary =BenchmarkRunner.Run<ParameterBenchmark>();
        }
    }
    [DisassemblyDiagnoser(printAsm: true, printSource: true)]
    public class ParameterBenchmark
    {
        [Benchmark]
        public void Classic()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassic.Bar(null);
                else if (i == 1)
                    FooClassic.Bar(null, null);
                else if (i == 2)
                    FooClassic.Bar(null, null, null);
                else if (i == 3)
                    FooClassic.Bar(null, null, null, null);
                else if (i == 4)
                    FooClassic.Bar(null, null, null, null, null);
                else if (i == 5)
                    FooClassic.Bar(null, null, null, null, null, null);
                else if (i == 6)
                    FooClassic.Bar(null, null, null, null, null, null, null);
                else if (i == 7)
                    FooClassic.Bar(null, null, null, null, null, null, null, null);
                else if (i == 8)
                    FooClassic.Bar(null, null, null, null, null, null, null, null, null);
                else if (i == 9)
                    FooClassic.Bar(null, null, null, null, null, null, null, null, null, null);
            }
        }

        [Benchmark]
        public void Params()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooParams.Bar(null);
                else if (i == 1)
                    FooParams.Bar(null, null);
                else if (i == 2)
                    FooParams.Bar(null, null, null);
                else if (i == 3)
                    FooParams.Bar(null, null, null, null);
                else if (i == 4)
                    FooParams.Bar(null, null, null, null, null);
                else if (i == 5)
                    FooParams.Bar(null, null, null, null, null, null);
                else if (i == 6)
                    FooParams.Bar(null, null, null, null, null, null, null);
                else if (i == 7)
                    FooParams.Bar(null, null, null, null, null, null, null, null);
                else if (i == 8)
                    FooParams.Bar(null, null, null, null, null, null, null, null, null);
                else if (i == 9)
                    FooParams.Bar(null, null, null, null, null, null, null, null, null, null);
            }
        }
    }
}
