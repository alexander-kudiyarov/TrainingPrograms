using System;
using System.Collections.Generic;
using Core.Entities;

namespace Core.TrainingPrograms
{
    public abstract class TrainingProgramBase : ITrainingProgram
    {
        protected TrainingProgramBase(Lazy<Session>[] sessions)
        {
            Sessions = sessions;
        }

        public abstract string Name { get; }
        public Lazy<Session>[] Sessions { get; }

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