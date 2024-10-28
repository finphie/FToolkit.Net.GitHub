namespace FToolkit.Net.GitHub.Client.Actions.Secrets;

/// <summary>
/// GitHub Actionsのシークレットを表すクラスです。
/// </summary>
public sealed record Secret
{
    /// <summary>
    /// 公開キーを使用して暗号化されたシークレットの値。
    /// </summary>
    public required string EncryptedValue { get; init; }

    /// <summary>
    /// 使用した公開キーのID。
    /// </summary>
    public required string KeyId { get; init; }
}
