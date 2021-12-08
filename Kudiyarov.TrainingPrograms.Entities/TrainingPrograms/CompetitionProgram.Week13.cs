using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms;

public sealed partial class CompetitionProgram
{
    private static Session GetSession13_1()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 5 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = MultiRepeat.GetMaxoutRepeats()
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

    private static Session GetSession13_3()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 1, Sets = 3 }
            }
        };

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
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

    private static Session GetSession13_4()
    {
        var ex = new Snatch(ExerciseType.Snatch)
        {
            Repeats = SingleRepeat.GetMaxoutRepeats()
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex)
            }
        };

        return session;
    }
}