using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medallion.Threading;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.DistributedLock
{
    public interface IDistributedLockFactory
    {
        IDistributedLock Create(string lockName);
    }
}
