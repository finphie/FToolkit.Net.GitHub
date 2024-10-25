namespace FToolkit.Net.GitHub.Client.Entities;

/// <summary>
/// ステータスチェックに関するブランチ保護の設定を表すクラスです。
/// </summary>
public sealed record BranchProtectionRequiredStatusChecks
{
    /// <summary>
    /// マージする前にブランチを最新にする必要があるかどうか。
    /// </summary>
    public bool Strict { get; init; }

    /// <summary>
    /// 合格する必要があるステータスチェックのリスト。
    /// </summary>
    public IReadOnlyList<string>? Contexts { get; init; }
}
