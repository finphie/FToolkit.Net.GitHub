using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub.Repositories;

/// <summary>
/// スカッシュマージにおけるコミットタイトルの種類。
/// </summary>
public enum SquashMergeCommitTitle
{
    /// <summary>
    /// プルリクエストのタイトル
    /// </summary>
    [JsonStringEnumMemberName("PR_TITLE")]
    PullRequestTitle,

    /// <summary>
    /// コミットが1つだけの場合はコミットのタイトル。
    /// 複数のコミットがある場合はプルリクエストのタイトル。
    /// </summary>
    [JsonStringEnumMemberName("COMMIT_OR_PR_TITLE")]
    CommitOrPullRequestTitle
}
