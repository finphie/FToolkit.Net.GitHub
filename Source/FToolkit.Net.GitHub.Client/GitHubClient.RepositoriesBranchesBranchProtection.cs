﻿using System.Net.Http.Json;
using FToolkit.Net.GitHub.Client.Branches.BranchProtection;

namespace FToolkit.Net.GitHub.Client;

/// <summary>
/// <see cref="IBranchProtectionClient"/>を実装する部分クラスです。
/// </summary>
partial class GitHubClient : IBranchProtectionClient
{
    /// <inheritdoc/>
    async Task IBranchProtectionClient.UpdateBranchProtectionAsync(string owner, string name, string branch, BranchProtection entity, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);
        ArgumentNullException.ThrowIfNull(entity);

        var response = await _client.PutAsJsonAsync(new Uri($"/repos/{owner}/{name}/branches/{branch}/protection", UriKind.Relative), entity, JsonContext.Default.BranchProtection, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc/>
    async Task IBranchProtectionClient.DeleteBranchProtectionAsync(string owner, string name, string branch, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(owner);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(branch);

        var response = await _client.DeleteAsync(new Uri($"/repos/{owner}/{name}/branches/{branch}/protection", UriKind.Relative), cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
