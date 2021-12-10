using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms.Strength;

public sealed class PullAndSquatProgram : BaseTrainingProgram
{
    public override ProgramType Type => ProgramType.PullAndSquat;
    public override string Name => "Pull and Squat Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4, GetSession5_5,
            GetSession6_1, GetEmptySession, GetSession6_3, GetSession6_4, GetSession6_5
        };
    }

    private static Session GetSession1_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex2 = new Snatch(MuscleSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 5, Sets = 3 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 1, 3 } },
                new MultiRepeat { Percent = 0.8, Repeats = new[] { 1, 3 }, Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = new[] { 1, 2 }, Sets = 3 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.6, Repeats = 5, Sets = 4 }
            }
        };

        var ex5 = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
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
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new CleanAndJerk(PowerClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 4, 4 }, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_3()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex2 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 4 }
            }
        };

        var ex3 = new Snatch(DeficitSnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            }
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B),
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
        var ex1 = new Snatch(PowerSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 2, 2 }, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession1_5()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 1, 5 }, Sets = 3 }
            }
        };

        var ex3 = new BackSquat(BackSquatNarrowFeet)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 8, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2, 4 }, Sets = 3 }
            }
        };

        var ex3 = new Snatch(RomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 4 }
            }
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 3 }
            }
        };

        var ex5 = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, FrontSquat, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2, 4 }, Sets = 4 }
            }
        };

        var ex3 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.85, Repeats = 4, Sets = 3 },
                new SingleRepeat { Percent = 1.00, Repeats = 1 }
            }
        };

        var ex4 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 3 } },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 1, 3 }, Sets = 3 }
            }
        };

        var ex3 = new Snatch(HangSnatchPullAboveKnees)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 4 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 4 }
            }
        };

        var ex5 = new Accessory(BarbellSquatJump)
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
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession2_4()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 7 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 2, 1 } },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 1, 2 } },
                new MultiRepeat { Percent = 0.7, Repeats = new[] { 1, 1 }, Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(JerkSupport)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Percent = 0.80, Time = TimeSpan.FromSeconds(6) },
                new StaticRepeat { Percent = 1.00, Time = TimeSpan.FromSeconds(6) },
                new StaticRepeat { Percent = 1.05, Time = TimeSpan.FromSeconds(6), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession2_5()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new CleanAndJerk(MuscleSquatClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 4 }
            }
        };

        var ex4 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 6, 6 }, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 4 }
            }
        };

        var ex3 = new Snatch(DeficitSnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 4 },
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            }
        };

        var ex5 = new Snatch(SnatchPushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession3_2()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new MultiCleanAndJerk(CleanPull, Clean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 2, 2 }, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 5, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 4 }, Sets = 4 }
            }
        };

        var ex3 = new Snatch(MediumGripPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.9, Repeats = 5, Sets = 3 }
            }
        };

        var ex4 = new BackSquat(BackSquatNarrowFeet)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 4 }
            }
        };

        var ex5 = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession3_4()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2 }, Sets = 5 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession3_5()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new CleanAndJerk(MuscleSquatClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(JerkSupport)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Percent = 1.1, Time = TimeSpan.FromSeconds(6), Sets = 4 }
            }
        };

        var ex5 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 8, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new Snatch(HipSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
            }
        };

        var ex3 = new Snatch(DeficitSnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 1 }
            }
        };

        var ex4 = new BackSquat(BackSquatPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession4_2()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new MultiCleanAndJerk(CleanFromBlocks, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 3 }, Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 2, 3 }, Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = new[] { 1, 3 }, Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 1.1, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession4_3()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 3, 3 }, Sets = 4 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.70, Repeats = new[] { 1, 3 } },
                new MultiRepeat { Percent = 0.80, Repeats = new[] { 1, 3 }, Sets = 2 },
                new MultiRepeat { Percent = 0.90, Repeats = new[] { 1, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = new[] { 1, 1 }, Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = new[] { 1, 1 } }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.9, Repeats = 4 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.1, Repeats = 1, Sets = 2 }
            }
        };

        var ex5 = new CleanAndJerk(JerkSupport)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Percent = 1.10, Time = TimeSpan.FromSeconds(6), Sets = 2 },
                new StaticRepeat { Percent = 1.15, Time = TimeSpan.FromSeconds(6), Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession4_4()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 2, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = new[] { 2, 1 }, Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = new[] { 1, 2 }, Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = new[] { 1, 1 } }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, ex1A, ex1B, ex1C),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession4_5()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 3 }, Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 1, 3 }, Sets = 3 }
            }
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.85, Repeats = 6, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession5_1()
    {
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1C = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex2 = new CleanAndJerk(MuscleSquatClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.1, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession5_2()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 1, 4 }, Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = new[] { 1, 4 }, Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = new[] { 1, 1 }, Sets = 1 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPushPress, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.7, Repeats = new[] { 3, 3 }, Sets = 2 }
            }
        };

        var ex4 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 4, 4 }, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession5_3()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, FrontSquat, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2, 2 }, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 4 },
                new SingleRepeat { Percent = 0.80, Repeats = 4 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.10, Repeats = 1 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 }
            }
        };

        var ex5 = new Accessory(BarbellSquatJump)
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
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession5_4()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 6 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.4, Repeats = new[] { 2, 2 }, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession5_5()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(JerkSupport)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Percent = 1.0, Time = TimeSpan.FromSeconds(4) },
                new StaticRepeat { Percent = 1.1, Time = TimeSpan.FromSeconds(4) },
                new StaticRepeat { Percent = 1.2, Time = TimeSpan.FromSeconds(4) }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession6_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, FrontSquat, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2, 2 }, Sets = 3 }
            }
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new Accessory(BoxJump)
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
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession6_3()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = new[] { 2, 2 }, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 4, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession6_4()
    {
        var ex1 = new Snatch(HipSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(Clean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession6_5()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = SingleRepeat.GetMaxoutRepeats()
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats = SingleRepeat.GetMaxoutRepeats()
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }
}