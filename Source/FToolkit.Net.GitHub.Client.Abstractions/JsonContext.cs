using System.Text.Json.Serialization;
using FToolkit.Net.GitHub.Client.Actions.Permissions;
using FToolkit.Net.GitHub.Client.Actions.Secrets;
using FToolkit.Net.GitHub.Client.Branches.BranchProtection;
using FToolkit.Net.GitHub.Client.Repositories;

namespace FToolkit.Net.GitHub.Client;

/// <inheritdoc/>
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower,
    GenerationMode = JsonSourceGenerationMode.Metadata,
    UseStringEnumConverter = true)]
[JsonSerializable(typeof(Repository))]
[JsonSerializable(typeof(BranchProtection))]
[JsonSerializable(typeof(RepositoryWorkflowPermissions))]
[JsonSerializable(typeof(Secret))]
[JsonSerializable(typeof(PublicKey))]
public sealed partial class JsonContext : JsonSerializerContext;
