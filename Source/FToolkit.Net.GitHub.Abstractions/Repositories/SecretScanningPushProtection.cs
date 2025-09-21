namespace FToolkit.Net.GitHub;

/// <summary>
/// シークレットスキャンのプッシュ保護に関する設定を表すクラスです。
/// </summary>
public sealed record SecretScanningPushProtection
{
    /// <summary>
    /// シークレットスキャンのプッシュ保護を有効にするかどうか。
    /// </summary>
    public Status? Status { get; init; }
}
