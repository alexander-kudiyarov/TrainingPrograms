namespace Core.Entities
{
    public static class Stats
    {
        public static double BarbellFactor => 2.5;
        public static double DumbbellFactor => 1;
        public static double WorkWeight => 0.8;
        public static double Snatch => 55;
        public static double CleanAndJerk { get; } = Snatch / 0.825;
        public static double BackSquat { get; } = CleanAndJerk * 1.25;
        public static double BenchBackSquat { get; } = BackSquat * 1.1;
        public static double FrontSquat { get; } = BackSquat * 0.85;
        public static double Deadlift { get; } = BackSquat * 1.2;
        public static double BenchPress { get; } = BackSquat * 0.75;
        public static double InclineBenchPress { get; } = BackSquat * 0.6;
        public static double Press { get; } = BackSquat * 0.45;
        public static double BicepsCurl { get; } = BackSquat * 0.3;
        public static double BicepsCurlRg { get; } = BackSquat * 0.2625;
        public static double FrenchPress { get; } = BicepsCurl;
        public static double BackSplitSquat { get; } = BackSquat / 2;
        public static double SnatchDeadlift { get; } = BackSquat * 0.9;
        public static double RomanianDeadlift { get; } = Deadlift * 0.55; // ?
        public static double LateralPull { get; } = RomanianDeadlift; // ?
        public static double PullUp { get; } = BackSquat * 0.675;
        public static double Lunges { get; } = BackSplitSquat;
        private static double MediumGripPull { get; } = (Snatch + CleanAndJerk) / 2 * PullFactor;
        public static double DeficitMediumGripPull { get; } = MediumGripPull * DeficitFactor;
        public static double PushPress { get; } = BackSquat * 0.6375;
        private static double PullFactor => 1.1;
        private static double DeficitFactor => 0.9;
        //private static double Body => 71;
        //private static double Bar => 20;
    }
}