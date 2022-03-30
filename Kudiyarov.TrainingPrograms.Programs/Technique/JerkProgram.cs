using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using NodaTime;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public class JerkProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Jerk;
    public override string Name => "Jerk Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        var sessions = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1
        };

        return sessions;
    }

    private static Session GetSession1_1()
    {
        var warmup = GetWarmup1();

        var ex1 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(PushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            }
        };

        var ex4 = new Accessory(PressWithRubberBand)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
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
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
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
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            }
        };

        var ex1E = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
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

    private static Session GetSession1_3()
    {
        var ex1A = new Accessory(ReverseHyperextension)
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
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            }
        };

        var ex1C = new Accessory(SotsPressPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
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

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(JerkBehindTheNeck)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            }
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            }
        };

        var ex5 = new CleanAndJerk(Stats.PushPress, PushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 8, Sets = 3 }
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

    private static Session GetSession1_4()
    {
        var ex1A = new Accessory(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            }
        };

        var ex1B = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10, Sets = 2 }
            }
        };

        var ex1D = new Accessory(SnatchOnPlates)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(SnatchPullTillPower, HangPowerSnatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex3 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.75, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 4 }
            }
        };

        var ex4 = new Accessory(DeathJump)
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
                new(ex1A, ex1B, ex1C, ex1D),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_5()
    {
        var warmup = GetWarmup1();

        var ex1 = new CleanAndJerk(Cluster)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 4 }
            }
        };

        var ex2 = new CleanAndJerk(PushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 4, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(JerkSupport)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Percent = 0.9, Duration = Duration.FromSeconds(6), Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12, Sets = 3 }
            }
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            }
        };

        var c = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10, Sets = 2 }
            }
        };

        var e = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiCleanAndJerk(CleanPullTillPowerPosition, Clean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new Accessory(ChickenJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            }
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var c = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 2 }
            }
        };

        var e = new MultiSnatch(MuscleSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(5, 5), Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(PowerSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = GetRange(0.3, 0.4, 3, 8)
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12, Sets = 3 }
            }
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            }
        };

        var c = new Accessory(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            }
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10, Sets = 2 }
            }
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiCleanAndJerk(Clean, FrontSquat, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.40, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.40, Repeats = Array(1, 1, 1), Sets = 2 }
            }
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.65, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(JerkSupport)
        {
            Repeats = GetRange(0.9, 0.95, Duration.FromSeconds(6), 6)
        };

        var ex4 = new MultiAccessory(PressInSplitPosition, OverheadSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Light, Repeats = Array(4, 4), Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_4()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            }
        };

        var b = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            }
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            }
        };

        var e = new Accessory(SnatchOnPlates)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(SnatchPullTillPower, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 6 }
            }
        };

        var ex2 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession2_5()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12, Sets = 3 }
            }
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            }
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 10, Sets = 2 }
            }
        };

        var d = new Accessory(CleanStretching)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            }
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new CleanAndJerk(Jerk)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.40, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
            }
        };

        var ex2 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.40, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 5, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 1 }
            }
        };

        var ex3 = new MultiCleanAndJerk(PausePushPress, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.40, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 4 }
            }
        };

        var ex4 = new Accessory(BarbellSquatJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            }
        };

        var b = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            }
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            }
        };

        var e = new MultiAccessory(MuscleSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Repeats = Array(4, 4), Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
        {
            Repeats = GetRange(0.4, 0.5, Array(3, 2), 4)
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = GetRange(0.3, 0.4, 3, 8)
        };

        var ex3 = new Accessory(DeathJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static BaseExercise[] GetWarmup1()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10, Sets = 2 }
            }
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            }
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            }
        };

        var d = new Accessory(CleanStretching)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            }
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 3 }
            }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        return warmup;
    }
}