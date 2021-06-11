using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Repeats;

namespace Core.TrainingPrograms
{
    public abstract class BaseTrainingProgram
    {
        private readonly IReadOnlyList<Func<Session>> _sessions;

        protected BaseTrainingProgram(IReadOnlyList<Func<Session>> sessions)
        {
            _sessions = sessions;
        }

        public abstract ProgramType Type { get; }
        public abstract string Name { get; }
        public int Days => _sessions.Count;

        public Session Get(int day)
        {
            var index = day - 1;
            var func = _sessions[index];
            var result = func.Invoke();
            result.Day = day;
            return result;
        }

        protected static IEnumerable<Repeat> GetRange(double start, double stop, int sets, int repeats)
        {
            var step = GetStep(start, stop, sets);

            for (var i = 0; i < sets; i++)
            {
                var percent = GetPercent(start, step, i);
                var result = new SingleRepeat {Percent = percent, Repeats = repeats};
                yield return result;
            }
        }

        protected static IEnumerable<Repeat> GetRange(double start, double stop, int sets, IReadOnlyList<int> repeats)
        {
            var step = GetStep(start, stop, sets);

            for (var i = 0; i < sets; i++)
            {
                var percent = GetPercent(start, step, i);
                var result = new MultiRepeat {Percent = percent, Repeats = repeats};
                yield return result;
            }
        }

        private static double GetStep(double start, double stop, int sets)
        {
            var diff = stop - start;
            var steps = sets - 1;
            var result = diff / steps;
            return result;
        }

        private static double GetPercent(double start, double step, int i)
        {
            var result = start + step * i;
            return result;
        }
    }
}