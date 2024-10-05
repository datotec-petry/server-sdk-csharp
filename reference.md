# Reference
## Calls
<details><summary><code>client.Calls.<a href="/src/Vapi.Net/Calls/CallsClient.cs">ListAsync</a>(CallsListRequest { ... }) -> IEnumerable<Call></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calls.ListAsync(new CallsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CallsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calls.<a href="/src/Vapi.Net/Calls/CallsClient.cs">CreateAsync</a>(CreateCallDto { ... }) -> Call</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calls.CreateAsync(new CreateCallDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateCallDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calls.<a href="/src/Vapi.Net/Calls/CallsClient.cs">GetAsync</a>(id) -> Call</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calls.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calls.<a href="/src/Vapi.Net/Calls/CallsClient.cs">DeleteAsync</a>(id) -> Call</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calls.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Calls.<a href="/src/Vapi.Net/Calls/CallsClient.cs">UpdateAsync</a>(id, UpdateCallDto { ... }) -> Call</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Calls.UpdateAsync("id", new UpdateCallDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateCallDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Assistants
<details><summary><code>client.Assistants.<a href="/src/Vapi.Net/Assistants/AssistantsClient.cs">ListAsync</a>(AssistantsListRequest { ... }) -> IEnumerable<Assistant></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assistants.ListAsync(new AssistantsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssistantsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assistants.<a href="/src/Vapi.Net/Assistants/AssistantsClient.cs">CreateAsync</a>(CreateAssistantDto { ... }) -> Assistant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assistants.CreateAsync(new CreateAssistantDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAssistantDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assistants.<a href="/src/Vapi.Net/Assistants/AssistantsClient.cs">GetAsync</a>(id) -> Assistant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assistants.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assistants.<a href="/src/Vapi.Net/Assistants/AssistantsClient.cs">DeleteAsync</a>(id) -> Assistant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assistants.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assistants.<a href="/src/Vapi.Net/Assistants/AssistantsClient.cs">UpdateAsync</a>(id, UpdateAssistantDto { ... }) -> Assistant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assistants.UpdateAsync("id", new UpdateAssistantDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateAssistantDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PhoneNumbers
<details><summary><code>client.PhoneNumbers.<a href="/src/Vapi.Net/PhoneNumbers/PhoneNumbersClient.cs">ListAsync</a>(PhoneNumbersListRequest { ... }) -> IEnumerable<OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber>></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PhoneNumbers.ListAsync(new PhoneNumbersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PhoneNumbersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PhoneNumbers.<a href="/src/Vapi.Net/PhoneNumbers/PhoneNumbersClient.cs">CreateAsync</a>(OneOf<CreateByoPhoneNumberDto, CreateTwilioPhoneNumberDto, CreateVonagePhoneNumberDto, CreateVapiPhoneNumberDto> { ... }) -> OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PhoneNumbers.CreateAsync(
    new CreateByoPhoneNumberDto { Provider = "byo-phone-number", CredentialId = "credentialId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OneOf<CreateByoPhoneNumberDto, CreateTwilioPhoneNumberDto, CreateVonagePhoneNumberDto, CreateVapiPhoneNumberDto>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PhoneNumbers.<a href="/src/Vapi.Net/PhoneNumbers/PhoneNumbersClient.cs">GetAsync</a>(id) -> OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PhoneNumbers.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PhoneNumbers.<a href="/src/Vapi.Net/PhoneNumbers/PhoneNumbersClient.cs">DeleteAsync</a>(id) -> OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PhoneNumbers.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PhoneNumbers.<a href="/src/Vapi.Net/PhoneNumbers/PhoneNumbersClient.cs">UpdateAsync</a>(id, UpdatePhoneNumberDto { ... }) -> OneOf<ByoPhoneNumber, TwilioPhoneNumber, VonagePhoneNumber, VapiPhoneNumber></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PhoneNumbers.UpdateAsync("id", new UpdatePhoneNumberDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdatePhoneNumberDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Squads
<details><summary><code>client.Squads.<a href="/src/Vapi.Net/Squads/SquadsClient.cs">ListAsync</a>(SquadsListRequest { ... }) -> IEnumerable<Squad></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Squads.ListAsync(new SquadsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SquadsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Squads.<a href="/src/Vapi.Net/Squads/SquadsClient.cs">CreateAsync</a>(CreateSquadDto { ... }) -> Squad</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Squads.CreateAsync(
    new CreateSquadDto { Members = new List<SquadMemberDto>() { new SquadMemberDto() } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSquadDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Squads.<a href="/src/Vapi.Net/Squads/SquadsClient.cs">GetAsync</a>(id) -> Squad</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Squads.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Squads.<a href="/src/Vapi.Net/Squads/SquadsClient.cs">DeleteAsync</a>(id) -> Squad</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Squads.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Squads.<a href="/src/Vapi.Net/Squads/SquadsClient.cs">UpdateAsync</a>(id, UpdateSquadDto { ... }) -> Squad</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Squads.UpdateAsync(
    "id",
    new UpdateSquadDto { Members = new List<SquadMemberDto>() { new SquadMemberDto() } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateSquadDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Blocks
<details><summary><code>client.Blocks.<a href="/src/Vapi.Net/Blocks/BlocksClient.cs">ListAsync</a>(BlocksListRequest { ... }) -> IEnumerable<OneOf<ConversationBlock, ToolCallBlock, WorkflowBlock>></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Blocks.ListAsync(new BlocksListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BlocksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Blocks.<a href="/src/Vapi.Net/Blocks/BlocksClient.cs">CreateAsync</a>(OneOf<CreateConversationBlockDto, CreateToolCallBlockDto, CreateWorkflowBlockDto> { ... }) -> OneOf<ConversationBlock, ToolCallBlock, WorkflowBlock></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Blocks.CreateAsync(
    new CreateConversationBlockDto { Type = "conversation", Instruction = "instruction" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OneOf<CreateConversationBlockDto, CreateToolCallBlockDto, CreateWorkflowBlockDto>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Blocks.<a href="/src/Vapi.Net/Blocks/BlocksClient.cs">GetAsync</a>(id) -> OneOf<ConversationBlock, ToolCallBlock, WorkflowBlock></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Blocks.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Blocks.<a href="/src/Vapi.Net/Blocks/BlocksClient.cs">DeleteAsync</a>(id) -> OneOf<ConversationBlock, ToolCallBlock, WorkflowBlock></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Blocks.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Blocks.<a href="/src/Vapi.Net/Blocks/BlocksClient.cs">UpdateAsync</a>(id, UpdateBlockDto { ... }) -> OneOf<ConversationBlock, ToolCallBlock, WorkflowBlock></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Blocks.UpdateAsync("id", new UpdateBlockDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateBlockDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tools
<details><summary><code>client.Tools.<a href="/src/Vapi.Net/Tools/ToolsClient.cs">ListAsync</a>(ToolsListRequest { ... }) -> IEnumerable<OneOf<DtmfTool, EndCallTool, FunctionTool, GhlTool, MakeTool, TransferCallTool, OutputTool>></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tools.ListAsync(new ToolsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ToolsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tools.<a href="/src/Vapi.Net/Tools/ToolsClient.cs">CreateAsync</a>(OneOf<CreateDtmfToolDto, CreateEndCallToolDto, CreateFunctionToolDto, CreateGhlToolDto, CreateMakeToolDto, CreateTransferCallToolDto, CreateOutputToolDto> { ... }) -> OneOf<DtmfTool, EndCallTool, FunctionTool, GhlTool, MakeTool, TransferCallTool, OutputTool></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tools.CreateAsync(new CreateDtmfToolDto { Type = "dtmf" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OneOf<CreateDtmfToolDto, CreateEndCallToolDto, CreateFunctionToolDto, CreateGhlToolDto, CreateMakeToolDto, CreateTransferCallToolDto, CreateOutputToolDto>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tools.<a href="/src/Vapi.Net/Tools/ToolsClient.cs">GetAsync</a>(id) -> OneOf<DtmfTool, EndCallTool, FunctionTool, GhlTool, MakeTool, TransferCallTool, OutputTool></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tools.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tools.<a href="/src/Vapi.Net/Tools/ToolsClient.cs">DeleteAsync</a>(id) -> OneOf<DtmfTool, EndCallTool, FunctionTool, GhlTool, MakeTool, TransferCallTool, OutputTool></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tools.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tools.<a href="/src/Vapi.Net/Tools/ToolsClient.cs">UpdateAsync</a>(id, UpdateToolDto { ... }) -> OneOf<DtmfTool, EndCallTool, FunctionTool, GhlTool, MakeTool, TransferCallTool, OutputTool></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tools.UpdateAsync("id", new UpdateToolDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateToolDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Files
<details><summary><code>client.Files.<a href="/src/Vapi.Net/Files/FilesClient.cs">ListAsync</a>() -> IEnumerable<File></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/Vapi.Net/Files/FilesClient.cs">GetAsync</a>(id) -> File</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/Vapi.Net/Files/FilesClient.cs">DeleteAsync</a>(id) -> File</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Files.<a href="/src/Vapi.Net/Files/FilesClient.cs">UpdateAsync</a>(id, UpdateFileDto { ... }) -> File</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Files.UpdateAsync("id", new UpdateFileDto());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateFileDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Analytics
<details><summary><code>client.Analytics.<a href="/src/Vapi.Net/Analytics/AnalyticsClient.cs">GetAsync</a>(AnalyticsQueryDto { ... }) -> IEnumerable<AnalyticsQueryResult></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Analytics.GetAsync(
    new AnalyticsQueryDto
    {
        Queries = new List<AnalyticsQuery>()
        {
            new AnalyticsQuery
            {
                Table = "call",
                Name = "name",
                Operations = new List<AnalyticsOperation>()
                {
                    new AnalyticsOperation
                    {
                        Operation = AnalyticsOperationOperation.Sum,
                        Column = AnalyticsOperationColumn.Id,
                    },
                },
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnalyticsQueryDto` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Logs
<details><summary><code>client.Logs.<a href="/src/Vapi.Net/Logs/LogsClient.cs">GetAsync</a>(LogsGetRequest { ... }) -> LogsPaginatedResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Logs.GetAsync(new LogsGetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LogsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
