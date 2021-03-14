using BenchmarkDotNet.Running;

namespace ConsoleUi
{
    public abstract class Benchmark
    {
    }

    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}