using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using NodaTime;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs;

public sealed class MuscleGainProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.MuscleGain;
    public override string Name => "Muscle Gain";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return new[]
        {
            GetSession1_1, GetSession1_2
        };
    }

    private static Session GetSession1_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSquatSnatch, SnatchPushPress)
        {
            Repeats = GetRange(0.4, 0.5, Array(4, 4), 5)
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 5), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 4), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 4), Sets = 4 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 5 }
            }
        };

        var ex5A = new Accessory(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            }
        };

        var ex5B = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(3, ex5A, ex5B)
            }
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var ex1 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 6), Sets = 4 }
            }
        };

        var ex3 = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(8, 8), Sets = 4 }
            }
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 3 }
            }
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60) },
                new StaticRepeat { Duration = Duration.FromSeconds(50) },
                new StaticRepeat { Duration = Duration.FromSeconds(40) }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
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