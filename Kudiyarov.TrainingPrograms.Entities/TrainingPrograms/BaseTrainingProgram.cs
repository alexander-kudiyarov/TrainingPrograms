using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms;

public abstract class BaseTrainingProgram
{
    protected static readonly Func<Session> EmptySession;
    private readonly Lazy<IReadOnlyList<Func<Session>>> _sessions;

    static BaseTrainingProgram()
    {
        EmptySession = GetEmptySession;
    }

    protected BaseTrainingProgram()
    {
        _sessions = new Lazy<IReadOnlyList<Func<Session>>>(GetSessions);
    }

    private IReadOnlyList<Func<Session>> Sessions => _sessions.Value;

    public abstract ProgramType Type { get; }
    public abstract string Name { get; }
    public int Days => Sessions.Count;
    protected abstract IReadOnlyList<Func<Session>> GetSessions();

    public Session Get(int day)
    {
        var index = day - 1;
        var func = Sessions[index];
        var result = func();
        result.Day = day;
        return result;
    }

    protected static T[] Array<T>(params T[] value)
    {
        return value;
    }

    private static Session GetEmptySession()
    {
        return new Session();
    }

    protected static IReadOnlyList<Repeat> GetRange(double start, double stop, int repeats, int sets)
    {
        var result = GetRange(start, stop, Func, sets);
        return result;

        Repeat Func(double percent)
        {
            return new SingleRepeat { Percent = percent, Repeats = repeats };
        }
    }

    protected static IReadOnlyList<Repeat> GetRange(double start, double stop, IReadOnlyList<int> repeats, int sets)
    {
        var result = GetRange(start, stop, Func, sets);
        return result;

        Repeat Func(double percent)
        {
            return new MultiRepeat { Percent = percent, Repeats = repeats };
        }
    }

    private static IReadOnlyList<Repeat> GetRange(double start, double stop, Func<double, Repeat> func, int sets)
    {
        var result = new Repeat[sets];
        var step = GetStep(start, stop, sets);

        for (var i = 0; i < sets; i++)
        {
            var percent = GetPercent(start, step, i);
            result[i] = func(percent);
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