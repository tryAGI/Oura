
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible daily stress summary types.
    /// </summary>
    public enum DailyStressSummary
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Restored,
        /// <summary>
        /// 
        /// </summary>
        Stressful,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DailyStressSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DailyStressSummary value)
        {
            return value switch
            {
                DailyStressSummary.Normal => "normal",
                DailyStressSummary.Restored => "restored",
                DailyStressSummary.Stressful => "stressful",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DailyStressSummary? ToEnum(string value)
        {
            return value switch
            {
                "normal" => DailyStressSummary.Normal,
                "restored" => DailyStressSummary.Restored,
                "stressful" => DailyStressSummary.Stressful,
                _ => null,
            };
        }
    }
}