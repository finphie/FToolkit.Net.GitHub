namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIのクライアントに関するインターフェイスです。
/// </summary>
public interface IGitHubClient
{
    /// <summary>
    /// リポジトリに関する操作を提供するクライアントです。
    /// </summary>
    IRepositoriesClient Repositories { get; }
}
