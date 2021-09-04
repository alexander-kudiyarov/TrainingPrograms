using System;
using System.Collections.Generic;
using Kudiyarov.TrainingPrograms.Core.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Core.Common.Entities;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Repeats;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Requests;
using Kudiyarov.TrainingPrograms.Core.Common.Helpers;
using Kudiyarov.TrainingPrograms.Core.Common.TrainingPrograms;
using Kudiyarov.TrainingPrograms.Core.Dal.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace Kudiyarov.TrainingPrograms.Core.Bll
{
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

        public IEnumerable<BaseTrainingProgram> Get()
        {
            var result = _repository.Get();
            return result;
        }

        public BaseTrainingProgram Get(ProgramType type)
        {
            var result = _repository.Get(type);
            return result;
        }

        public Session Get(SessionRequest request)
        {
            var result = _memoryCache.GetOrCreate(request, _ => GetFromRepository(request));
            return result;
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
                // foreach (var repeat in exercise.Repeats)
                // {
                //     if (repeat is not WeightedRepeat weightedRepeat) continue;
                //     CalculatePercentage(exercise, weightedRepeat);
                //     AddWarmupRepeats(exercise);
                // }

            foreach (var repeat in exercise.Repeats)
            {
                CalculateWeight(exercise, repeat);
                RoundWeight(exercise, repeat);
            }
        }

        // private static void CalculatePercentage(BaseExercise exercise, Repeat repeat)
        // {
        //     if (exercise.Weight == null || repeat.Percent != null) return;
        //
        //     var repeats = repeat switch
        //     {
        //         SingleRepeat singleRepeat => singleRepeat.Repeats,
        //         MultiRepeat multiRepeat => multiRepeat.Repeats.Max(),
        //         _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
        //     };
        //
        //     var percent = repeats switch
        //     {
        //         1 => 1,
        //         _ => 1 - repeats * 0.025
        //     };
        //
        //     var result = percent * Stats.WorkWeight;
        //     repeat.Percent = result;
        // }
        //
        // private static void AddWarmupRepeats(BaseExercise exercise)
        // {
        //     if (!exercise.IsWarmupNeeded
        //         || exercise.Repeats.First() is not WeightedRepeat repeat) return;
        //
        //     var warmUps = new List<Repeat>();
        //
        //     for (var i = 0.5; i.LessThan(repeat.Percent); i += 0.1)
        //     {
        //         Repeat result = repeat switch
        //         {
        //             SingleRepeat singleRepeat => new SingleRepeat {Percent = i, Repeats = singleRepeat.Repeats},
        //             MultiRepeat multiRepeat => new MultiRepeat {Percent = i, Repeats = multiRepeat.Repeats},
        //             // TODO Fix
        //             _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
        //         };
        //
        //         warmUps.Add(result);
        //     }
        //
        //     warmUps.AddRange(exercise.Repeats);
        //     exercise.Repeats = warmUps;
        //     exercise.IsWarmupNeeded = false;
        // }

        private static void CalculateWeight(BaseExercise exercise, Repeat repeat)
        {
            if (repeat.Weight == null && exercise.Weight != null)
                repeat.Weight = exercise.Weight * repeat.Percent;
        }

        private static void RoundWeight(BaseExercise exercise, Repeat repeat)
        {
            if (repeat.Weight == null) return;

            var equipment = exercise switch
            {
                Accessory accessory => accessory.EquipmentType,
                _ => EquipmentType.Barbell
            };

            var factor = equipment switch
            {
                EquipmentType.Barbell => Stats.BarbellFactor,
                EquipmentType.Dumbbell => Stats.DumbbellFactor,
                _ => throw new ArgumentOutOfRangeException(nameof(equipment), "Type is not defined")
            };

            var roundedWeight = repeat.Weight.Value.RoundTo(factor);
            repeat.Weight = roundedWeight;
        }
    }
}