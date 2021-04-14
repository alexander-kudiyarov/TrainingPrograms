using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using static Core.Entities.Enums.ExerciseType;

namespace Core.TrainingPrograms
{
    public sealed class LegsProgram : BaseTrainingProgram
    {
        private static readonly IReadOnlyList<Func<Session>> Sessions = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4,
            GetSession5_1
        };

        public LegsProgram() : base(Sessions)
        {
        }

        public override ProgramType Type => ProgramType.LegsProgram;
        public override string Name => "Legs Program";

        private static Session GetSession1_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 3}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 8},
                    new SingleRepeat {Percent = 0.6, Repeats = 8, Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 12, Sets = 3}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new CleanAndJerk(Clean, FrontSquat, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 2}, Sets = 4}
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.4, Repeats = new[] {8, 8}, Sets = 5}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new BackSquat(BackSquatNarrowFeet)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 8, Sets = 5}
                }
            };

            var ex3 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 8, Sets = 5}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 5, Sets = 6}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession1_4()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 5}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 3},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession2_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new Snatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 3}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6},
                    new SingleRepeat {Percent = 0.6, Repeats = 6},
                    new SingleRepeat {Percent = 0.7, Repeats = 6, Sets = 5}
                }
            };

            var ex4 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 10, Sets = 3}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new CleanAndJerk(Clean, FrontSquat, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 2}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(BackSquatWithPause)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 4}
                }
            };

            var ex4 = new BackSquat(BenchBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.6, Repeats = 6},
                    new SingleRepeat {Percent = 0.7, Repeats = 6},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 6, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 6, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.65, Repeats = 8, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 4},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 5}
                }
            };

            var ex3 = new CleanAndJerk(BackLunges)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.4, Repeats = new[] {8, 8}, Sets = 5}
                }
            };

            var ex4 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 5}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession2_4()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 6}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 5}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession3_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 2, 2}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.85, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new BackSquat(BenchBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 3}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new CleanAndJerk(PowerClean, FrontSquat, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 2}, Sets = 4}
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3, Sets = 4},
                    new SingleRepeat {Percent = 0.9, Repeats = 3},
                    new SingleRepeat {Percent = 1, Repeats = 3, Sets = 4},
                    new SingleRepeat {Percent = 1, Repeats = 2},
                    new SingleRepeat {Percent = 1, Repeats = 3},
                    new SingleRepeat {Percent = 1, Repeats = 2}
                }
            };

            var ex4 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 6, Sets = 4}
                }
            };

            var ex5 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.6, Repeats = 8, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 8},
                    new SingleRepeat {Percent = 0.6, Repeats = 6},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.8, Repeats = 4},
                    new SingleRepeat {Percent = 0.9, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 6},
                    new SingleRepeat {Percent = 0.5, Repeats = 8}
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 1, Repeats = 2},
                    new SingleRepeat {Percent = 1, Repeats = 1},
                    new SingleRepeat {Percent = 1, Repeats = 2},
                    new SingleRepeat {Percent = 1, Repeats = 1}
                }
            };

            var ex4 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {6, 6}, Sets = 4}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession3_4()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 1, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 5},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 2}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession4_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new Snatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 3}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.85, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.925, Repeats = 1, Sets = 2}
                }
            };

            var ex4 = new BackSquat(BenchBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 0.95, Repeats = 2, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 6, Sets = 3}
                }
            };

            var ex6 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 5}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5),
                    new(ex6)
                }
            };

            return session;
        }

        private static Session GetSession4_2()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new CleanAndJerk(CleanPull, Clean, FrontSquat, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 2, 2}, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 1, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 1.05, Repeats = 2},
                    new SingleRepeat {Percent = 1.05, Repeats = 1},
                    new SingleRepeat {Percent = 1.05, Repeats = 2},
                    new SingleRepeat {Percent = 1.05, Repeats = 1}
                }
            };

            var ex4 = new CleanAndJerk(BackLunges)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {5, 5}, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 6, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
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
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex2 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {5, 5}, Sets = 3}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 2, Sets = 3},
                    new SingleRepeat {Percent = 0.925, Repeats = 2, Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 1, Repeats = 2}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession4_4()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1C = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession5_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex1B = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 10}
                }
            };

            var ex2 = new Snatch(ExerciseType.Snatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {3, 2, 1}, Sets = 3}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 2},
                    new SingleRepeat {Percent = 0.85, Repeats = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 2},
                    new SingleRepeat {Percent = 0.925, Repeats = 2, Sets = 3}
                }
            };

            var ex4 = new BackSquat(BackSquatWithPause)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.6, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3, Sets = 3}
                }
            };

            var ex5 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 6, Sets = 3}
                }
            };

            var ex6 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 6}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(2, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5),
                    new(ex6)
                }
            };

            return session;
        }
    }
}