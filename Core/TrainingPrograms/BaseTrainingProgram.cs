using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;

namespace Core.TrainingPrograms
{
    public abstract class BaseTrainingProgram
    {
        private readonly IDictionary<int, Func<Session>> _sessions;

        protected BaseTrainingProgram(IDictionary<int, Func<Session>> sessions)
        {
            _sessions = sessions;
        }

        public abstract ProgramType Type { get; }
        public abstract string Name { get; }

        public int Count => _sessions.Count;

        public Session Get(int day)
        {
            var func = _sessions[day];
            var result = func.Invoke();

            return result;
        }

        protected static T[] Concat<T>(ICollection<T> x, ICollection<T> y)
        {
            var result = new T[x.Count + y.Count];
            x.CopyTo(result, 0);
            y.CopyTo(result, x.Count);
            return result;
        }

        protected static IList<Repeat> GetRange(double start, double stop, int sets, string repeats)
        {
            var step = GetStep(start, stop, sets);
            var result = new Repeat[sets];

            for (var i = 0; i < sets; i++)
            {
                var percent = GetPercent(start, step, i);
                result[i] = new Repeat {Percent = percent, Repeats = repeats};
            }

            return result;
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