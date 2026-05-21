
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining a daily activity that is a 24-hour period starting at 4 a.m.
    /// </summary>
    public sealed partial class PublicDailyActivity
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object defining the metadata of a collection model instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.Metadata Meta { get; set; }

        /// <summary>
        /// Active calories expended in kilocalories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_calories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveCalories { get; set; }

        /// <summary>
        /// Average MET minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageMetMinutes { get; set; }

        /// <summary>
        /// 5-minute activity classification for the period where every character corresponds to:<br/>
        /// '0' = non wear<br/>
        /// '1' = rest<br/>
        /// '2' = inactive<br/>
        /// '3' = low activity<br/>
        /// '4' = medium activity<br/>
        /// '5' = high activity<br/>
        /// Example: "001233334555524001".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_5_min")]
        public string? Class5Min { get; set; }

        /// <summary>
        /// Object defining activity score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicActivityContributors Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Equivalent walking distance of energe expenditure in meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equivalent_walking_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EquivalentWalkingDistance { get; set; }

        /// <summary>
        /// The total METs of each minute classified as high activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_activity_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighActivityMetMinutes { get; set; }

        /// <summary>
        /// The total time in seconds of each minute classified as high activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_activity_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighActivityTime { get; set; }

        /// <summary>
        /// Number of inactivity alerts received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_alerts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InactivityAlerts { get; set; }

        /// <summary>
        /// The total METs of each minute classified as low activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_activity_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LowActivityMetMinutes { get; set; }

        /// <summary>
        /// The total time in seconds of each minute classified as low activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_activity_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LowActivityTime { get; set; }

        /// <summary>
        /// The total METs of each minute classified as medium activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium_activity_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MediumActivityMetMinutes { get; set; }

        /// <summary>
        /// The total time in seconds of each minute classified as medium activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium_activity_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MediumActivityTime { get; set; }

        /// <summary>
        /// Object defining a recorded sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("met")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicSample Met { get; set; }

        /// <summary>
        /// Meters remaining to target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meters_to_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MetersToTarget { get; set; }

        /// <summary>
        /// Ring non-wear time in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_wear_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NonWearTime { get; set; }

        /// <summary>
        /// Resting time in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RestingTime { get; set; }

        /// <summary>
        /// Activity score in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Sedentary MET minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sedentary_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SedentaryMetMinutes { get; set; }

        /// <summary>
        /// Sedentary time in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sedentary_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SedentaryTime { get; set; }

        /// <summary>
        /// Total number of steps taken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Steps { get; set; }

        /// <summary>
        /// Daily activity target in kilocalories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_calories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetCalories { get; set; }

        /// <summary>
        /// Daily activity target in meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_meters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetMeters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Total calories expended in kilocalories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCalories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyActivity" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="meta">
        /// Object defining the metadata of a collection model instance.
        /// </param>
        /// <param name="activeCalories">
        /// Active calories expended in kilocalories.
        /// </param>
        /// <param name="averageMetMinutes">
        /// Average MET minutes.
        /// </param>
        /// <param name="contributors">
        /// Object defining activity score contributors.
        /// </param>
        /// <param name="day"></param>
        /// <param name="equivalentWalkingDistance">
        /// Equivalent walking distance of energe expenditure in meters.
        /// </param>
        /// <param name="highActivityMetMinutes">
        /// The total METs of each minute classified as high activity.
        /// </param>
        /// <param name="highActivityTime">
        /// The total time in seconds of each minute classified as high activity.
        /// </param>
        /// <param name="inactivityAlerts">
        /// Number of inactivity alerts received.
        /// </param>
        /// <param name="lowActivityMetMinutes">
        /// The total METs of each minute classified as low activity.
        /// </param>
        /// <param name="lowActivityTime">
        /// The total time in seconds of each minute classified as low activity.
        /// </param>
        /// <param name="mediumActivityMetMinutes">
        /// The total METs of each minute classified as medium activity.
        /// </param>
        /// <param name="mediumActivityTime">
        /// The total time in seconds of each minute classified as medium activity.
        /// </param>
        /// <param name="met">
        /// Object defining a recorded sample.
        /// </param>
        /// <param name="metersToTarget">
        /// Meters remaining to target.
        /// </param>
        /// <param name="nonWearTime">
        /// Ring non-wear time in seconds.
        /// </param>
        /// <param name="restingTime">
        /// Resting time in seconds.
        /// </param>
        /// <param name="sedentaryMetMinutes">
        /// Sedentary MET minutes.
        /// </param>
        /// <param name="sedentaryTime">
        /// Sedentary time in seconds.
        /// </param>
        /// <param name="steps">
        /// Total number of steps taken.
        /// </param>
        /// <param name="targetCalories">
        /// Daily activity target in kilocalories.
        /// </param>
        /// <param name="targetMeters">
        /// Daily activity target in meters.
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="totalCalories">
        /// Total calories expended in kilocalories.
        /// </param>
        /// <param name="class5Min">
        /// 5-minute activity classification for the period where every character corresponds to:<br/>
        /// '0' = non wear<br/>
        /// '1' = rest<br/>
        /// '2' = inactive<br/>
        /// '3' = low activity<br/>
        /// '4' = medium activity<br/>
        /// '5' = high activity<br/>
        /// Example: "001233334555524001".
        /// </param>
        /// <param name="score">
        /// Activity score in range [1, 100].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicDailyActivity(
            string id,
            global::Oura.Metadata meta,
            int activeCalories,
            double averageMetMinutes,
            global::Oura.PublicActivityContributors contributors,
            string day,
            int equivalentWalkingDistance,
            int highActivityMetMinutes,
            int highActivityTime,
            int inactivityAlerts,
            int lowActivityMetMinutes,
            int lowActivityTime,
            int mediumActivityMetMinutes,
            int mediumActivityTime,
            global::Oura.PublicSample met,
            int metersToTarget,
            int nonWearTime,
            int restingTime,
            int sedentaryMetMinutes,
            int sedentaryTime,
            int steps,
            int targetCalories,
            int targetMeters,
            string timestamp,
            int totalCalories,
            string? class5Min,
            int? score)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.ActiveCalories = activeCalories;
            this.AverageMetMinutes = averageMetMinutes;
            this.Class5Min = class5Min;
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.EquivalentWalkingDistance = equivalentWalkingDistance;
            this.HighActivityMetMinutes = highActivityMetMinutes;
            this.HighActivityTime = highActivityTime;
            this.InactivityAlerts = inactivityAlerts;
            this.LowActivityMetMinutes = lowActivityMetMinutes;
            this.LowActivityTime = lowActivityTime;
            this.MediumActivityMetMinutes = mediumActivityMetMinutes;
            this.MediumActivityTime = mediumActivityTime;
            this.Met = met ?? throw new global::System.ArgumentNullException(nameof(met));
            this.MetersToTarget = metersToTarget;
            this.NonWearTime = nonWearTime;
            this.RestingTime = restingTime;
            this.Score = score;
            this.SedentaryMetMinutes = sedentaryMetMinutes;
            this.SedentaryTime = sedentaryTime;
            this.Steps = steps;
            this.TargetCalories = targetCalories;
            this.TargetMeters = targetMeters;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TotalCalories = totalCalories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyActivity" /> class.
        /// </summary>
        public PublicDailyActivity()
        {
        }

    }
}