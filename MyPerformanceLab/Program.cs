using BenchmarkDotNet.Running;
using MyPerformanceLab;

// This triggers the heavy-duty measurement cycle
var summary = BenchmarkRunner.Run<StringPerformance>();