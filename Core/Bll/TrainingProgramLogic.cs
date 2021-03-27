using System;
using System.Collections.Generic;
using System.Linq;
using Core.Bll.Interfaces;
using Core.Common.Helpers;
using Core.Dal.Interfaces;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using Core.TrainingPrograms;

namespace Core.Bll
{
    public class TrainingProgramLogic : ITrainingProgramLogic
    {
        private readonly IProgramRepository _repository;

        public TrainingProgramLogic(IProgramRepository repository)
        {
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

        public Session Get(ProgramType type, int day)
        {
            var session = _repository.Get(type, day);
            ProcessSession(session);
            return session;
        }

        private static void ProcessSession(Session session)
        {
            ProcessWeights(session);
            SplitRepeats(session);
        }

        private static void ProcessWeights(Session session)
        {
            foreach (var set in session.Rounds)
            foreach (var exercise in set.Exercises)
            {
                foreach (var repeat in exercise.Repeats)
                {
                    if (repeat is not WeightedRepeat weightedRepeat) continue;
                    CalculatePercentage(exercise, weightedRepeat);
                    AddWarmupRepeats(exercise);
                }

                foreach (var repeat in exercise.Repeats)
                {
                    if (repeat is not WeightedRepeat weightedRepeat) continue;
                    CalculateWeight(exercise, weightedRepeat);
                    RoundWeight(exercise, weightedRepeat);
                }
            }
        }

        private static void SplitRepeats(Session session)
        {
            foreach (var round in session.Rounds)
            foreach (var exercise in round.Exercises)
                exercise.Repeats = Split(exercise.Repeats);

            static IEnumerable<Repeat> Split(IEnumerable<Repeat> exercise)
            {
                foreach (var set in exercise)
                    for (var i = 0; i < set.Sets; i++)
                        yield return set;
            }
        }

        private static void CalculatePercentage(BaseExercise exercise, WeightedRepeat repeat)
        {
            if (exercise.Weight == null || repeat.Percent != null) return;

            var repeats = repeat switch
            {
                SingleRepeat singleRepeat => singleRepeat.Repeats,
                MultiRepeat multiRepeat => multiRepeat.Repeats.Max(),
                _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
            };

            var percent = repeats switch
            {
                1 => 1,
                _ => 1 - repeats * 0.025
            };

            var result = percent * Stats.WorkWeight;
            repeat.Percent = result;
        }

        private static void AddWarmupRepeats(BaseExercise exercise)
        {
            if (!exercise.IsWarmupNeeded
                || exercise.Repeats.First() is not WeightedRepeat repeat) return;

            var warmUps = new List<Repeat>();

            for (var i = 0.5; i.LessThan(repeat.Percent); i += 0.1)
            {
                WeightedRepeat result = repeat switch
                {
                    SingleRepeat singleRepeat => new SingleRepeat {Percent = i, Repeats = singleRepeat.Repeats},
                    MultiRepeat multiRepeat => new MultiRepeat {Percent = i, Repeats = multiRepeat.Repeats},
                    // TODO Fix
                    _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
                };

                warmUps.Add(result);
            }

            warmUps.AddRange(exercise.Repeats);
            exercise.Repeats = warmUps;
            exercise.IsWarmupNeeded = false;
        }

        private static void CalculateWeight(BaseExercise exercise, WeightedRepeat repeat)
        {
            if (repeat.Weight == null && exercise.Weight != null)
                repeat.Weight = exercise.Weight * repeat.Percent;
        }

        private static void RoundWeight(BaseExercise exercise, WeightedRepeat repeat)
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

            var roundedWeight = Math.Round(repeat.Weight.Value / factor) * factor;
            repeat.Weight = roundedWeight;
        }
    }
}