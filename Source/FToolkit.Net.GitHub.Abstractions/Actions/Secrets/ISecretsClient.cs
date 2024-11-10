namespace FToolkit.Net.GitHub.Actions.Secrets;

/// <summary>
/// GitHub Actionsのシークレットに関する操作を提供するインターフェイスです。
/// </summary>
public interface ISecretsClient
{
    /// <summary>
    /// 公開キーを取得します。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/ja/rest/actions/secrets?apiVersion=2022-11-28#get-a-repository-public-key">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>公開キーを返します。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    /// <exception cref="InvalidOperationException">HTTPレスポンスが<see langword="null"/>です。</exception>
    Task<PublicKey> GetPublicKeyAsync(string owner, string name, CancellationToken cancellationToken = default);

    /// <summary>
    /// シークレットを作成または更新します。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="secretName">シークレット名</param>
    /// <param name="entity">シークレット</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/ja/rest/actions/secrets?apiVersion=2022-11-28#create-or-update-a-repository-secret">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>このメソッドが完了すると、オブジェクトまたは値は返されません。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="secretName"/>、<paramref name="entity"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="secretName"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    Task CreateOrUpdateAsync(string owner, string name, string secretName, Secret entity, CancellationToken cancellationToken = default);
}
