using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微信寄快递相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteExpressExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /express/users/{openid}/transform 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_9_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TransformExpressUserOpenIdResponse> ExecuteTransformExpressUserOpenIdAsync(this WechatTenpayClient client, Models.TransformExpressUserOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "express", "users", request.OpenId, "transform");

            return await client.SendRequestWithJsonAsync<Models.TransformExpressUserOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
