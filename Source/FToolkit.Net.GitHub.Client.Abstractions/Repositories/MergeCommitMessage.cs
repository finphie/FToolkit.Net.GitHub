using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub.Client.Repositories;

/// <summary>
/// マージにおけるコミットメッセージの種類。
/// </summary>
public enum MergeCommitMessage
{
    /// <summary>
    /// プルリクエストのタイトル
    /// </summary>
    [JsonStringEnumMemberName("PR_TITLE")]
    PullRequestTitle,

    /// <summary>
    /// プルリクエストの本文
    /// </summary>
    [JsonStringEnumMemberName("PR_BODY")]
    PullRequestBody,

    /// <summary>
    /// 空白のコミットメッセージ
    /// </summary>
    [JsonStringEnumMemberName("BLANK")]
    Blank
}
