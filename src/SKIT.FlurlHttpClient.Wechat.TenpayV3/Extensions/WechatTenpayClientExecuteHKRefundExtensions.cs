using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供境外支付退款（For HK）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteHKRefundExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /refunds 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_2.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKRefundResponse> ExecuteCreateHKRefundAsync(this WechatTenpayClient client, Models.CreateHKRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "refunds");

            return await client.SendRequestWithJsonAsync<Models.CreateHKRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds/out-refund-no/{out_refund_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKRefundByOutRefundNumberResponse> ExecuteGetHKRefundByOutRefundNumberAsync(this WechatTenpayClient client, Models.GetHKRefundByOutRefundNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "refunds", "out-refund-no", request.OutRefundNumber)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKRefundByOutRefundNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds/id/{refund_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKRefundByIdResponse> ExecuteGetHKRefundByIdAsync(this WechatTenpayClient client, Models.GetHKRefundByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "refunds", "id", request.RefundId)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKRefundByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
