namespace FToolkit.Net.GitHub;

/// <summary>
/// ライセンスに関する操作を提供するインターフェイスです。
/// </summary>
public interface ILicensesClient
{
    /// <summary>
    /// ライセンス文を取得します。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/ja/rest/licenses/licenses?apiVersion=2022-11-28#get-the-license-for-a-repository">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>ライセンス文を返します。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    Task<string> GetLicenseContentAsync(string owner, string name, CancellationToken cancellationToken = default);
}
