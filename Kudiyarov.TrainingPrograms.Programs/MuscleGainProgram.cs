using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs;

public sealed class MuscleGainProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.MuscleGain;
    public override string Name => "Muscle Gain";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return new Func<Session>[]
        {
            GetSession1_1
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
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(4, 4), Sets = 5 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchBelowKnees)
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

        var ex5A = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 12 }
            }
        };

        var ex5B = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
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
}