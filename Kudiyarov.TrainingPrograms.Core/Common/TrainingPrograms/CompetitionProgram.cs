using System;
using System.Collections.Generic;
using Kudiyarov.TrainingPrograms.Core.Common.Entities;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Core.Common.TrainingPrograms
{
    public sealed class CompetitionProgram : BaseTrainingProgram
    {
        private static readonly IReadOnlyList<Func<Session>> Sessions = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4, GetSession5_5,
            GetSession6_1, GetSession6_2, GetSession6_3, GetSession6_4, GetSession6_5,
            GetSession7_1, GetSession7_2, GetSession7_3, GetSession7_4, GetSession7_5,
            GetSession8_1, GetSession8_2, GetSession8_3, GetSession8_4, GetSession8_5,
            GetSession9_1, GetSession9_2, GetSession9_3, GetSession9_4, GetSession9_5,
            GetSession10_1
        };

        public CompetitionProgram() : base(Sessions)
        {
        }

        public override ProgramType Type => ProgramType.Competition;
        public override string Name => "Competition Program";

        private static Session GetSession1_1()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new MultiSnatch(HangSnatchBelowKnees, HangSnatchAboveKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 4 }
                }
            };

            var ex2 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.7, Repeats = Array(1, 3), Sets = 2 },
                    new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 4 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 5, Sets = 4 }
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 3 }
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

        private static Session GetSession1_2()
        {
            var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
            {
                Repeats = GetRange(0.3, 0.35, Array(4, 4), 4)
            };

            var ex2 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 5 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 8, Sets = 4 }
                }
            };

            var ex5 = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession1_3()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new CleanAndJerk(CleanFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 3 }
                }
            };

            var ex2 = new CleanAndJerk(CleanPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 3 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 }
                }
            };

            var ex3 = new MultiCleanAndJerk(FrontSquat, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 3), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 3 }
                }
            };

            var ex4 = new Accessory(CalfRise)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 20, Sets = 2 }
                }
            };

            var ex5 = new Accessory(KneesToElbows)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
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

        private static Session GetSession1_4()
        {
            var warmup = GetCleanAndJerkWarmUp1();

            var ex1 = new MultiCleanAndJerk(PowerClean, PowerCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 5 }
                }
            };

            var ex2 = new CleanAndJerk(DeficitCleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new Snatch(SnatchPushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 8, Sets = 4 }
                }
            };

            var ex5A = new Accessory(WristFlexion)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
                }
            };

            var ex5B = new Accessory(WristExtension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession1_5()
        {
            var ex1 = new MultiSnatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 4 }
                }
            };

            var ex2 = new Snatch(MediumGripPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
                }
            };

            var ex3 = new BackSquat(BackSquatNarrowFeet)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 4 }
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
                    new StaticRepeat { Time = TimeSpan.FromSeconds(45), Sets = 4 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession2_1()
        {
            var warmup = GetSnatchWarmUp2();

            var ex1 = new Snatch(SnatchFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 5 }
                }
            };

            var ex2 = new Snatch(SnatchPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 5, Sets = 2 },
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 4 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 3 }
                }
            };

            var ex5 = new Accessory(LegRaise)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
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

        private static Session GetSession2_2()
        {
            var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.3, Repeats = Array(4, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.4, Repeats = Array(3, 2), Sets = 4 }
                }
            };

            var ex2 = new MultiCleanAndJerk(PushPress, PowerJerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex3 = new CleanAndJerk(PowerJerk)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new Snatch(SnatchPressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession2_3()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 3 }
                }
            };

            var ex2 = new MultiCleanAndJerk(CleanPull, HangCleanPullBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.7, Repeats = Array(1, 3), Sets = 1 },
                    new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 2 },
                    new MultiRepeat { Percent = 0.9, Repeats = Array(1, 3), Sets = 2 }
                }
            };

            var ex3 = new CleanAndJerk(Jerk)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new Accessory(Press)
            {
                Repeats = new Repeat[]
                {
                    // TODO ??
                    new SingleRepeat { Percent = 0.625, Repeats = 8, Sets = 4 }
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

        private static Session GetSession2_4()
        {
            var warmup = GetCleanAndJerkWarmUp2();

            var ex1 = new MultiCleanAndJerk(CleanPull, Clean)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 5 }
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 }
                }
            };

            var ex3 = new CleanAndJerk(JerkSupport)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat { Percent = 1, Time = TimeSpan.FromSeconds(6), Sets = 6 }
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 6, Sets = 4 }
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

        private static Session GetSession2_5()
        {
            var ex1 = new MultiSnatch(PowerSnatch, PowerSnatchAboveKnee, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2, 1), Sets = 5 }
                }
            };

            var ex2 = new Snatch(DeficitSnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
                }
            };

            var ex3 = new BackSquat(BackSquatWithPause)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
                }
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

        private static Session GetSession3_1()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new MultiSnatch(SnatchPushPress, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex2 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 3 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 1 },
                    new MultiRepeat { Percent = 0.9, Repeats = Array(1, 3), Sets = 3 }
                }
            };

            var ex4 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
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

        private static Session GetSession3_2()
        {
            var ex1 = new MultiSnatch(MuscleSquatSnatch, SnatchBalance)
            {
                Repeats = GetRange(0.35, 0.45, Array(4, 4), 4)
            };

            var ex2 = new MultiCleanAndJerk(PowerClean, PowerCleanBelowKnee, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1, 1), Sets = 5 }
                }
            };

            var ex3 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(6, 6), Sets = 3 }
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession3_3()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new MultiCleanAndJerk(FrontSquat, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 1), Sets = 1 }
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.70, Repeats = 3 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3 },
                    new SingleRepeat { Percent = 0.90, Repeats = 3 },
                    new SingleRepeat { Percent = 0.95, Repeats = 3 },
                    new SingleRepeat { Percent = 1.00, Repeats = 3 }
                }
            };

            var ex3 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 4 }
                }
            };

            var ex4 = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 20, Sets = 3 }
                }
            };

            var ex5A = new Accessory(WristFlexion)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
                }
            };

            var ex5B = new Accessory(WristExtension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession3_4()
        {
            var warmup = GetCleanAndJerkWarmUp2();

            var ex1 = new MultiCleanAndJerk(CleanFromBlocks, FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(CleanPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 4 }
                }
            };

            var ex5 = new Accessory(ToesToBar)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 3 }
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

        private static Session GetSession3_5()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
                }
            };

            var ex2 = new MultiSnatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 5 }
                }
            };

            var ex3 = new Snatch(DeficitSnatchPullWith2Stops)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 4 }
                }
            };

            var ex4 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 5 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession4_1()
        {
            var warmup = GetSnatchWarmUp3();

            var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchAboveKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 3 }
                }
            };

            var ex2 = new Snatch(SnatchPullWith2Stops)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 1, Sets = 1 }
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 4 }
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

        private static Session GetSession4_2()
        {
            var ex1 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = GetRange(0.35, 0.45, 4, 4)
            };

            var ex2 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 4 }
                }
            };

            var ex3 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 4 }
                }
            };

            var ex4 = new Accessory(CalfRise)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 20, Sets = 2 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession4_3()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new CleanAndJerk(Jerk)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 5 }
                }
            };

            var ex3 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 4 }
                }
            };

            var ex4 = new Accessory(LegRaise)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 4 }
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

        private static Session GetSession4_4()
        {
            var warmup = GetSnatchWarmUp2();

            var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 4 }
                }
            };

            var ex2 = new Snatch(MediumGripPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 4 }
                }
            };

            var ex3 = new Snatch(SnatchPressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
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

        private static Session GetSession4_5()
        {
            var warmup = GetCleanAndJerkWarmUp1();

            var ex1 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(2, 1), Sets = 2 }
                }
            };

            var ex2 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 10, Sets = 4 }
                }
            };

            var ex4 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat { Time = TimeSpan.FromSeconds(45), Sets = 4 }
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

        private static Session GetSession5_1()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new Snatch(SnatchPushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
                }
            };

            var ex2 = new Snatch(SnatchFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 3 },
                    new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new Snatch(SnatchPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 4 }
                }
            };

            var ex4 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 1 },
                    new SingleRepeat { Percent = 0.60, Repeats = 6, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 6, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 6, Sets = 2 }
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

        private static Session GetSession5_2()
        {
            var ex1 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
                }
            };

            var ex2 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 4 }
                }
            };

            var ex3 = new MultiCleanAndJerk(CleanPull, HangCleanPullBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.9, Repeats = Array(1, 3), Sets = 2 },
                    new MultiRepeat { Percent = 1.0, Repeats = Array(1, 2), Sets = 3 }
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
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession5_3()
        {
            var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
            {
                Repeats = GetRange(0.4, 0.5, Array(3, 2), 4)
            };

            var ex2 = new Snatch(MediumGripPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(Jerk)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.800, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 }
                }
            };

            var ex4 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(6, 6), Sets = 3 }
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat { Time = TimeSpan.FromSeconds(60) }
                }
            };

            var ex5B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(4, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession5_4()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 1), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(2, 1), Sets = 1 }
                }
            };

            var ex2 = new CleanAndJerk(CleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 3 },
                    new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 1.10, Repeats = 2, Sets = 1 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 2 }
                }
            };

            var ex4 = new Accessory(PressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.725, Repeats = 8, Sets = 3 }
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

        private static Session GetSession5_5()
        {
            var ex1 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 5 }
                }
            };

            var ex2 = new MultiCleanAndJerk(FrontSquat, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 4 }
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
                }
            };

            var ex4 = new Accessory(KneesToElbows)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 4 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession6_1()
        {
            var warmup = GetSnatchWarmUp2();

            var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 3 }
                }
            };

            var ex2 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.8, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.9, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 1.0, Repeats = Array(1, 2), Sets = 3 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 4 }
                }
            };

            var ex4 = new Accessory(Press)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.725, Repeats = 6, Sets = 4 }
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

        private static Session GetSession6_2()
        {
            var warmup = GetCleanAndJerkWarmUp2();

            var ex1 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 }
                }
            };

            var ex2 = new MultiSnatch(SotsPress, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4), Sets = 5 }
                }
            };

            var ex3A = new Accessory(WristFlexion)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
                }
            };

            var ex3B = new Accessory(WristExtension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
                }
            };

            var ex4 = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 20, Sets = 3 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(warmup),
                    new(ex1),
                    new(ex2),
                    new(3, ex3A, ex3B),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession6_3()
        {
            var warmup = GetSnatchWarmUp3();

            var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 3 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 3 }
                }
            };

            var ex2 = new Snatch(SnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
                }
            };

            var ex3 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.5, Repeats = Array(6, 6), Sets = 3 }
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
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

        private static Session GetSession6_4()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 3 }
                }
            };

            var ex2 = new CleanAndJerk(DeficitCleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.70, Repeats = 4 },
                    new SingleRepeat { Percent = 0.80, Repeats = 4 },
                    new SingleRepeat { Percent = 0.90, Repeats = 4 },
                    new SingleRepeat { Percent = 1.00, Repeats = 4 },
                    new SingleRepeat { Percent = 1.05, Repeats = 4 }
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 6, Sets = 4 }
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

        private static Session GetSession6_5()
        {
            var ex1 = new Snatch(HipSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 4 }
                }
            };

            var ex2 = new MultiSnatch(SnatchPushPress, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2, 2), Sets = 3 }
                }
            };

            var ex3 = new Snatch(SnatchPushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 },
                    new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.95, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 1 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 8, Sets = 4 }
                }
            };

            var ex5 = new Accessory(CalfRise)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 20, Sets = 2 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession7_1()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new Snatch(SnatchFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 2 }
                }
            };

            var ex2 = new Snatch(SnatchPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.80, Repeats = 4, Sets = 1 },
                    new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.05, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 1.10, Repeats = 3, Sets = 2 }
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 8, Sets = 4 }
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

        private static Session GetSession7_2()
        {
            var ex1 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 4 }
                }
            };

            var ex2 = new CleanAndJerk(Clean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 3 }
                }
            };

            var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 4 }
                }
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

        private static Session GetSession7_3()
        {
            var warmup = GetSnatchWarmUp2();

            var ex1 = new Snatch(DeficitSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 3 }
                }
            };

            var ex2 = new CleanAndJerk(Jerk)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 1 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 6 },
                    new SingleRepeat { Percent = 0.6, Repeats = 5 },
                    new SingleRepeat { Percent = 0.7, Repeats = 4 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3 },
                    new SingleRepeat { Percent = 0.9, Repeats = 2 }
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
                }
            };

            var ex5A = new Accessory(WristFlexion)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
                }
            };

            var ex5B = new Accessory(WristExtension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
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
                    new(3, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession7_4()
        {
            var warmup = GetCleanAndJerkWarmUp1();

            var ex1 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.85, Repeats = Array(2, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.85, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(CleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 1.00, Repeats = 4, Sets = 2 },
                    new SingleRepeat { Percent = 1.05, Repeats = 3, Sets = 2 }
                }
            };

            var ex3 = new Accessory(PressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.725, Repeats = 8, Sets = 3 }
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 6, Sets = 3 }
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

        private static Session GetSession7_5()
        {
            var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 3 }
                }
            };

            var ex2 = new MultiSnatch(SnatchPushPress, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.60, Repeats = Array(3, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(3, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 0.95, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 1.00, Repeats = Array(1, 1), Sets = 1 },
                    new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 1 }
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
                }
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

        private static Session GetSession9_1()
        {
            var warmup = GetSnatchWarmUp2();

            var ex1Repeats = new List<Repeat>
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
            };

            ex1Repeats.AddRange(
                GetRange(0.85, 0.875, Array(1, 1), 4));

            var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
            {
                Repeats = ex1Repeats
            };

            var ex2 = new MultiSnatch(SnatchPull, HangSnatchBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.90, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                    new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 2 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 6, Sets = 3 }
                }
            };

            var ex5 = new Accessory(KneesToElbows)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 4 }
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

        private static Session GetSession9_2()
        {
            var warmup = GetCleanAndJerkWarmUp1();

            var ex1 = new CleanAndJerk(Clean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 }
                }
            };

            var ex2 = new CleanAndJerk(CleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 3 },
                    new SingleRepeat { Percent = 1.1, Repeats = 1, Sets = 1 }
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

        private static Session GetSession9_3()
        {
            var warmup = GetSnatchWarmUp3();

            var ex1 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(Jerk)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 1 }
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
                }
            };

            var ex4 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 4 }
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

        private static Session GetSession9_4()
        {
            var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                    new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                    new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 4 }
                }
            };

            var ex2Repeats = new List<Repeat>
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 2 }
            };

            ex2Repeats.AddRange(
                GetRange(0.9, 0.925, Array(1, 1), 4));

            var ex2 = new MultiCleanAndJerk(Clean, Jerk)
            {
                Repeats = ex2Repeats
            };

            var ex3 = new CleanAndJerk(CleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.800, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.900, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.925, Repeats = 3, Sets = 1 }
                }
            };

            var ex5 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Weight = Stats.Bar, Repeats = 5, Sets = 3 }
                }
            };

            var ex6A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat { Time = TimeSpan.FromSeconds(60) }
                }
            };

            var ex6B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15 }
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5),
                    new(4, ex6A, ex6B)
                }
            };

            return session;
        }

        private static Session GetSession9_5()
        {
            var ex1 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 5 }
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.9, Repeats = 1, Sets = 1 }
                }
            };

            var ex3 = new CleanAndJerk(JerkSupport)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat { Percent = 1.1, Time = TimeSpan.FromSeconds(6), Sets = 2 }
                }
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

        private static Session GetSession10_1()
        {
            var warmup = GetSnatchWarmUp2();

            var ex1 = new Snatch(SnatchFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.500, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.600, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.650, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.925, Repeats = 2, Sets = 1 },
                    new SingleRepeat { Percent = 0.950, Repeats = 1, Sets = 1 },
                    new SingleRepeat { Percent = 0.975, Repeats = 1, Sets = 1 },
                    new SingleRepeat { Percent = 1.000, Repeats = 1, Sets = 1 }
                }
            };

            var ex2 = new Snatch(SnatchPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                    new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                    new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                    new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 3 }
                }
            };

            var ex4 = new Accessory(PressInSitPosition)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.75, Repeats = 6, Sets = 3 }
                }
            };

            var ex5 = new Accessory(KneesToElbows)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 12, Sets = 3 }
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

        private static BaseExercise[] GetSnatchWarmUp1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 2 }
                }
            };

            var ex2 = new MultiSnatch(SnatchPushPress, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4, 4), Sets = 3 }
                }
            };

            var result = new BaseExercise[] { ex1, ex2 };
            return result;
        }

        private static BaseExercise[] GetSnatchWarmUp2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 2 }
                }
            };

            var ex2 = new Snatch(SnatchPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 4 }
                }
            };

            var result = new BaseExercise[] { ex1, ex2 };
            return result;
        }

        private static BaseExercise[] GetSnatchWarmUp3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 2 }
                }
            };

            var ex2 = new Snatch(SnatchOnPlates)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 4 }
                }
            };

            var result = new BaseExercise[] { ex1, ex2 };
            return result;
        }

        private static BaseExercise[] GetCleanAndJerkWarmUp1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 3 }
                }
            };

            var result = new BaseExercise[] { ex1, ex2 };
            return result;
        }

        private static BaseExercise[] GetCleanAndJerkWarmUp2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 2 }
                }
            };

            var ex2 = new CleanAndJerk(CleanOnPlates)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 4 }
                }
            };

            var result = new BaseExercise[] { ex1, ex2 };
            return result;
        }

        private static BaseExercise[] GetCleanAndJerkWarmUp3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat { Repeats = 15, Sets = 2 }
                }
            };

            var ex2 = new MultiCleanAndJerk(MuscleClean, FrontSquat, Press)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4, 4), Sets = 3 }
                }
            };

            var result = new BaseExercise[] { ex1, ex2 };
            return result;
        }
    }
}