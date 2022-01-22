using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteFraudExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /risk/getpublickey 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/mch_pay_yhk.php?chapter=24_7&index=4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRiskPublicKeyResponse> ExecuteGetRiskPublicKeyAsync(this WechatTenpayClient client, Models.GetRiskPublicKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "risk", "getpublickey");
            flurlReq.Url = Url.Parse("https://fraud.mch.weixin.qq.com/risk/getpublickey");

            return await client.SendRequestWithXmlAsync<Models.GetRiskPublicKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
