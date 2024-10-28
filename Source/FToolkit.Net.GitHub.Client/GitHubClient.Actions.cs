using FToolkit.Net.GitHub.Client.Actions;
using FToolkit.Net.GitHub.Client.Actions.Permissions;
using FToolkit.Net.GitHub.Client.Actions.Secrets;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IActionsClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IActionsClient
{
    /// <inheritdoc/>
    IPermissionsClient IActionsClient.Permissions => this;

    /// <inheritdoc/>
    ISecretsClient IActionsClient.Secrets => this;
}
