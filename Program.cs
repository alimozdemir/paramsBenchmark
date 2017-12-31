using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;

namespace paramsBenchmark
{
    class RefType
    {
        public RefType(int val)
        {
            TestValue = val;
        }
        public int TestValue { get; }
    }
    unsafe class Program
    {

        static unsafe void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ParameterBenchmark>();

            /*RefType ins1 = new RefType(5);
            RefType ins2 = new RefType(10);
            RefType ins3 = new RefType(15);
            PrintAddress("ins1", ins1);
            PrintAddress("ins2", ins2);
            PrintAddress("ins3", ins3);
            ParamsTest(ins1, ins2);

            ParamsTest(ins1, ins2);*/
            //ClassicTest(ins1, ins2);
        }
        static unsafe void PrintAddress(string value, object val)
        {
            TypedReference tr = __makeref(val);
            IntPtr ptr = **(IntPtr**)(&tr);

            Console.WriteLine("{0}\t\t\tArray Pointer 0x{1}", value, ptr.ToString("x"));
        }
        static unsafe void ParamsTest(params RefType[] values)
        {
            PrintAddress("Params", values);
            PrintAddress("Params", values[0]);
            PrintAddress("Params", values[1]);
            //PrintAddress("Params", values[2]);
        }
        static unsafe void ClassicTest(RefType ref1, RefType ref2)
        {
            var objectArray = new object[] { ref1, ref2 };
            PrintAddress("Classic", objectArray);
            PrintAddress("Classic", objectArray[0]);
            PrintAddress("Classic", objectArray[1]);
        }

    }
    [MemoryDiagnoser]
    [DisassemblyDiagnoser]
    public class ParameterBenchmark
    {
        //[Benchmark]
        public void ClassicWithObject()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassic.BarObject(null);
                else if (i == 1)
                    FooClassic.BarObject(null, null);
                else if (i == 2)
                    FooClassic.BarObject(null, null, null);
                else if (i == 3)
                    FooClassic.BarObject(null, null, null, null);
                else if (i == 4)
                    FooClassic.BarObject(null, null, null, null, null);
                else if (i == 5)
                    FooClassic.BarObject(null, null, null, null, null, null);
                else if (i == 6)
                    FooClassic.BarObject(null, null, null, null, null, null, null);
                else if (i == 7)
                    FooClassic.BarObject(null, null, null, null, null, null, null, null);
                else if (i == 8)
                    FooClassic.BarObject(null, null, null, null, null, null, null, null, null);
                else if (i == 9)
                    FooClassic.BarObject(null, null, null, null, null, null, null, null, null, null);
            }
        }
        //[Benchmark]
        public void ClassicWithObjectArray()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassicWithArray.BarObject(null);
                else if (i == 1)
                    FooClassicWithArray.BarObject(null, null);
                else if (i == 2)
                    FooClassicWithArray.BarObject(null, null, null);
                else if (i == 3)
                    FooClassicWithArray.BarObject(null, null, null, null);
                else if (i == 4)
                    FooClassicWithArray.BarObject(null, null, null, null, null);
                else if (i == 5)
                    FooClassicWithArray.BarObject(null, null, null, null, null, null);
                else if (i == 6)
                    FooClassicWithArray.BarObject(null, null, null, null, null, null, null);
                else if (i == 7)
                    FooClassicWithArray.BarObject(null, null, null, null, null, null, null, null);
                else if (i == 8)
                    FooClassicWithArray.BarObject(null, null, null, null, null, null, null, null, null);
                else if (i == 9)
                    FooClassicWithArray.BarObject(null, null, null, null, null, null, null, null, null, null);
            }
        }
        //[Benchmark]
        public void ParamsWithObject()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooParams.BarObject(null);
                else if (i == 1)
                    FooParams.BarObject(null, null);
                else if (i == 2)
                    FooParams.BarObject(null, null, null);
                else if (i == 3)
                    FooParams.BarObject(null, null, null, null);
                else if (i == 4)
                    FooParams.BarObject(null, null, null, null, null);
                else if (i == 5)
                    FooParams.BarObject(null, null, null, null, null, null);
                else if (i == 6)
                    FooParams.BarObject(null, null, null, null, null, null, null);
                else if (i == 7)
                    FooParams.BarObject(null, null, null, null, null, null, null, null);
                else if (i == 8)
                    FooParams.BarObject(null, null, null, null, null, null, null, null, null);
                else if (i == 9)
                    FooParams.BarObject(null, null, null, null, null, null, null, null, null, null);
            }
        }
        [Benchmark]
        public void ClassicWithRef()
        {
            RefType val = new RefType(10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassic.BarObject(val);
                else if (i == 1)
                    FooClassic.BarObject(val, val);
                else if (i == 2)
                    FooClassic.BarObject(val, val, val);
                else if (i == 3)
                    FooClassic.BarObject(val, val, val, val);
                else if (i == 4)
                    FooClassic.BarObject(val, val, val, val, val);
                else if (i == 5)
                    FooClassic.BarObject(val, val, val, val, val, val);
                else if (i == 6)
                    FooClassic.BarObject(val, val, val, val, val, val, val);
                else if (i == 7)
                    FooClassic.BarObject(val, val, val, val, val, val, val, val);
                else if (i == 8)
                    FooClassic.BarObject(val, val, val, val, val, val, val, val, val);
                else if (i == 9)
                    FooClassic.BarObject(val, val, val, val, val, val, val, val, val, val);
            }
        }
        [Benchmark]
        public void ClassicWithRefArray()
        {
            RefType val = new RefType(10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassicWithArray.BarObject(val);
                else if (i == 1)
                    FooClassicWithArray.BarObject(val, val);
                else if (i == 2)
                    FooClassicWithArray.BarObject(val, val, val);
                else if (i == 3)
                    FooClassicWithArray.BarObject(val, val, val, val);
                else if (i == 4)
                    FooClassicWithArray.BarObject(val, val, val, val, val);
                else if (i == 5)
                    FooClassicWithArray.BarObject(val, val, val, val, val, val);
                else if (i == 6)
                    FooClassicWithArray.BarObject(val, val, val, val, val, val, val);
                else if (i == 7)
                    FooClassicWithArray.BarObject(val, val, val, val, val, val, val, val);
                else if (i == 8)
                    FooClassicWithArray.BarObject(val, val, val, val, val, val, val, val, val);
                else if (i == 9)
                    FooClassicWithArray.BarObject(val, val, val, val, val, val, val, val, val, val);
            }
        }
        [Benchmark]
        public void ParamsWithRef()
        {
            RefType val = new RefType(10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooParams.BarObject(val);
                else if (i == 1)
                    FooParams.BarObject(val, val);
                else if (i == 2)
                    FooParams.BarObject(val, val, val);
                else if (i == 3)
                    FooParams.BarObject(val, val, val, val);
                else if (i == 4)
                    FooParams.BarObject(val, val, val, val, val);
                else if (i == 5)
                    FooParams.BarObject(val, val, val, val, val, val);
                else if (i == 6)
                    FooParams.BarObject(val, val, val, val, val, val, val);
                else if (i == 7)
                    FooParams.BarObject(val, val, val, val, val, val, val, val);
                else if (i == 8)
                    FooParams.BarObject(val, val, val, val, val, val, val, val, val);
                else if (i == 9)
                    FooParams.BarObject(val, val, val, val, val, val, val, val, val, val);
            }
        }

        /*[Benchmark]
        public void ClassicWithInteger()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassicUnsafe.BarInteger(i);
                else if (i == 1)
                    FooClassicUnsafe.BarInteger(i, i);
                else if (i == 2)
                    FooClassicUnsafe.BarInteger(i, i, i);
                else if (i == 3)
                    FooClassicUnsafe.BarInteger(i, i, i, i);
                else if (i == 4)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i);
                else if (i == 5)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i);
                else if (i == 6)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i);
                else if (i == 7)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i, i);
                else if (i == 8)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i, i, i);
                else if (i == 9)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i, i, i, i);
            }
        }*/

        //[Benchmark]
        public void ParamsUnsafeWithInteger()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    FooClassicUnsafe.BarInteger(i);
                else if (i == 1)
                    FooClassicUnsafe.BarInteger(i, i);
                else if (i == 2)
                    FooClassicUnsafe.BarInteger(i, i, i);
                else if (i == 3)
                    FooClassicUnsafe.BarInteger(i, i, i, i);
                else if (i == 4)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i);
                else if (i == 5)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i);
                else if (i == 6)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i);
                else if (i == 7)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i, i);
                else if (i == 8)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i, i, i);
                else if (i == 9)
                    FooClassicUnsafe.BarInteger(i, i, i, i, i, i, i, i, i, i);
            }
        }
    }
}
