namespace FToolkit.Net.GitHub.Client.Actions.Permissions;

/// <summary>
/// GitHub Actionsのパーミッションに関する操作を提供するクライアントです。
/// </summary>
public interface IPermissionsClient
{
    /// <summary>
    /// GitHub Actionsのパーミッションに関する設定を行います。
    /// </summary>
    /// <param name="owner">オーナー名</param>
    /// <param name="name">リポジトリ名</param>
    /// <param name="entity">パーミッション設定</param>
    /// <param name="cancellationToken">キャンセル要求を行うためのトークン</param>
    /// <remarks>
    /// <para>詳しくは、<a href="https://docs.github.com/en/rest/actions/permissions?apiVersion=2022-11-28#set-default-workflow-permissions-for-a-repository">APIドキュメント</a>を参照してください。</para>
    /// </remarks>
    /// <returns>このメソッドが完了すると、オブジェクトまたは値は返されません。</returns>
    /// <exception cref="ArgumentNullException"><paramref name="owner"/>または<paramref name="name"/>、<paramref name="entity"/>が<see langword="null"/>です。</exception>
    /// <exception cref="ArgumentException"><paramref name="owner"/>または<paramref name="name"/>が空です。</exception>
    /// <exception cref="HttpRequestException">HTTPリクエストに失敗しました。</exception>
    Task SetDefaultWorkflowPermissionsAsync(string owner, string name, RepositoryWorkflowPermissions entity, CancellationToken cancellationToken = default);
}
