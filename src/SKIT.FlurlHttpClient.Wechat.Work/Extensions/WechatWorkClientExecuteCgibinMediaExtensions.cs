using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/upload 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90253 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90389 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90871 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadResponse> ExecuteCgibinMediaUploadAsync(this WechatWorkClient client, Models.CgibinMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            const string TYPE_IMAGE = "image";
            const string TYPE_VOICE = "voice";
            const string TYPE_VIDEO = "video";

            if (request.FileName == null)
            {
                string ext = "";
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
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "media", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.CgibinMediaUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadimg 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90256 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90392 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90874 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadImageResponse> ExecuteCgibinMediaUploadImageAsync(this WechatWorkClient client, Models.CgibinMediaUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "media", "uploadimg")
                .SetQueryParam("access_token", request.AccessToken);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.CgibinMediaUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/upload_attachment 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95098 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95178 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadAttachmentResponse> ExecuteCgibinMediaUploadAttachmentAsync(this WechatWorkClient client, Models.CgibinMediaUploadAttachmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            const string TYPE_IMAGE = "image";
            const string TYPE_VIDEO = "video";
            const string TYPE_FILE = "file";

            if (request.FileName == null)
            {
                string ext = "";
                if (TYPE_IMAGE.Equals(request.Type))
                    ext = ".png";
                else if (TYPE_VIDEO.Equals(request.Type))
                    ext = ".mp4";
                else if (TYPE_FILE.Equals(request.Type))
                    ext = ".txt";

                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ext;
            }

            if (request.FileContentType == null)
            {
                if (TYPE_IMAGE.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";
                else if (TYPE_VIDEO.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVideo(request.FileName!) ?? "video/mp4";
                else if (TYPE_FILE.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVoice(request.FileName!) ?? "text/plain";
                else
                    request.FileContentType = "application/octet-stream";
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "media", "upload_attachment")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_type", request.Type)
                .SetQueryParam("attachment_type", request.AttachmentType);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.CgibinMediaUploadAttachmentResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90254 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90390 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90872 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaGetResponse> ExecuteCgibinMediaGetAsync(this WechatWorkClient client, Models.CgibinMediaGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "media", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestWithJsonAsync<Models.CgibinMediaGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get/jssdk 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90255 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90391 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90873 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaGetJssdkResponse> ExecuteCgibinMediaGetJssdkAsync(this WechatWorkClient client, Models.CgibinMediaGetJssdkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "media", "get", "jssdk")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestWithJsonAsync<Models.CgibinMediaGetJssdkResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
