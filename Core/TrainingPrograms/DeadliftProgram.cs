using System;
using Core.Entities;
using Core.Entities.Exercises;
using static Core.Entities.Enums.Exercises.AccessoryType;
using static Core.Entities.Enums.Exercises.CleanAndJerkType;
using static Core.Entities.Enums.Exercises.DeadliftType;
using static Core.Entities.Enums.Exercises.SnatchType;

namespace Core.TrainingPrograms
{
    public class DeadliftProgram : ITrainingProgram
    {
        public const string Name = "Deadlift Program";

        public DeadliftProgram()
        {
            Sessions = GetSessions();
        }

        string ITrainingProgram.Name => Name;

        public Lazy<Session>[] Sessions { get; }

        private static Lazy<Session>[] GetSessions()
        {
            var sessions = new Lazy<Session>[]
            {
                new(GetSession1),
                new(GetSession2),
                new(GetSession3),
                new(GetSession4),
                new(GetSession5)
            };

            return sessions;
        }

        private static Session GetSession1()
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
                Day = 1,
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

        private static Session GetSession2()
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
                Day = 2,
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

        private static Session GetSession3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new[] {new Repeat {Repeats = "10", Sets = 4}}
            };

            var ex2 = new CleanAndJerk(DeficitClean)
            {
                Repeats = new[] {new Repeat {Percent = 0.5, Repeats = "3", Sets = 4}}
            };

            var ex3 = new Deadlift(BaseDeadlift)
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
                Day = 3,
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

        private static Session GetSession4()
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
                Day = 4,
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

        private static Session GetSession5()
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

            var ex5 = new Accessory(BackSquat)
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
                Day = 5,
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
    }
}