using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.HttpClients
{
    public interface IWechatApiHttpClientFactory
    {
        WechatApiClient Create(string appId);
    }
}
