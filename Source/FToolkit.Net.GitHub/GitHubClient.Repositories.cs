using System.Net.Http.Json;

namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="IRepositoriesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IRepositoriesClient
{
    /// <inheritdoc/>
    async Task IRepositoriesClient.UpdateAsync(string owner, string name, Repository entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(entity);

        var response = await _client.PatchAsJsonAsync($"/repos/{owner}/{name}", entity, JsonContext.Default.Repository, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
