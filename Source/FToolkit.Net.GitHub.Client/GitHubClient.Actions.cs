using FToolkit.Net.GitHub.Client.Actions;
using FToolkit.Net.GitHub.Client.Actions.Permissions;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IActionsClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IActionsClient
{
    /// <inheritdoc/>
    IPermissionsClient IActionsClient.Permissions => this;
}
