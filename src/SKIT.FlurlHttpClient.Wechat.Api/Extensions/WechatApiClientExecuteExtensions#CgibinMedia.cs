namespace SKIT.FlurlHttpClient.Wechat.Api
{
    using SKIT.FlurlHttpClient;

    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/temporary/api_uploadtempmedia.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/temporary/api_uploadtempmedia.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_uploadtempmedia.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadResponse> ExecuteCgibinMediaUploadAsync(this WechatApiClient client, Models.CgibinMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            const string TYPE_IMAGE = "image";
            const string TYPE_THUMB = "thumb";
            const string TYPE_VOICE = "voice";
            const string TYPE_VIDEO = "video";

            if (request.FileName is null)
            {
                string ext = string.Empty;
                if (TYPE_IMAGE.Equals(request.Type))
                    ext = ".png";
                else if (TYPE_THUMB.Equals(request.Type))
                    ext = ".jpg";
                else if (TYPE_VOICE.Equals(request.Type))
                    ext = ".mp3";
                else if (TYPE_VIDEO.Equals(request.Type))
                    ext = ".mp4";

                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ext;
            }

            if (request.FileContentType is null)
            {
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName);
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.CgibinMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/temporary/api_getmedia.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/temporary/api_getmedia.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_getmedia.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaGetResponse> ExecuteCgibinMediaGetAsync(this WechatApiClient client, Models.CgibinMediaGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "media", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadimg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/notify/message/api_uploadimage.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_uploadimage.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/notify/message/api_uploadimage.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_uploadimage.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Create_a_Coupon_Voucher_or_Card.html ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadImageResponse> ExecuteCgibinMediaUploadImageAsync(this WechatApiClient client, Models.CgibinMediaUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
            {
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";
            }

            if (request.FileContentType is null)
            {
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName);
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "uploadimg")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.CgibinMediaUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadnews 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/notify/message/api_uploadnewsmsg.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/notify/message/api_uploadnewsmsg.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadNewsResponse> ExecuteCgibinMediaUploadNewsAsync(this WechatApiClient client, Models.CgibinMediaUploadNewsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "uploadnews")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaUploadNewsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadvideo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/notify/message/api_uploadnewsmsg.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadVideoResponse> ExecuteCgibinMediaUploadVideoAsync(this WechatApiClient client, Models.CgibinMediaUploadVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "uploadvideo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaUploadVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Feedback
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/getfeedbackmedia 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getfeedbackmedia.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaGetFeedbackMediaResponse> ExecuteCgibinMediaGetFeedbackMediaAsync(this WechatApiClient client, Models.CgibinMediaGetFeedbackMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "media", "getfeedbackmedia")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("record_id", request.RecordId)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaGetFeedbackMediaResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Voice
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/addvoicetorecofortext 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ai/api_addvoicetorecofortext.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ai/api_addvoicetorecofortext.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaVoiceAddVoiceToRecognitionForTextResponse> ExecuteCgibinMediaVoiceAddVoiceToRecognitionForTextAsync(this WechatApiClient client, Models.CgibinMediaVoiceAddVoiceToRecognitionForTextRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "voice", "addvoicetorecofortext")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("format", request.Format)
                .SetQueryParam("voice_id", request.VoiceId)
                .SetQueryParam("lang", request.Language);

            using var httpContent = new ByteArrayContent(request.VoiceBytes ?? Array.Empty<byte>());
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mp3");
            httpContent.Headers.ContentLength = request.VoiceBytes?.Length;

            return await client.SendFlurlRequestAsync<Models.CgibinMediaVoiceAddVoiceToRecognitionForTextResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/queryrecoresultfortext 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ai/api_queryrecoresultfortext.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ai/api_queryrecoresultfortext.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaVoiceQueryRecognitionResultForTextResponse> ExecuteCgibinMediaVoiceQueryRecognitionResultForTextAsync(this WechatApiClient client, Models.CgibinMediaVoiceQueryRecognitionResultForTextRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "voice", "queryrecoresultfortext")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("voice_id", request.VoiceId)
                .SetQueryParam("lang", request.Language);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaVoiceQueryRecognitionResultForTextResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/translatecontent 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ai/api_translatecontent.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ai/api_translatecontent.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaVoiceTranslateContentResponse> ExecuteCgibinMediaVoiceTranslateContentAsync(this WechatApiClient client, Models.CgibinMediaVoiceTranslateContentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "voice", "translatecontent")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("lfrom", request.FromLanguage)
                .SetQueryParam("lto", request.ToLanguage);

            using var httpContent = new ByteArrayContent(request.VoiceBytes ?? Array.Empty<byte>());
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mp3");
            httpContent.Headers.ContentLength = request.VoiceBytes?.Length;

            return await client.SendFlurlRequestAsync<Models.CgibinMediaVoiceTranslateContentResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
