namespace FToolkit.Net.GitHub;

/// <summary>
/// リポジトリに関する操作を提供するインターフェイスです。
/// </summary>
public interface IRepositoriesClient
{
    /// <summary>
    /// リポジトリに関する設定を更新します。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="entity">リポジトリに関する設定</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/ja/rest/repos/repos?apiVersion=2022-11-28#update-a-repository">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>このメソッドが完了すると、オブジェクトまたは値は返されません。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="entity"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    Task UpdateAsync(string owner, string name, Repository entity, CancellationToken cancellationToken = default);
}
