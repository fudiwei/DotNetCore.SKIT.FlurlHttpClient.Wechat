using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteHKCustomsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /customs/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/declarecustom/chapter3_1.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKCustomsOrderResponse> ExecuteCreateHKCustomsOrderAsync(this WechatTenpayClient client, Models.CreateHKCustomsOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customs", "orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateHKCustomsOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customs/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/declarecustom/chapter3_1.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryHKCustomsOrdersResponse> ExecuteQueryHKCustomsOrdersAsync(this WechatTenpayClient client, Models.QueryHKCustomsOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customs", "orders")
                .SetQueryParam("mchid", request.MerchantId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("order_type", request.OrderType)
                .SetQueryParam("order_no", request.OrderNumber)
                .SetQueryParam("customs", request.Customs);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryHKCustomsOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customs/redeclare 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/declarecustom/chapter3_4.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RedeclareHKCustomsOrderResponse> ExecuteRedeclareHKCustomsOrderAsync(this WechatTenpayClient client, Models.RedeclareHKCustomsOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customs", "redeclare");

            return await client.SendFlurlRequestAsJsonAsync<Models.RedeclareHKCustomsOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /customs/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/declarecustom/chapter3_5.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyHKCustomsOrderResponse> ExecuteModifyHKCustomsOrderAsync(this WechatTenpayClient client, Models.ModifyHKCustomsOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "customs", "orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyHKCustomsOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customs/verify-certificate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/declarecustom/chapter3_2.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.VerifyHKCustomsCertificateResponse> ExecuteVerifyHKCustomsCertificateAsync(this WechatTenpayClient client, Models.VerifyHKCustomsCertificateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customs", "verify-certificate");

            return await client.SendFlurlRequestAsJsonAsync<Models.VerifyHKCustomsCertificateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
