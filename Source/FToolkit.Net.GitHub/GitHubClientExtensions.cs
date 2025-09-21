namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="GitHubClient"/>クラスに関する拡張メソッドです。
/// </summary>
public static class GitHubClientExtensions
{
    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIの設定を適用します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    public static void ConfigureHttpClient(this HttpClient client)
        => client.BaseAddress = ApiEndpoints.GitHubApiUrl;

    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIの設定を適用します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    /// <param name="token">GitHub APIのトークン</param>
    /// <exception cref="ArgumentNullException"><paramref name="token"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="token"/>が空です。</exception>
    public static void ConfigureHttpClient(this HttpClient client, string token)
    {
        ArgumentException.ThrowIfNullOrEmpty(token);
        client.ConfigureHttpClient(new Credentials(AuthenticationType.Token, token));
    }

    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIの設定を適用します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    /// <param name="credentials">GitHub APIの認証に必要な資格情報</param>
    /// <exception cref="ArgumentNullException"><paramref name="credentials"/>が<see langword="null"/>です。</exception>
    public static void ConfigureHttpClient(this HttpClient client, Credentials credentials)
    {
        ArgumentNullException.ThrowIfNull(credentials);

        client.ConfigureHttpClient();
        client.AddGitHubClientHeader(credentials);
    }

    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIのヘッダーを追加します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    public static void AddGitHubClientHeader(this HttpClient client)
    {
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
        client.DefaultRequestHeaders.Add("User-Agent", nameof(FToolkit));
        client.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
    }

    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIのヘッダーを追加します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    /// <param name="token">GitHub APIのトークン</param>
    /// <exception cref="ArgumentNullException"><paramref name="token"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="token"/>が空です。</exception>
    public static void AddGitHubClientHeader(this HttpClient client, string token)
    {
        ArgumentException.ThrowIfNullOrEmpty(token);
        client.AddGitHubClientHeader(new Credentials(AuthenticationType.Token, token));
    }

    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIのヘッダーを追加します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    /// <param name="credentials">GitHub APIの認証に必要な資格情報</param>
    /// <exception cref="ArgumentNullException"><paramref name="credentials"/>が<see langword="null"/>です。</exception>
    public static void AddGitHubClientHeader(this HttpClient client, Credentials credentials)
    {
        ArgumentNullException.ThrowIfNull(credentials);

        client.AddGitHubClientHeader();
        client.DefaultRequestHeaders.Add("Authorization", credentials.ToString());
    }
}
