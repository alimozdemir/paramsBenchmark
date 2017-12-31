``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Threshold 2 [1511, November Update] (10.0.10586.0)
Processor=Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), ProcessorCount=2
.NET Core SDK=2.1.3
  [Host]     : .NET Core 2.0.4 (Framework 4.6.25921.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.4 (Framework 4.6.25921.01), 64bit RyuJIT


```
|              Method |      Mean |     Error |     StdDev |    Median |  Gen 0 | Allocated |
|-------------------- |----------:|----------:|-----------:|----------:|-------:|----------:|
|      ClassicWithRef |  40.89 ns | 0.5632 ns |  0.4703 ns |  41.00 ns | 0.0114 |      24 B |
| ClassicWithRefArray | 322.83 ns | 2.8397 ns |  2.2170 ns | 322.82 ns | 0.3352 |     704 B |
|       ParamsWithRef | 311.31 ns | 6.2609 ns | 15.8221 ns | 303.55 ns | 0.3352 |     704 B |
