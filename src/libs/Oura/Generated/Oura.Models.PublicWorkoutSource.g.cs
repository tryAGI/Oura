
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
                "manual" => PublicWorkoutSource.Manual,
                "workout_heart_rate" => PublicWorkoutSource.WorkoutHeartRate,
                _ => null,
            };
        }
    }
}