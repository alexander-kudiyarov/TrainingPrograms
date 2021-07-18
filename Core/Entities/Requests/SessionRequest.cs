using System;
using Core.Entities.Enums;

namespace Core.Entities.Requests
{
    public class SessionRequest
    {
        public ProgramType ProgramType { get; init; }
        public int Day { get; init; }

        public override bool Equals(object other)
        {
            return other is SessionRequest request
                   && Equals(request);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine((int) ProgramType, Day);
        }

        private bool Equals(SessionRequest other)
        {
            return ProgramType == other.ProgramType
                   && Day == other.Day;
        }
    }
}