namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="GitHubClient"/>クラスに関する拡張メソッドです。
/// </summary>
public static class GitHubClientExtensions
{
    /// <summary>
    /// <see cref="HttpClient"/>クラスにGitHub APIのヘッダーを追加します。
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/>クラスのインスタンス</param>
    /// <param name="credentials">GitHub APIの認証に必要な資格情報</param>
    public static void AddGitHubClientHeader(this HttpClient client, Credentials credentials)
    {
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
        client.DefaultRequestHeaders.Add("User-Agent", nameof(FToolkit));
        client.DefaultRequestHeaders.Add("Authorization", credentials.ToString());
        client.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
    }
}
