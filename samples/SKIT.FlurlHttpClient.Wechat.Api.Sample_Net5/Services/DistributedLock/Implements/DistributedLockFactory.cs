using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Medallion.Threading;
using Medallion.Threading.FileSystem;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.DistributedLock.Implements
{
    class DistributedLockFactory : IDistributedLockFactory
    {
        private readonly DirectoryInfo _lockFileDirectory = new DirectoryInfo(Environment.CurrentDirectory);

        public IDistributedLock Create(string lockName)
        {
            return new FileDistributedLock(_lockFileDirectory, lockName);
        }
    }
}
