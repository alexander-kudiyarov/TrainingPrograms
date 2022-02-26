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
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4
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
                new MultiRepeat { Weight = Stats.Pvc, Repeats = Array(5, 5), Sets = 2 }
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

    private static Session GetSession1_3()
    {
        var warmup = GetWarmup1(15, 15, 5);

        var ex1 = new CleanAndJerk(HipMuscleClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 4, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, HangPowerClean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(MediumGripPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
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
        var warmup = GetWarmup1(15, 15, 5);

        var ex1A = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 8 }
            }
        };

        var ex1B = new Accessory(WallSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8 }
            }
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new Accessory(PressWithRubberBand)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 4 }
            }
        };

        var ex4 = new Accessory(ReversePlank)
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
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_5()
    {
        var warmup = GetWarmup2(15, 15);

        var ex1A = new Accessory(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex1B = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex2 = new CleanAndJerk(DeficitClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            }
        };

        var ex4 = new BackSquat(BackSquatNarrowFeet)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var warmup = GetWarmup2(15, 15, 5);

        var ex1 = new MultiCleanAndJerk(CleanStretching, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6, Sets = 2 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, FrontSquat, PushPress)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 1, 2), 3)
        };

        var ex3 = new CleanAndJerk(MediumGripPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 2 }
            }
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
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
        var warmup = GetWarmup4(15, 15, 15);

        var ex1 = new Snatch(MuscleSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex3 = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                // todo ??
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 3 }
            }
        };

        var ex4 = new Accessory(BarbellSquatJump)
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
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var warmup = GetWarmup2(15, 15, 5);

        var ex1 = GetCleanWarmup(6);

        var ex2 = new MultiCleanAndJerk(CleanPullTillPowerPosition, Clean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
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
        var warmup = GetWarmup2(15, 15, 5);

        var ex2A = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 8 }
            }
        };

        var ex2B = new Accessory(WallSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8 }
            }
        };

        var ex3 = new CleanAndJerk(Jerk)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 1, Sets = 2 }
            }
        };

        var ex4 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            }
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(2, ex2A, ex2B),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession2_5()
    {
        var warmup = GetWarmup4(15, 15, 15);

        var ex2A = new Accessory(HipMuscleClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex2B = new Accessory(BoxFrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex3 = new MultiCleanAndJerk(Clean, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 3), Sets = 1 }
            }
        };

        var ex4 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.10, Repeats = 1, Sets = 1 }
            }
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2 }
            }
        };

        var ex6 = new Accessory(DeathJump)
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
                new(3, warmup),
                new(3, ex2A, ex2B),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            }
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var warmup = GetWarmup1(15, 15, 5);

        var ex2A = new Accessory(ElbowsRotationRackSupport)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6 }
            }
        };

        var ex2B = new Accessory(BoxFrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6 }
            }
        };

        var ex3 = new MultiCleanAndJerk(CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 5 }
            }
        };

        var ex4 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
            }
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 4 }
            }
        };

        var ex6 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(3, ex2A, ex2B),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            }
        };

        return session;
    }

    private static Session GetSession3_2()
    {
        var warmup = GetWarmup5(15, 15, 15);

        var ex2A = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 8 }
            }
        };

        var ex2B = new Accessory(WallSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8 }
            }
        };

        var ex3 = new CleanAndJerk(Jerk)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 6 }
            }
        };

        var ex4 = new Accessory(Press)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 3 }
            }
        };

        var ex5 = new Accessory(DeathJump)
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
                new(3, warmup),
                new(2, ex2A, ex2B),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var warmup = GetWarmup1(15, 15, 5);

        var ex2A = new Accessory(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex2B = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex3 = new MultiCleanAndJerk(CleanFromBlocks, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 1 }
            }
        };

        var ex4 = new CleanAndJerk(CleanFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.1, Repeats = 2, Sets = 3 }
            }
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 3 }
            }
        };

        var ex6 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(3, ex2A, ex2B),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            }
        };

        return session;
    }

    private static Session GetSession3_4()
    {
        var warmup = GetWarmup1(15, 15, 5);

        var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 3 }
            }
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 6 }
            }
        };

        var ex3 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession3_5()
    {
        var warmup = GetWarmup5(15, 15, 15);

        var ex1 = new MultiCleanAndJerk(MuscleClean, FrontSquat, Press)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Stats.Pvc, Repeats = Array(4, 4, 4), Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.500, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.775, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.850, Repeats = Array(3, 1), Sets = 1 }
            }
        };

        var ex3 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new BackSquat(BackSquatPause)
        {
            Repeats = new[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 3 }
            }
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
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
        var warmup = GetWarmup2(10, 15, 5);

        var ex1 = new MultiCleanAndJerk(CleanStretching, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Stats.Pvc, Repeats = Array(5, 5), Sets = 2 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.1, Repeats = 3, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2 }
            }
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(30), Sets = 2 }
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

    private static Session GetSession4_2()
    {
        var warmup = GetWarmup4(10, 15, 8);

        var ex1 = new Snatch(MuscleSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex3 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 5, Sets = 3 }
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

    private static Session GetSession4_3()
    {
        var warmup = GetWarmup2(10, 15, 5);

        var ex1A = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex1B = new CleanAndJerk(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = 6 }
            }
        };

        var ex2 = new CleanAndJerk(Clean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 1 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.10, Repeats = 1, Sets = 2 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession4_4()
    {
        var warmup = GetWarmup2(10, 15, 5);

        var ex1A = new MultiCleanAndJerk(MuscleClean, FrontSquat, Press)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Stats.Pvc, Repeats = Array(3, 3, 3), Sets = 2 }
            }
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, Array(1, 2), 3)
        };

        var ex3 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                // TODO ??
                new SingleRepeat { Percent = 0.4, Repeats = 5, Sets = 3 }
            }
        };

        var ex4 = new Accessory(ReversePlank)
        {
            Repeats = new[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(30), Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1A),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static BaseExercise[] GetCleanWarmup(int repeats)
    {
        var a = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = repeats, Sets = 3 }
            }
        };

        var b = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Pvc, Repeats = repeats, Sets = 3 }
            }
        };

        var c = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = repeats, Sets = 3 }
            }
        };

        var result = new BaseExercise[]
        {
            a, b, c
        };

        return result;
    }
}