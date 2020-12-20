using Core.Entities.Exercises;

namespace Core.Entities
{
    public class Set
    {
        public Set(int rounds, bool isSuperset, params BaseExercise[] exercises)
        {
            Rounds = rounds;
            IsSuperset = isSuperset;
            Exercises = exercises;
        }

        public Set(params BaseExercise[] exercises)
        {
            Exercises = exercises;
        }

        public BaseExercise[] Exercises { get; }

        public int Rounds { get; } = 1;

        public bool IsSuperset { get; }
    }
}