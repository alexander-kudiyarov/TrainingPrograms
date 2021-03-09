using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using static Core.Entities.Enums.Exercises.AccessoryType;
using static Core.Entities.Enums.Exercises.CleanAndJerkType;
using static Core.Entities.Enums.Exercises.BackSquatType;
using static Core.Entities.Enums.Exercises.SnatchType;

namespace Core.TrainingPrograms
{
    public sealed class LegsProgram : BaseTrainingProgram
    {
        public LegsProgram() : base(GetSessions())
        {
        }

        public override ProgramType Type => ProgramType.LegsProgram;
        public override string Name => "Legs Program";

        private static IDictionary<int, Func<Session>> GetSessions()
        {
            var key = 0;

            var result = new Dictionary<int, Func<Session>>
            {
                [++key] = GetSession1_1
            };

            return result;
        }

        private static Session GetSession1_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "10"}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "10"}
                }
            };

            var ex1C = new Accessory(GakkSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "10"}
                }
            };

            var ex2 = new Snatch(BaseSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "3+3", Sets = 4}
                }
            };

            var ex3 = new BackSquat(BaseBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "8"},
                    new() {Percent = 0.6, Repeats = "8", Sets = 4}
                }
            };

            var ex4 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new() {Percent = 0.5, Repeats = "12", Sets = 3}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new() {Repeats = "8", Sets = 4}
                }
            };

            var session = new Session
            {
                Sets = new Set[]
                {
                    new(3, false, ex1A, ex1B, ex1C),
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