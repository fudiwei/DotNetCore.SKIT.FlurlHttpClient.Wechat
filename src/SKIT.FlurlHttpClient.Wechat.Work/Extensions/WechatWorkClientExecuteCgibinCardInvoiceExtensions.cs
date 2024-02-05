using System;
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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90284 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90420 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90902 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "getinvoiceinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCardInvoiceReimburseGetInvoiceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/updateinvoicestatus 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90285 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90421 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90903 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "updateinvoicestatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCardInvoiceReimburseUpdateInvoiceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/updatestatusbatch 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90286 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90422 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90904 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "updatestatusbatch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCardInvoiceReimburseUpdateStatusBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/card/invoice/reimburse/getinvoiceinfobatch 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90287 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90423 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90905 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "card", "invoice", "reimburse", "getinvoiceinfobatch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCardInvoiceReimburseGetInvoiceInfoBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
