using FToolkit.Net.GitHub.Client.Branches;
using FToolkit.Net.GitHub.Client.Repositories;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IRepositoriesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IRepositoriesClient
{
    /// <inheritdoc/>
    IBranchesClient IRepositoriesClient.Branch => this;

    /// <inheritdoc/>
    Task IRepositoriesClient.UpdateAsync(string owner, string name, Repository entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(entity);

        return PatchAsJsonAsync($"/repos/{owner}/{name}", entity, JsonContext.Default.Repository, cancellationToken);
    }
}
