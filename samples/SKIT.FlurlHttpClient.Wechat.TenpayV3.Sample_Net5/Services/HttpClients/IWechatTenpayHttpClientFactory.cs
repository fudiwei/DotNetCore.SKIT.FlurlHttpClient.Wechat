using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.HttpClients
{
    public interface IWechatTenpayHttpClientFactory
    {
        /// <summary>
        /// 获取第一个配置普通商户或服务商商户
        /// </summary>
        /// <param name="isServiceProvider"></param>
        /// <returns></returns>
        WechatTenpayClient Create(bool isServiceProvider = false);
        WechatTenpayClient Create(string merchantId);
    }
}
