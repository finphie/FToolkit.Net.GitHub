using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub.Client.Branches.BranchProtection;

/// <summary>
/// ブランチ保護に関する設定を表すクラスです。
/// </summary>
public sealed record BranchProtection
{
    /// <summary>
    /// 管理者にも適用するかどうか。
    /// </summary>
    public bool EnforceAdmins { get; init; }

    /// <summary>
    /// 直線状の履歴を必須にするかどうか。
    /// </summary>
    public bool? RequiredLinearHistory { get; init; }

    /// <summary>
    /// 強制プッシュを許可するかどうか。
    /// </summary>
    public bool? AllowForcePushes { get; init; }

    /// <summary>
    /// プッシュアクセス権を持つユーザーが、保護されたブランチを削除できるようにするかどうか。
    /// </summary>
    public bool? AllowDeletions { get; init; }

    /// <summary>
    /// マージ前にコメントの解決を必須にするかどうか。
    /// </summary>
    public bool? RequiredConversationResolution { get; init; }

    /// <summary>
    /// ステータスチェックに関するブランチ保護の設定。
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public RequiredStatusChecks? RequiredStatusChecks { get; init; }

    /// <summary>
    /// レビューに関するブランチ保護の設定。
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public RequiredPullRequestReviews? RequiredPullRequestReviews { get; init; }

    /// <summary>
    /// 保護されたブランチにプッシュできる人のリスト。
    /// </summary>
    /// <remarks>
    /// <para>このプロパティは使用していませんが、GitHub APIリクエストの際に必要です。</para>
    /// </remarks>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    internal object? Restrictions { get; }
}
