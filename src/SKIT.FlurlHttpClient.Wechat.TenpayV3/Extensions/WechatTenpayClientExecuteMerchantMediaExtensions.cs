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
    /// 为 <see cref="WechatTenpayClient"/> 提供媒体文件上传相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant/media/upload 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter2_1_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter2_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantMediaImageResponse> ExecuteUploadMerchantMediaImageAsync(this WechatTenpayClient client, Models.UploadMerchantMediaImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.FileName))
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (string.IsNullOrEmpty(request.FileHash))
                request.FileHash = Utilities.Sha256Util.Hash(request.FileBytes).ToLower();

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
            using var metaContent = new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(metaContent, "\"meta\"");                                                                  // NOTICE: meta 必须要加双引号
            httpContent.Add(fileContent, "\"file\"", "\"" + request.FileName + "\"");                                  // NOTICE: file 必须要加双引号
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary); // NOTICE: boundary 不能加引号
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "media", "upload")
                .SetOptions(request);

            return await client.SendRequestAsync<Models.UploadMerchantMediaImageResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/media/video_upload 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter2_1_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter2_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantMediaVideoResponse> ExecuteUploadMerchantMediaVideoAsync(this WechatTenpayClient client, Models.UploadMerchantMediaVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.FileName))
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".mp4";

            if (string.IsNullOrEmpty(request.FileHash))
                request.FileHash = Utilities.Sha256Util.Hash(request.FileBytes).ToLower();

            if (string.IsNullOrEmpty(request.FileContentType))
            {
                if (request.FileName!.EndsWith(".avi", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/x-msvideo";
                else if (request.FileName!.EndsWith(".wmv", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/x-ms-wmv";
                else if (request.FileName!.EndsWith(".mpeg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/mpeg";
                else if (request.FileName!.EndsWith(".mov", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/quicktime";
                else if (request.FileName!.EndsWith(".mkv", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/mkv";
                else if (request.FileName!.EndsWith(".m4v", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/x-m4v";
                else if (request.FileName!.EndsWith(".flv", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/x-flv";
                else if (request.FileName!.EndsWith(".f4v", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/x-f4v";
                else if (request.FileName!.EndsWith(".rmvb", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/vnd.rn-realvideo";
                else
                    request.FileContentType = "video/mp4";
            }

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes);
            using var metaContent = new ByteArrayContent(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request)));
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(metaContent, "\"meta\"");                                                                  // NOTICE: meta 必须要加双引号
            httpContent.Add(fileContent, "\"file\"", "\"" + request.FileName + "\"");                                  // NOTICE: file 必须要加双引号
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary); // NOTICE: boundary 不能加引号
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "media", "video_upload")
                .SetOptions(request);

            return await client.SendRequestAsync<Models.UploadMerchantMediaVideoResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
    }
}
