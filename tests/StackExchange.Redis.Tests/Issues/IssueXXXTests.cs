using System.Threading.Tasks;

namespace StackExchange.Redis.Tests.Issues;

public class IssueXXXTests()
{
    [Fact]
    public void Execute()
    {
        Parallel.For(0, 100, _ =>
        {
            using var conn = ConnectionMultiplexer.Connect(
                $"abortConnect=false,syncTimeout=1,{TestConfig.Current.SentinelServer},serviceName={TestConfig.Current.SentinelSeviceName}");
        });
    }
}
