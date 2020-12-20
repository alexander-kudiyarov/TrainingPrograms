using System;
using Core.Entities;
using Core.Entities.Exercises;
using static Core.Entities.Exercises.Enums.AccessoryType;
using static Core.Entities.Exercises.Enums.CleanAndJerkType;
using static Core.Entities.Exercises.Enums.DeadliftType;
using static Core.Entities.Exercises.Enums.SnatchType;

namespace Core.TrainingPrograms
{
    public class BodybuildingProgram : Base, ITrainingProgram
    {
        public const string Name = "Bodybuilding Program";

        public BodybuildingProgram()
        {
            Sessions = GetSessions();
        }

        string ITrainingProgram.Name => Name;

        public Lazy<Session>[] Sessions { get; }

        private static Lazy<Session>[] GetSessions()
        {
            var sessions = new[]
            {
                new Lazy<Session>(GetSession1),
                new Lazy<Session>(GetSession2),
                new Lazy<Session>(GetSession3),
                new Lazy<Session>(GetSession4),
                new Lazy<Session>(GetSession5),
                new Lazy<Session>(GetSession6),
                new Lazy<Session>(GetSession7),
                new Lazy<Session>(GetSession8),
                new Lazy<Session>(GetSession9),
                new Lazy<Session>(GetSession10),
                new Lazy<Session>(GetSession11),
                new Lazy<Session>(GetSession12),
                new Lazy<Session>(GetSession13),
                new Lazy<Session>(GetSession14),
                new Lazy<Session>(GetSession15),
                new Lazy<Session>(GetSession16)
            };

            return sessions;
        }

        private static Session GetSession1()
        {
            var ex1 = new Accessory(BackSquat)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Accessory(BenchBackSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex3 = new Accessory(BackSplitSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15+15", Sets = 2}}
            };

            var ex4 = new Accessory(CalfRise)
            {
                Repeats = new[] {new Repeat {Repeats = "20", Sets = 2}}
            };

            var ex5 = new Accessory(Press)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex6 = new CleanAndJerk(Stats.PushPress, PushPress)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex7 = new Accessory(DiscRearDeltFly)
            {
                Repeats = new[] {new Repeat {Repeats = "20", Sets = 2}}
            };

            var ex8 = new Accessory(Crunch)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 2}}
            };

