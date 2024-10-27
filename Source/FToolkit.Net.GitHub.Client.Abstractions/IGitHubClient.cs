using FToolkit.Net.GitHub.Client.Actions;
using FToolkit.Net.GitHub.Client.Branches;
using FToolkit.Net.GitHub.Client.Repositories;

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

    /// <summary>
    /// ブランチに関する操作を提供するクライアントです。
    /// </summary>
    IBranchesClient Branches { get; }

    /// <summary>
    /// GitHub Actionsのパーミッションに関する操作を提供するクライアントです。
    /// </summary>
    IActionsClient Actions { get; }
}
