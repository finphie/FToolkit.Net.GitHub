using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub.Client.Repositories;

/// <summary>
/// スカッシュマージにおけるコミットメッセージの種類。
/// </summary>
public enum SquashMergeCommitMessage
{
    /// <summary>
    /// プルリクエストの本文
    /// </summary>
    [JsonStringEnumMemberName("PR_BODY")]
    PullRequestBody,

    /// <summary>
    /// ブランチのコミットメッセージ
    /// </summary>
    [JsonStringEnumMemberName("COMMIT_MESSAGES")]
    CommitMessages,

    /// <summary>
    /// 空白のコミットメッセージ
    /// </summary>
    [JsonStringEnumMemberName("BLANK")]
    Blank
}
