using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System;
using Struct_Example;


namespace Benchmark
{
    [MemoryDiagnoser]

    public class Benchmark_1
    {
        [Benchmark]
        public void StructTest()
        {
            StructPoint point = new StructPoint();
            point.X = 1;
            point.Y = 2;
        }

        [Benchmark]

        public void ClassTest()
        {
            ClassPoint point = new ClassPoint();
            point.X = 1;
            point.Y = 2;
            var result = point.X = point.Y;
        }

    }

   // [MemoryDiagnoser]
    /*public class Benchmark_2
    {
        
    }*/

   [MemoryDiagnoser]

    public class Benchmark_3
    {
        struct Mystruct
        {
            public Decimal MyProperty1 { get; set; }
            public Decimal MyProperty2 { get; set; }

            public Decimal MyProperty3 { get; set; }

            public Decimal MyProperty4 { get; set; }

            public Decimal MyProperty5 { get; set; }

            public Decimal MyProperty6 { get; set; }

            public Decimal MyProperty7 { get; set; }

            public Decimal MyProperty8 { get; set; }

            public Decimal MyProperty9 { get; set; }

            public Decimal MyProperty10 { get; set; }
        }

        class MyClass
        {
            public Decimal MyProperty1 { get; set; }
            public Decimal MyProperty2 { get; set; }

            public Decimal MyProperty3 { get; set; }

            public Decimal MyProperty4 { get; set; }

            public Decimal MyProperty5 { get; set; }

            public Decimal MyProperty6 { get; set; }

            public Decimal MyProperty7 { get; set; }

            public Decimal MyProperty8 { get; set; }

            public Decimal MyProperty9 { get; set; }

            public Decimal MyProperty10 { get; set; }
        }

        private Mystruct _mystruct = new Mystruct();
        private MyClass _myClass = new MyClass();

        private void Foo(MyClass myClass)
        {
            var t = myClass.MyProperty1 + myClass.MyProperty2;
        }

        private void Bar(Mystruct myStruct)
        {
            var t = myStruct.MyProperty1 + myStruct.MyProperty2;
        }

        [Benchmark]

        public void StructTest()
        {
            Bar(_mystruct);
        }

        [Benchmark]

        public void ClassTest()
        {
            Foo(_myClass);
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<MyParserBenchmark>();
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}