namespace FToolkit.Net.GitHub;

/// <summary>
/// GitHub APIのクライアント。
/// </summary>
public sealed partial class GitHubClient : IGitHubClient
{
    readonly HttpClient _client;

    /// <summary>
    /// <see cref="GitHubClient"/>クラスの新しいインスタンスを初期化します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    /// <exception cref="ArgumentNullException"><paramref name="client"/>が<see langword="null"/>です。</exception>
    public GitHubClient(HttpClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    /// <inheritdoc/>
    public IRepositoriesClient Repositories => this;

    /// <inheritdoc/>
    public IBranchesClient Branches => this;

    /// <inheritdoc/>
    public IActionsClient Actions => this;

    /// <inheritdoc/>
    public ILicensesClient Licenses => this;

    /// <summary>
    /// <see cref="GitHubClient"/>クラスのインスタンスを生成します。
    /// </summary>
    /// <returns><see cref="GitHubClient"/>クラスのインスタンスを返します。</returns>
    public static GitHubClient Create()
    {
        var client = CreateHttpClient();
        client.ConfigureHttpClient();

        return new(client);
    }

    /// <summary>
    /// <see cref="GitHubClient"/>クラスのインスタンスを生成します。
    /// </summary>
    /// <param name="token">GitHub APIのトークン</param>
    /// <returns><see cref="GitHubClient"/>クラスのインスタンスを返します。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="token"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="token"/>が空です。</exception>
    public static GitHubClient Create(string token)
    {
        ArgumentException.ThrowIfNullOrEmpty(token);

        var client = CreateHttpClient();
        client.ConfigureHttpClient(token);

        return new(client);
    }

    /// <summary>
    /// <see cref="GitHubClient"/>クラスのインスタンスを生成します。
    /// </summary>
    /// <param name="credentials">GitHub APIの認証に必要な資格情報</param>
    /// <returns><see cref="GitHubClient"/>クラスのインスタンスを返します。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="credentials"/>が<see langword="null"/>です。</exception>
    public static GitHubClient Create(Credentials credentials)
    {
        ArgumentNullException.ThrowIfNull(credentials);

        var client = CreateHttpClient();
        client.ConfigureHttpClient(credentials);

        return new(client);
    }

    static HttpClient CreateHttpClient() => new();
}
