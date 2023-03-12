using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供支付即服务相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaints-v2 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_11.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_11.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant-service", "complaints-v2")
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString);

            if (request.ComplaintedMerchantId != null)
                flurlReq.SetQueryParam("complainted_mchid", request.ComplaintedMerchantId);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMerchantServiceComplaintsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaints-v2/{complaint_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_13.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_13.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant-service", "complaints-v2", request.ComplaintId);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantServiceComplaintByComplaintIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaints-v2/{complaint_id}/negotiation-historys 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_12.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant-service", "complaints-v2", request.ComplaintId, "negotiation-historys");

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMerchantServiceComplaintNegotiationHistoriesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaints-v2/{complaint_id}/response 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_14.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_14.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantServiceComplaintResponseResponse> ExecuteCreateMerchantServiceComplaintResponseAsync(this WechatTenpayClient client, Models.CreateMerchantServiceComplaintResponseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComplaintedMerchantId == null)
                request.ComplaintedMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "response");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantServiceComplaintResponseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaints-v2/{complaint_id}/complete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_15.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_15.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetMerchantServiceComplaintCompleteResponse> ExecuteSetMerchantServiceComplaintCompleteAsync(this WechatTenpayClient client, Models.SetMerchantServiceComplaintCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComplaintedMerchantId == null)
                request.ComplaintedMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "complete");

            return await client.SendRequestWithJsonAsync<Models.SetMerchantServiceComplaintCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaints-v2/{complaint_id}/update-refund-progress 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_19.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_19.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "update-refund-progress");

            return await client.SendRequestWithJsonAsync<Models.UpdateMerchantServiceComplaintRefundProgressResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/complaint-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "merchant-service", "complaint-notifications");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-service/complaint-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant-service", "complaint-notifications");

            return await client.SendRequestWithJsonAsync<Models.GetMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchant-service/complaint-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Put, "merchant-service", "complaint-notifications");

            return await client.SendRequestWithJsonAsync<Models.UpdateMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /merchant-service/complaint-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Delete, "merchant-service", "complaint-notifications");

            return await client.SendRequestWithJsonAsync<Models.DeleteMerchantServiceComplaintNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-service/images/upload 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_10.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantServiceImageResponse> ExecuteUploadMerchantServiceImageAsync(this WechatTenpayClient client, Models.UploadMerchantServiceImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash == null)
                request.FileHash = BitConverter.ToString(Utilities.SHA256Utility.Hash(request.FileBytes)).Replace("-", string.Empty).ToLower();

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-service", "images", "upload");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadMerchantServiceImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter10_2_18.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_2_18.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl);

            return await client.SendRequestWithJsonAsync<Models.DownloadMerchantServiceImageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
