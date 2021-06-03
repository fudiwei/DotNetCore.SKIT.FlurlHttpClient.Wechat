using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/upload 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90253 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90389 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadResponse> ExecuteCgibinMediaUploadAsync(this WechatWorkClient client, Models.CgibinMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.FileName))
            {
                string ext = "";
                if ("image".Equals(request.Type))
                    ext = ".png";
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
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "upload")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            return await client.SendRequestAsync<Models.CgibinMediaUploadResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/media/uploadimg 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90256 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90392 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMediaUploadImageResponse> ExecuteCgibinMediaUploadImageAsync(this WechatWorkClient client, Models.CgibinMediaUploadImageRequest request, CancellationToken cancellationToken = default)
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
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "media", "uploadimg")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinMediaUploadImageResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90254 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90390 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "media", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestAsync<Models.CgibinMediaGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/media/get/jssdk 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90255 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90391 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "media", "get", "jssdk")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendRequestAsync<Models.CgibinMediaGetJssdkResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
