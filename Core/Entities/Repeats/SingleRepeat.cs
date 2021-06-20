using System.Collections.Generic;

namespace Core.Entities.Repeats
{
    public class SingleRepeat : Repeat
    {
        public int Repeats { get; init; }

        public static IReadOnlyList<Repeat> GetMaxoutRepeats()
        {
            var result = new Repeat[]
            {
                new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 1},
                new SingleRepeat {Percent = 0.65, Repeats = 2, Sets = 1},
                new SingleRepeat {Percent = 0.7, Repeats = 2, Sets = 2},
                new SingleRepeat {Percent = 0.75, Repeats = 2, Sets = 1},
                new SingleRepeat {Percent = 0.8, Repeats = 1, Sets = 2},
                new SingleRepeat {Percent = 0.85, Repeats = 1, Sets = 1},
                new SingleRepeat {Percent = 0.9, Repeats = 1, Sets = 1},
                new SingleRepeat {Percent = 0.925, Repeats = 1, Sets = 1},
                new SingleRepeat {Percent = 0.95, Repeats = 1, Sets = 1},
                new SingleRepeat {Percent = 0.975, Repeats = 1, Sets = 1},
                new SingleRepeat {Percent = 1.0, Repeats = 1, Sets = 1},
                new SingleRepeat {Percent = 1.025, Repeats = 1, Sets = 1}
            };

            return result;
        }
    }
}