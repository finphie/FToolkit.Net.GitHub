using System.Net.Http.Json;
using FToolkit.Net.GitHub.Actions.Permissions;

namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="IPermissionsClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IPermissionsClient
{
    /// <inheritdoc/>
    async Task IPermissionsClient.SetDefaultWorkflowPermissionsAsync(string owner, string name, RepositoryWorkflowPermissions entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(entity);

        var response = await _client.PutAsJsonAsync($"/repos/{owner}/{name}/actions/permissions/workflow", entity, JsonContext.Default.RepositoryWorkflowPermissions, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
