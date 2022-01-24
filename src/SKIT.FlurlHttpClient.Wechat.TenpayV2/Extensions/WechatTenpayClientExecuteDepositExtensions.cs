﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteDepositExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /deposit/unifiedorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_7&index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_8&index=3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateDepositUnifiedOrderResponse> ExecuteCreateDepositUnifiedOrderAsync(this WechatTenpayClient client, Models.CreateDepositUnifiedOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "unifiedorder");

            return await client.SendRequestWithXmlAsync<Models.CreateDepositUnifiedOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/micropay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_1&index=6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateDepositMicroPayResponse> ExecuteCreateDepositMicroPayAsync(this WechatTenpayClient client, Models.CreateDepositMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "micropay");

            return await client.SendRequestWithXmlAsync<Models.CreateDepositMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/facepay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_0&index=5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateDepositFacePayResponse> ExecuteCreateDepositFacePayAsync(this WechatTenpayClient client, Models.CreateDepositFacePayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "facepay");

            return await client.SendRequestWithXmlAsync<Models.CreateDepositFacePayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/orderquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_2&index=7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetDepositOrderResponse> ExecuteGetDepositOrderAsync(this WechatTenpayClient client, Models.GetDepositOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "orderquery");

            return await client.SendRequestWithXmlAsync<Models.GetDepositOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_3&index=8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseDepositOrderResponse> ExecuteReverseDepositOrderAsync(this WechatTenpayClient client, Models.ReverseDepositOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "reverse");

            return await client.SendRequestWithXmlAsync<Models.ReverseDepositOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/consume 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_4&index=9 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ConsumeDepositResponse> ExecuteConsumeDepositAsync(this WechatTenpayClient client, Models.ConsumeDepositRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "consume");

            return await client.SendRequestWithXmlAsync<Models.ConsumeDepositResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/refund 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_5&index=10 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateDepositRefundResponse> ExecuteCreateDepositRefundAsync(this WechatTenpayClient client, Models.CreateDepositRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "refund");

            return await client.SendRequestWithXmlAsync<Models.CreateDepositRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /deposit/refundquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_6&index=11 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetDepositRefundResponse> ExecuteGetDepositRefundAsync(this WechatTenpayClient client, Models.GetDepositRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "deposit", "refundquery");

            return await client.SendRequestWithXmlAsync<Models.GetDepositRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
