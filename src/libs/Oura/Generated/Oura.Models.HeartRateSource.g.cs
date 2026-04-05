
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public enum HeartRateSource
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
    public static class HeartRateSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeartRateSource value)
        {
            return value switch
            {
                HeartRateSource.Awake => "awake",
                HeartRateSource.Live => "live",
                HeartRateSource.Rest => "rest",
                HeartRateSource.Session => "session",
                HeartRateSource.Sleep => "sleep",
                HeartRateSource.Workout => "workout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeartRateSource? ToEnum(string value)
        {
            return value switch
            {
                "awake" => HeartRateSource.Awake,
                "live" => HeartRateSource.Live,
                "rest" => HeartRateSource.Rest,
                "session" => HeartRateSource.Session,
                "sleep" => HeartRateSource.Sleep,
                "workout" => HeartRateSource.Workout,
                _ => null,
            };
        }
    }
}