            var ex9 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 2}}
            };

            var session = new Session
            {
                Day = 1,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(ex6),
                    new Set(ex7),
                    new Set(ex8),
                    new Set(ex9)
                }
            };

            return session;
        }

        private static Session GetSession2()
        {
            var ex1A = new Accessory(PushUp)
            {
                Repeats = new[] {new Repeat {Repeats = "10"}}
            };

            var ex1B = new Accessory(ReversePushUp)
            {
                Repeats = new[] {new Repeat {Repeats = "10"}}
            };

            var ex2 = new Accessory(BenchPress)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex3 = new Accessory(InclineBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex4 = new Accessory(SeatedBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "25", Sets = 2}}
            };

            var ex5 = new Accessory(FrenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex6A = new Accessory(TricepsExtension)
            {
                Repeats = new[] {new Repeat {Repeats = "20+20"}}
            };

            var ex6B = new Accessory(MilitaryPlank)
            {
                Repeats = new[] {new Repeat {Repeats = "30 sec"}}
            };

            var session = new Session
            {
                Day = 2,
                Sets = new[]
                {
                    new Set(2, false, ex1A, ex1B),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(2, true, ex6A, ex6B)
                }
            };

            return session;
        }

        private static Session GetSession3()
        {
            var ex = new Snatch(PowerSnatch, BaseSnatch)
            {
                Repeats = GetRange(0.5, 0.6, 6, "2+2")
            };

            var session = new Session
            {
                Day = 3,
                Sets = new[]
                {
                    new Set(ex)
                }
            };

            return session;
        }

        private static Session GetSession4()
        {
            var ex1 = new Deadlift(Stats.SnatchDeadlift, SnatchDeadlift)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Deadlift(Stats.RomanianDeadlift, RomanianDeadlift)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex3 = new Accessory(LateralPull)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex4 = new Accessory(BicepsCurl)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex5 = new Accessory(WristFlexion)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 2}}
            };

            var ex6 = new Accessory(DiscJuggling)
            {
                Repeats = new[] {new Repeat {Repeats = "30", Sets = 2}}
            };

            var session = new Session
            {
                Day = 4,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(ex6)
                }
            };

            return session;
        }

        private static Session GetSession5()
        {
            var ex1 = new CleanAndJerk(FrontSquat)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 3}}
            };

            var ex2 = new Accessory(BenchBackSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex3 = new Accessory(ForwardLunges)
            {
                Repeats = new[] {new Repeat {Repeats = "12+12", Sets = 3}}
            };

            var ex4 = new Accessory(AsymmetryPress)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex5 = new Snatch(SnatchPushPress)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex6A = new Accessory(LateralRaise)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex6B = new Accessory(DiscPress)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex7 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 2}}
            };

            var session = new Session
            {
                Day = 5,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(2, true, ex6A, ex6B),
                    new Set(ex7)
                }
            };

            return session;
        }

        private static Session GetSession6()
        {
            var ex1A = new Accessory(WidePushUp)
            {
                Repeats = new[] {new Repeat {Repeats = "10"}}
            };

            var ex1B = new Accessory(SeatedBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex2 = new Accessory(BenchPress)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex3 = new Accessory(AsymmetryBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex4 = new Accessory(InclineBenchPressNg)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex5 = new Accessory(FrenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20", Sets = 4}}
            };

            var ex6A = new Accessory(TricepsExtension)
            {
                Repeats = new[] {new Repeat {Repeats = "30"}}
            };

            var ex6B = new Accessory(ReversePushUp)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var session = new Session
            {
                Day = 6,
                Sets = new[]
                {
                    new Set(3, false, ex1A, ex1B),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(2, true, ex6A, ex6B)
                }
            };

            return session;
        }

        private static Session GetSession7()
        {
            var ex = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = GetRange(0.5, 0.6, 6, "2+2")
            };

            var session = new Session
            {
                Day = 7,
                Sets = new[]
                {
                    new Set(ex)
                }
            };

            return session;
        }

        private static Session GetSession8()
        {
            var ex1 = new Deadlift(BaseDeadlift)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Deadlift(AsymmetryDeadlift)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 4}}
            };

            var ex3A = new Accessory(ChinUp)
            {
                Repeats = new[] {new Repeat {Repeats = "6"}}
            };

            var ex3B = new Accessory(DiscLateralPull)
            {
                Repeats = new[] {new Repeat {Repeats = "12"}}
            };

            var ex4 = new Accessory(BicepsCurlReverseGrip)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex5 = new Accessory(WristRoll)
            {
                Repeats = new[] {new Repeat {Repeats = "1", Sets = 2}}
            };

            var ex6A = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "60 sec"}}
            };

            var ex6B = new Accessory(Crunch)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var session = new Session
            {
                Day = 8,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(4, true, ex3A, ex3B),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(2, true, ex6A, ex6B)
                }
            };

            return session;
        }

        private static Session GetSession9()
        {
            var ex1 = new Accessory(BackSquat)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex2 = new Accessory(BackLunges)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex3 = new Accessory(CalfRise)
            {
                Repeats = new[] {new Repeat {Repeats = "30", Sets = 2}}
            };

            var ex4 = new Accessory(SittingPress)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex5 = new Accessory(PressWithRubberBand)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex6 = new Accessory(Halo)
            {
                Repeats = new[] {new Repeat {Repeats = "10+10", Sets = 3}}
            };

            var session = new Session
            {
                Day = 9,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(ex6)
                }
            };

            return session;
        }

        private static Session GetSession10()
        {
            var ex1A = new Accessory(ReversePushUp)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex1B = new Accessory(SeatedBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex2 = new Accessory(BenchPress)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex3 = new Accessory(InclineBenchPressWg)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex4 = new Accessory(AsymmetryBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex5 = new Accessory(FrenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20", Sets = 3}}
            };

            var ex6A = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "30 sec"}}
            };

            var ex6B = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "30 sec"}}
            };

            var session = new Session
            {
                Day = 10,
                Sets = new[]
                {
                    new Set(3, true, ex1A, ex1B),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(3, true, ex6A, ex6B)
                }
            };

            return session;
        }

        private static Session GetSession11()
        {
            var ex1 = new Snatch(BaseSnatch, OverheadSquat)
            {
                Repeats = GetRange(0.5, 0.6, 5, "3+3")
            };

            var ex2 = new CleanAndJerk(FrontSquat, Jerk)
            {
                Repeats = GetRange(0.5, 0.6, 5, "1+4")
            };

            var session = new Session
            {
                Day = 11,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2)
                }
            };

            return session;
        }

        private static Session GetSession12()
        {
            var ex1 = new Snatch(Stats.DeficitMediumGripPull, DeficitMediumGripPull)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex2 = new Deadlift(Stats.RomanianDeadlift, RomanianDeadlift)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex3A = new Accessory(PullUp)
            {
                Repeats = new[] {new Repeat {Repeats = "8"}}
            };

            var ex3B = new Accessory(LateralPullRg)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex4A = new Accessory(BicepsCurl)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex4B = new Accessory(DiscHammerCurls)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex5 = new Accessory(Crunch)
            {
                Repeats = new[] {new Repeat {Repeats = "30", Sets = 2}}
            };

            var session = new Session
            {
                Day = 12,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(3, true, ex3A, ex3B),
                    new Set(3, true, ex4A, ex4B),
                    new Set(ex5)
                }
            };

            return session;
        }

        private static Session GetSession13()
        {
            var ex1 = new CleanAndJerk(Stats.FrontSquat, FrontSquat)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Accessory(BenchBackSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 2}}
            };

            var ex3 = new Accessory(SingleLegReach)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex4 = new Accessory(SquatReach)
            {
                Repeats = new[] {new Repeat {Repeats = "20", Sets = 2}}
            };

            var ex5 = new CleanAndJerk(Stats.PushPress, PushPress)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex6A = new Accessory(AsymmetryPress)
            {
                Repeats = new[] {new Repeat {Repeats = "12"}}
            };

            var ex6B = new Accessory(DiscPress)
            {
                Repeats = new[] {new Repeat {Repeats = "12"}}
            };

            var ex7A = new Accessory(DiscFrontRise)
            {
                Repeats = new[] {new Repeat {Repeats = "16"}}
            };

            var ex7B = new Accessory(DiscRussianTwist)
            {
                Repeats = new[] {new Repeat {Repeats = "16"}}
            };

            var session = new Session
            {
                Day = 13,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(ex4),
                    new Set(ex5),
                    new Set(4, true, ex6A, ex6B),
                    new Set(2, true, ex7A, ex7B)
                }
            };

            return session;
        }

        private static Session GetSession14()
        {
            var ex1A = new Accessory(ReversePushUp)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex1B = new Accessory(SittingPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex2 = new Accessory(InclineBenchPressWg)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex3 = new Accessory(InclineBenchPressNg)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 3}}
            };

            var ex4A = new Accessory(DeclineBenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex4B = new Accessory(DiscBridgePullover)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex5 = new Accessory(DumbbellFrenchPress)
            {
                Repeats = new[] {new Repeat {Repeats = "20", Sets = 4}}
            };

            var ex6 = new Accessory(MilitaryPlank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 3}}
            };

            var session = new Session
            {
                Day = 14,
                Sets = new[]
                {
                    new Set(2, false, ex1A, ex1B),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(2, true, ex4A, ex4B),
                    new Set(ex5),
                    new Set(ex6)
                }
            };

            return session;
        }

        private static Session GetSession15()
        {
            var ex1 = new CleanAndJerk(CleanPullTillPowerPosition, MuscleSquatClean)
            {
                Repeats = GetRange(0.5, 0.6, 5, "3+3")
            };

            var ex2 = new CleanAndJerk(Clean)
            {
                Repeats = GetRange(0.5, 0.6, 6, "3")
            };

            var session = new Session
            {
                Day = 15,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2)
                }
            };

            return session;
        }

        private static Session GetSession16()
        {
            var ex1 = new Deadlift(BaseDeadlift)
            {
                IsWarmupNeeded = true,
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex2 = new Deadlift(AsymmetryDeadlift)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 4}}
            };

            var ex3 = new Accessory(LateralPull)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 4}}
            };

            var ex4A = new Accessory(BicepsCurl)
            {
                Repeats = new[] {new Repeat {Repeats = "15"}}
            };

            var ex4B = new Accessory(WristFlexion)
            {
                Repeats = new[] {new Repeat {Repeats = "20"}}
            };

            var ex5 = new Accessory(DiscJuggling)
            {
                Repeats = new[] {new Repeat {Repeats = "40", Sets = 2}}
            };

            var session = new Session
            {
                Day = 16,
                Sets = new[]
                {
                    new Set(ex1),
                    new Set(ex2),
                    new Set(ex3),
                    new Set(3, true, ex4A, ex4B),
                    new Set(ex5)
                }
            };

            return session;
        }
    }
}