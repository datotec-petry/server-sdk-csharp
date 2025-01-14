using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AzureOpenAiCredentialRegion>))]
public enum AzureOpenAiCredentialRegion
{
    [EnumMember(Value = "australia")]
    Australia,

    [EnumMember(Value = "canada")]
    Canada,

    [EnumMember(Value = "eastus2")]
    Eastus2,

    [EnumMember(Value = "eastus")]
    Eastus,

    [EnumMember(Value = "france")]
    France,

    [EnumMember(Value = "india")]
    India,

    [EnumMember(Value = "japan")]
    Japan,

    [EnumMember(Value = "uaenorth")]
    Uaenorth,

    [EnumMember(Value = "northcentralus")]
    Northcentralus,

    [EnumMember(Value = "norway")]
    Norway,

    [EnumMember(Value = "southcentralus")]
    Southcentralus,

    [EnumMember(Value = "swedencentral")]
    Swedencentral,

    [EnumMember(Value = "switzerland")]
    Switzerland,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "westus")]
    Westus,

    [EnumMember(Value = "westus3")]
    Westus3,
}
