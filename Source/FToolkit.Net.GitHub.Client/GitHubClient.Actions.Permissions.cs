using FToolkit.Net.GitHub.Client.Actions.Permissions;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IPermissionsClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IPermissionsClient
{
    /// <inheritdoc/>
    Task IPermissionsClient.SetDefaultWorkflowPermissions(string owner, string name, RepositoryWorkflowPermissions entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(entity);

        return PutAsJsonAsync($"/repos/{owner}/{name}/actions/permissions/workflow", entity, JsonContext.Default.RepositoryWorkflowPermissions, cancellationToken);
    }
}
