using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TrieveKnowledgeBaseVectorStoreSearchPlanSearchType>))]
public enum TrieveKnowledgeBaseVectorStoreSearchPlanSearchType
{
    [EnumMember(Value = "fulltext")]
    Fulltext,

    [EnumMember(Value = "semantic")]
    Semantic,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "bm25")]
    Bm25,
}
