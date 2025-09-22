using System.Net.Http.Json;

namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="ISecretsClient"/>を実装する部分クラスです。
/// </content>
partial class GitHubClient : ISecretsClient
{
    /// <inheritdoc/>
    async Task<PublicKey> ISecretsClient.GetPublicKeyAsync(string owner, string name, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var url = new Uri($"/repos/{owner}/{name}/actions/secrets/public-key", UriKind.Relative);
        var response = await _client.GetFromJsonAsync(url, JsonContext.Default.PublicKey, cancellationToken)
            .ConfigureAwait(false);

        return response ?? throw new InvalidOperationException("The response from the GitHub API was null.");
    }

    /// <inheritdoc/>
    async Task ISecretsClient.CreateOrUpdateAsync(string owner, string name, string secretName, Secret entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(secretName);
        ArgumentNullException.ThrowIfNull(entity);

        var url = new Uri($"/repos/{owner}/{name}/actions/secrets/{secretName}", UriKind.Relative);
        var response = await _client.PutAsJsonAsync(url, entity, JsonContext.Default.Secret, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
