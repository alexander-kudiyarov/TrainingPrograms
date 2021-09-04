using System;

namespace Kudiyarov.TrainingPrograms.Core.Common.Helpers
{
    public static class MathHelper
    {
        private const double Tolerance = 0.000000001;

        public static bool Equal(this double x, double y)
        {
            var diff = x - y;
            var result = LessThanTolerance(diff);
            return result;
        }

        public static bool LessThan(this double x, double y)
        {
            var diff = x - y;
            var result = !LessThanTolerance(diff) && diff < 0;
            return result;
        }

        public static bool MoreThan(this double x, double y)
        {
            var diff = x - y;
            var result = !LessThanTolerance(diff) && diff > 0;
            return result;
        }

        public static double RoundTo(this double value, double factor)
        {
            var result = Math.Round(value / factor, MidpointRounding.AwayFromZero) * factor;
            return result;
        }

        private static bool LessThanTolerance(double value)
        {
            var abs = Math.Abs(value);
            var result = abs < Tolerance;
            return result;
        }
    }
}