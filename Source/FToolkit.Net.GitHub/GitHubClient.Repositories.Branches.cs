namespace FToolkit.Net.GitHub;

/// <content>
/// <see cref="IBranchesClient"/>を実装する部分クラスです。
/// </content>
partial class GitHubClient : IBranchesClient
{
    /// <inheritdoc/>
    IBranchProtectionClient IBranchesClient.BranchProtection => this;
}
