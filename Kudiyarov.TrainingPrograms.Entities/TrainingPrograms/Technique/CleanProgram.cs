using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using NodaTime;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms.Technique;

public class CleanProgram : BackTechniqueProgram
{
    public override ProgramType Type => ProgramType.Clean;
    public override string Name => "Clean Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        var sessions = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2
        };

        return sessions;
    }

    private static Session GetSession1_1()
    {
        var warmup = GetWarmup1(15, 15, 5);

        var ex1 = new MultiCleanAndJerk(CleanStretching, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(5, 5), Sets = 2 }
            }
        };

        var ex2 = new MultiCleanAndJerk(CleanPull, Clean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 4 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 4 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            }
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(45), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
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
        var warmup = GetWarmup2(15, 15);

        var ex1 = new Snatch(MuscleSnatch)
        {
            Repeats = new Repeat[]
            {
                // todo ??
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 4 }
            }
        };

        var ex3 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 10, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }
}