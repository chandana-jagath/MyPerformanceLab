# C# High-Performance & Zero-Allocation Lab 🚀

Welcome to the companion repository for my technical blog series on **Modern .NET Performance Engineering**. 
This repository contains production-grade benchmarks, memory optimization patterns, and deep dives into .NET 10 internals.

## 🎯 Objectives
* **Zero-Allocation:** Demonstrating `Span<T>` and `Memory<T>` to eliminate GC pressure.
* **Benchmarking:** Standardized performance testing using `BenchmarkDotNet`.
* **Native AOT:** Optimizing microservices for the smallest possible memory footprint.

---

## 🔬 Benchmark: String Processing vs. ReadOnlySpan<char>

This lab compares traditional string manipulation with modern memory-safe slicing.

### The Results (Generated via BenchmarkDotNet)

You can find the lab result: MyPerformanceLab/bin/Release/net10.0/BenchmarkDotNet.Artifacts/results/MyPerformanceLab.StringPerformance-report-github.md

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.7840/24H2/2024Update/HudsonValley)
Intel Core Ultra 7 155U 1.70GHz, 1 CPU, 14 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  
| Method             | Mean         | Error      | StdDev     | Rank | Gen0  | Allocated | 
|--------------------|--------------|------------|------------|------|-------|-----------|
| **UsingSpan**      | **2.129 ns** | 0.0452 ns  | 0.0353 ns  | 1    | -     | **0 B**   |
| UsingSubstring     | 6.485 ns     | 0.1697 ns  | 0.1588 ns  | 2    | 0.0064|  40 B     |

> **Key Takeaway:** The Span-based approach is ~3x faster and results in **Zero Heap Allocations**, drastically
> reducing Garbage Collector (GC) activity in high-throughput systems.

