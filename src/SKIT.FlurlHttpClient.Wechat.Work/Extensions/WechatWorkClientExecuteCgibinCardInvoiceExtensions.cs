﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinCardInvoiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/getinvoiceinfo 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90284 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90420 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90902 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCardInvoiceReimburseGetInvoiceInfoResponse> ExecuteCgibinCardInvoiceReimburseGetInvoiceInfoAsync(this WechatWorkClient client, Models.CgibinCardInvoiceReimburseGetInvoiceInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "getinvoiceinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCardInvoiceReimburseGetInvoiceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/updateinvoicestatus 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90285 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90421 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90903 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCardInvoiceReimburseUpdateInvoiceStatusResponse> ExecuteCgibinCardInvoiceReimburseUpdateInvoiceStatusAsync(this WechatWorkClient client, Models.CgibinCardInvoiceReimburseUpdateInvoiceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "updateinvoicestatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCardInvoiceReimburseUpdateInvoiceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/updatestatusbatch 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90286 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90422 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90904 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCardInvoiceReimburseUpdateStatusBatchResponse> ExecuteCgibinCardInvoiceReimburseUpdateStatusBatchAsync(this WechatWorkClient client, Models.CgibinCardInvoiceReimburseUpdateStatusBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "updatestatusbatch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCardInvoiceReimburseUpdateStatusBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/getinvoiceinfobatch 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90287 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90423 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90905 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCardInvoiceReimburseGetInvoiceInfoBatchResponse> ExecuteCgibinCardInvoiceReimburseGetInvoiceInfoBatchAsync(this WechatWorkClient client, Models.CgibinCardInvoiceReimburseGetInvoiceInfoBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "getinvoiceinfobatch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCardInvoiceReimburseGetInvoiceInfoBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
