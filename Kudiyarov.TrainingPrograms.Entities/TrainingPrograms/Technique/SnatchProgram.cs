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
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2
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
            var warmup = GetWarmup2();

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
                    new(2, warmup),
                    new(ex1),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession1_3()
        {
            var warmup = GetWarmup1();

            var ex1 = new Snatch(SnatchOnPlates)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 3 }
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 },
                    new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 4 }
                }
            };

            var ex3 = new Snatch(SnatchBalance)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
                }
            };

            var ex4 = new Snatch(SnatchPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
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

        private static Session GetSession1_4()
        {
            var warmup = GetWarmup1();

            var ex1 = new Accessory(ElbowsRotation)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 6, Sets = 3 }
                }
            };

            var ex2 = new Accessory(HipCleanBalance)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = 0, Repeats = 6, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(Clean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 2 },
                    new SingleRepeat { Percent = 0.7, Repeats = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 2 }
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

        private static Session GetSession1_5()
        {
            var warmup = GetWarmup2();

            var ex1 = new MultiAccessory(SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Weight = 0, Repeats = Array(4, 4), Sets = 2 }
                }
            };

            var ex2 = new MultiSnatch(HipPowerSnatch, SnatchBalance)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 3 }
                }
            };

            var ex3 = new Snatch(SnatchPushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 3 }
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

        private static Session GetSession2_1()
        {
            var warmup = GetWarmup3();

            var ex1 = new MultiSnatch(MuscleSnatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Weight = 0, Repeats = Array(4, 4, 4), Sets = 2 }
                }
            };

            var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch, SnatchBalance)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 3 }
                }
            };

            var ex3 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.500, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.600, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.750, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.775, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 1 }
                }
            };

            var ex4 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 3), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 3), Sets = 1 },
                    new MultiRepeat { Percent = 0.90, Repeats = Array(1, 3), Sets = 2 },
                    new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 1 }
                }
            };

            var ex5 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 9, Sets = 1 },
                    new SingleRepeat { Percent = 0.6, Repeats = 7, Sets = 1 },
                    new SingleRepeat { Percent = 0.7, Repeats = 5, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 }
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
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession2_2()
        {
            var warmup = GetWarmup4();

            var ex1 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 4 }
                }
            };

            var ex2 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 }
                }
            };

            var ex3 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    // TODO ??
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 5, Sets = 4 }
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

        private static BaseExercise[] GetWarmup2()
        {
            var a = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var b = new Accessory(Abs)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var warmup = new BaseExercise[]
            {
                a, b
            };

            return warmup;
        }

        private static BaseExercise[] GetWarmup3()
        {
            var a = new Accessory(ReverseHyperextension)
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

        private static BaseExercise[] GetWarmup4()
        {
            var a = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var b = new Accessory(Abs)
            {
                Repeats = new Repeat[] { new SingleRepeat { Repeats = 15 } }
            };

            var warmup = new BaseExercise[]
            {
                a, b
            };

            return warmup;
        }
    }
}