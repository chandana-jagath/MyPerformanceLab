using BenchmarkDotNet.Attributes;

namespace MyPerformanceLab
{
    [MemoryDiagnoser] // Essential for tracking GC and RAM
    [RankColumn]      // Add 1, 2, 3 ranking to your results
    public class StringPerformance
    {
        private const string TelemetryData = "ID:9982-XYZ-2026-LOG-DATA";
        private const int Length = 8;

        [Benchmark(Baseline = true)] // This is the "Before" (Standard)
        public string UsingSubstring()
        {
            int start = TelemetryData.IndexOf(':') + 1;
            return TelemetryData.Substring(start, Length);
        }

        [Benchmark] // This is the "After" (optimization)
        public ReadOnlySpan<char> UsingSpan()
        {
            ReadOnlySpan<char> span = TelemetryData.AsSpan();
            int start = span.IndexOf(':') + 1;
            return span.Slice(start, Length);
        }
    }
}
