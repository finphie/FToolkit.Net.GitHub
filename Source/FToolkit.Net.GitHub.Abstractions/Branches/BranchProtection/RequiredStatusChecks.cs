namespace FToolkit.Net.GitHub.Branches.BranchProtection;

/// <summary>
/// ステータスチェックに関するブランチ保護の設定を表すクラスです。
/// </summary>
public sealed record RequiredStatusChecks
{
    /// <summary>
    /// マージする前にブランチを最新にする必要があるかどうか。
    /// </summary>
    public bool Strict { get; init; }

    /// <summary>
    /// 合格する必要があるステータスチェックのリスト。
    /// </summary>
    public IReadOnlyList<string> Contexts { get; init; } = [];
}
