namespace FToolkit.Net.GitHub;

/// <summary>
/// レビューに関するブランチ保護の設定を表すクラスです。
/// </summary>
public sealed record RequiredPullRequestReviews
{
    /// <summary>
    /// 新しいコミットがプッシュされたときに、承認済みのレビューを却下するかどうか。
    /// </summary>
    public bool? DismissStaleReviews { get; init; }

    /// <summary>
    /// コード所有者のレビューが必須かどうか。
    /// </summary>
    public bool? RequireCodeOwnerReviews { get; init; }

    /// <summary>
    /// プルリクエストの承認に必要なレビュアーの数。
    /// </summary>
    public int? RequiredApprovingReviewCount { get; init; }

    /// <summary>
    /// 最新のプッシュを行ったユーザー以外が承認する必要があるかどうか。
    /// </summary>
    public bool? RequireLastPushApproval { get; init; }
}
