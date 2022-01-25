﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePAPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/preentrustweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPPayPreEntrustWebResponse> ExecuteCreatePAPPayPreEntrustWebAsync(this WechatTenpayClient client, Models.CreatePAPPayPreEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "preentrustweb");

            return await client.SendRequestWithXmlAsync<Models.CreatePAPPayPreEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/h5entrustweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPPayH5EntrustWebResponse> ExecuteCreatePAPPayH5EntrustWebAsync(this WechatTenpayClient client, Models.CreatePAPPayH5EntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "h5entrustweb");

            return await client.SendRequestWithXmlAsync<Models.CreatePAPPayH5EntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/contractorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateContractOrderResponse> ExecuteCreateContractOrderAsync(this WechatTenpayClient client, Models.CreateContractOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "contractorder");

            return await client.SendRequestWithXmlAsync<Models.CreateContractOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/pappayapply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPAPPayResponse> ExecuteApplyPAPPayAsync(this WechatTenpayClient client, Models.ApplyPAPPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "pappayapply");

            return await client.SendRequestWithXmlAsync<Models.ApplyPAPPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/deletecontract 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_9.shtml </para>
        /// <para>REF" https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeletePAPPayContractResponse> ExecuteDeletePAPPayContractAsync(this WechatTenpayClient client, Models.DeletePAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "deletecontract");

            return await client.SendRequestWithXmlAsync<Models.DeletePAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/querycontract 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPPayContractResponse> ExecuteGetPAPPayContractAsync(this WechatTenpayClient client, Models.GetPAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "querycontract");

            return await client.SendRequestWithXmlAsync<Models.GetPAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
