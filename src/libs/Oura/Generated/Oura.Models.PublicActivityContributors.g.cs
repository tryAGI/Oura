
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining activity score contributors.
    /// </summary>
    public sealed partial class PublicActivityContributors
    {
        /// <summary>
        /// Contribution of meeting previous 7-day daily activity targets in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meet_daily_targets")]
        public int? MeetDailyTargets { get; set; }

        /// <summary>
        /// Contribution of previous 24-hour inactivity alerts in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("move_every_hour")]
        public int? MoveEveryHour { get; set; }

        /// <summary>
        /// Contribution of previous 7-day recovery time in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_time")]
        public int? RecoveryTime { get; set; }

        /// <summary>
        /// Contribution of previous 24-hour activity in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stay_active")]
        public int? StayActive { get; set; }

        /// <summary>
        /// Contribution of previous 7-day exercise frequency in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_frequency")]
        public int? TrainingFrequency { get; set; }

        /// <summary>
        /// Contribution of previous 7-day exercise volume in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_volume")]
        public int? TrainingVolume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicActivityContributors" /> class.
        /// </summary>
        /// <param name="meetDailyTargets">
        /// Contribution of meeting previous 7-day daily activity targets in range [1, 100].
        /// </param>
        /// <param name="moveEveryHour">
        /// Contribution of previous 24-hour inactivity alerts in range [1, 100].
        /// </param>
        /// <param name="recoveryTime">
        /// Contribution of previous 7-day recovery time in range [1, 100].
        /// </param>
        /// <param name="stayActive">
        /// Contribution of previous 24-hour activity in range [1, 100].
        /// </param>
        /// <param name="trainingFrequency">
        /// Contribution of previous 7-day exercise frequency in range [1, 100].
        /// </param>
        /// <param name="trainingVolume">
        /// Contribution of previous 7-day exercise volume in range [1, 100].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicActivityContributors(
            int? meetDailyTargets,
            int? moveEveryHour,
            int? recoveryTime,
            int? stayActive,
            int? trainingFrequency,
            int? trainingVolume)
        {
            this.MeetDailyTargets = meetDailyTargets;
            this.MoveEveryHour = moveEveryHour;
            this.RecoveryTime = recoveryTime;
            this.StayActive = stayActive;
            this.TrainingFrequency = trainingFrequency;
            this.TrainingVolume = trainingVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicActivityContributors" /> class.
        /// </summary>
        public PublicActivityContributors()
        {
        }

    }
}