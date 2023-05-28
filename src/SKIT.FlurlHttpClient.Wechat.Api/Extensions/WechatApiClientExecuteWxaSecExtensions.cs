using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteWxaSecExtensions
    {
        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/upload_shipping_info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderUploadShippingInfoResponse> ExecuteWxaSecOrderUploadShippingInfoAsync(this WechatApiClient client, Models.WxaSecOrderUploadShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "upload_shipping_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderUploadShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/upload_combined_shipping_info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderUploadCombinedShippingInfoResponse> ExecuteWxaSecOrderUploadCombinedShippingInfoAsync(this WechatApiClient client, Models.WxaSecOrderUploadCombinedShippingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "upload_combined_shipping_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderUploadCombinedShippingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/notify_confirm_receive 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderNotifyConfirmReceiveResponse> ExecuteWxaSecOrderNotifyConfirmReceiveAsync(this WechatApiClient client, Models.WxaSecOrderNotifyConfirmReceiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "notify_confirm_receive")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderNotifyConfirmReceiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/set_msg_jump_path 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderSetMessageJumpPathResponse> ExecuteWxaSecOrderSetMessageJumpPathAsync(this WechatApiClient client, Models.WxaSecOrderSetMessageJumpPathRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "set_msg_jump_path")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderSetMessageJumpPathResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/is_trade_managed 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderIsTradeManagedResponse> ExecuteWxaSecOrderIsTradeManagedAsync(this WechatApiClient client, Models.WxaSecOrderIsTradeManagedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "is_trade_managed")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderIsTradeManagedResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/get_order_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderGetOrderListResponse> ExecuteWxaSecOrderGetOrderListAsync(this WechatApiClient client, Models.WxaSecOrderGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "get_order_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/order/get_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecOrderGetOrderResponse> ExecuteWxaSecOrderGetOrderAsync(this WechatApiClient client, Models.WxaSecOrderGetOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "order", "get_order")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecOrderGetOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Vod
        #region Vod/Upload
        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/singlefileupload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_1-1-%E5%8D%95%E4%B8%AA%E6%96%87%E4%BB%B6%E4%B8%8A%E4%BC%A0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodSingleFileUploadResponse> ExecuteWxaSecVodSingleFileUploadAsync(this WechatApiClient client, Models.WxaSecVodSingleFileUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "singlefileupload")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: $"{request.MediaName}.{request.MediaType}", fileBytes: request.MediaFileBytes, fileContentType: "video/mp4", formDataName: "media_data");
            if (request.CoverType != null) httpContent.Add(new StringContent(request.CoverType), "cover_type");
            if (request.CoverFileBytes != null) httpContent.Add(new ByteArrayContent(request.CoverFileBytes), "cover_data");
            if (request.SourceContext != null) httpContent.Add(new StringContent(request.SourceContext), "source_context");
            return await client.SendRequestAsync<Models.WxaSecVodSingleFileUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/pullupload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_1-2-%E6%8B%89%E5%8F%96%E4%B8%8A%E4%BC%A0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodPullUploadResponse> ExecuteWxaSecVodPullUploadAsync(this WechatApiClient client, Models.WxaSecVodPullUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "pullupload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodPullUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/gettask 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_1-3-%E6%9F%A5%E8%AF%A2%E4%BB%BB%E5%8A%A1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodGetTaskResponse> ExecuteWxaSecVodGetTaskAsync(this WechatApiClient client, Models.WxaSecVodGetTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "gettask")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodGetTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/applyupload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_1-4-%E7%94%B3%E8%AF%B7%E5%88%86%E7%89%87%E4%B8%8A%E4%BC%A0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodApplyUploadResponse> ExecuteWxaSecVodApplyUploadAsync(this WechatApiClient client, Models.WxaSecVodApplyUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "applyupload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodApplyUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/uploadpart 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_1-5-%E4%B8%8A%E4%BC%A0%E5%88%86%E7%89%87 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodUploadPartResponse> ExecuteWxaSecVodUploadPartAsync(this WechatApiClient client, Models.WxaSecVodUploadPartRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "uploadpart")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: string.Empty, fileBytes: request.FileBytes, fileContentType: "application/octet-stream", formDataName: "data");
            httpContent.Add(new StringContent(request.UploadId), "upload_id");
            httpContent.Add(new StringContent(request.PartNumber.ToString()), "part_number");
            httpContent.Add(new StringContent(request.FileType.ToString()), "resource_type");
            return await client.SendRequestAsync<Models.WxaSecVodUploadPartResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/commitupload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_1-6-%E7%A1%AE%E8%AE%A4%E4%B8%8A%E4%BC%A0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodCommitUploadResponse> ExecuteWxaSecVodCommitUploadAsync(this WechatApiClient client, Models.WxaSecVodCommitUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "commitupload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodCommitUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region /Vod/Media
        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/listmedia 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_2-1-%E8%8E%B7%E5%8F%96%E5%AA%92%E8%B5%84%E5%88%97%E8%A1%A8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodListMediaResponse> ExecuteWxaSecVodListMediaAsync(this WechatApiClient client, Models.WxaSecVodListMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "listmedia")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodListMediaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/getmedia 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_2-2-%E8%8E%B7%E5%8F%96%E5%AA%92%E8%B5%84%E8%AF%A6%E7%BB%86%E4%BF%A1%E6%81%AF </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodGetMediaResponse> ExecuteWxaSecVodGetMediaAsync(this WechatApiClient client, Models.WxaSecVodGetMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "getmedia")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodGetMediaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/getmedialink 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_2-3-%E8%8E%B7%E5%8F%96%E5%AA%92%E8%B5%84%E6%92%AD%E6%94%BE%E9%93%BE%E6%8E%A5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodGetMediaLinkResponse> ExecuteWxaSecVodGetMediaLinkAsync(this WechatApiClient client, Models.WxaSecVodGetMediaLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "getmedialink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodGetMediaLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/deletemedia 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_2-4-%E5%88%A0%E9%99%A4%E5%AA%92%E8%B5%84 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodDeleteMediaResponse> ExecuteWxaSecVodDeleteMediaAsync(this WechatApiClient client, Models.WxaSecVodDeleteMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "deletemedia")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodDeleteMediaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region /Vod/Drama
        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/auditdrama 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_3-1-%E5%89%A7%E7%9B%AE%E6%8F%90%E5%AE%A1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodAuditDramaResponse> ExecuteWxaSecVodAuditDramaAsync(this WechatApiClient client, Models.WxaSecVodAuditDramaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "auditdrama")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodAuditDramaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/listdramas 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_3-2-%E8%8E%B7%E5%8F%96%E5%89%A7%E7%9B%AE%E5%88%97%E8%A1%A8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodListDramasResponse> ExecuteWxaSecVodListDramasAsync(this WechatApiClient client, Models.WxaSecVodListDramasRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "listdramas")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodListDramasResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/sec/vod/getdrama 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_3-3-%E8%8E%B7%E5%8F%96%E5%89%A7%E7%9B%AE%E4%BF%A1%E6%81%AF </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSecVodGetDramaResponse> ExecuteWxaSecVodGetDramaAsync(this WechatApiClient client, Models.WxaSecVodGetDramaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "sec", "vod", "getdrama")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaSecVodGetDramaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion
    }
}
