namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIのクライアント。
/// </summary>
public sealed partial class GitHubClient : IDisposable, IGitHubClient
{
    readonly HttpClient _client;

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
        _client = new(handler, disposeHandler)
        {
            BaseAddress = GitHubApiUrl,
            DefaultRequestHeaders =
            {
                { "Accept", "application/vnd.github.v3+json" },
                { "Authorization", $"Bearer {GitHubToken}" },
                { "X-GitHub-Api-Version", "2022-11-28" }
            }
        };
    }

    /// <inheritdoc/>
    public IRepositoriesClient Repositories => this;

    /// <summary>
    /// GitHub APIにアクセスするためのトークン。
    /// </summary>
    public required string GitHubToken { get; init; }

    /// <summary>
    /// GitHub APIのベースURL。
    /// </summary>
    public Uri GitHubApiUrl { get; init; } = new("https://api.github.com/");

    /// <inheritdoc/>
    public void Dispose() => _client.Dispose();
}
