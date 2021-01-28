using System;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using static Core.Entities.Enums.Exercises.AccessoryType;
using static Core.Entities.Enums.Exercises.CleanAndJerkType;
using static Core.Entities.Enums.Exercises.BackSquatType;
using static Core.Entities.Enums.Exercises.DeadliftType;
using static Core.Entities.Enums.Exercises.SnatchType;

namespace Core.TrainingPrograms
{
    public sealed class DeadliftProgram : TrainingProgramBase
    {
        public DeadliftProgram() : base(GetSessions())
        {
        }

        public override ProgramType Type => ProgramType.DeadliftProgram;
        public override string Name => "Deadlift Program";

        private static Lazy<Session>[] GetSessions()
        {
            var sessions = new Lazy<Session>[]
            {
                new(GetSession1_1), new(GetSession1_2), new(GetSession1_3),
                new(GetSession2_1), new(GetSession2_2), new(GetSession2_3),
                new(GetSession3_1), new(GetSession3_2), new(GetSession3_3),
                new(GetSession4_1), new(GetSession4_2), new(GetSession4_3),
                new(GetSession5_1), new(GetSession5_2), new(GetSession5_3),
                new(GetSession6_1), new(GetSession6_2), new(GetSession6_3),
                new(GetSession7_1)
            };

            return sessions;
        }

        private static Session GetSession1_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Snatch(PowerSnatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "2+2+1", Sets = 4}}
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5"},
                    new() {Percent = 0.8, Repeats = "4", Sets = 4}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession1_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 3},
                    new() {Percent = 0.6, Repeats = "2", Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 3},
                    new() {Percent = 0.6, Repeats = "1+1", Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "4"},
                    new() {Percent = 0.6, Repeats = "4"},
                    new() {Percent = 0.7, Repeats = "4"},
                    new() {Percent = 0.8, Repeats = "4", Sets = 4}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
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
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "3", Sets = 4}}
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5", Sets = 5}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat, PushPress)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "1+3", Sets = 4}}
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new CleanAndJerk(PowerClean, PowerCleanBelowKnee, PushPress)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "1+2+3", Sets = 4}}
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5"},
                    new() {Percent = 0.825, Repeats = "4", Sets = 4}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession2_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 3},
                    new() {Percent = 0.6, Repeats = "3"}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "1+3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+3", Sets = 3}
                }
            };

            var ex5 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5"},
                    new() {Percent = 0.8, Repeats = "4", Sets = 4}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession2_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Snatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "2+2", Sets = 4}}
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.775, Repeats = "5", Sets = 4}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new[] {new Repeat {Percent = 0.3, Repeats = "6", Sets = 4}}
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "45 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession3_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = GetRange(0.4, 0.5, 4, "4")
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5"},
                    new() {Percent = 0.8, Repeats = "4", Sets = 2},
                    new() {Percent = 0.85, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "60 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession3_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "3", Sets = 2},
                    new() {Percent = 0.7, Repeats = "2", Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+1", Sets = 3},
                    new() {Percent = 0.7, Repeats = "1+1"}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5"},
                    new() {Percent = 0.8, Repeats = "5"},
                    new() {Percent = 0.8, Repeats = "5", Sets = 5}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession3_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = GetRange(0.4, 0.5, 3, "6")
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "5"},
                    new() {Percent = 0.6, Repeats = "5"},
                    new() {Percent = 0.7, Repeats = "5"},
                    new() {Percent = 0.825, Repeats = "4", Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat, PushPress)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "1+5", Sets = 4}}
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "60 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession4_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new CleanAndJerk(Clean, HangCleanBelowKnee)
            {
                Repeats = new[]
                {
                    new Repeat {Percent = 0.5, Repeats = "1+3", Sets = 2},
                    new Repeat {Percent = 0.6, Repeats = "1+1", Sets = 3}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "4"},
                    new() {Percent = 0.6, Repeats = "4"},
                    new() {Percent = 0.7, Repeats = "4"},
                    new() {Percent = 0.825, Repeats = "3", Sets = 4}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 4}}
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "60 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession4_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "3", Sets = 5}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+2", Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.9, Repeats = "3", Sets = 3}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession4_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Snatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "3+1", Sets = 4}}
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.825, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new[] {new Repeat {Percent = 0.3, Repeats = "8", Sets = 3}}
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "60 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession5_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Snatch(PowerSnatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "2+2+2", Sets = 4}}
            };

            var ex3X = new Repeat[]
            {
                new() {Percent = 0.5, Repeats = "3"},
                new() {Percent = 0.6, Repeats = "3"},
                new() {Percent = 0.7, Repeats = "3"},
                new() {Percent = 0.8, Repeats = "3"}
            };

            var ex3Y = GetRange(0.9, 0.95, 3, "2");

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = Concat(ex3X, ex3Y)
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession5_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 4}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1", Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+1", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1+1"},
                    new() {Percent = 0.8, Repeats = "1+1"}
                }
            };

            var ex5 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.65, Repeats = "3"},
                    new() {Percent = 0.75, Repeats = "3"},
                    new() {Percent = 0.85, Repeats = "3", Sets = 4}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession5_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2", Sets = 2}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.85, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(PushPress, PowerJerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+3", Sets = 3}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession6_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new CleanAndJerk(Clean, HangCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "1+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+2", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1+1", Sets = 2}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.85, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new Accessory(DeathJump)
            {
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession6_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "12", Sets = 3}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "3", Sets = 5}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "3+3", Sets = 5}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3", Sets = 2},
                    new() {Percent = 0.9, Repeats = "2", Sets = 3}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
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

        private static Session GetSession6_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Snatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+1", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2+1", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1+1", Sets = 2}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.9, Repeats = "2", Sets = 3}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new[] {new Repeat {Percent = 0.3, Repeats = "8", Sets = 4}}
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec", Sets = 3}}
            };

            var session = new Session
            {
                Sets = new Set[]
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
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Snatch(PowerSnatch, HipSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "1+3", Sets = 4}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "2"},
                    new() {Percent = 0.9, Repeats = "2"},
                    new() {Percent = 0.95, Repeats = "1", Sets = 2}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new[] {new Repeat {Repeats = "6", Sets = 4}}
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec"}}
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec"}}
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(2, false, ex5A, ex5B)
                }
            };

            return session;
        }
    }
}