using FToolkit.Net.GitHub.Client.Actions;
using FToolkit.Net.GitHub.Client.Branches;
using FToolkit.Net.GitHub.Client.Repositories;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIのクライアント。
/// </summary>
public sealed partial class GitHubClient : IGitHubClient
{
    static readonly Uri GitHubApiUrl = new("https://api.github.com/");
    readonly HttpClient _client;

    /// <summary>
    /// <see cref="GitHubClient"/>クラスの新しいインスタンスを初期化します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
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

    /// <summary>
    /// <see cref="GitHubClient"/>クラスのインスタンスを生成します。
    /// </summary>
    /// <param name="credentials">GitHub APIの認証に必要な資格情報</param>
    /// <returns><see cref="GitHubClient"/>クラスのインスタンスを返します。</returns>
    public static GitHubClient Create(Credentials credentials)
    {
        var client = CreateHttpClient();
        client.AddGitHubClientHeader(credentials);

        return new(client);
    }

    static HttpClient CreateHttpClient()
    {
        return new()
        {
            BaseAddress = GitHubApiUrl
        };
    }
}
