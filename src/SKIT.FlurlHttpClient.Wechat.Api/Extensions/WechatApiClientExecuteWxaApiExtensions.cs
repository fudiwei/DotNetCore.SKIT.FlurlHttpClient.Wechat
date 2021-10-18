using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteWxaApiExtensions
    {
        #region NewTemplate
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/newtmpl/addtemplate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#addTemplate%E9%80%89%E7%94%A8%E6%A8%A1%E6%9D%BF </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/subscribe-message/subscribeMessage.addTemplate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateAddTemplateResponse> ExecuteWxaApiNewTemplateAddTemplateAsync(this WechatApiClient client, Models.WxaApiNewTemplateAddTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "newtmpl", "addtemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiNewTemplateAddTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/newtmpl/deltemplate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#deleteTemplate%E5%88%A0%E9%99%A4%E6%A8%A1%E6%9D%BF </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/subscribe-message/subscribeMessage.deleteTemplate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateDeleteTemplateResponse> ExecuteWxaApiNewTemplateDeleteTemplateAsync(this WechatApiClient client, Models.WxaApiNewTemplateDeleteTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "newtmpl", "deltemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiNewTemplateDeleteTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/getcategory 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#getCategory%E8%8E%B7%E5%8F%96%E5%85%AC%E4%BC%97%E5%8F%B7%E7%B1%BB%E7%9B%AE </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/subscribe-message/subscribeMessage.getCategory.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetCategoryResponse> ExecuteWxaApiNewTemplateGetCategoryAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "getcategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiNewTemplateGetCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/getpubtemplatekeywords 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#getPubTemplateKeyWordsById%E8%8E%B7%E5%8F%96%E6%A8%A1%E6%9D%BF%E4%B8%AD%E7%9A%84%E5%85%B3%E9%94%AE%E8%AF%8D </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/subscribe-message/subscribeMessage.getPubTemplateKeyWordsById.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetPublicTemplateKeywordsResponse> ExecuteWxaApiNewTemplateGetPublicTemplateKeywordsAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetPublicTemplateKeywordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "getpubtemplatekeywords")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tid", request.TemplateTitleId);

            return await client.SendRequestWithJsonAsync<Models.WxaApiNewTemplateGetPublicTemplateKeywordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/getpubtemplatetitles 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#getPubTemplateTitleList%E8%8E%B7%E5%8F%96%E7%B1%BB%E7%9B%AE%E4%B8%8B%E7%9A%84%E5%85%AC%E5%85%B1%E6%A8%A1%E6%9D%BF </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/subscribe-message/subscribeMessage.getPubTemplateTitleList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetPublicTemplateTitlesResponse> ExecuteWxaApiNewTemplateGetPublicTemplateTitlesAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetPublicTemplateTitlesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "getpubtemplatetitles")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("ids", "\"" + string.Join(",", request.CategoryIdList) + "\"")
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendRequestWithJsonAsync<Models.WxaApiNewTemplateGetPublicTemplateTitlesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/gettemplate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#getTemplateList%E8%8E%B7%E5%8F%96%E7%A7%81%E6%9C%89%E6%A8%A1%E6%9D%BF%E5%88%97%E8%A1%A8 </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/subscribe-message/subscribeMessage.getTemplateList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetTemplateResponse> ExecuteWxaApiNewTemplateGetTemplateAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "gettemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiNewTemplateGetTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Opertaion
        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/feedback/list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getFeedback.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiFeedbackListResponse> ExecuteWxaApiFeedbackListAsync(this WechatApiClient client, Models.WxaApiFeedbackListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "feedback", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("num", request.Limit);

            if (request.Type.HasValue)
                flurlReq.SetQueryParam("type", request.Type);

            return await client.SendRequestWithJsonAsync<Models.WxaApiFeedbackListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/log/jserr_detail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getJsErrDetail.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogJsErrorDetailResponse> ExecuteWxaApiLogJsErrorDetailAsync(this WechatApiClient client, Models.WxaApiLogJsErrorDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "log", "jserr_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiLogJsErrorDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/log/jserr_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getJsErrList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogJsErrorListResponse> ExecuteWxaApiLogJsErrorListAsync(this WechatApiClient client, Models.WxaApiLogJsErrorListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "log", "jserr_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiLogJsErrorListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/log/get_performance 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getPerformance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogGetPerformanceResponse> ExecuteWxaApiLogGetPerformanceAsync(this WechatApiClient client, Models.WxaApiLogGetPerformanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "log", "get_performance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiLogGetPerformanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/log/get_scene 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getSceneList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogGetSceneResponse> ExecuteWxaApiLogGetSceneAsync(this WechatApiClient client, Models.WxaApiLogGetSceneRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "log", "get_scene")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiLogGetSceneResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/log/get_client_version 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getVersionList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogGetClientVersionResponse> ExecuteWxaApiLogGetClientVersionAsync(this WechatApiClient client, Models.WxaApiLogGetClientVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "log", "get_client_version")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiLogGetClientVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/userlog/userlog_search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.realtimelogSearch.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiUserLogSearchResponse> ExecuteWxaApiUserLogSearchAsync(this WechatApiClient client, Models.WxaApiUserLogSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "userlog", "userlog_search")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("begintime", request.BeginTimestamp)
                .SetQueryParam("endtime", request.EndTimestamp);

            if (request.TraceId != null)
                flurlReq.SetQueryParam("traceId", request.TraceId);

            if (request.PagePath != null)
                flurlReq.SetQueryParam("url", request.PagePath);

            if (request.UserId != null)
                flurlReq.SetQueryParam("id", request.UserId);

            if (request.FilterMessage != null)
                flurlReq.SetQueryParam("filterMsg", request.FilterMessage);

            if (request.LogLevel.HasValue)
                flurlReq.SetQueryParam("level", request.LogLevel.Value);

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("start", request.Offset.Value);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithJsonAsync<Models.WxaApiUserLogSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LiveBroadcast
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomCreateResponse> ExecuteWxaApiBroadcastRoomCreateAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/deleteroom 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomDeleteRoomResponse> ExecuteWxaApiBroadcastRoomDeleteRoomAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomDeleteRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "deleteroom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomDeleteRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/editroom 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomEditRoomResponse> ExecuteWxaApiBroadcastRoomEditRoomAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomEditRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "editroom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomEditRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getpushurl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetPushUrlResponse> ExecuteWxaApiBroadcastRoomGetPushUrlAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetPushUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getpushurl")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomGetPushUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getsharedcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetSharedCodeResponse> ExecuteWxaApiBroadcastRoomGetSharedCodeAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetSharedCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getsharedcode")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            if (request.CustomParameter != null)
                flurlReq.SetQueryParam("params", request.CustomParameter);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomGetSharedCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatefeedpublic 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#17 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateFeedPublicResponse> ExecuteWxaApiBroadcastRoomUpdateFeedPublicAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateFeedPublicRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatefeedpublic")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomUpdateFeedPublicResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatereplay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#18 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateReplayResponse> ExecuteWxaApiBroadcastRoomUpdateReplayAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateReplayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatereplay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomUpdateReplayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatekf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#19 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateKfResponse> ExecuteWxaApiBroadcastRoomUpdateKfAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateKfRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatekf")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomUpdateKfResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatecomment 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#20 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateCommentResponse> ExecuteWxaApiBroadcastRoomUpdateCommentAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatecomment")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomUpdateCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region LiveBroadcastRoomGoods
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/addgoods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomAddGoodsResponse> ExecuteWxaApiBroadcastRoomAddGoodsAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomAddGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "addgoods")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomAddGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/onsale 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#21 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsOnSaleResponse> ExecuteWxaApiBroadcastGoodsOnSaleAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsOnSaleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "onsale")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsOnSaleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/deleteInRoom 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#22 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsDeleteInRoomResponse> ExecuteWxaApiBroadcastGoodsDeleteInRoomAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsDeleteInRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "deleteInRoom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsDeleteInRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/push 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#23 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsPushResponse> ExecuteWxaApiBroadcastGoodsPushAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsPushRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "push")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsPushResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/sort 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#24 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsSortResponse> ExecuteWxaApiBroadcastGoodsSortAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsSortRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "sort")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsSortResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/getVideo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#25 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsGetVideoResponse> ExecuteWxaApiBroadcastGoodsGetVideoAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsGetVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "getVideo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsGetVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LiveBroadcastRoomAssistant
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/addassistant 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#9 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomAddAssistantResponse> ExecuteWxaApiBroadcastRoomAddAssistantAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomAddAssistantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "addassistant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomAddAssistantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/modifyassistant 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#10 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomModifyAssistantResponse> ExecuteWxaApiBroadcastRoomModifyAssistantAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomModifyAssistantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "modifyassistant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomModifyAssistantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/removeassistant 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#11 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomRemoveAssistantResponse> ExecuteWxaApiBroadcastRoomRemoveAssistantAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomRemoveAssistantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "removeassistant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomRemoveAssistantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getassistantlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#12 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetAssistantListResponse> ExecuteWxaApiBroadcastRoomGetAssistantListAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetAssistantListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getassistantlist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomGetAssistantListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LiveBroadcastRoomAnchor
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/addsubanchor 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#13 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomAddSubAnchorResponse> ExecuteWxaApiBroadcastRoomAddSubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomAddSubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "addsubanchor")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomAddSubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/modifysubanchor 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#14 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomModifySubAnchorResponse> ExecuteWxaApiBroadcastRoomModifySubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomModifySubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "modifysubanchor")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomModifySubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/deletesubanchor 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#15 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomDeleteSubAnchorResponse> ExecuteWxaApiBroadcastRoomDeleteSubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomDeleteSubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "deletesubanchor")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomDeleteSubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getsubanchor 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#16 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetSubAnchorResponse> ExecuteWxaApiBroadcastRoomGetSubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetSubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getsubanchor")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoomGetSubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LiveBroadcastGoods
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsAddResponse> ExecuteWxaApiBroadcastGoodsAddAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/resetaudit 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsResetAuditResponse> ExecuteWxaApiBroadcastGoodsResetAuditAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsResetAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "resetaudit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsResetAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/audit 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsAuditResponse> ExecuteWxaApiBroadcastGoodsAuditAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "audit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsDeleteResponse> ExecuteWxaApiBroadcastGoodsDeleteAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsUpdateResponse> ExecuteWxaApiBroadcastGoodsUpdateAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/getgoodswarehouse 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGetGoodsWarehouseResponse> ExecuteWxaApiBroadcastGetGoodsWarehouseAsync(this WechatApiClient client, Models.WxaApiBroadcastGetGoodsWarehouseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "getgoodswarehouse")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGetGoodsWarehouseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/goods/getapproved 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/commodity-api.html#7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsGetApprovedResponse> ExecuteWxaApiBroadcastGoodsGetApprovedAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsGetApprovedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "goods", "getapproved")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("status", request.AuditStatus);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastGoodsGetApprovedResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LiveBroadcastRole
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/role/addrole 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/role-manage.html#1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoleAddRoleResponse> ExecuteWxaApiBroadcastRoleAddRoleAsync(this WechatApiClient client, Models.WxaApiBroadcastRoleAddRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "role", "addrole")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoleAddRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/role/deleterole 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/role-manage.html#2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoleDeleteRoleResponse> ExecuteWxaApiBroadcastRoleDeleteRoleAsync(this WechatApiClient client, Models.WxaApiBroadcastRoleDeleteRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "role", "deleterole")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoleDeleteRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/role/getrolelist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/role-manage.html#4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoleGetRoleListResponse> ExecuteWxaApiBroadcastRoleGetRoleListAsync(this WechatApiClient client, Models.WxaApiBroadcastRoleGetRoleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "role", "getrolelist")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Keyword != null)
                flurlReq.SetQueryParam("keyword", request.Keyword);

            if (request.Role.HasValue)
                flurlReq.SetQueryParam("role", request.Role.Value);

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithJsonAsync<Models.WxaApiBroadcastRoleGetRoleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion
    }
}
