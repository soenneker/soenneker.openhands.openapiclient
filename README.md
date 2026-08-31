[![](https://img.shields.io/nuget/v/soenneker.openhands.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openhands.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openhands.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openhands.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openhands.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openhands.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openhands.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openhands.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenHands.OpenApiClient

Typed request builders and models for calling the OpenHands Cloud API from .NET.

## Installation

```bash
dotnet add package Soenneker.OpenHands.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.OpenHands.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);
adapter.BaseUrl = "https://app.all-hands.dev";

var client = new OpenHandsOpenApiClient(adapter);
var conversations = await client.Api.V1.AppConversations.Search.GetAsync(request =>
{
    request.QueryParameters.Limit = 20;
}, cancellationToken);
```

Set the request adapter's base URL before constructing the client. The generated surface includes conversations, sandboxes, repositories, configuration, secrets, integrations, and service-health endpoints.

For configuration-based credentials and managed client reuse, use [`Soenneker.OpenHands.OpenApiClientUtil`](https://github.com/soenneker/soenneker.openhands.openapiclientutil).
