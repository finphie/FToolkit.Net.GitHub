using FToolkit.Net.GitHub.Client.Branches.BranchProtection;

namespace FToolkit.Net.GitHub.Client.Branches;

/// <summary>
/// ブランチに関する操作を提供するインターフェイスです。
/// </summary>
public interface IBranchesClient
{
    /// <summary>
    /// ブランチ保護に関する操作を提供するインターフェイスです。
    /// </summary>
    IBranchProtectionClient BranchProtection { get; }
}
