
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible public SleepTime status.
    /// </summary>
    public enum PublicSleepTimeStatus
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
    public static class PublicSleepTimeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSleepTimeStatus value)
        {
            return value switch
            {
                PublicSleepTimeStatus.BadSleepQuality => "bad_sleep_quality",
                PublicSleepTimeStatus.NotEnoughNights => "not_enough_nights",
                PublicSleepTimeStatus.NotEnoughRecentNights => "not_enough_recent_nights",
                PublicSleepTimeStatus.OnlyRecommendedFound => "only_recommended_found",
                PublicSleepTimeStatus.OptimalFound => "optimal_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSleepTimeStatus? ToEnum(string value)
        {
            return value switch
            {
                "bad_sleep_quality" => PublicSleepTimeStatus.BadSleepQuality,
                "not_enough_nights" => PublicSleepTimeStatus.NotEnoughNights,
                "not_enough_recent_nights" => PublicSleepTimeStatus.NotEnoughRecentNights,
                "only_recommended_found" => PublicSleepTimeStatus.OnlyRecommendedFound,
                "optimal_found" => PublicSleepTimeStatus.OptimalFound,
                _ => null,
            };
        }
    }
}