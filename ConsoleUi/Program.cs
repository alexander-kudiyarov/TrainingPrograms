using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Core.Bll;
using Core.Bll.Interfaces;
using Core.Dal;
using Core.Entities;
using Core.TrainingPrograms;

namespace ConsoleUi
{
    public class Benchmark
    {
        private readonly ITrainingProgramLogic _logic;

        public Benchmark()
        {
            var repository = new ProgramRepository();
            _logic = new TrainingProgramLogic(repository);
        }

        [Benchmark]
        public Session GetSession1()
        {
            var result = _logic.Get(BodybuildingProgram.Name, 1);
            return result;
        }

        [Benchmark]
        public Session GetSession2()
        {
            var result = _logic.Get(BodybuildingProgram.Name, 2);
            return result;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}