using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using static Core.Entities.Enums.ExerciseType;

namespace Core.TrainingPrograms
{
    public sealed class PullAndSquatProgram : BaseTrainingProgram
    {
        private static readonly IReadOnlyList<Func<Session>> Sessions = new Func<Session>[]
        {
            GetSession1_1
        };

        public PullAndSquatProgram() : base(Sessions)
        {
        }

        public override ProgramType Type => ProgramType.PullAndSquat;
        public override string Name => "Pull and Squat Program";

        private static Session GetSession1_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex2 = new Snatch(MuscleSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 5, Sets = 3}
                }
            };

            var ex3 = new Snatch(SnatchPull, HangSnatchPullBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 3}},
                    new MultiRepeat {Percent = 0.8, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.9, Repeats = new[] {1, 2}, Sets = 3}
                }
            };

            var ex4 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5, Sets = 4}
                }
            };

            var ex5 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 6, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
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