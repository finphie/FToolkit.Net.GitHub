using System.Net.Http.Json;
using System.Text.Json.Serialization.Metadata;
using FToolkit.Net.GitHub.Client.Actions;
using FToolkit.Net.GitHub.Client.Branches;
using FToolkit.Net.GitHub.Client.Repositories;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIのクライアント。
/// </summary>
public sealed partial class GitHubClient : IDisposable, IGitHubClient
{
    static readonly Uri GitHubApiUrl = new("https://api.github.com/");

    /// <summary>
    /// <see cref="GitHubClient"/>クラスの新しいインスタンスを初期化します。
    /// </summary>
    public GitHubClient()
        : this(new HttpClientHandler(), true)
    {
    }

    /// <summary>
    /// 指定されたハンドラーを使用して、<see cref="GitHubClient"/>クラスの新しいインスタンスを初期化します。
    /// </summary>
    /// <param name="handler">HTTPメッセージハンドラー。</param>
    public GitHubClient(HttpMessageHandler handler)
        : this(handler, true)
    {
    }

    /// <summary>
    /// 指定されたハンドラーとハンドラーの破棄オプションを使用して、<see cref="GitHubClient"/>クラスの新しいインスタンスを初期化します。
    /// </summary>
    /// <param name="handler">HTTPメッセージハンドラー。</param>
    /// <param name="disposeHandler">ハンドラーを破棄するかどうかを示すブール値。</param>
    public GitHubClient(HttpMessageHandler handler, bool disposeHandler)
    {
        ArgumentNullException.ThrowIfNull(handler);

        Client = new(handler, disposeHandler)
        {
            BaseAddress = GitHubApiUrl
        };
    }

    /// <summary>
    /// <see cref="HttpClient"/>クラスのインスタンス。
    /// </summary>
    public HttpClient Client { get; }

    /// <summary>
    /// GitHub APIの認証に必要な資格情報。
    /// </summary>
    public required Credentials Credentials { get; init; }

    /// <inheritdoc/>
    public IRepositoriesClient Repositories => this;

    /// <inheritdoc/>
    public IBranchesClient Branches => this;

    /// <inheritdoc/>
    public IActionsClient Actions => this;

    /// <inheritdoc/>
    public void Dispose() => Client.Dispose();

    Task PutAsJsonAsync<T>(string requestUri, T value, JsonTypeInfo<T> jsonTypeInfo, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Put, new Uri(requestUri, UriKind.Relative))
        {
            Content = JsonContent.Create(value, jsonTypeInfo)
        };

        return SendAsync(request, cancellationToken);
    }

    Task DeleteAsync(string requestUri, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(requestUri, UriKind.Relative));
        return SendAsync(request, cancellationToken);
    }

    Task PatchAsJsonAsync<T>(string requestUri, T value, JsonTypeInfo<T> jsonTypeInfo, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Patch, new Uri(requestUri, UriKind.Relative))
        {
            Content = JsonContent.Create(value, jsonTypeInfo)
        };

        return SendAsync(request, cancellationToken);
    }

    async Task SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Accept", "application/vnd.github.v3+json");
        request.Headers.Add("User-Agent", nameof(FToolkit));
        request.Headers.Add("Authorization", Credentials.ToString());
        request.Headers.Add("X-GitHub-Api-Version", "2022-11-28");

        var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return;
    }
}
