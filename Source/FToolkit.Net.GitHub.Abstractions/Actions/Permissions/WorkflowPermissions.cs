using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub.Actions.Permissions;

/// <summary>
/// ワークフローのパーミッション。
/// </summary>
public enum WorkflowPermissions
{
    /// <summary>
    /// 読み取り権限。
    /// </summary>
    [JsonStringEnumMemberName("read")]
    Read,

    /// <summary>
    /// 書き込み権限。
    /// </summary>
    [JsonStringEnumMemberName("write")]
    Write
}
