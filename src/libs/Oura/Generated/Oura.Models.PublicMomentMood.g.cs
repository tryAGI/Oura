
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible Moment moods.
    /// </summary>
    public enum PublicMomentMood
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
    public static class PublicMomentMoodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicMomentMood value)
        {
            return value switch
            {
                PublicMomentMood.Bad => "bad",
                PublicMomentMood.Good => "good",
                PublicMomentMood.Great => "great",
                PublicMomentMood.Same => "same",
                PublicMomentMood.Worse => "worse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicMomentMood? ToEnum(string value)
        {
            return value switch
            {
                "bad" => PublicMomentMood.Bad,
                "good" => PublicMomentMood.Good,
                "great" => PublicMomentMood.Great,
                "same" => PublicMomentMood.Same,
                "worse" => PublicMomentMood.Worse,
                _ => null,
            };
        }
    }
}