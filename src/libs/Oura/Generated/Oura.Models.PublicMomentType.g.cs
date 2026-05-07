
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible Moment types.
    /// </summary>
    public enum PublicMomentType
    {
        /// <summary>
        /// 
        /// </summary>
        BodyStatus,
        /// <summary>
        /// 
        /// </summary>
        Breathing,
        /// <summary>
        /// 
        /// </summary>
        Meditation,
        /// <summary>
        /// 
        /// </summary>
        Nap,
        /// <summary>
        /// 
        /// </summary>
        Relaxation,
        /// <summary>
        /// 
        /// </summary>
        Rest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicMomentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicMomentType value)
        {
            return value switch
            {
                PublicMomentType.BodyStatus => "body_status",
                PublicMomentType.Breathing => "breathing",
                PublicMomentType.Meditation => "meditation",
                PublicMomentType.Nap => "nap",
                PublicMomentType.Relaxation => "relaxation",
                PublicMomentType.Rest => "rest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicMomentType? ToEnum(string value)
        {
            return value switch
            {
                "body_status" => PublicMomentType.BodyStatus,
                "breathing" => PublicMomentType.Breathing,
                "meditation" => PublicMomentType.Meditation,
                "nap" => PublicMomentType.Nap,
                "relaxation" => PublicMomentType.Relaxation,
                "rest" => PublicMomentType.Rest,
                _ => null,
            };
        }
    }
}