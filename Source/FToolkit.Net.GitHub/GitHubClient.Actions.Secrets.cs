using System.Net.Http.Json;
using FToolkit.Net.GitHub.Actions.Secrets;

namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="ISecretsClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : ISecretsClient
{
    /// <inheritdoc/>
    async Task<PublicKey> ISecretsClient.GetPublicKeyAsync(string owner, string name, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var response = await _client.GetFromJsonAsync($"/repos/{owner}/{name}/actions/secrets/public-key", JsonContext.Default.PublicKey, cancellationToken)
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

        var response = await _client.PutAsJsonAsync($"/repos/{owner}/{name}/actions/secrets/{secretName}", entity, JsonContext.Default.Secret, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
