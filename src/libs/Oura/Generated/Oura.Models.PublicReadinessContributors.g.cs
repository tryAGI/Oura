
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining readiness score contributors.
    /// </summary>
    public sealed partial class PublicReadinessContributors
    {
        /// <summary>
        /// Contribution of cumulative activity balance in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_balance")]
        public int? ActivityBalance { get; set; }

        /// <summary>
        /// Contribution of body temperature in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_temperature")]
        public int? BodyTemperature { get; set; }

        /// <summary>
        /// Contribution of heart rate variability balance in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_balance")]
        public int? HrvBalance { get; set; }

        /// <summary>
        /// Contribution of previous day's activity in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_day_activity")]
        public int? PreviousDayActivity { get; set; }

        /// <summary>
        /// Contribution of previous night's sleep in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_night")]
        public int? PreviousNight { get; set; }

        /// <summary>
        /// Contribution of recovery index in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_index")]
        public int? RecoveryIndex { get; set; }

        /// <summary>
        /// Contribution of resting heart rate in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_heart_rate")]
        public int? RestingHeartRate { get; set; }

        /// <summary>
        /// Contribution of sleep balance in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_balance")]
        public int? SleepBalance { get; set; }

        /// <summary>
        /// Contribution of sleep regularity in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_regularity")]
        public int? SleepRegularity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicReadinessContributors" /> class.
        /// </summary>
        /// <param name="activityBalance">
        /// Contribution of cumulative activity balance in range [1, 100].
        /// </param>
        /// <param name="bodyTemperature">
        /// Contribution of body temperature in range [1, 100].
        /// </param>
        /// <param name="hrvBalance">
        /// Contribution of heart rate variability balance in range [1, 100].
        /// </param>
        /// <param name="previousDayActivity">
        /// Contribution of previous day's activity in range [1, 100].
        /// </param>
        /// <param name="previousNight">
        /// Contribution of previous night's sleep in range [1, 100].
        /// </param>
        /// <param name="recoveryIndex">
        /// Contribution of recovery index in range [1, 100].
        /// </param>
        /// <param name="restingHeartRate">
        /// Contribution of resting heart rate in range [1, 100].
        /// </param>
        /// <param name="sleepBalance">
        /// Contribution of sleep balance in range [1, 100].
        /// </param>
        /// <param name="sleepRegularity">
        /// Contribution of sleep regularity in range [1, 100].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicReadinessContributors(
            int? activityBalance,
            int? bodyTemperature,
            int? hrvBalance,
            int? previousDayActivity,
            int? previousNight,
            int? recoveryIndex,
            int? restingHeartRate,
            int? sleepBalance,
            int? sleepRegularity)
        {
            this.ActivityBalance = activityBalance;
            this.BodyTemperature = bodyTemperature;
            this.HrvBalance = hrvBalance;
            this.PreviousDayActivity = previousDayActivity;
            this.PreviousNight = previousNight;
            this.RecoveryIndex = recoveryIndex;
            this.RestingHeartRate = restingHeartRate;
            this.SleepBalance = sleepBalance;
            this.SleepRegularity = sleepRegularity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicReadinessContributors" /> class.
        /// </summary>
        public PublicReadinessContributors()
        {
        }
    }
}