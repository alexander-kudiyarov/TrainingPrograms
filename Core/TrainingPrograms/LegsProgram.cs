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
        public LegsProgram() : base(GetSessions())
        {
        }

        public override ProgramType Type => ProgramType.LegsProgram;
        public override string Name => "Legs Program";

        private static IReadOnlyDictionary<int, Func<Session>> GetSessions()
        {
            var key = 0;

            var result = new Dictionary<int, Func<Session>>
            {
                [++key] = GetSession1_1, [++key] = GetSession1_2, [++key] = GetSession1_3
            };

            return result;
        }

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
    }
}