using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Oura;

#pragma warning disable CS1591

public sealed partial class SourceGenerationContext
{
    private static SourceGenerationContext? s_default;

    public static SourceGenerationContext Default => s_default ??= new SourceGenerationContext(new JsonSerializerOptions());

    public SourceGenerationContext()
        : base(null)
    {
    }

    public SourceGenerationContext(JsonSerializerOptions? options)
        : base(options)
    {
    }

    protected override JsonSerializerOptions? GeneratedSerializerOptions => Options;

    public override JsonTypeInfo? GetTypeInfo(Type type) => null;
}

#pragma warning restore CS1591
