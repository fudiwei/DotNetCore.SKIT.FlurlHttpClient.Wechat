using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat
{
    public abstract class WechatHttpCallInterceptor
    {
        public virtual Task BeforeCallAsync(FlurlCall flurlCall)
        {
            return Task.CompletedTask;
        }

        public virtual Task AfterCallAsync(FlurlCall flurlCall)
        {
            return Task.CompletedTask;
        }
    }
}
