
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Average breathing rate during sleep as breaths/second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_breath")]
        public double? AverageBreath { get; set; }

        /// <summary>
        /// Average heart rate during sleep as beats/minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_heart_rate")]
        public double? AverageHeartRate { get; set; }

        /// <summary>
        /// Average heart rate variability during sleep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_hrv")]
        public int? AverageHrv { get; set; }

        /// <summary>
        /// Duration spent awake in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awake_time")]
        public int? AwakeTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bedtime_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BedtimeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bedtime_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BedtimeStart { get; set; }

        /// <summary>
        /// Day that the sleep belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// Duration spent in deep sleep in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_sleep_duration")]
        public int? DeepSleepDuration { get; set; }

        /// <summary>
        /// Sleep efficiency rating in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficiency")]
        public int? Efficiency { get; set; }

        /// <summary>
        /// Object containing heart rate samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public global::Oura.SampleModel? HeartRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv")]
        public global::Oura.SampleModel? Hrv { get; set; }

        /// <summary>
        /// Sleep latency in seconds. This is the time it took for the user to fall asleep after going to bed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public int? Latency { get; set; }

        /// <summary>
        /// Duration spent in light sleep in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("light_sleep_duration")]
        public int? LightSleepDuration { get; set; }

        /// <summary>
        /// Flag indicating if a low battery alert occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_battery_alert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LowBatteryAlert { get; set; }

        /// <summary>
        /// Lowest heart rate during sleep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lowest_heart_rate")]
        public int? LowestHeartRate { get; set; }

        /// <summary>
        ///         30-second movement classification for the period where every character corresponds to:<br/>
        ///         '1' = no motion,<br/>
        ///         '2' = restless,<br/>
        ///         '3' = tossing and turning<br/>
        ///         '4' = active<br/>
        ///         <br/>
        /// Example: 1143222134
        /// </summary>
        /// <example>1143222134</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_30_sec")]
        public string? Movement30Sec { get; set; }

        /// <summary>
        /// ECore sleep period identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Period { get; set; }

        /// <summary>
        /// Object containing the readiness details for this sleep. As opposed to the daily readiness object which represents the readiness for the entire day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness")]
        public global::Oura.ReadinessSummary? Readiness { get; set; }

        /// <summary>
        /// Effect on readiness score caused by this sleep period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_score_delta")]
        public int? ReadinessScoreDelta { get; set; }

        /// <summary>
        /// Duration spent in REM sleep in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rem_sleep_duration")]
        public int? RemSleepDuration { get; set; }

        /// <summary>
        /// Number of restless periods during sleep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restless_periods")]
        public int? RestlessPeriods { get; set; }

        /// <summary>
        ///         5-minute sleep phase classification for the period where every character corresponds to:<br/>
        ///         '1' = deep sleep,<br/>
        ///         '2' = light sleep,<br/>
        ///         '3' = REM sleep<br/>
        ///         '4' = awake.<br/>
        ///         <br/>
        /// Example: 444423323441114
        /// </summary>
        /// <example>444423323441114</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_phase_5_min")]
        public string? SleepPhase5Min { get; set; }

        /// <summary>
        /// Effect on sleep score caused by this sleep period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score_delta")]
        public int? SleepScoreDelta { get; set; }

        /// <summary>
        /// Version of the sleep algorithm used to calculate the sleep data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_algorithm_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.SleepAlgorithmVersionJsonConverter))]
        public global::Oura.SleepAlgorithmVersion? SleepAlgorithmVersion { get; set; }

        /// <summary>
        /// The reason for the creation or update of the latest version of this sleep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_analysis_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.SleepAnalysisReasonJsonConverter))]
        public global::Oura.SleepAnalysisReason? SleepAnalysisReason { get; set; }

        /// <summary>
        /// Duration spent in bed in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_bed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeInBed { get; set; }

        /// <summary>
        /// Total sleep duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_sleep_duration")]
        public int? TotalSleepDuration { get; set; }

        /// <summary>
        /// Possible sleep period types.<br/>
        /// 'deleted' = deleted sleep by user.<br/>
        /// 'sleep' = user confirmed sleep / nap, min 15 minutes, max 3 hours, contributes to daily scores<br/>
        /// 'late_nap' = user confirmed sleep / nap, min 15 minutes, ended after sleep day change (6 pm), contributes to next days daily scores<br/>
        /// 'long_sleep' = sleep that is long enough (&gt;3h) to automatically contribute to daily scores<br/>
        /// 'rest' = Falsely detected sleep / nap, rejected in confirm prompt by user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.SleepTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.SleepType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bedtimeEnd"></param>
        /// <param name="bedtimeStart"></param>
        /// <param name="day">
        /// Day that the sleep belongs to.
        /// </param>
        /// <param name="lowBatteryAlert">
        /// Flag indicating if a low battery alert occurred.
        /// </param>
        /// <param name="period">
        /// ECore sleep period identifier.
        /// </param>
        /// <param name="timeInBed">
        /// Duration spent in bed in seconds.
        /// </param>
        /// <param name="type">
        /// Possible sleep period types.<br/>
        /// 'deleted' = deleted sleep by user.<br/>
        /// 'sleep' = user confirmed sleep / nap, min 15 minutes, max 3 hours, contributes to daily scores<br/>
        /// 'late_nap' = user confirmed sleep / nap, min 15 minutes, ended after sleep day change (6 pm), contributes to next days daily scores<br/>
        /// 'long_sleep' = sleep that is long enough (&gt;3h) to automatically contribute to daily scores<br/>
        /// 'rest' = Falsely detected sleep / nap, rejected in confirm prompt by user
        /// </param>
        /// <param name="averageBreath">
        /// Average breathing rate during sleep as breaths/second.
        /// </param>
        /// <param name="averageHeartRate">
        /// Average heart rate during sleep as beats/minute.
        /// </param>
        /// <param name="averageHrv">
        /// Average heart rate variability during sleep.
        /// </param>
        /// <param name="awakeTime">
        /// Duration spent awake in seconds.
        /// </param>
        /// <param name="deepSleepDuration">
        /// Duration spent in deep sleep in seconds.
        /// </param>
        /// <param name="efficiency">
        /// Sleep efficiency rating in range [1, 100].
        /// </param>
        /// <param name="heartRate">
        /// Object containing heart rate samples.
        /// </param>
        /// <param name="hrv"></param>
        /// <param name="latency">
        /// Sleep latency in seconds. This is the time it took for the user to fall asleep after going to bed.
        /// </param>
        /// <param name="lightSleepDuration">
        /// Duration spent in light sleep in seconds.
        /// </param>
        /// <param name="lowestHeartRate">
        /// Lowest heart rate during sleep.
        /// </param>
        /// <param name="movement30Sec">
        ///         30-second movement classification for the period where every character corresponds to:<br/>
        ///         '1' = no motion,<br/>
        ///         '2' = restless,<br/>
        ///         '3' = tossing and turning<br/>
        ///         '4' = active<br/>
        ///         <br/>
        /// Example: 1143222134
        /// </param>
        /// <param name="readiness">
        /// Object containing the readiness details for this sleep. As opposed to the daily readiness object which represents the readiness for the entire day.
        /// </param>
        /// <param name="readinessScoreDelta">
        /// Effect on readiness score caused by this sleep period.
        /// </param>
        /// <param name="remSleepDuration">
        /// Duration spent in REM sleep in seconds.
        /// </param>
        /// <param name="restlessPeriods">
        /// Number of restless periods during sleep.
        /// </param>
        /// <param name="sleepPhase5Min">
        ///         5-minute sleep phase classification for the period where every character corresponds to:<br/>
        ///         '1' = deep sleep,<br/>
        ///         '2' = light sleep,<br/>
        ///         '3' = REM sleep<br/>
        ///         '4' = awake.<br/>
        ///         <br/>
        /// Example: 444423323441114
        /// </param>
        /// <param name="sleepScoreDelta">
        /// Effect on sleep score caused by this sleep period.
        /// </param>
        /// <param name="sleepAlgorithmVersion">
        /// Version of the sleep algorithm used to calculate the sleep data.
        /// </param>
        /// <param name="sleepAnalysisReason">
        /// The reason for the creation or update of the latest version of this sleep.
        /// </param>
        /// <param name="totalSleepDuration">
        /// Total sleep duration in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepModel(
            string id,
            string bedtimeEnd,
            string bedtimeStart,
            global::System.DateTime day,
            bool lowBatteryAlert,
            int period,
            int timeInBed,
            global::Oura.SleepType type,
            double? averageBreath,
            double? averageHeartRate,
            int? averageHrv,
            int? awakeTime,
            int? deepSleepDuration,
            int? efficiency,
            global::Oura.SampleModel? heartRate,
            global::Oura.SampleModel? hrv,
            int? latency,
            int? lightSleepDuration,
            int? lowestHeartRate,
            string? movement30Sec,
            global::Oura.ReadinessSummary? readiness,
            int? readinessScoreDelta,
            int? remSleepDuration,
            int? restlessPeriods,
            string? sleepPhase5Min,
            int? sleepScoreDelta,
            global::Oura.SleepAlgorithmVersion? sleepAlgorithmVersion,
            global::Oura.SleepAnalysisReason? sleepAnalysisReason,
            int? totalSleepDuration)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AverageBreath = averageBreath;
            this.AverageHeartRate = averageHeartRate;
            this.AverageHrv = averageHrv;
            this.AwakeTime = awakeTime;
            this.BedtimeEnd = bedtimeEnd ?? throw new global::System.ArgumentNullException(nameof(bedtimeEnd));
            this.BedtimeStart = bedtimeStart ?? throw new global::System.ArgumentNullException(nameof(bedtimeStart));
            this.Day = day;
            this.DeepSleepDuration = deepSleepDuration;
            this.Efficiency = efficiency;
            this.HeartRate = heartRate;
            this.Hrv = hrv;
            this.Latency = latency;
            this.LightSleepDuration = lightSleepDuration;
            this.LowBatteryAlert = lowBatteryAlert;
            this.LowestHeartRate = lowestHeartRate;
            this.Movement30Sec = movement30Sec;
            this.Period = period;
            this.Readiness = readiness;
            this.ReadinessScoreDelta = readinessScoreDelta;
            this.RemSleepDuration = remSleepDuration;
            this.RestlessPeriods = restlessPeriods;
            this.SleepPhase5Min = sleepPhase5Min;
            this.SleepScoreDelta = sleepScoreDelta;
            this.SleepAlgorithmVersion = sleepAlgorithmVersion;
            this.SleepAnalysisReason = sleepAnalysisReason;
            this.TimeInBed = timeInBed;
            this.TotalSleepDuration = totalSleepDuration;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepModel" /> class.
        /// </summary>
        public SleepModel()
        {
        }
    }
}