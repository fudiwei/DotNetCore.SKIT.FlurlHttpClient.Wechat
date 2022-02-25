using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供境外支付子商户进件（For HK）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteHKMerchantsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/Onborading_Sub_Merchant/chapter3_1.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定特殊的 <see cref="WechatTenpayClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddHKSubMerchantResponse> ExecuteAddHKSubMerchantAsync(this WechatTenpayClient client, Models.AddHKSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchants")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendRequestWithJsonAsync<Models.AddHKSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchants/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/Onborading%20Sub%20Merchant/chapter3_2.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定特殊的 <see cref="WechatTenpayClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKSubMerchantResponse> ExecuteGetHKSubMerchantAsync(this WechatTenpayClient client, Models.GetHKSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "merchants", request.SubMerchantId)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sp_appid", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetHKSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/Onborading_Sub_Merchant/chapter3_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定特殊的 <see cref="WechatTenpayClientOptions.Endpoints"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyHKSubMerchantResponse> ExecuteModifyHKSubMerchantAsync(this WechatTenpayClient client, Models.ModifyHKSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, "merchants");

            return await client.SendRequestWithJsonAsync<Models.ModifyHKSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
