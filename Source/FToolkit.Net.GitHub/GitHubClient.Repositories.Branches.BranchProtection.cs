using System.Net.Http.Json;
using FToolkit.Net.GitHub.Branches.BranchProtection;

namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="IBranchProtectionClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IBranchProtectionClient
{
    /// <inheritdoc/>
    async Task IBranchProtectionClient.UpdateAsync(string owner, string name, string branch, BranchProtection entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);
        ArgumentNullException.ThrowIfNull(entity);

        var response = await _client.PutAsJsonAsync($"/repos/{owner}/{name}/branches/{branch}/protection", entity, JsonContext.Default.BranchProtection, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc/>
    async Task IBranchProtectionClient.DeleteAsync(string owner, string name, string branch, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);

        var response = await _client.DeleteAsync(new Uri($"/repos/{owner}/{name}/branches/{branch}/protection"), cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
