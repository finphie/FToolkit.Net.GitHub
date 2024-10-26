namespace FToolkit.Net.GitHub.Client.Repositories;

/// <summary>
/// セキュリティ機能と分析機能に関する設定を表すクラスです。
/// </summary>
public sealed record SecurityAndAnalysis
{
    /// <summary>
    /// シークレットスキャンに関する設定。
    /// </summary>
    public SecretScanning? SecretScanning { get; init; }

    /// <summary>
    /// シークレットスキャンのプッシュ保護に関する設定。
    /// </summary>
    public SecretScanningPushProtection? SecretScanningPushProtection { get; init; }
}
