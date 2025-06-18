using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinChatDataExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/get_auth_user_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99641 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataGetAuthUserListResponse> ExecuteCgibinChatDataGetAuthUserListAsync(this WechatWorkClient client, Models.CgibinChatDataGetAuthUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "get_auth_user_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataGetAuthUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/get_corp_auth_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataGetCorpAuthInfoResponse> ExecuteCgibinChatDataGetCorpAuthInfoAsync(this WechatWorkClient client, Models.CgibinChatDataGetCorpAuthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "get_corp_auth_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataGetCorpAuthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/set_public_key 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99587 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSetPublicKeyResponse> ExecuteCgibinChatDataSetPublicKeyAsync(this WechatWorkClient client, Models.CgibinChatDataSetPublicKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "set_public_key")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSetPublicKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/set_receive_callback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100018 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSetReceiveCallbackResponse> ExecuteCgibinChatDataSetReceiveCallbackAsync(this WechatWorkClient client, Models.CgibinChatDataSetReceiveCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "set_receive_callback")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSetReceiveCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/set_log_level 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100109 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSetLogLevelResponse> ExecuteCgibinChatDataSetLogLevelAsync(this WechatWorkClient client, Models.CgibinChatDataSetLogLevelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "set_log_level")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSetLogLevelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/upload_media 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100175 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataUploadMediaResponse> ExecuteCgibinChatDataUploadMediaAsync(this WechatWorkClient client, Models.CgibinChatDataUploadMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower();

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.CgibinChatDataUploadMediaResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/sync_msg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97240 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSyncMessageResponse> ExecuteCgibinChatDataSyncMessageAsync(this WechatWorkClient client, Models.CgibinChatDataSyncMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "sync_msg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSyncMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/groupchat/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99495 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataGroupChatGetResponse> ExecuteCgibinChatDataGroupChatGetAsync(this WechatWorkClient client, Models.CgibinChatDataGroupChatGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "groupchat", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataGroupChatGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        #region AgreeStatus
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/getagreestatus/single 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99530 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataGetAgreeStatusSingleResponse> ExecuteCgibinChatDataGetAgreeStatusSingleAsync(this WechatWorkClient client, Models.CgibinChatDataGetAgreeStatusSingleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "getagreestatus", "single")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataGetAgreeStatusSingleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/getagreestatus/room 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99530 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataGetAgreeStatusRoomResponse> ExecuteCgibinChatDataGetAgreeStatusRoomAsync(this WechatWorkClient client, Models.CgibinChatDataGetAgreeStatusRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "getagreestatus", "room")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataGetAgreeStatusRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region AnalyzeTask
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/analyze_task_add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99527 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataAnalyzeTaskAddResponse> ExecuteCgibinChatDataAnalyzeTaskAddAsync(this WechatWorkClient client, Models.CgibinChatDataAnalyzeTaskAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "analyze_task_add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataAnalyzeTaskAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/analyze_task_submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99527 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataAnalyzeTaskSubmitResponse> ExecuteCgibinChatDataAnalyzeTaskSubmitAsync(this WechatWorkClient client, Models.CgibinChatDataAnalyzeTaskSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "analyze_task_submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataAnalyzeTaskSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/analyze_task_result 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99527 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataAnalyzeTaskResultResponse> ExecuteCgibinChatDataAnalyzeTaskResultAsync(this WechatWorkClient client, Models.CgibinChatDataAnalyzeTaskResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "analyze_task_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataAnalyzeTaskResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region DebugMode
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/open_debug_mode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100091 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataOpenDebugModeResponse> ExecuteCgibinChatDataOpenDebugModeAsync(this WechatWorkClient client, Models.CgibinChatDataOpenDebugModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "open_debug_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataOpenDebugModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/close_debug_mode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100092 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataCloseDebugModeResponse> ExecuteCgibinChatDataCloseDebugModeAsync(this WechatWorkClient client, Models.CgibinChatDataCloseDebugModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "close_debug_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataCloseDebugModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/check_debug_mode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100114 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataCheckDebugModeResponse> ExecuteCgibinChatDataCheckDebugModeAsync(this WechatWorkClient client, Models.CgibinChatDataCheckDebugModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "check_debug_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataCheckDebugModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region Export
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/export/create_job 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99620 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataExportCreateJobResponse> ExecuteCgibinChatDataExportCreateJobAsync(this WechatWorkClient client, Models.CgibinChatDataExportCreateJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "export", "create_job")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataExportCreateJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/export/get_job_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99620 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataExportGetJobStatusResponse> ExecuteCgibinChatDataExportGetJobStatusAsync(this WechatWorkClient client, Models.CgibinChatDataExportGetJobStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "export", "get_job_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataExportGetJobStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region HideSensitiveInfoConfig
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/set_hide_sensitiveinfo_config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99622 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSetHideSensitiveInfoConfigResponse> ExecuteCgibinChatDataSetHideSensitiveInfoConfigAsync(this WechatWorkClient client, Models.CgibinChatDataSetHideSensitiveInfoConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "set_hide_sensitiveinfo_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSetHideSensitiveInfoConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/get_hide_sensitiveinfo_config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99622 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataGetHideSensitiveInfoConfigResponse> ExecuteCgibinChatDataGetHideSensitiveInfoConfigAsync(this WechatWorkClient client, Models.CgibinChatDataGetHideSensitiveInfoConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "get_hide_sensitiveinfo_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataGetHideSensitiveInfoConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region Keyword
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/keyword/create_rule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataKeywordCreateRuleResponse> ExecuteCgibinChatDataKeywordCreateRuleAsync(this WechatWorkClient client, Models.CgibinChatDataKeywordCreateRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "keyword", "create_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataKeywordCreateRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/keyword/update_rule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataKeywordUpdateRuleResponse> ExecuteCgibinChatDataKeywordUpdateRuleAsync(this WechatWorkClient client, Models.CgibinChatDataKeywordUpdateRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "keyword", "update_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataKeywordUpdateRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/keyword/delete_rule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataKeywordDeleteRuleResponse> ExecuteCgibinChatDataKeywordDeleteRuleAsync(this WechatWorkClient client, Models.CgibinChatDataKeywordDeleteRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "keyword", "delete_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataKeywordDeleteRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/keyword/get_rule_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataKeywordGetRuleListResponse> ExecuteCgibinChatDataKeywordGetRuleListAsync(this WechatWorkClient client, Models.CgibinChatDataKeywordGetRuleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "keyword", "get_rule_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataKeywordGetRuleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/keyword/get_rule_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataKeywordGetRuleDetailResponse> ExecuteCgibinChatDataKeywordGetRuleDetailAsync(this WechatWorkClient client, Models.CgibinChatDataKeywordGetRuleDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "keyword", "get_rule_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataKeywordGetRuleDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/keyword/get_hit_msg_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97266 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataKeywordGetHitMessageListResponse> ExecuteCgibinChatDataKeywordGetHitMessageListAsync(this WechatWorkClient client, Models.CgibinChatDataKeywordGetHitMessageListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "keyword", "get_hit_msg_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataKeywordGetHitMessageListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region Program
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/sync_call_program 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100020 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSyncCallProgramResponse> ExecuteCgibinChatDataSyncCallProgramAsync(this WechatWorkClient client, Models.CgibinChatDataSyncCallProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "sync_call_program")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSyncCallProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/async_program_task 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100021 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataAsyncProgramTaskResponse> ExecuteCgibinChatDataAsyncProgramTaskAsync(this WechatWorkClient client, Models.CgibinChatDataAsyncProgramTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "async_program_task")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataAsyncProgramTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/async_program_result 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100021 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataAsyncProgramResultResponse> ExecuteCgibinChatDataAsyncProgramResultAsync(this WechatWorkClient client, Models.CgibinChatDataAsyncProgramResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "async_program_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataAsyncProgramResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region Search
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/search_chat 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99496 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSearchChatResponse> ExecuteCgibinChatDataSearchChatAsync(this WechatWorkClient client, Models.CgibinChatDataSearchChatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "search_chat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSearchChatResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/search_msg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97374 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChatDataSearchMessageResponse> ExecuteCgibinChatDataSearchMessageAsync(this WechatWorkClient client, Models.CgibinChatDataSearchMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "search_msg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSearchMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion

        #region SpecialApi
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/specapi/create_job 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99460 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-06-06 下线。")]
        public static async Task<Models.CgibinChatDataSpecialApiCreateJobResponse> ExecuteCgibinChatDataSpecialApiCreateJobAsync(this WechatWorkClient client, Models.CgibinChatDataSpecialApiCreateJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "specapi", "create_job")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSpecialApiCreateJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/chatdata/specapi/get_job_result 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99462 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2024-06-06 下线。")]
        public static async Task<Models.CgibinChatDataSpecialApiGetJobResultResponse> ExecuteCgibinChatDataSpecialApiGetJobResultAsync(this WechatWorkClient client, Models.CgibinChatDataSpecialApiGetJobResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "chatdata", "specapi", "get_job_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChatDataSpecialApiGetJobResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
        #endregion
    }
}
