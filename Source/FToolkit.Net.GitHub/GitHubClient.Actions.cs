namespace FToolkit.Net.GitHub;

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
