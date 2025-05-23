using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteMerchantServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaints-v2 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012533431 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691285 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantServiceComplaintsResponse> ExecuteQueryMerchantServiceComplaintsAsync(this WechatTenpayClient client, Models.QueryMerchantServiceComplaintsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-service", "complaints-v2")
                .SetQueryParam("complainted_mchid", request.ComplaintedMerchantId)
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantServiceComplaintsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaints-v2/{complaint_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012533436 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691648 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantServiceComplaintByComplaintIdResponse> ExecuteGetMerchantServiceComplaintByComplaintIdAsync(this WechatTenpayClient client, Models.GetMerchantServiceComplaintByComplaintIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-service", "complaints-v2", request.ComplaintId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantServiceComplaintByComplaintIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaints-v2/{complaint_id}/negotiation-historys 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012533439 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691802 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantServiceComplaintNegotiationHistoriesResponse> ExecuteQueryMerchantServiceComplaintNegotiationHistoriesAsync(this WechatTenpayClient client, Models.QueryMerchantServiceComplaintNegotiationHistoriesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-service", "complaints-v2", request.ComplaintId, "negotiation-historys")
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantServiceComplaintNegotiationHistoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaints-v2/{complaint_id}/response 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467254 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012467213 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantServiceComplaintResponseResponse> ExecuteCreateMerchantServiceComplaintResponseAsync(this WechatTenpayClient client, Models.CreateMerchantServiceComplaintResponseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComplaintedMerchantId is null)
                request.ComplaintedMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "response");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantServiceComplaintResponseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaints-v2/{complaint_id}/complete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467255 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012467217 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetMerchantServiceComplaintCompleteResponse> ExecuteSetMerchantServiceComplaintCompleteAsync(this WechatTenpayClient client, Models.SetMerchantServiceComplaintCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComplaintedMerchantId is null)
                request.ComplaintedMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "complete");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetMerchantServiceComplaintCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaints-v2/{complaint_id}/update-refund-progress 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467256 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012467218 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMerchantServiceComplaintRefundProgressResponse> ExecuteUpdateMerchantServiceComplaintRefundProgressAsync(this WechatTenpayClient client, Models.UpdateMerchantServiceComplaintRefundProgressRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "update-refund-progress");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMerchantServiceComplaintRefundProgressResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaint-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012458679 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012458106 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantServiceComplaintNotificationResponse> ExecuteCreateMerchantServiceComplaintNotificationAsync(this WechatTenpayClient client, Models.CreateMerchantServiceComplaintNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-service", "complaint-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaint-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012459014 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012459065 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantServiceComplaintNotificationResponse> ExecuteGetMerchantServiceComplaintNotificationAsync(this WechatTenpayClient client, Models.GetMerchantServiceComplaintNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-service", "complaint-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchant-service/complaint-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012459282 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012459287 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMerchantServiceComplaintNotificationResponse> ExecuteUpdateMerchantServiceComplaintNotificationAsync(this WechatTenpayClient client, Models.UpdateMerchantServiceComplaintNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "merchant-service", "complaint-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /merchant-service/complaint-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012460452 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460474 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMerchantServiceComplaintNotificationResponse> ExecuteDeleteMerchantServiceComplaintNotificationAsync(this WechatTenpayClient client, Models.DeleteMerchantServiceComplaintNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "merchant-service", "complaint-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/images/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467250 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012467222 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantServiceImageResponse> ExecuteUploadMerchantServiceImageAsync(this WechatTenpayClient client, Models.UploadMerchantServiceImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToLower();

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-service", "images", "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadMerchantServiceImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467251 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012467223 ]]>
        /// </para>
        /// <para><i>（请注意此接口不受构造 <see cref="WechatTenpayClient" /> 时指定的 <see cref="WechatTenpayClientOptions.Endpoint"/> 参数控制。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadMerchantServiceImageResponse> ExecuteDownloadMerchantServiceImageAsync(this WechatTenpayClient client, Models.DownloadMerchantServiceImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl);

            return await client.SendFlurlRequestAsJsonAsync<Models.DownloadMerchantServiceImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
