using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_provider_token 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91200 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90648 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetProviderTokenResponse> ExecuteCgibinServiceGetProviderTokenAsync(this WechatWorkClient client, Models.CgibinServiceGetProviderTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_provider_token");

            var requestData = new { corpid = client.Credentials.CorpId, provider_secret = client.Credentials.ProviderSecret };
            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetProviderTokenResponse>(flurlReq, data: requestData, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_suite_token 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90600 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90785 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetSuiteTokenResponse> ExecuteCgibinServiceGetSuiteTokenAsync(this WechatWorkClient client, Models.CgibinServiceGetSuiteTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.SuiteId == null)
                request.SuiteId = client.Credentials.SuiteId;

            if (request.SuiteSecret == null)
                request.SuiteSecret = client.Credentials.SuiteSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_suite_token");

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetSuiteTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/get_pre_auth_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90601 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90786 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetPreAuthCodeResponse> ExecuteCgibinServiceGetPreAuthCodeAsync(this WechatWorkClient client, Models.CgibinServiceGetPreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "service", "get_pre_auth_code")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetPreAuthCodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/set_session_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90602 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90787 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceSetSessionInfoResponse> ExecuteCgibinServiceSetSessionInfoAsync(this WechatWorkClient client, Models.CgibinServiceSetSessionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "set_session_info")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceSetSessionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_permanent_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90603 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90788 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetPermanentCodeResponse> ExecuteCgibinServiceGetPermanentCodeAsync(this WechatWorkClient client, Models.CgibinServiceGetPermanentCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_permanent_code")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetPermanentCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_auth_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90604 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90789 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetAuthInfoResponse> ExecuteCgibinServiceGetAuthInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetAuthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_auth_info")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetAuthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_corp_token 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90605 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90790 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetCorpTokenResponse> ExecuteCgibinServiceGetCorpTokenAsync(this WechatWorkClient client, Models.CgibinServiceGetCorpTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_corp_token")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetCorpTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_admin_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90605 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90791 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetAdminListResponse> ExecuteCgibinServiceGetAdminListAsync(this WechatWorkClient client, Models.CgibinServiceGetAdminListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_admin_list")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetAdminListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_customized_auth_url 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95436 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetCustomizedAuthUrlResponse> ExecuteCgibinServiceGetCustomizedAuthUrlAsync(this WechatWorkClient client, Models.CgibinServiceGetCustomizedAuthUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_customized_auth_url")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetCustomizedAuthUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_app_qrcode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95430 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetAppQrcodeResponse> ExecuteCgibinServiceGetAppQrcodeAsync(this WechatWorkClient client, Models.CgibinServiceGetAppQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_app_qrcode")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetAppQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Register
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_register_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90581 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90805 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetRegisterCodeResponse> ExecuteCgibinServiceGetRegisterCodeAsync(this WechatWorkClient client, Models.CgibinServiceGetRegisterCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_register_code")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetRegisterCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_register_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90582 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90806 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetRegisterInfoResponse> ExecuteCgibinServiceGetRegisterInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetRegisterInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_register_info")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetRegisterInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Media
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/media/upload 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceMediaUploadResponse> ExecuteCgibinServiceMediaUploadAsync(this WechatWorkClient client, Models.CgibinServiceMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            const string TYPE_IMAGE = "image";
            const string TYPE_VOICE = "voice";
            const string TYPE_VIDEO = "video";

            if (request.FileName == null)
            {
                string ext = string.Empty;
                if (TYPE_IMAGE.Equals(request.Type))
                    ext = ".png";
                else if (TYPE_VOICE.Equals(request.Type))
                    ext = ".mp3";
                else if (TYPE_VIDEO.Equals(request.Type))
                    ext = ".mp4";

                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ext;
            }

            if (request.FileContentType == null)
            {
                if (TYPE_IMAGE.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";
                else if (TYPE_VOICE.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVoice(request.FileName!) ?? "audio/mp3";
                else if (TYPE_VIDEO.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVideo(request.FileName!) ?? "video/mp4";
                else
                    request.FileContentType = "application/octet-stream";
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "media", "upload")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken)
                .SetQueryParam("type", request.Type);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendRequestAsync<Models.CgibinServiceMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region OAuth
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/getuserinfo3rd 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91121 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91155 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceUserInfo3rdResponse> ExecuteCgibinServiceUserInfo3rdAsync(this WechatWorkClient client, Models.CgibinServiceUserInfo3rdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "service", "getuserinfo3rd")
                .SetQueryParam("suite_access_token", request.AccessToken)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceUserInfo3rdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/getuserdetail3rd 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91122 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91156 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceUserDetail3rdResponse> ExecuteCgibinServiceUserDetail3rdAsync(this WechatWorkClient client, Models.CgibinServiceUserDetail3rdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "getuserdetail3rd")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceUserDetail3rdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_login_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91125 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91158 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetLoginInfoResponse> ExecuteCgibinServiceGetLoginInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetLoginInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_login_info")
                .SetQueryParam("access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetLoginInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Contact
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/contact/id_translate 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91846 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceContactIdTranslateResponse> ExecuteCgibinServiceContactIdTranslateAsync(this WechatWorkClient client, Models.CgibinServiceContactIdTranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "contact", "id_translate")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceContactIdTranslateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/contact/sort 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92093 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceContactSortResponse> ExecuteCgibinServiceContactSortAsync(this WechatWorkClient client, Models.CgibinServiceContactSortRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "contact", "sort")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceContactSortResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/contact/search 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91844 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceContactSearchResponse> ExecuteCgibinServiceContactSearchAsync(this WechatWorkClient client, Models.CgibinServiceContactSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "contact", "search")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceContactSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/contact/batchsearch 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91844 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceContactBatchSearchResponse> ExecuteCgibinServiceContactBatchSearchAsync(this WechatWorkClient client, Models.CgibinServiceContactBatchSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "contact", "batchsearch")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceContactBatchSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Batch
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/batch/getresult 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceBatchGetResultResponse> ExecuteCgibinServiceBatchGetResultAsync(this WechatWorkClient client, Models.CgibinServiceBatchGetResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "service", "batch", "getresult")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken)
                .SetQueryParam("jobid", request.JobId);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceBatchGetResultResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region Device
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/add_device 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90626 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceAddDeviceResponse> ExecuteCgibinServiceAddDeviceAsync(this WechatWorkClient client, Models.CgibinServiceAddDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "add_device")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceAddDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_device_auth_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90753 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetDeviceAuthInfoResponse> ExecuteCgibinServiceGetDeviceAuthInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetDeviceAuthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "get_device_auth_info")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetDeviceAuthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/reset_secret_no 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90753 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceResetSecretNumberResponse> ExecuteCgibinServiceResetSecretNumberAsync(this WechatWorkClient client, Models.CgibinServiceResetSecretNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "reset_secret_no")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceResetSecretNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/list_device 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91346 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceListDeviceResponse> ExecuteCgibinServiceListDeviceAsync(this WechatWorkClient client, Models.CgibinServiceListDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "list_device")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceListDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/fetch_device_log 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91475 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceFetchDeviceLogResponse> ExecuteCgibinServiceFetchDeviceLogAsync(this WechatWorkClient client, Models.CgibinServiceFetchDeviceLogRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "fetch_device_log")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceFetchDeviceLogResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/del_device 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92770 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceDeleteDeviceResponse> ExecuteCgibinServiceDeleteDeviceAsync(this WechatWorkClient client, Models.CgibinServiceDeleteDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "del_device")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceDeleteDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/set_printer_support_state 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92782 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceSetPrinterSupportStateResponse> ExecuteCgibinServiceSetPrinterSupportStateAsync(this WechatWorkClient client, Models.CgibinServiceSetPrinterSupportStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "set_printer_support_state")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceSetPrinterSupportStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MiniProgram
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/miniprogram/jscode2session 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92468 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92468 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceMiniProgramJsCode2SessionResponse> ExecuteCgibinServiceMiniProgramJsCode2SessionAsync(this WechatWorkClient client, Models.CgibinServiceMiniProgramJsCode2SessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "service", "miniprogram", "jscode2session")
                .SetQueryParam("suite_access_token", request.AccessToken)
                .SetQueryParam("js_code", request.JsCode)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceMiniProgramJsCode2SessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Migration
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/externalcontact/finish_external_userid_migration 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95327 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceExternalContactFinishExternalUserIdMigrationResponse> ExecuteCgibinServiceExternalContactFinishExternalUserIdMigrationAsync(this WechatWorkClient client, Models.CgibinServiceExternalContactFinishExternalUserIdMigrationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "externalcontact", "finish_external_userid_migration")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceExternalContactFinishExternalUserIdMigrationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/externalcontact/unionid_to_external_userid_3rd 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95327 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceExternalContactUnionIdToExternalUserId3rdResponse> ExecuteCgibinServiceExternalContactUnionIdToExternalUserId3rdAsync(this WechatWorkClient client, Models.CgibinServiceExternalContactUnionIdToExternalUserId3rdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "externalcontact", "unionid_to_external_userid_3rd")
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceExternalContactUnionIdToExternalUserId3rdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/corpid_to_opencorpid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95435 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceCorpIdToOpenCorpIdResponse> ExecuteCgibinServiceCorpIdToOpenCorpIdAsync(this WechatWorkClient client, Models.CgibinServiceCorpIdToOpenCorpIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "service", "corpid_to_opencorpid")
                .SetQueryParam("access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceCorpIdToOpenCorpIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
