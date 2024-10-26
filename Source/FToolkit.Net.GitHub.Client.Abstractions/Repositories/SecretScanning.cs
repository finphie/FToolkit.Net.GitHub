namespace FToolkit.Net.GitHub.Client.Repositories;

/// <summary>
/// シークレットスキャンの設定を表すクラスです。
/// </summary>
public sealed record SecretScanning
{
    /// <summary>
    /// シークレットスキャンを有効にするかどうか。
    /// </summary>
    public Status? Status { get; init; }
}
