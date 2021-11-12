using System;
using System.Collections.Generic;
using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms
{
    public sealed partial class CompetitionProgram
    {
        private static Session GetSession8_1()
        {
            var warmup = GetSnatchWarmUp3();

            var ex1 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 3 }
                }
            };

            var ex2 = new Snatch(SnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 2 }
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
                }
            };

            var ex5 = new Accessory(ToesToBar)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 4 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(warmup),
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession8_2()
        {
            var ex1 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 4 }
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = GetRange(0.35, 0.45, 3, 6)
            };

            var ex3 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = GetRange(0.35, 0.45, Array(1, 2), 6)
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession8_3()
        {
            var warmup = GetCleanAndJerkWarmUp1();

            var ex1 = new CleanAndJerk(CleanFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.775, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 1 }
                }
            };

            var ex2 = new CleanAndJerk(CleanPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.1, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(6, 6), Sets = 3 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 8, Sets = 4 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(warmup),
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession8_4()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new MultiSnatch(SnatchPushPress, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.95, Repeats = Array(1, 1), Sets = 1 }
                }
            };

            var ex2Repeats = new List<Repeat>
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 }
            };

            ex2Repeats.AddRange(
                GetRange(0.75, 0.8, Array(1, 1), 4));

            var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
            {
                Repeats = ex2Repeats
            };

            var ex3 = new Snatch(SnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
                }
            };

            var ex4 = new Snatch(SnatchPressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat { Time = TimeSpan.FromSeconds(60), Sets = 4 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(warmup),
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession8_5()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.500, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.600, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.650, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.750, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.800, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.850, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.875, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.900, Repeats = Array(1, 2), Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(warmup),
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }
    }
}