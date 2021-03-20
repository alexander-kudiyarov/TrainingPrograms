using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using static Core.Entities.Enums.ExerciseType;

namespace Core.TrainingPrograms
{
    public sealed class DeadliftProgram : BaseTrainingProgram
    {
        public DeadliftProgram() : base(GetSessions())
        {
        }

        public override ProgramType Type => ProgramType.DeadliftProgram;
        public override string Name => "Deadlift Program";

        private static IReadOnlyList<Func<Session>> GetSessions()
        {
            var result = new Func<Session>[]
            {
                GetSession1_1, GetSession1_2, GetSession1_3,
                GetSession2_1, GetSession2_2, GetSession2_3,
                GetSession3_1, GetSession3_2, GetSession3_3,
                GetSession4_1, GetSession4_2, GetSession4_3,
                GetSession5_1, GetSession5_2, GetSession5_3,
                GetSession6_1, GetSession6_2, GetSession6_3,
                GetSession7_1, GetSession7_2, GetSession7_3,
                GetSession8_1, GetSession8_2, GetSession8_3,
                GetSession9_1, GetSession9_2, GetSession9_3,
                GetSession10_1, GetSession10_2, GetSession10_3,
                GetSession11_1, GetSession11_2, GetSession11_3,
                GetSession12_1, GetSession12_2
            };

            return result;
        }

        private static Session GetSession1_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Snatch(PowerSnatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 1}, Sets = 4}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 4}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(45), Sets = 3}
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

        private static Session GetSession1_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 3},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 1}, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 4}
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
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 4}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5, Sets = 5}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 3}, Sets = 4}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(45), Sets = 3}
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
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new CleanAndJerk(PowerClean, PowerCleanBelowKnee, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 2, 3}, Sets = 4}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.825, Repeats = 4, Sets = 4}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(45), Sets = 3}
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

        private static Session GetSession2_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 3}, Sets = 3}
                }
            };

            var ex5 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 4}
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

        private static Session GetSession2_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Snatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 4}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.775, Repeats = 5, Sets = 4}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 6, Sets = 4}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(45), Sets = 3}
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

        private static Session GetSession3_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = GetRange(0.4, 0.5, 4, 4)
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.85, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(60), Sets = 3}
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

        private static Session GetSession3_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2, Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 1}, Sets = 3},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.8, Repeats = 5},
                    new SingleRepeat {Percent = 0.8, Repeats = 5, Sets = 5}
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

        private static Session GetSession3_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = GetRange(0.4, 0.5, 3, 6)
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.825, Repeats = 4, Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 5}, Sets = 4}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(60), Sets = 3}
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

        private static Session GetSession4_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new CleanAndJerk(Clean, HangCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 1}, Sets = 3}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.825, Repeats = 3, Sets = 4}
                }
            };

            var ex4 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(60), Sets = 3}
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

        private static Session GetSession4_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 3, Sets = 5}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 2}, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 3}
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

        private static Session GetSession4_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Snatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 1}, Sets = 4}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.825, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 8, Sets = 3}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(60), Sets = 3}
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

        private static Session GetSession5_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Snatch(PowerSnatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 2}, Sets = 4}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 0.925, Repeats = 2},
                    new SingleRepeat {Percent = 0.95, Repeats = 2}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90), Sets = 3}
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

        private static Session GetSession5_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12, Sets = 4}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 1, Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}},
                    new MultiRepeat {Percent = 0.8, Repeats = new[] {1, 1}}
                }
            };

            var ex5 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.65, Repeats = 3},
                    new SingleRepeat {Percent = 0.75, Repeats = 3},
                    new SingleRepeat {Percent = 0.85, Repeats = 3, Sets = 4}
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

        private static Session GetSession5_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 4}
                }
            };

            var ex2 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 2}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.85, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(PushPress, PowerJerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 3}, Sets = 3}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90), Sets = 3}
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

        private static Session GetSession6_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(Clean, HangCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 2}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.85, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90), Sets = 3}
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

        private static Session GetSession6_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12, Sets = 3}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat
                    {
                        Percent = 0.4, Repeats = 3, Sets = 5
                    }
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.4, Repeats = new[] {3, 3}, Sets = 5}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 3}
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

        private static Session GetSession6_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Snatch(DeficitPowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 2}
                }
            };

            var ex3 = new Deadlift(DeficitDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 3}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 8, Sets = 4}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90), Sets = 3}
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
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Snatch(PowerSnatch, HipSnatch)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 3}, Sets = 4}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 0.95, Repeats = 1, Sets = 2}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
                }
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession7_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 2, Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 3}, Sets = 3}
                }
            };

            var ex5 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3, Sets = 3}
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

        private static Session GetSession7_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(CleanFromBlocks, FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 1}, Sets = 3}
                }
            };

            var ex3 = new Deadlift(DeadliftFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4, Sets = 3}
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
                }
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession8_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(PowerClean, PowerCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 2}, Sets = 2}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.75, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.85, Repeats = 3, Sets = 3},
                    new SingleRepeat {Percent = 0.95, Repeats = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
                }
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession8_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10, Sets = 3}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 1, Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 5}
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

        private static Session GetSession8_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Snatch(SnatchFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 3}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3},
                    new SingleRepeat {Percent = 0.95, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 6, Sets = 4}
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
                }
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession9_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 4, Sets = 3}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 3}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
                }
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession9_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex3 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.8, Repeats = new[] {1, 1}}
                }
            };

            var ex5 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 4}
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

        private static Session GetSession9_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(CleanFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 3}
                }
            };

            var ex3 = new Deadlift(DeadliftFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3},
                    new SingleRepeat {Percent = 1, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(PushPress, PowerJerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 3}
                }
            };

            var ex5A = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
                }
            };

            var ex5B = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90)}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession10_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(PowerClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 1, Sets = 2}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.75, Repeats = 3},
                    new SingleRepeat {Percent = 0.825, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90), Sets = 2}
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

        private static Session GetSession10_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 3, Sets = 4}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.4, Repeats = new[] {3, 3}, Sets = 3}
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

        private static Session GetSession10_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 3}
                }
            };

            var ex2 = new Snatch(PowerSnatch, ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 3}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 0.95, Repeats = 2}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(90), Sets = 2}
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

        private static Session GetSession11_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20, Sets = 2}
                }
            };

            var ex2 = new Snatch(PowerSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 2}
                }
            };

            var ex3 = new Deadlift(ExerciseType.Deadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.75, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(60), Sets = 2}
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

        private static Session GetSession11_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20, Sets = 2}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 3, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.4, Repeats = new[] {2, 2}, Sets = 3}
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

        private static Session GetSession11_3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20, Sets = 2}
                }
            };

            var ex2 = new CleanAndJerk(Clean, FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 1}, Sets = 2}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.75, Repeats = 2, Sets = 3}
                }
            };

            var ex4 = new Accessory(ReversePlank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(60), Sets = 2}
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

        private static Session GetSession12_1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex2 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 4, Sets = 5}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }

        private static Session GetSession12_2()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex2 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }
    }
}