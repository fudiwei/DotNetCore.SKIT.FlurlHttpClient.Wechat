using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/New_temporary_materials.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/customer-message/customerServiceMessage.uploadTempMedia.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadResponse> ExecuteCgibinMediaUploadAsync(this WechatApiClient client, Models.CgibinMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.FileName))
            {
                string ext = "";
                if ("image".Equals(request.Type))
                    ext = ".png";
                else if ("thumb".Equals(request.Type))
                    ext = ".jpg";
                else if ("voice".Equals(request.Type))
                    ext = ".mp3";
                else if ("video".Equals(request.Type))
                    ext = ".mp4";

                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ext;
            }

            if (string.IsNullOrEmpty(request.FileContentType))
            {
                if (request.FileName!.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else if (request.FileName!.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else if (request.FileName!.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/png";
                else if (request.FileName!.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/gif";
                else if (request.FileName!.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "audio/mpeg";
                else if (request.FileName!.EndsWith(".amr", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "audio/amr";
                else if (request.FileName!.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/mp4";
                else
                    request.FileContentType = "application/octet-stream";
            }

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", "\"" + request.FileName + "\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length ?? 0;
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "upload")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            return await client.SendRequestAsync<Models.CgibinMediaUploadResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Get_temporary_materials.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/customer-message/customerServiceMessage.getTempMedia.html </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "media", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestAsync<Models.CgibinMediaGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadimg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#0 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Adding_Permanent_Assets.html#%E4%B8%8A%E4%BC%A0%E5%9B%BE%E6%96%87%E6%B6%88%E6%81%AF%E5%86%85%E7%9A%84%E5%9B%BE%E7%89%87%E8%8E%B7%E5%8F%96URL </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Create_a_Coupon_Voucher_or_Card.html#4 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Stores/WeChat_Store_Interface.html#6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadImageResponse> ExecuteCgibinMediaUploadImageAsync(this WechatApiClient client, Models.CgibinMediaUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.FileName))
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (string.IsNullOrEmpty(request.FileContentType))
            {
                if (request.FileName!.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else if (request.FileName!.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else
                    request.FileContentType = "image/png";
            }

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", "\"" + request.FileName + "\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length ?? 0;
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "uploadimg")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinMediaUploadImageResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadnews 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#1 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "uploadnews")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMediaUploadNewsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadvideo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#3 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "uploadvideo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMediaUploadVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Voice
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/addvoicetorecofortext 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/AI_Open_API.html#%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3%E2%80%94%E2%80%94%E6%8F%90%E4%BA%A4%E8%AF%AD%E9%9F%B3 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "voice", "addvoicetorecofortext")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("format", request.Format)
                .SetQueryParam("voice_id", request.VoiceId)
                .SetQueryParam("lang", request.Language);

            using var httpContent = new ByteArrayContent(request.VoiceBytes);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mp3");
            return await client.SendRequestAsync<Models.CgibinMediaVoiceAddVoiceToRecognitionForTextResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/queryrecoresultfortext 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/AI_Open_API.html#%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3%E2%80%94%E2%80%94%E8%8E%B7%E5%8F%96%E8%AF%AD%E9%9F%B3%E8%AF%86%E5%88%AB%E7%BB%93%E6%9E%9C </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "voice", "queryrecoresultfortext")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("voice_id", request.VoiceId)
                .SetQueryParam("lang", request.Language);

            return await client.SendRequestAsync<Models.CgibinMediaVoiceQueryRecognitionResultForTextResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/voice/translatecontent 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/AI_Open_API.html#%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3%E2%80%94%E2%80%94%E5%BE%AE%E4%BF%A1%E7%BF%BB%E8%AF%91 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "voice", "translatecontent")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("lfrom", request.FromLanguage)
                .SetQueryParam("lto", request.ToLanguage);

            using var httpContent = new ByteArrayContent(request.VoiceBytes);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mp3");
            return await client.SendRequestAsync<Models.CgibinMediaVoiceTranslateContentResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region Operation
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/getfeedbackmedia 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/operation/operation.getFeedbackmedia.html </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "media", "getfeedbackmedia")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("record_id", request.RecordId)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestAsync<Models.CgibinMediaGetFeedbackMediaResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
