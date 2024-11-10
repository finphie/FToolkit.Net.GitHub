using FToolkit.Net.GitHub.Actions.Permissions;
using FToolkit.Net.GitHub.Actions.Secrets;

namespace FToolkit.Net.GitHub.Actions;

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
