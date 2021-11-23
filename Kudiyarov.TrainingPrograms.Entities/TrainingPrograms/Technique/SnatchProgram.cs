using System;
using System.Collections.Generic;
using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms.Technique
{
    public sealed class SnatchProgram : BaseTrainingProgram
    {
        protected override IReadOnlyList<Func<Session>> Sessions { get; } = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2
        };

        public override ProgramType Type => ProgramType.Snatch;
        public override string Name => "Snatch Program";

        private static Session GetSession1_1()
        {
            var warmup = GetWarmup1();

            var ex1 = new MultiSnatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(3, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 },
                    new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex2 = new Snatch(SnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 3 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
                }
            };

            // todo ??
            var ex4 = new Accessory(SnatchPressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(2, warmup),
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession1_2()
        {
            var warmupA = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var warmupB = new Accessory(Abs)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var ex1 = new Snatch(MuscleSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
                }
            };

            var ex2 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 },
                    new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex3 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.4, Repeats = 10, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(2, warmupA, warmupB),
                    new(ex1),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static BaseExercise[] GetWarmup1()
        {
            var a = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 10 } }
            };

            var b = new Accessory(Abs)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var c = new Accessory(BoxJump)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 5 } }
            };

            var warmup = new BaseExercise[]
            {
                a, b, c
            };

            return warmup;
        }
    }
}