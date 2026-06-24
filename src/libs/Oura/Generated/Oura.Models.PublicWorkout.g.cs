
#nullable enable

namespace Oura
{
    /// <summary>
    /// Public model for Workout.
    /// </summary>
    public sealed partial class PublicWorkout
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of the workout activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Activity { get; set; }

        /// <summary>
        /// Energy burned in kilocalories during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Distance traveled in meters during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDatetime { get; set; }

        /// <summary>
        /// Possible workout intensities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicWorkoutIntensityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicWorkoutIntensity Intensity { get; set; }

        /// <summary>
        /// User-defined label for the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Possible workout sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicWorkoutSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicWorkoutSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDatetime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicWorkout" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="activity">
        /// Type of the workout activity.
        /// </param>
        /// <param name="day"></param>
        /// <param name="endDatetime"></param>
        /// <param name="intensity">
        /// Possible workout intensities.
        /// </param>
        /// <param name="source">
        /// Possible workout sources.
        /// </param>
        /// <param name="startDatetime"></param>
        /// <param name="calories">
        /// Energy burned in kilocalories during the workout.
        /// </param>
        /// <param name="distance">
        /// Distance traveled in meters during the workout.
        /// </param>
        /// <param name="label">
        /// User-defined label for the workout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicWorkout(
            string id,
            string activity,
            string day,
            string endDatetime,
            global::Oura.PublicWorkoutIntensity intensity,
            global::Oura.PublicWorkoutSource source,
            string startDatetime,
            double? calories,
            double? distance,
            string? label)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Activity = activity ?? throw new global::System.ArgumentNullException(nameof(activity));
            this.Calories = calories;
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Distance = distance;
            this.EndDatetime = endDatetime ?? throw new global::System.ArgumentNullException(nameof(endDatetime));
            this.Intensity = intensity;
            this.Label = label;
            this.Source = source;
            this.StartDatetime = startDatetime ?? throw new global::System.ArgumentNullException(nameof(startDatetime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicWorkout" /> class.
        /// </summary>
        public PublicWorkout()
        {
        }

    }
}