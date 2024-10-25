namespace FToolkit.Net.GitHub.Client.Entities;

/// <summary>
/// リポジトリに関する設定を表すクラスです。
/// </summary>
public sealed record Repository
{
    /// <summary>
    /// Issuesを有効にするかどうか。
    /// </summary>
    public bool? HasIssues { get; init; }

    /// <summary>
    /// Projectsを有効にするかどうか。
    /// </summary>
    public bool? HasProjects { get; init; }

    /// <summary>
    /// Wikiを有効にするかどうか。
    /// </summary>
    public bool? HasWiki { get; init; }

    /// <summary>
    /// Discussionsを有効にするかどうか。
    /// </summary>
    public bool? HasDiscussions { get; init; }

    /// <summary>
    /// 「Create a merge commit」を有効にするかどうか。
    /// </summary>
    public bool? AllowMergeCommit { get; init; }

    /// <summary>
    /// 「Squash Merge」を有効にするかどうか。
    /// </summary>
    public bool? AllowSquashMerge { get; init; }

    /// <summary>
    /// 「Rebase and Merge」を有効にするかどうか。
    /// </summary>
    public bool? AllowRebaseMerge { get; init; }

    /// <summary>
    /// 自動マージ機能を有効にするかどうか。
    /// </summary>
    public bool? AllowAutoMerge { get; init; }

    /// <summary>
    /// プルリクエストマージ時に、ブランチを自動的に削除するかどうか。
    /// </summary>
    public bool? DeleteBranchOnMerge { get; init; }

    /// <summary>
    /// 「Update branch」を有効にするかどうか。
    /// </summary>
    public bool? AllowUpdateBranch { get; init; }

    /// <summary>
    /// マージにおけるコミットタイトルの種類。
    /// </summary>
    public string? MergeCommitTitle { get; init; }

    /// <summary>
    /// マージにおけるコミットメッセージの種類。
    /// </summary>
    public string? MergeCommitMessage { get; init; }

    /// <summary>
    /// スカッシュマージにおけるコミットタイトルの種類。
    /// </summary>
    public string? SquashMergeCommitTitle { get; init; }

    /// <summary>
    /// スカッシュマージにおけるコミットメッセージの種類。
    /// </summary>
    public string? SquashMergeCommitMessage { get; init; }
}
