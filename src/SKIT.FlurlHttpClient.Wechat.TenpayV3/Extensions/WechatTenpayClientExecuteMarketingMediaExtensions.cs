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
    /// 为 <see cref="WechatTenpayClient"/> 提供图片上传（营销专用）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMarketingMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/media/image-upload 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_0_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_0_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMarketingMediaImageResponse> ExecuteUploadMarketingMediaImageAsync(this WechatTenpayClient client, Models.UploadMarketingMediaImageRequest request, CancellationToken cancellationToken = default)
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
            using var metaContent = new ByteArrayContent(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request)));
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(metaContent, "\"meta\"");                                                                  // NOTICE: meta 必须要加双引号
            httpContent.Add(fileContent, "\"file\"", "\"" + request.FileName + "\"");                                  // NOTICE: file 必须要加双引号
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary); // NOTICE: boundary 不能加引号
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "marketing", "favor", "media", "image-upload")
                .SetOptions(request);

            return await client.SendRequestAsync<Models.UploadMarketingMediaImageResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
    }
}
