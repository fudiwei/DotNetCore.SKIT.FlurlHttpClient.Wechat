using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteXDCExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /xdc/apiv2getsignkey/sign/getsignkey 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=23_1&amp;index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=23_1&amp;index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=23_1&amp;index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=23_1&amp;index=2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSandboxSignKeyResponse> ExecuteGetSandboxSignKeyAsync(this WechatTenpayClient client, Models.GetSandboxSignKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "xdc", "apiv2getsignkey", "sign", "getsignkey");

            return await client.SendRequestWithXmlAsync<Models.GetSandboxSignKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
