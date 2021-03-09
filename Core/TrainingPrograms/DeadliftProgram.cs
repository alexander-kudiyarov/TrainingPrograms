using System;
using System.Collections.Generic;
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
    public sealed class DeadliftProgram : BaseTrainingProgram
    {
        public DeadliftProgram() : base(GetSessions())
        {
        }

        public override ProgramType Type => ProgramType.DeadliftProgram;
        public override string Name => "Deadlift Program";

        private static IDictionary<int, Func<Session>> GetSessions()
        {
            var key = 0;

            var result = new Dictionary<int, Func<Session>>
            {
                [++key] = GetSession1_1, [++key] = GetSession1_3, [++key] = GetSession1_5,
                [++key] = GetSession2_1, [++key] = GetSession2_3, [++key] = GetSession2_5,
                [++key] = GetSession3_1, [++key] = GetSession3_3, [++key] = GetSession3_5,
                [++key] = GetSession4_1, [++key] = GetSession4_3, [++key] = GetSession4_5,
                [++key] = GetSession5_1, [++key] = GetSession5_3, [++key] = GetSession5_5,
                [++key] = GetSession6_1, [++key] = GetSession6_3, [++key] = GetSession6_5,
                [++key] = GetSession7_1, [++key] = GetSession7_3, [++key] = GetSession7_5,
                [++key] = GetSession8_1, [++key] = GetSession8_3, [++key] = GetSession8_5,
                [++key] = GetSession9_1, [++key] = GetSession9_3, [++key] = GetSession9_5,
                [++key] = GetSession10_1, [++key] = GetSession10_3, [++key] = GetSession10_5,
                [++key] = GetSession11_1, [++key] = GetSession11_3, [++key] = GetSession11_5,
                [++key] = GetSession12_1, [++key] = GetSession12_3
            };

            return result;
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

        private static Session GetSession1_3()
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

        private static Session GetSession1_5()
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

        private static Session GetSession2_3()
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

        private static Session GetSession2_5()
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

        private static Session GetSession3_3()
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

        private static Session GetSession3_5()
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

        private static Session GetSession4_3()
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

        private static Session GetSession4_5()
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

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.9, Repeats = "2"},
                    new() {Percent = 0.925, Repeats = "2"},
                    new() {Percent = 0.95, Repeats = "2"}
                }
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

        private static Session GetSession5_3()
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

        private static Session GetSession5_5()
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

        private static Session GetSession6_3()
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

        private static Session GetSession6_5()
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

        private static Session GetSession7_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 2}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "3", Sets = 3},
                    new() {Percent = 0.7, Repeats = "2", Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+3", Sets = 3}
                }
            };

            var ex5 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3", Sets = 3}
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

        private static Session GetSession7_5()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new CleanAndJerk(CleanFromBlocks, FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3+1", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2+1", Sets = 3}
                }
            };

            var ex3 = new Deadlift(DeadliftFromBlocks)
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

            var ex4 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "6", Sets = 2},
                    new() {Percent = 0.6, Repeats = "4", Sets = 3}
                }
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

        private static Session GetSession8_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new CleanAndJerk(PowerClean, PowerCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "1+3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+2", Sets = 2}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "4"},
                    new() {Percent = 0.6, Repeats = "4"},
                    new() {Percent = 0.7, Repeats = "4"},
                    new() {Percent = 0.75, Repeats = "3", Sets = 2},
                    new() {Percent = 0.85, Repeats = "3", Sets = 3},
                    new() {Percent = 0.95, Repeats = "3"}
                }
            };

            var ex4 = new Accessory(DeathJump)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 4}}
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

        private static Session GetSession8_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 3}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2", Sets = 2},
                    new() {Percent = 0.7, Repeats = "2", Sets = 2},
                    new() {Percent = 0.8, Repeats = "1", Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 3}
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
                    new() {Percent = 0.9, Repeats = "3", Sets = 5}
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

        private static Session GetSession8_5()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Snatch(SnatchFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "4", Sets = 2},
                    new() {Percent = 0.6, Repeats = "3", Sets = 3}
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
                    new() {Percent = 0.9, Repeats = "3"},
                    new() {Percent = 0.95, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new[]
                {
                    new Repeat {Percent = 0.4, Repeats = "6", Sets = 4}
                }
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

        private static Session GetSession9_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "4", Sets = 3}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "4"},
                    new() {Percent = 0.7, Repeats = "4"},
                    new() {Percent = 0.8, Repeats = "2", Sets = 2},
                    new() {Percent = 0.9, Repeats = "2", Sets = 3}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "8", Sets = 4}
                }
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

        private static Session GetSession9_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new[] {new Repeat {Repeats = "15", Sets = 2}}
            };

            var ex3 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+1", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1+1", Sets = 2},
                    new() {Percent = 0.8, Repeats = "1+1"}
                }
            };

            var ex5 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.9, Repeats = "2", Sets = 4}
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

        private static Session GetSession9_5()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new CleanAndJerk(CleanFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2", Sets = 3}
                }
            };

            var ex3 = new Deadlift(DeadliftFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.8, Repeats = "3"},
                    new() {Percent = 0.9, Repeats = "3"},
                    new() {Percent = 1, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(PushPress, PowerJerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2+2", Sets = 3}
                }
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

        private static Session GetSession10_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "8", Sets = 3}}
            };

            var ex2 = new CleanAndJerk(PowerClean)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1", Sets = 2}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "4"},
                    new() {Percent = 0.7, Repeats = "4"},
                    new() {Percent = 0.75, Repeats = "3"},
                    new() {Percent = 0.825, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "8", Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new[] {new Repeat {Repeats = "90 sec", Sets = 2}}
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

        private static Session GetSession10_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "8", Sets = 3}
                }
            };

            var ex2 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "3", Sets = 4}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "3+3", Sets = 3}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession10_5()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "8", Sets = 3}
                }
            };

            var ex2 = new Snatch(PowerSnatch, BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+2", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+2", Sets = 2},
                    new() {Percent = 0.7, Repeats = "1+1", Sets = 3}
                }
            };

            var ex3 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2"},
                    new() {Percent = 0.6, Repeats = "2"},
                    new() {Percent = 0.7, Repeats = "2"},
                    new() {Percent = 0.8, Repeats = "2"},
                    new() {Percent = 0.9, Repeats = "2"},
                    new() {Percent = 0.95, Repeats = "2"}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "8", Sets = 4}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "90 sec", Sets = 2}
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

        private static Session GetSession11_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "20", Sets = 2}
                }
            };

            var ex2 = new Snatch(PowerSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3", Sets = 2},
                    new() {Percent = 0.6, Repeats = "2", Sets = 2}
                }
            };

            var ex3 = new Deadlift(BaseDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.75, Repeats = "3", Sets = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "8", Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "60 sec", Sets = 2}
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

        private static Session GetSession11_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "20", Sets = 2}
                }
            };

            var ex2 = new Snatch(BaseSnatch)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "3", Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.4, Repeats = "2+2", Sets = 3}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession11_5()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "20", Sets = 2}
                }
            };

            var ex2 = new CleanAndJerk(Clean, FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "2+1", Sets = 2},
                    new() {Percent = 0.6, Repeats = "1+1", Sets = 2}
                }
            };

            var ex3 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3"},
                    new() {Percent = 0.7, Repeats = "3"},
                    new() {Percent = 0.75, Repeats = "2", Sets = 3}
                }
            };

            var ex4 = new Accessory(ReversePlank)
            {
                Repeats = new[]
                {
                    new Repeat {Repeats = "60 sec", Sets = 2}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession12_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "15", Sets = 2}
                }
            };

            var ex2 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.3, Repeats = "4", Sets = 5}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }

        private static Session GetSession12_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "15", Sets = 2}
                }
            };

            var ex2 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3"},
                    new() {Percent = 0.6, Repeats = "3", Sets = 3}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }
    }
}