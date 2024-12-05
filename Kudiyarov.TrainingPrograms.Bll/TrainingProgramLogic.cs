using Kudiyarov.Packages.DoubleExtensions;
using Kudiyarov.TrainingPrograms.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;
using Microsoft.Extensions.Caching.Memory;

namespace Kudiyarov.TrainingPrograms.Bll;

public class TrainingProgramLogic : ITrainingProgramLogic
{
    private readonly IMemoryCache _memoryCache;
    private readonly IProgramRepository _repository;

    public TrainingProgramLogic(
        IMemoryCache memoryCache,
        IProgramRepository repository)
    {
        _memoryCache = memoryCache;
        _repository = repository;
    }

    public IEnumerable<TrainingProgram> Get()
    {
        var result = _repository.Get();
        return result;
    }

    public TrainingProgram Get(ProgramType type)
    {
        var result = _repository.Get(type);
        return result;
    }

    public Session Get(SessionRequest request)
    {
        var result = _memoryCache.GetOrCreate(request, _ => GetFromRepository(request));
        return result!;
    }

    private Session GetFromRepository(SessionRequest request)
    {
        var session = _repository.Get(request);
        ProcessWeights(session);
        return session;
    }

    private static void ProcessWeights(Session session)
    {
        foreach (var set in session.Rounds)
        foreach (var exercise in set.Exercises)
        {
            foreach (var repeat in exercise.Repeats)
            {
                CalculatePercentage(exercise, repeat);
            }
            
            AddWarmup(exercise);
            
            foreach (var repeat in exercise.Repeats)
            {
                CalculateWeight(exercise, repeat);
                // RoundWeight(exercise, repeat);
            }
        }
    }

    private static void AddWarmup(BaseExercise exercise)
    {
        if (!exercise.IsWarmupNeeded)
        {
            return;
        }
        
        var firstRepeat = exercise.Repeats[0];

        if (firstRepeat is not { Percent: not null })
        {
            return;
        }
        
        var workPercent = firstRepeat.Percent;
        var warmupPercent = 0.5;
        var newList = new List<Repeat>();

        while (warmupPercent.LessThan(workPercent.Value))
        {
            Repeat repeat = firstRepeat switch
            {
                SingleRepeat single => new SingleRepeat {Percent = warmupPercent, Repeats = single.Repeats},
                MultiRepeat multi => new MultiRepeat {Percent = warmupPercent, Repeats = multi.Repeats},
                StaticRepeat staticR => new StaticRepeat {Percent = warmupPercent, Duration = staticR.Duration}
            };
                    
            newList.Add(repeat);
            warmupPercent += 0.1;
        }
        
        newList.AddRange(exercise.Repeats);
        exercise.Repeats = newList;
    }

    private static void CalculatePercentage(BaseExercise exercise, Repeat repeat)
    {
        if (repeat.Weight != null || repeat.Percent != null || exercise.Weight == null)
        {
            return;
        }

        var repeats = repeat switch
        {
            SingleRepeat singleRepeat => singleRepeat.Repeats,
            MultiRepeat multiRepeat => multiRepeat.Repeats.Max(),
            _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
        };

        var percent = GetPercent(repeats, repeat.Intensity);

        repeat.Percent = percent;
    }

    private static double GetPercent(int repeats, Intensity intensity)
    {
        var reserveRepeats = GetReserveRepeats(intensity);
        var percent = GetPercent(repeats + reserveRepeats);
        return percent;
    }

    private static double GetReserveRepeats(Intensity intensity)
    {
        var repeats = intensity switch
        {
            Intensity.None => 0,
            Intensity.Light => 5,
            Intensity.Medium => 3.5,
            Intensity.High => 1.5,
            _ => throw new ArgumentOutOfRangeException(nameof(intensity))
        };

        return repeats;
    }

    private static double GetPercent(double repeats)
    {
        var result = repeats.RelativeEquals(1)
            ? 1
            : 1 - repeats * 0.025;

        return result;
    }

    private static void CalculateWeight(BaseExercise exercise, Repeat repeat)
    {
        if (repeat.Weight == null && exercise.Weight != null)
        {
            repeat.Weight = exercise.Weight * repeat.Percent;
        }
    }

    private static void RoundWeight(BaseExercise exercise, Repeat repeat)
    {
        if (repeat.Weight == null)
        {
            return;
        }

        var equipment = exercise switch
        {
            Accessory accessory => accessory.EquipmentType,
            _ => EquipmentType.Barbell
        };

        var factor = equipment switch
        {
            EquipmentType.Barbell => Constants.BarbellFactor,
            EquipmentType.Dumbbell => Constants.DumbbellFactor,
            _ => throw new ArgumentOutOfRangeException(nameof(equipment), "Type is not defined")
        };

        var roundedWeight = repeat.Weight.Value.RoundTo(factor);
        repeat.Weight = roundedWeight;
    }
}