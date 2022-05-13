using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
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
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5
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

    private static Session GetSession1_2()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var c = new CleanAndJerk(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(CleanFromBlocks, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(CleanPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            }
        };

        var ex3 = new Accessory(PressWithRubberBand)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 5, Sets = 3 }
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

    private static Session GetSession1_3()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var b = new Snatch(SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            }
        };

        var c = new Snatch(SnatchOnPlates)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchAboveKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex2 = new Snatch(DeficitSnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new Accessory(DeathJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 5, Sets = 3 }
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
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_4()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8 }
            }
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            }
        };

        var c = new MultiCleanAndJerk(MuscleClean, Press)
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

        var ex1 = new CleanAndJerk(PowerClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 }
            }
        };

        var ex3 = new BackSquat(BackSquatPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
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

    private static Session GetSession1_5()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var c = new Snatch(HipSnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(HipSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 2), Sets = 10 }
            }
        };

        var ex2 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 5, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }
}