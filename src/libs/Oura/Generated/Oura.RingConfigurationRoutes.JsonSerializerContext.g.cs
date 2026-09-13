
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Oura
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicRingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicRingConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingColor), TypeInfoPropertyName = "PublicRingColor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingDesign), TypeInfoPropertyName = "PublicRingDesign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingHardwareType), TypeInfoPropertyName = "PublicRingHardwareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicRingConfigurationMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingColor?), TypeInfoPropertyName = "NullablePublicRingColor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingDesign?), TypeInfoPropertyName = "NullablePublicRingDesign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingHardwareType?), TypeInfoPropertyName = "NullablePublicRingHardwareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>?), TypeInfoPropertyName = "NullableAnyOfMultiDocumentResponsePublicRingConfigurationMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicRingConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.AnyOf<string, int?>>))]
    internal sealed partial class RingConfigurationRoutesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RingConfigurationRoutesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RingConfigurationRoutesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RingConfigurationRoutesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Oura.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>());
            options.Converters.Add(new global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>());
            options.Converters.Add(new global::Oura.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Oura.PublicRingColor)

                    || typeToConvert == typeof(global::Oura.PublicRingColor?)

                    || typeToConvert == typeof(global::Oura.PublicRingDesign)

                    || typeToConvert == typeof(global::Oura.PublicRingDesign?)

                    || typeToConvert == typeof(global::Oura.PublicRingHardwareType)

                    || typeToConvert == typeof(global::Oura.PublicRingHardwareType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Oura.PublicRingColor))
                {
                    return new global::Oura.JsonConverters.PublicRingColorJsonConverter();
                }

                if (typeToConvert == typeof(global::Oura.PublicRingColor?))
                {
                    return new global::Oura.JsonConverters.PublicRingColorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Oura.PublicRingDesign))
                {
                    return new global::Oura.JsonConverters.PublicRingDesignJsonConverter();
                }

                if (typeToConvert == typeof(global::Oura.PublicRingDesign?))
                {
                    return new global::Oura.JsonConverters.PublicRingDesignNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Oura.PublicRingHardwareType))
                {
                    return new global::Oura.JsonConverters.PublicRingHardwareTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Oura.PublicRingHardwareType?))
                {
                    return new global::Oura.JsonConverters.PublicRingHardwareTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RingConfigurationRoutesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}