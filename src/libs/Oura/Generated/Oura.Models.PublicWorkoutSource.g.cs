
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible workout sources.
    /// </summary>
    public enum PublicWorkoutSource
    {
        /// <summary>
        ///
        /// </summary>
        Autodetected,
        /// <summary>
        ///
        /// </summary>
        Confirmed,
        /// <summary>
        ///
        /// </summary>
        LiveOuraHeartRate,
        /// <summary>
        ///
        /// </summary>
        LiveThirdPartyHeartRate,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        WorkoutHeartRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicWorkoutSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicWorkoutSource value)
        {
            return value switch
            {
                PublicWorkoutSource.Autodetected => "autodetected",
                PublicWorkoutSource.Confirmed => "confirmed",
                PublicWorkoutSource.LiveOuraHeartRate => "live_oura_heart_rate",
                PublicWorkoutSource.LiveThirdPartyHeartRate => "live_third_party_heart_rate",
                PublicWorkoutSource.Manual => "manual",
                PublicWorkoutSource.WorkoutHeartRate => "workout_heart_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicWorkoutSource? ToEnum(string value)
        {
            return value switch
            {
                "autodetected" => PublicWorkoutSource.Autodetected,
                "confirmed" => PublicWorkoutSource.Confirmed,
                "live_oura_heart_rate" => PublicWorkoutSource.LiveOuraHeartRate,
                "live_third_party_heart_rate" => PublicWorkoutSource.LiveThirdPartyHeartRate,
                "manual" => PublicWorkoutSource.Manual,
                "workout_heart_rate" => PublicWorkoutSource.WorkoutHeartRate,
                _ => null,
            };
        }
    }
}