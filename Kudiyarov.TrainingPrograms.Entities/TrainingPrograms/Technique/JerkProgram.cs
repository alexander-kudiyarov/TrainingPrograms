using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms.Technique;

public class JerkProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Jerk;
    public override string Name => "Jerk Program";

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
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10, Sets = 2 }
            }
        };

        var ex1B = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Stats.Pvc, Repeats = Array(8, 8), Sets = 2 }
            }
        };

        var ex1C = new Accessory(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6, Sets = 2 }
            }
        };

        var ex1D = new Accessory(CleanStretching)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            }
        };

        var ex1E = new Accessory(JerkDropBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(PushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            }
        };

        var ex5 = new Accessory(PressWithRubberBand)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1A, ex1B, ex1C, ex1D, ex1E),
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
        var ex1A = new Accessory(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 8, Sets = 3 }
            }
        };

        var ex1B = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var ex1C = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var ex1D = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 10, Sets = 2 }
            }
        };

        var ex1E = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 8, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 4 }
            }
        };

        var ex3 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 6 }
            }
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1A, ex1B, ex1C, ex1D, ex1E),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }
}