using System.Net.Http.Json;

namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="IPermissionsClient"/>を実装する部分クラスです。
/// </content>
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
