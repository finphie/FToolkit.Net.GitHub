using System.Net.Http.Json;
using FToolkit.Net.GitHub.Client.Entities.Repositories;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IRepositoriesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IRepositoriesClient
{
    /// <inheritdoc/>
    public IRepositoriesClient Repositories => this;

    /// <inheritdoc/>
    async Task IRepositoriesClient.UpdateAsync(string owner, string name, Repository entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(entity);

        var response = await _client.PatchAsJsonAsync(new Uri($"/repos/{owner}/{name}", UriKind.Relative), entity, JsonContext.Default.Repository, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
