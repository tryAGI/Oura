
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible SleepTime recommendation.
    /// </summary>
    public enum SleepTimeRecommendation
    {
        /// <summary>
        /// 
        /// </summary>
        EarlierBedtime,
        /// <summary>
        /// 
        /// </summary>
        EarlierWakeUpTime,
        /// <summary>
        /// 
        /// </summary>
        FollowOptimalBedtime,
        /// <summary>
        /// 
        /// </summary>
        ImproveEfficiency,
        /// <summary>
        /// 
        /// </summary>
        LaterBedtime,
        /// <summary>
        /// 
        /// </summary>
        LaterWakeUpTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SleepTimeRecommendationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepTimeRecommendation value)
        {
            return value switch
            {
                SleepTimeRecommendation.EarlierBedtime => "earlier_bedtime",
                SleepTimeRecommendation.EarlierWakeUpTime => "earlier_wake_up_time",
                SleepTimeRecommendation.FollowOptimalBedtime => "follow_optimal_bedtime",
                SleepTimeRecommendation.ImproveEfficiency => "improve_efficiency",
                SleepTimeRecommendation.LaterBedtime => "later_bedtime",
                SleepTimeRecommendation.LaterWakeUpTime => "later_wake_up_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepTimeRecommendation? ToEnum(string value)
        {
            return value switch
            {
                "earlier_bedtime" => SleepTimeRecommendation.EarlierBedtime,
                "earlier_wake_up_time" => SleepTimeRecommendation.EarlierWakeUpTime,
                "follow_optimal_bedtime" => SleepTimeRecommendation.FollowOptimalBedtime,
                "improve_efficiency" => SleepTimeRecommendation.ImproveEfficiency,
                "later_bedtime" => SleepTimeRecommendation.LaterBedtime,
                "later_wake_up_time" => SleepTimeRecommendation.LaterWakeUpTime,
                _ => null,
            };
        }
    }
}