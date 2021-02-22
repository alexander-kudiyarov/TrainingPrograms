using System;
using System.Collections.Generic;
using System.Linq;
using Core.Bll.Interfaces;
using Core.Common.Helpers;
using Core.Dal.Interfaces;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
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
            ProcessSession(session, day);
            return session;
        }

        private static void ProcessSession(Session session, int day)
        {
            ProcessWeights(session);
            SplitRepeats(session);
            session.Day = day;
        }

        private static void ProcessWeights(Session session)
        {
            foreach (var set in session.Sets)
            foreach (var exercise in set.Exercises)
            {
                foreach (var repeat in exercise.Repeats)
                {
                    CalculatePercentage(exercise, repeat);
                    AddWarmupRepeats(exercise);
                }

                foreach (var repeat in exercise.Repeats)
                {
                    CalculateWeight(exercise, repeat);
                    RoundWeight(exercise, repeat);
                }
            }
        }

        private static void SplitRepeats(Session session)
        {
            foreach (var set in session.Sets)
            foreach (var exercise in set.Exercises)
            {
                var repeats = exercise.Repeats;
                var sets = repeats.Sum(i => i.Sets);
                var list = new List<Repeat>(sets);

                foreach (var repeat in repeats)
                {
                    list.AddRange(Enumerable.Repeat(repeat, repeat.Sets));
                    repeat.Sets = 1;
                }

                exercise.Repeats = list;
            }
        }

        private static void CalculatePercentage(BaseExercise exercise, Repeat repeat)
        {
            if (exercise.Weight == null || repeat.Percent != null) return;

            var repeats = repeat.Repeats.Split('+');
            var firstRepeat = repeats[0];
            var isInt = int.TryParse(firstRepeat, out var value);

            if (!isInt) return;

            var percent = value switch
            {
                1 => 1,
                _ => 1 - value * 0.025
            };

            var result = percent * Stats.WorkWeight;
            repeat.Percent = result;
        }

        private static void AddWarmupRepeats(BaseExercise exercise)
        {
            if (!exercise.IsWarmupNeeded) return;
            var firstRepeat = exercise.Repeats[0];
            var warmUps = new List<Repeat>();

            for (var i = 0.5; i.LessThan(firstRepeat.Percent); i += 0.1)
            {
                var warmUp = new Repeat {Percent = i, Repeats = firstRepeat.Repeats};
                warmUps.Add(warmUp);
            }

            warmUps.AddRange(exercise.Repeats);
            exercise.Repeats = warmUps;
            exercise.IsWarmupNeeded = false;
        }

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

            var roundedWeight = Math.Round(repeat.Weight.Value / factor) * factor;
            repeat.Weight = roundedWeight;
        }
    }
}