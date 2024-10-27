using FToolkit.Net.GitHub.Client.Branches;
using FToolkit.Net.GitHub.Client.Branches.BranchProtection;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IBranchesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IBranchesClient
{
    /// <inheritdoc/>
    IBranchProtectionClient IBranchesClient.BranchProtection => this;
}
