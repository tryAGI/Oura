
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyActivityModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 5-minute activity classification for the activity period:<br/>
        /// * ```0```	non wear<br/>
        /// * ```1``` rest<br/>
        /// * ```2``` inactive<br/>
        /// * ```3``` low activity<br/>
        /// * ```4``` medium activity<br/>
        /// * ```5``` high activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_5_min")]
        public string? Class5Min { get; set; }

        /// <summary>
        /// Activity score in range ```[1, 100]```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Active calories expended (in kilocalories)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_calories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveCalories { get; set; }

        /// <summary>
        /// Average metabolic equivalent (MET) in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageMetMinutes { get; set; }

        /// <summary>
        /// Object defining activity score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.ActivityContributors Contributors { get; set; }

        /// <summary>
        /// Equivalent walking distance (in meters) of energy expenditure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equivalent_walking_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EquivalentWalkingDistance { get; set; }

        /// <summary>
        /// High activity metabolic equivalent (MET) in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_activity_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighActivityMetMinutes { get; set; }

        /// <summary>
        /// High activity metabolic equivalent (MET) in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_activity_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighActivityTime { get; set; }

        /// <summary>
        /// Number of inactivity alerts received
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_alerts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InactivityAlerts { get; set; }

        /// <summary>
        /// Low activity metabolic equivalent (MET) in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_activity_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LowActivityMetMinutes { get; set; }

        /// <summary>
        /// Low activity metabolic equivalent (MET) in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_activity_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LowActivityTime { get; set; }

        /// <summary>
        /// Medium activity metabolic equivalent (MET) in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium_activity_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MediumActivityMetMinutes { get; set; }

        /// <summary>
        /// Medium activity metabolic equivalent (MET) in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium_activity_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MediumActivityTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("met")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.SampleModel Met { get; set; }

        /// <summary>
        /// Remaining meters to target (from ```target_meters```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meters_to_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MetersToTarget { get; set; }

        /// <summary>
        /// The time (in seconds) in which the ring was not worn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_wear_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NonWearTime { get; set; }

        /// <summary>
        /// Resting time (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RestingTime { get; set; }

        /// <summary>
        /// Sedentary metabolic equivalent (MET) in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sedentary_met_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SedentaryMetMinutes { get; set; }

        /// <summary>
        /// Sedentary metabolic equivalent (MET) in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sedentary_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SedentaryTime { get; set; }

        /// <summary>
        /// Total number of steps taken
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Steps { get; set; }

        /// <summary>
        /// Daily activity target (in kilocalories)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_calories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetCalories { get; set; }

        /// <summary>
        /// Daily activity target (in meters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_meters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetMeters { get; set; }

        /// <summary>
        /// Total calories expended (in kilocalories)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCalories { get; set; }

        /// <summary>
        /// The ```YYYY-MM-DD``` formatted local date indicating when the daily activity occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyActivityModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activeCalories">
        /// Active calories expended (in kilocalories)
        /// </param>
        /// <param name="averageMetMinutes">
        /// Average metabolic equivalent (MET) in minutes
        /// </param>
        /// <param name="contributors">
        /// Object defining activity score contributors.
        /// </param>
        /// <param name="equivalentWalkingDistance">
        /// Equivalent walking distance (in meters) of energy expenditure
        /// </param>
        /// <param name="highActivityMetMinutes">
        /// High activity metabolic equivalent (MET) in minutes
        /// </param>
        /// <param name="highActivityTime">
        /// High activity metabolic equivalent (MET) in seconds
        /// </param>
        /// <param name="inactivityAlerts">
        /// Number of inactivity alerts received
        /// </param>
        /// <param name="lowActivityMetMinutes">
        /// Low activity metabolic equivalent (MET) in minutes
        /// </param>
        /// <param name="lowActivityTime">
        /// Low activity metabolic equivalent (MET) in seconds
        /// </param>
        /// <param name="mediumActivityMetMinutes">
        /// Medium activity metabolic equivalent (MET) in minutes
        /// </param>
        /// <param name="mediumActivityTime">
        /// Medium activity metabolic equivalent (MET) in seconds
        /// </param>
        /// <param name="met"></param>
        /// <param name="metersToTarget">
        /// Remaining meters to target (from ```target_meters```
        /// </param>
        /// <param name="nonWearTime">
        /// The time (in seconds) in which the ring was not worn
        /// </param>
        /// <param name="restingTime">
        /// Resting time (in seconds)
        /// </param>
        /// <param name="sedentaryMetMinutes">
        /// Sedentary metabolic equivalent (MET) in minutes
        /// </param>
        /// <param name="sedentaryTime">
        /// Sedentary metabolic equivalent (MET) in seconds
        /// </param>
        /// <param name="steps">
        /// Total number of steps taken
        /// </param>
        /// <param name="targetCalories">
        /// Daily activity target (in kilocalories)
        /// </param>
        /// <param name="targetMeters">
        /// Daily activity target (in meters)
        /// </param>
        /// <param name="totalCalories">
        /// Total calories expended (in kilocalories)
        /// </param>
        /// <param name="day">
        /// The ```YYYY-MM-DD``` formatted local date indicating when the daily activity occurred
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="class5Min">
        /// 5-minute activity classification for the activity period:<br/>
        /// * ```0```	non wear<br/>
        /// * ```1``` rest<br/>
        /// * ```2``` inactive<br/>
        /// * ```3``` low activity<br/>
        /// * ```4``` medium activity<br/>
        /// * ```5``` high activity
        /// </param>
        /// <param name="score">
        /// Activity score in range ```[1, 100]```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyActivityModel(
            string id,
            int activeCalories,
            double averageMetMinutes,
            global::Oura.ActivityContributors contributors,
            int equivalentWalkingDistance,
            int highActivityMetMinutes,
            int highActivityTime,
            int inactivityAlerts,
            int lowActivityMetMinutes,
            int lowActivityTime,
            int mediumActivityMetMinutes,
            int mediumActivityTime,
            global::Oura.SampleModel met,
            int metersToTarget,
            int nonWearTime,
            int restingTime,
            int sedentaryMetMinutes,
            int sedentaryTime,
            int steps,
            int targetCalories,
            int targetMeters,
            int totalCalories,
            global::System.DateTime day,
            string timestamp,
            string? class5Min,
            int? score)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Class5Min = class5Min;
            this.Score = score;
            this.ActiveCalories = activeCalories;
            this.AverageMetMinutes = averageMetMinutes;
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
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
            this.SedentaryMetMinutes = sedentaryMetMinutes;
            this.SedentaryTime = sedentaryTime;
            this.Steps = steps;
            this.TargetCalories = targetCalories;
            this.TargetMeters = targetMeters;
            this.TotalCalories = totalCalories;
            this.Day = day;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyActivityModel" /> class.
        /// </summary>
        public DailyActivityModel()
        {
        }
    }
}