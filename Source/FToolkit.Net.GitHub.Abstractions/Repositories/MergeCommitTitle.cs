using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub.Repositories;

/// <summary>
/// マージにおけるコミットタイトルの種類。
/// </summary>
public enum MergeCommitTitle
{
    /// <summary>
    /// プルリクエストのタイトル
    /// </summary>
    [JsonStringEnumMemberName("PR_TITLE")]
    PullRequestTitle,

    /// <summary>
    /// マージメッセージのデフォルトのタイトル
    /// </summary>
    /// <remarks>
    /// <para>
    /// <example>
    /// Merge pull request #123 from branch-name
    /// </example>
    /// </para>
    /// </remarks>
    [JsonStringEnumMemberName("MERGE_MESSAGE")]
    MergeMessage
}
