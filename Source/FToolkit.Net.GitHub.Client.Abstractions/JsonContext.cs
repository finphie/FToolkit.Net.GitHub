﻿using System.Text.Json.Serialization;
using FToolkit.Net.GitHub.Client.Entities;

namespace FToolkit.Net.GitHub.Client;

/// <inheritdoc/>
[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower, GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(Repository))]
[JsonSerializable(typeof(BranchProtection))]
public sealed partial class JsonContext : JsonSerializerContext;
