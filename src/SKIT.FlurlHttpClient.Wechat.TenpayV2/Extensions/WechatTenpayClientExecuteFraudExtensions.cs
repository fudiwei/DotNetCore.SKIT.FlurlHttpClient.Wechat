using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteFraudExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /risk/getpublickey 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/mch_pay_yhk.php?chapter=24_7&amp;index=4 </para>
        /// <para><i>（请注意此接口不受构造 <see cref="WechatTenpayClient" /> 时指定的 <see cref="WechatTenpayClientOptions.Endpoint"/> 参数控制。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRiskPublicKeyResponse> ExecuteGetRiskPublicKeyAsync(this WechatTenpayClient client, Models.GetRiskPublicKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "risk", "getpublickey")
                .WithUrl("https://fraud.mch.weixin.qq.com/risk/getpublickey");

            return await client.SendRequestWithXmlAsync<Models.GetRiskPublicKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
