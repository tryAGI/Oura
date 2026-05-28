
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible sleep analysis reasons.
    /// </summary>
    public enum PublicSleepAnalysisReason
    {
        /// <summary>
        /// 
        /// </summary>
        BedtimeEdit,
        /// <summary>
        /// 
        /// </summary>
        ForegroundSleepAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicSleepAnalysisReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSleepAnalysisReason value)
        {
            return value switch
            {
                PublicSleepAnalysisReason.BedtimeEdit => "bedtime_edit",
                PublicSleepAnalysisReason.ForegroundSleepAnalysis => "foreground_sleep_analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSleepAnalysisReason? ToEnum(string value)
        {
            return value switch
            {
                "bedtime_edit" => PublicSleepAnalysisReason.BedtimeEdit,
                "foreground_sleep_analysis" => PublicSleepAnalysisReason.ForegroundSleepAnalysis,
                _ => null,
            };
        }
    }
}