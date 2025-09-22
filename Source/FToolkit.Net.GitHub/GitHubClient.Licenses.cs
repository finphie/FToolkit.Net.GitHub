namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="ILicensesClient"/>を実装する部分クラスです。
/// </content>
partial class GitHubClient : ILicensesClient
{
    /// <inheritdoc/>
    async Task<string> ILicensesClient.GetLicenseContentAsync(string owner, string name, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var url = new Uri($"repos/{owner}/{name}/license", UriKind.Relative);
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("Accept", "application/vnd.github.raw+json");

        var response = await _client.SendAsync(request, cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
    }
}
