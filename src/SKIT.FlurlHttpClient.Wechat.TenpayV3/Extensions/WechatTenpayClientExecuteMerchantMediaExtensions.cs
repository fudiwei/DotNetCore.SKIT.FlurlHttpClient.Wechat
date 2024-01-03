using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant/media/upload 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/upload.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/upload.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/upload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantMediaImageResponse> ExecuteUploadMerchantMediaImageAsync(this WechatTenpayClient client, Models.UploadMerchantMediaImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash == null)
                request.FileHash = BitConverter.ToString(Utilities.SHA256Utility.Hash(request.FileBytes)).Replace("-", string.Empty).ToLower();

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant", "media", "upload");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadMerchantMediaImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/media/video_upload 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/video-upload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantMediaVideoResponse> ExecuteUploadMerchantMediaVideoAsync(this WechatTenpayClient client, Models.UploadMerchantMediaVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".mp4";

            if (request.FileHash == null)
                request.FileHash = BitConverter.ToString(Utilities.SHA256Utility.Hash(request.FileBytes)).Replace("-", string.Empty).ToLower();

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVideo(request.FileName!) ?? "video/mp4";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant", "media", "video_upload");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadMerchantMediaVideoResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
