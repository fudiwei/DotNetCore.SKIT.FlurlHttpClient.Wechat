using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /pay/micropay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_10&index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_10&index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/danpin.php?chapter=9_101&index=1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayMicroPayResponse> ExecuteCreatePayMicroPayAsync(this WechatTenpayClient client, Models.CreatePayMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "micropay");

            return await client.SendRequestWithXmlAsync<Models.CreatePayMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
