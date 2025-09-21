namespace FToolkit.Net.GitHub;

/// <summary>
/// GitHub Actionsに関する操作を提供するクライアントです。
/// </summary>
public interface IActionsClient
{
    /// <summary>
    /// GitHub Actionsのパーミッションに関する操作を提供するクライアントです。
    /// </summary>
    IPermissionsClient Permissions { get; }

    /// <summary>
    /// GitHub Actionsのシークレットに関する操作を提供するクライアントです。
    /// </summary>
    ISecretsClient Secrets { get; }
}
