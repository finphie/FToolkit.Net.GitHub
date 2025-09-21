namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="IActionsClient"/>を実装する部分クラスです。
/// </content>
partial class GitHubClient : IActionsClient
{
    /// <inheritdoc/>
    IPermissionsClient IActionsClient.Permissions => this;

    /// <inheritdoc/>
    ISecretsClient IActionsClient.Secrets => this;
}
