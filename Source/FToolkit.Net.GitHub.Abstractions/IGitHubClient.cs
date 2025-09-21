namespace FToolkit.Net.GitHub;

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

    /// <summary>
    /// ライセンスに関する操作を提供するクライアントです。
    /// </summary>
    ILicensesClient Licenses { get; }
}
