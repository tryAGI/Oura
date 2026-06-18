
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible heart rate sources.
    /// </summary>
    public enum PublicHeartRateSource
    {
        /// <summary>
        /// 
        /// </summary>
        Awake,
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        Rest,
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Sleep,
        /// <summary>
        /// 
        /// </summary>
        Workout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicHeartRateSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicHeartRateSource value)
        {
            return value switch
            {
                PublicHeartRateSource.Awake => "awake",
                PublicHeartRateSource.Live => "live",
                PublicHeartRateSource.Rest => "rest",
                PublicHeartRateSource.Session => "session",
                PublicHeartRateSource.Sleep => "sleep",
                PublicHeartRateSource.Workout => "workout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicHeartRateSource? ToEnum(string value)
        {
            return value switch
            {
                "awake" => PublicHeartRateSource.Awake,
                "live" => PublicHeartRateSource.Live,
                "rest" => PublicHeartRateSource.Rest,
                "session" => PublicHeartRateSource.Session,
                "sleep" => PublicHeartRateSource.Sleep,
                "workout" => PublicHeartRateSource.Workout,
                _ => null,
            };
        }
    }
}