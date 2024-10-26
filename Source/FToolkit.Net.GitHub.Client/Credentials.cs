namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIの認証に必要な資格情報。
/// </summary>
public sealed record Credentials
{
    /// <summary>
    /// 認証の種類。
    /// </summary>
    public AuthenticationType Type { get; init; }

    /// <summary>
    /// GitHub APIのトークン。
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// <see cref="AuthenticationType.Token"/>に設定した資格情報を返します。
    /// </summary>
    /// <param name="token">GitHub APIのトークン</param>
    public static implicit operator Credentials(string token)
        => new() { Type = AuthenticationType.Token, Token = token };

    /// <inheritdoc/>
    public override string ToString()
        => Type switch
        {
            AuthenticationType.Token => $"Token {Token}",
            AuthenticationType.Bearer => $"Bearer {Token}",
            _ => throw new ArgumentOutOfRangeException(nameof(Type))
        };
}
