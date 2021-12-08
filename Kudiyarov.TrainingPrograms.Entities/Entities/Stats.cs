namespace Kudiyarov.TrainingPrograms.Entities.Entities;

public static class Stats
{
    public static double Bar => 20;

    // https://www.t-nation.com/training/know-your-ratios-destroy-weaknesses

    public static double Snatch => 60;
    public static double CleanAndJerk => Snatch / 0.825;
    public static double BackSquat => CleanAndJerk * 1.25;
    public static double Deadlift => BackSquat * 1.2;
    public static double BenchPress => BackSquat * 0.75;
    public static double PushPress => BackSquat * 0.6375;
    public static double InclineBenchPress => BackSquat * 0.6;
    public static double Press => BackSquat * 0.45;

    // https://www.t-nation.com/training/know-your-ratios-destroy-weaknesses

    public static double BarbellFactor => 2.5;
    public static double DumbbellFactor => 1;
    public static double WorkWeight => 0.8;
    public static double BenchBackSquat => BackSquat * 1.1;
    public static double FrontSquat => BackSquat * 0.85;
    public static double BicepsCurl => BackSquat * 0.3;
    public static double FrenchPress => BicepsCurl;
    public static double BicepsCurlRg => BackSquat * 0.2625;
    public static double BackSplitSquat => BackSquat / 2;
    public static double SnatchDeadlift => BackSquat * 0.9;
    public static double RomanianDeadlift => Deadlift * 0.55; // ?
    public static double LateralPull => RomanianDeadlift; // ?
    public static double PullUp => BackSquat * 0.675;
    public static double Lunges => BackSplitSquat;
    private static double MediumGripPull => (Snatch + CleanAndJerk) / 2 * PullFactor;
    public static double DeficitMediumGripPull => MediumGripPull * DeficitFactor;
    private static double PullFactor => 1.1;

    private static double DeficitFactor => 0.9;
    //private static double Body => 71;
}