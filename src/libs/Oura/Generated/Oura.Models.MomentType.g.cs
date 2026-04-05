
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible Moment types.
    /// </summary>
    public enum MomentType
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
    public static class MomentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MomentType value)
        {
            return value switch
            {
                MomentType.BodyStatus => "body_status",
                MomentType.Breathing => "breathing",
                MomentType.Meditation => "meditation",
                MomentType.Nap => "nap",
                MomentType.Relaxation => "relaxation",
                MomentType.Rest => "rest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MomentType? ToEnum(string value)
        {
            return value switch
            {
                "body_status" => MomentType.BodyStatus,
                "breathing" => MomentType.Breathing,
                "meditation" => MomentType.Meditation,
                "nap" => MomentType.Nap,
                "relaxation" => MomentType.Relaxation,
                "rest" => MomentType.Rest,
                _ => null,
            };
        }
    }
}