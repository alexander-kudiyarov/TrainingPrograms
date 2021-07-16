using System;
using Core.Entities.Enums;

namespace Core.Entities.CacheKeys
{
    public class SessionCacheKey
    {
        public ProgramType ProgramType { get; init; }
        public int Day { get; init; }

        public override bool Equals(object other)
        {
            return other is SessionCacheKey sessionCacheKey
                   && Equals(sessionCacheKey);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine((int) ProgramType, Day);
        }
        
        private bool Equals(SessionCacheKey other)
        {
            return ProgramType == other.ProgramType
                   && Day == other.Day;
        }
    }
}