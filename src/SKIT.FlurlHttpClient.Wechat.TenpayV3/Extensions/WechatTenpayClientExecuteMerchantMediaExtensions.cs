using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
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
                request.FileHash = Security.SHA256Utility.Hash(request.FileBytes).ToLower();

            if (string.IsNullOrEmpty(request.FileContentType))
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant", "media", "upload");

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes);
            using var metaContent = new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(metaContent, $"\"{Constants.FormDataFields.FORMDATA_META}\"");
            httpContent.Add(fileContent, "\"file\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);

            return await client.SendRequestAsync<Models.UploadMerchantMediaImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
                request.FileHash = Security.SHA256Utility.Hash(request.FileBytes).ToLower();

            if (string.IsNullOrEmpty(request.FileContentType))
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVideo(request.FileName!) ?? "video/mp4";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant", "media", "video_upload");

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes);
            using var metaContent = new ByteArrayContent(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request)));
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(metaContent, $"\"{Constants.FormDataFields.FORMDATA_META}\"");
            httpContent.Add(fileContent, "\"file\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);

            return await client.SendRequestAsync<Models.UploadMerchantMediaVideoResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
