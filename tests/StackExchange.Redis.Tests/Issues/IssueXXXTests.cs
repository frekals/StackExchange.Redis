using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace StackExchange.Redis.Tests.Issues;

public class IssueXXXTests(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _output = output;

    [Fact]
    public void Execute()
    {
        Parallel.For(0, 10, _ =>
        {
            using var conn = ConnectionMultiplexer.Connect(
                $"abortConnect=false,syncTimeout=5,{TestConfig.Current.SentinelServer},serviceName={TestConfig.Current.SentinelSeviceName}");
        });
    }
}
