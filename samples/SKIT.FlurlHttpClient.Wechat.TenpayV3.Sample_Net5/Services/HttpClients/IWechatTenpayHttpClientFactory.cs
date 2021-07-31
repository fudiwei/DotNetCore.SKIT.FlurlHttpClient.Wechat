using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.HttpClients
{
    public interface IWechatTenpayHttpClientFactory
    {
        WechatTenpayClient Create(string merchantId);
    }
}
