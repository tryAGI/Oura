
#nullable enable

namespace Oura
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PersonalInfoResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public int? Age { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biological_sex")]
        public string? BiologicalSex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalInfoResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="biologicalSex"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonalInfoResponse(
            string id,
            int? age,
            double? weight,
            double? height,
            string? biologicalSex,
            string? email)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.BiologicalSex = biologicalSex;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalInfoResponse" /> class.
        /// </summary>
        public PersonalInfoResponse()
        {
        }

    }
}