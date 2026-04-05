
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible Moment moods.
    /// </summary>
    public enum MomentMood
    {
        /// <summary>
        /// 
        /// </summary>
        Bad,
        /// <summary>
        /// 
        /// </summary>
        Good,
        /// <summary>
        /// 
        /// </summary>
        Great,
        /// <summary>
        /// 
        /// </summary>
        Same,
        /// <summary>
        /// 
        /// </summary>
        Worse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MomentMoodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MomentMood value)
        {
            return value switch
            {
                MomentMood.Bad => "bad",
                MomentMood.Good => "good",
                MomentMood.Great => "great",
                MomentMood.Same => "same",
                MomentMood.Worse => "worse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MomentMood? ToEnum(string value)
        {
            return value switch
            {
                "bad" => MomentMood.Bad,
                "good" => MomentMood.Good,
                "great" => MomentMood.Great,
                "same" => MomentMood.Same,
                "worse" => MomentMood.Worse,
                _ => null,
            };
        }
    }
}