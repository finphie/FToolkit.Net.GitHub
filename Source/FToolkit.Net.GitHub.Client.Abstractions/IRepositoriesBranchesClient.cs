namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// リポジトリのブランチに関する操作を提供するインターフェイスです。
/// </summary>
public interface IRepositoriesBranchesClient
{
    /// <summary>
    /// ブランチ保護に関する操作を提供するインターフェイスです。
    /// </summary>
    IRepositoriesBranchesBranchProtectionClient BranchProtection { get; }
}
