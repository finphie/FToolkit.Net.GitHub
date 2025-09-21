namespace FToolkit.Net.GitHub;

/// <summary>
/// <see cref="IBranchesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IBranchesClient
{
    /// <inheritdoc/>
    IBranchProtectionClient IBranchesClient.BranchProtection => this;
}
