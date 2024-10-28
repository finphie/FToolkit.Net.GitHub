# FToolkit.Net.GitHub

[![Build(.NET)](https://github.com/finphie/FToolkit.Net.GitHub/actions/workflows/build-dotnet.yml/badge.svg)](https://github.com/finphie/FToolkit.Net.GitHub/actions/workflows/build-dotnet.yml)
[![NuGet](https://img.shields.io/nuget/v/FToolkit.Net.GitHub.Client?color=0078d4&label=NuGet)](https://www.nuget.org/packages/FToolkit.Net.GitHub.Client/)
[![Azure Artifacts](https://feeds.dev.azure.com/finphie/7af9aa4d-c550-43af-87a5-01539b2d9934/_apis/public/Packaging/Feeds/DotNet/Packages/ee0345dd-768f-4ce4-a59d-70f41b5f99e0/Badge)](https://dev.azure.com/finphie/Main/_artifacts/feed/DotNet/NuGet/FToolkit.Net.GitHub.Client?preferRelease=true)

GitHub APIクライアントです。

## 説明

FToolkit.Net.GitHubは、シンプルさやAOTに考慮して実装されたGitHub APIクライアントです。

> [!Important]
> 作者が必要なAPIだけを実装しています。そのため、極一部のAPIのみの実装となっています。

> [!Warning]
> メジャーバージョンアップ以外でも破壊的変更を行うことがあります。

## インストール

### NuGet（正式リリース版）

```shell
dotnet add package FToolkit.Net.GitHub.Client
```

### Azure Artifacts（開発用ビルド）

```shell
dotnet add package FToolkit.Net.GitHub.Client -s https://pkgs.dev.azure.com/finphie/Main/_packaging/DotNet/nuget/v3/index.json
```

## サポートフレームワーク

- .NET 9

## 作者

finphie

## ライセンス

MIT

## クレジット

このプロジェクトでは、次のライブラリ等を使用しています。

### アナライザー

- [DocumentationAnalyzers](https://github.com/DotNetAnalyzers/DocumentationAnalyzers)
- [IDisposableAnalyzers](https://github.com/DotNetAnalyzers/IDisposableAnalyzers)
- [Microsoft.CodeAnalysis.NetAnalyzers](https://github.com/dotnet/roslyn-analyzers)
- [Microsoft.VisualStudio.Threading.Analyzers](https://github.com/Microsoft/vs-threading)
- [Roslynator.Analyzers](https://github.com/dotnet/roslynator)
- [Roslynator.Formatting.Analyzers](https://github.com/dotnet/roslynator)
- [StyleCop.Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
