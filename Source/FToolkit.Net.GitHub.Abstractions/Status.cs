using System.Text.Json.Serialization;

namespace FToolkit.Net.GitHub;

/// <summary>
/// 有効または無効を表す列挙型です。
/// </summary>
public enum Status
{
    /// <summary>
    /// 有効
    /// </summary>
    [JsonStringEnumMemberName("enabled")]
    Enabled,

    /// <summary>
    /// 無効
    /// </summary>
    [JsonStringEnumMemberName("disabled")]
    Disabled
}
