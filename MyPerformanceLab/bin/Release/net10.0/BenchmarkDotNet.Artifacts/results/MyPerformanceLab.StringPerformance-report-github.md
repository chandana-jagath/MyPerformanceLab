```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.7840/24H2/2024Update/HudsonValley)
Intel Core Ultra 7 155U 1.70GHz, 1 CPU, 14 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method         | Mean     | Error     | StdDev    | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|--------------- |---------:|----------:|----------:|------:|--------:|-----:|-------:|----------:|------------:|
| UsingSubstring | 6.485 ns | 0.1697 ns | 0.1588 ns |  1.00 |    0.03 |    2 | 0.0064 |      40 B |        1.00 |
| UsingSpan      | 2.129 ns | 0.0452 ns | 0.0353 ns |  0.33 |    0.01 |    1 |      - |         - |        0.00 |
