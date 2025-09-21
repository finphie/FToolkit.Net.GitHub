namespace FToolkit.Net.GitHub;

/// <summary>
/// ワークフローのパーミッションを表すクラスです。
/// </summary>
public sealed record RepositoryWorkflowPermissions
{
    /// <summary>
    /// ワークフローを実行する際、GITHUB_TOKENに付与されるデフォルトの権限。
    /// </summary>
    public WorkflowPermissions? DefaultWorkflowPermissions { get; init; }

    /// <summary>
    /// GitHub Actionsがプルリクエストを承認できるかどうか。
    /// </summary>
    public bool? CanApprovePullRequestReviews { get; init; }
}
