using Medallion.Threading;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.DistributedLock
{
    public interface IDistributedLockFactory
    {
        IDistributedLock Create(string lockName);
    }
}
