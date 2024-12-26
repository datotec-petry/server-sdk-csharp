using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record TrieveKnowledgeBase
{
    /// <summary>
    /// This is the name of the knowledge base.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the plan on how to search the vector store while a call is going on.
    /// </summary>
    [JsonPropertyName("vectorStoreSearchPlan")]
    public required TrieveKnowledgeBaseVectorStoreSearchPlan VectorStoreSearchPlan { get; set; }

    /// <summary>
    /// This is the plan if you want us to create a new vector store on your behalf. To use an existing vector store from your account, use `vectoreStoreProviderId`
    /// </summary>
    [JsonPropertyName("vectorStoreCreatePlan")]
    public TrieveKnowledgeBaseVectorStoreCreatePlan? VectorStoreCreatePlan { get; set; }

    /// <summary>
    /// This is an vector store that you already have on your account with the provider. To create a new vector store, use vectorStoreCreatePlan.
    ///
    /// Usage:
    /// - To bring your own vector store from Trieve, go to https://trieve.ai
    /// - Create a dataset, and use the datasetId here.
    /// </summary>
    [JsonPropertyName("vectorStoreProviderId")]
    public string? VectorStoreProviderId { get; set; }

    /// <summary>
    /// This is the id of the knowledge base.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the org id of the knowledge base.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
