
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible workout intensities.
    /// </summary>
    public enum PublicWorkoutIntensity
    {
        /// <summary>
        ///
        /// </summary>
        Easy,
        /// <summary>
        ///
        /// </summary>
        Hard,
        /// <summary>
        ///
        /// </summary>
        Moderate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicWorkoutIntensityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicWorkoutIntensity value)
        {
            return value switch
            {
                PublicWorkoutIntensity.Easy => "easy",
                PublicWorkoutIntensity.Hard => "hard",
                PublicWorkoutIntensity.Moderate => "moderate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicWorkoutIntensity? ToEnum(string value)
        {
            return value switch
            {
                "easy" => PublicWorkoutIntensity.Easy,
                "hard" => PublicWorkoutIntensity.Hard,
                "moderate" => PublicWorkoutIntensity.Moderate,
                _ => null,
            };
        }
    }
}