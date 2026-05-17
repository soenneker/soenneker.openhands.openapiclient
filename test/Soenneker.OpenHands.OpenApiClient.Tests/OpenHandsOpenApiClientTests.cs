using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenHands.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenHandsOpenApiClientTests : HostedUnitTest
{
    public OpenHandsOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
