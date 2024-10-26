namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IRepositoriesBranchesClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IRepositoriesBranchesClient
{
    /// <inheritdoc/>
    IRepositoriesBranchesBranchProtectionClient IRepositoriesBranchesClient.BranchProtection => this;
}
