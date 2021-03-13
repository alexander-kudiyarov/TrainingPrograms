using BenchmarkDotNet.Running;
using Core.Bll;
using Core.Bll.Interfaces;
using Core.Dal;
using Core.TrainingPrograms;

namespace ConsoleUi
{
    public class Benchmark
    {
        private readonly ITrainingProgramLogic _logic;
        private readonly BaseTrainingProgram _program;

        public Benchmark()
        {
            var repository = new ProgramRepository();
            _logic = new TrainingProgramLogic(repository);
            _program = new BodybuildingProgram();
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