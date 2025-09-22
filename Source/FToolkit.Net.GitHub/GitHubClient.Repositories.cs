using System.Net.Http.Json;

namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="IRepositoriesClient"/>を実装する部分クラスです。
/// </content>
partial class GitHubClient : IRepositoriesClient
{
    /// <inheritdoc/>
    async Task IRepositoriesClient.UpdateAsync(string owner, string name, Repository entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(entity);

        var url = new Uri($"/repos/{owner}/{name}", UriKind.Relative);
        var response = await _client.PatchAsJsonAsync(url, entity, JsonContext.Default.Repository, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
