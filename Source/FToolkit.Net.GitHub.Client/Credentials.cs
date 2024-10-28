namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIの認証に必要な資格情報。
/// </summary>
/// <param name="Type">認証の種類。</param>
/// <param name="Token">GitHub APIのトークン。</param>
public sealed record Credentials(AuthenticationType Type, string Token)
{
    /// <inheritdoc/>
    public override string ToString()
        => Type switch
        {
            AuthenticationType.Token => $"Token {Token}",
            AuthenticationType.Bearer => $"Bearer {Token}",
            _ => throw new ArgumentOutOfRangeException(nameof(Type))
        };
}
