
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible public SleepTime recommendation.
    /// </summary>
    public enum PublicSleepTimeRecommendation
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
    public static class PublicSleepTimeRecommendationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSleepTimeRecommendation value)
        {
            return value switch
            {
                PublicSleepTimeRecommendation.EarlierBedtime => "earlier_bedtime",
                PublicSleepTimeRecommendation.EarlierWakeUpTime => "earlier_wake_up_time",
                PublicSleepTimeRecommendation.FollowOptimalBedtime => "follow_optimal_bedtime",
                PublicSleepTimeRecommendation.ImproveEfficiency => "improve_efficiency",
                PublicSleepTimeRecommendation.LaterBedtime => "later_bedtime",
                PublicSleepTimeRecommendation.LaterWakeUpTime => "later_wake_up_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSleepTimeRecommendation? ToEnum(string value)
        {
            return value switch
            {
                "earlier_bedtime" => PublicSleepTimeRecommendation.EarlierBedtime,
                "earlier_wake_up_time" => PublicSleepTimeRecommendation.EarlierWakeUpTime,
                "follow_optimal_bedtime" => PublicSleepTimeRecommendation.FollowOptimalBedtime,
                "improve_efficiency" => PublicSleepTimeRecommendation.ImproveEfficiency,
                "later_bedtime" => PublicSleepTimeRecommendation.LaterBedtime,
                "later_wake_up_time" => PublicSleepTimeRecommendation.LaterWakeUpTime,
                _ => null,
            };
        }
    }
}