using System.Text.Json.Serialization;
using FToolkit.Net.GitHub.Actions.Permissions;
using FToolkit.Net.GitHub.Actions.Secrets;
using FToolkit.Net.GitHub.Branches.BranchProtection;
using FToolkit.Net.GitHub.Repositories;

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
