
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible SleepTime status.
    /// </summary>
    public enum SleepTimeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        BadSleepQuality,
        /// <summary>
        /// 
        /// </summary>
        NotEnoughNights,
        /// <summary>
        /// 
        /// </summary>
        NotEnoughRecentNights,
        /// <summary>
        /// 
        /// </summary>
        OnlyRecommendedFound,
        /// <summary>
        /// 
        /// </summary>
        OptimalFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SleepTimeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepTimeStatus value)
        {
            return value switch
            {
                SleepTimeStatus.BadSleepQuality => "bad_sleep_quality",
                SleepTimeStatus.NotEnoughNights => "not_enough_nights",
                SleepTimeStatus.NotEnoughRecentNights => "not_enough_recent_nights",
                SleepTimeStatus.OnlyRecommendedFound => "only_recommended_found",
                SleepTimeStatus.OptimalFound => "optimal_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepTimeStatus? ToEnum(string value)
        {
            return value switch
            {
                "bad_sleep_quality" => SleepTimeStatus.BadSleepQuality,
                "not_enough_nights" => SleepTimeStatus.NotEnoughNights,
                "not_enough_recent_nights" => SleepTimeStatus.NotEnoughRecentNights,
                "only_recommended_found" => SleepTimeStatus.OnlyRecommendedFound,
                "optimal_found" => SleepTimeStatus.OptimalFound,
                _ => null,
            };
        }
    }
}