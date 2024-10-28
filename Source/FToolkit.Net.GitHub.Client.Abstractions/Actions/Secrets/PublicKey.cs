namespace FToolkit.Net.GitHub.Client.Actions.Secrets;

/// <summary>
/// 公開キー
/// </summary>
public sealed record PublicKey
{
    /// <summary>
    /// 公開キーのID
    /// </summary>
    public required string KeyId { get; init; }

    /// <summary>
    /// 公開キー
    /// </summary>
    public required string Key { get; init; }
}
