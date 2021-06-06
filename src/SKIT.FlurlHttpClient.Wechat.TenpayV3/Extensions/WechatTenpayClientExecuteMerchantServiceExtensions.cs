using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
                .CreateRequest(HttpMethod.Get, "merchant-service", "complaints-v2")
                .SetOptions(request)
                .SetQueryParam("begin_date", request.BeginDateString)
                .SetQueryParam("end_date", request.EndDateString);

            if (!string.IsNullOrEmpty(request.ComplaintedMerchantId))
                flurlReq.SetQueryParam("complainted_mchid", request.ComplaintedMerchantId);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestAsync<Models.QueryMerchantServiceComplaintsResponse>(flurlReq, cancellationToken: cancellationToken);
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
                .CreateRequest(HttpMethod.Get, "merchant-service", "complaints-v2", request.ComplaintId)
                .SetOptions(request);

            return await client.SendRequestAsync<Models.GetMerchantServiceComplaintByComplaintIdResponse>(flurlReq, cancellationToken: cancellationToken);
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
                .CreateRequest(HttpMethod.Get, "merchant-service", "complaints-v2", request.ComplaintId, "negotiation-historys")
                .SetOptions(request);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestAsync<Models.QueryMerchantServiceComplaintNegotiationHistoriesResponse>(flurlReq, cancellationToken: cancellationToken);
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

            if (string.IsNullOrEmpty(request.ComplaintedMerchantId))
                request.ComplaintedMerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "response")
                .SetOptions(request);

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

            if (string.IsNullOrEmpty(request.ComplaintedMerchantId))
                request.ComplaintedMerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant-service", "complaints-v2", request.ComplaintId, "complete")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.SetMerchantServiceComplaintCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateRequest(HttpMethod.Post, "merchant-service", "complaint-notifications")
                .SetOptions(request);

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
                .CreateRequest(HttpMethod.Get, "merchant-service", "complaint-notifications");

            return await client.SendRequestAsync<Models.GetMerchantServiceComplaintNotificationResponse>(flurlReq, cancellationToken: cancellationToken);
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
                .CreateRequest(HttpMethod.Put, "merchant-service", "complaint-notifications")
                .SetOptions(request);

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
                .CreateRequest(HttpMethod.Delete, "merchant-service", "complaint-notifications")
                .SetOptions(request);

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

            if (string.IsNullOrEmpty(request.FileName))
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (string.IsNullOrEmpty(request.FileHash))
                request.FileHash = Security.SHA256Utility.Hash(request.FileBytes).ToLower();

            if (string.IsNullOrEmpty(request.FileContentType))
            {
                if (request.FileName!.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/bmp";
                else if (request.FileName!.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else if (request.FileName!.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else
                    request.FileContentType = "image/png";
            }

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes);
            using var metaContent = new ByteArrayContent(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request)));
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(metaContent, "\"" + Constants.FormDataFields.FORMDATA_META + "\"");                        // NOTICE: meta 必须要加双引号
            httpContent.Add(fileContent, "\"file\"", "\"" + request.FileName + "\"");                                  // NOTICE: file 必须要加双引号
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary); // NOTICE: boundary 不能加引号
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant-service", "images", "upload")
                .SetOptions(request);

            return await client.SendRequestAsync<Models.UploadMerchantServiceImageResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
    }
}
