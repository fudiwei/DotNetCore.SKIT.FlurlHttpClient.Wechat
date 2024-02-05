using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/New_temporary_materials.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/customer-message/customerServiceMessage.uploadTempMedia.html ]]>
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
                if (TYPE_IMAGE.Equals(request.Type) || TYPE_THUMB.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";
                else if (TYPE_VOICE.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVoice(request.FileName!) ?? "audio/mp3";
                else if (TYPE_VIDEO.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVideo(request.FileName!) ?? "video/mp4";
                else
                    request.FileContentType = "application/octet-stream";
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.CgibinMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Get_temporary_materials.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/customer-message/customerServiceMessage.getTempMedia.html ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadimg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#0 ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Adding_Permanent_Assets.html#%E4%B8%8A%E4%BC%A0%E5%9B%BE%E6%96%87%E6%B6%88%E6%81%AF%E5%86%85%E7%9A%84%E5%9B%BE%E7%89%87%E8%8E%B7%E5%8F%96URL ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Create_a_Coupon_Voucher_or_Card.html#4 ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Stores/WeChat_Store_Interface.html#6 ]]>
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
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileContentType is null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "media", "uploadimg")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.CgibinMediaUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadnews 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#1 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaUploadNewsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadvideo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#3 ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaUploadVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Voice
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/addvoicetorecofortext 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/AI_Open_API.html#%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3%E2%80%94%E2%80%94%E6%8F%90%E4%BA%A4%E8%AF%AD%E9%9F%B3 ]]>
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

            return await client.SendFlurlRequestAsync<Models.CgibinMediaVoiceAddVoiceToRecognitionForTextResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/queryrecoresultfortext 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/AI_Open_API.html#%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3%E2%80%94%E2%80%94%E8%8E%B7%E5%8F%96%E8%AF%AD%E9%9F%B3%E8%AF%86%E5%88%AB%E7%BB%93%E6%9E%9C ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaVoiceQueryRecognitionResultForTextResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/translatecontent 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/AI_Open_API.html#%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3%E2%80%94%E2%80%94%E5%BE%AE%E4%BF%A1%E7%BF%BB%E8%AF%91 ]]>
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

            return await client.SendFlurlRequestAsync<Models.CgibinMediaVoiceTranslateContentResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region Operation
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/getfeedbackmedia 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getFeedbackmedia.html ]]>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMediaGetFeedbackMediaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
