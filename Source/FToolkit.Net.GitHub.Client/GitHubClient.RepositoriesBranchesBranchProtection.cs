using FToolkit.Net.GitHub.Client.Branches.BranchProtection;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IBranchProtectionClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IBranchProtectionClient
{
    /// <inheritdoc/>
    Task IBranchProtectionClient.UpdateAsync(string owner, string name, string branch, BranchProtection entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);
        ArgumentNullException.ThrowIfNull(entity);

        return PutAsJsonAsync($"/repos/{owner}/{name}/branches/{branch}/protection", entity, JsonContext.Default.BranchProtection, cancellationToken);
    }

    /// <inheritdoc/>
    Task IBranchProtectionClient.DeleteAsync(string owner, string name, string branch, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);

        return DeleteAsync($"/repos/{owner}/{name}/branches/{branch}/protection", cancellationToken);
    }
}
