namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="ILicensesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : ILicensesClient
{
    /// <inheritdoc/>
    public async Task<string> GetLicenseContentAsync(string owner, string name, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var request = new HttpRequestMessage(HttpMethod.Get, new Uri($"repos/{owner}/{name}/license"));
        request.Headers.Add("Accept", "application/vnd.github.raw+json");

        var response = await _client.SendAsync(request, cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
    }
}
