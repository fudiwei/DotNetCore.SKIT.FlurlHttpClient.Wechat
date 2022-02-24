using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供境外支付子商户进件相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/Onborading_Sub_Merchant/chapter3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddSubMerchantResponse> ExecuteAddSubMerchantAsync(this WechatTenpayClient client, Models.AddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchants")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendRequestWithJsonAsync<Models.AddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchants/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/Onborading%20Sub%20Merchant/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSubMerchantResponse> ExecuteGetSubMerchantAsync(this WechatTenpayClient client, Models.GetSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "merchants", request.SubMerchantId)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sp_appid", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/Onborading_Sub_Merchant/chapter3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifySubMerchantResponse> ExecuteModifySubMerchantAsync(this WechatTenpayClient client, Models.ModifySubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, "merchants");

            return await client.SendRequestWithJsonAsync<Models.ModifySubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
