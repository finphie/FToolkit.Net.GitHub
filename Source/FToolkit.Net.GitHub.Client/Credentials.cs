﻿namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// GitHub APIの認証に必要な資格情報。
/// </summary>
/// <param name="Type">認証の種類。</param>
/// <param name="Token">GitHub APIのトークン。</param>
public sealed record Credentials(AuthenticationType Type, string Token)
{
    /// <summary>
    /// <see cref="AuthenticationType.Token"/>に設定した資格情報を返します。
    /// </summary>
    /// <param name="token">GitHub APIのトークン</param>
    public static implicit operator Credentials(string token)
        => new(AuthenticationType.Token, token);

    /// <inheritdoc/>
    public override string ToString()
        => Type switch
        {
            AuthenticationType.Token => $"Token {Token}",
            AuthenticationType.Bearer => $"Bearer {Token}",
            _ => throw new ArgumentOutOfRangeException(nameof(Type))
        };
}
