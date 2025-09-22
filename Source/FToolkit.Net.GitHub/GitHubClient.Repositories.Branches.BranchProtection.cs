using System.Net.Http.Json;

namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="IBranchProtectionClient"/>を実装する部分クラスです。
/// </content>
partial class GitHubClient : IBranchProtectionClient
{
    /// <inheritdoc/>
    async Task IBranchProtectionClient.UpdateAsync(string owner, string name, string branch, BranchProtection entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);
        ArgumentNullException.ThrowIfNull(entity);

        var url = new Uri($"/repos/{owner}/{name}/branches/{branch}/protection", UriKind.Relative);
        var response = await _client.PutAsJsonAsync(url, entity, JsonContext.Default.BranchProtection, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc/>
    async Task IBranchProtectionClient.DeleteAsync(string owner, string name, string branch, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);

        var url = new Uri($"/repos/{owner}/{name}/branches/{branch}/protection", UriKind.Relative);
        var response = await _client.DeleteAsync(url, cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
