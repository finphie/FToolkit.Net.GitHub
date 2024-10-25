using FToolkit.Net.GitHub.Client.Entities;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// リポジトリのブランチ保護に関する操作を提供するインターフェイスです。
/// </summary>
public interface IRepositoryBranchesClient
{
    /// <summary>
    /// ブランチ保護に関する設定を更新します。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="branch">ブランチ名</param>
    /// <param name="entity">ブランチ保護に関する設定</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/ja/rest/branches/branch-protection?apiVersion=2022-11-28#update-branch-protection">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>このメソッドが完了すると、オブジェクトまたは値は返されません。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="branch"/>、<paramref name="entity"/>がnullです。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="branch"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    Task UpdateBranchProtectionAsync(string owner, string name, string branch, BranchProtection entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// ブランチ保護に関する設定を削除します。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="branch">ブランチ名</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/ja/rest/branches/branch-protection?apiVersion=2022-11-28#delete-branch-protection">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>このメソッドが完了すると、オブジェクトまたは値は返されません。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="branch"/>がnullです。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="branch"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    Task DeleteBranchProtectionAsync(string owner, string name, string branch, CancellationToken cancellationToken = default);
}
