using System.Net.Http.Json;
using FToolkit.Net.GitHub.Client.Entities;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IRepositoryBranchesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IRepositoryBranchesClient
{
    /// <inheritdoc/>
    IRepositoryBranchesClient IRepositoriesClient.Branch => this;

    /// <inheritdoc/>
    async Task IRepositoryBranchesClient.UpdateBranchProtectionAsync(string owner, string name, string branch, BranchProtection entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);
        ArgumentNullException.ThrowIfNull(entity);

        var response = await _client.PutAsJsonAsync(new Uri($"/repos/{owner}/{name}/branches/{branch}/protection", UriKind.Relative), entity, (System.Text.Json.Serialization.Metadata.JsonTypeInfo<BranchProtection>)JsonContext.Default.GitHubBranchProtection, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc/>
    async Task IRepositoryBranchesClient.DeleteBranchProtectionAsync(string owner, string name, string branch, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);

        var response = await _client.DeleteAsync(new Uri($"/repos/{owner}/{name}/branches/{branch}/protection", UriKind.Relative), cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
