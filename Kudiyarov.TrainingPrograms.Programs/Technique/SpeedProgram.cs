using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public class SpeedProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Speed;
    public override string Name => "Speed Cycle";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        var sessions = new Func<Session>[]
        {
            GetSession1_1
        };

        return sessions;
    }

    private static Session GetSession1_1()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8 }
            }
        };

        var b = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6 }
            }
        };

        var c = new MultiSnatch(MuscleSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(PowerSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 1 }
            }
        };

        var ex2 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
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