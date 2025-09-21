using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub;

/// <inheritdoc/>
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower,
    GenerationMode = JsonSourceGenerationMode.Metadata,
    UseStringEnumConverter = true)]
[JsonSerializable(typeof(Repository))]
[JsonSerializable(typeof(BranchProtection))]
[JsonSerializable(typeof(RepositoryWorkflowPermissions))]
[JsonSerializable(typeof(PublicKey))]
[JsonSerializable(typeof(Secret))]
public sealed partial class JsonContext : JsonSerializerContext;
