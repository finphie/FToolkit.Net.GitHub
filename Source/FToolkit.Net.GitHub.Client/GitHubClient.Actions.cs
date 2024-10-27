using FToolkit.Net.GitHub.Client.Actions;
using FToolkit.Net.GitHub.Client.Actions.Permissions;

namespace FToolkit.Net.GitHub.Client;

partial class GitHubClient : IActionsClient
{
    /// <inheritdoc/>
    IPermissionsClient IActionsClient.Permissions => this;
}
