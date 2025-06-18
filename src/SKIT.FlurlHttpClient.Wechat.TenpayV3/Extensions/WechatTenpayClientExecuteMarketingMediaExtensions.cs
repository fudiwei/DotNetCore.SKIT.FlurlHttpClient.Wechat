using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteMarketingMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/media/image-upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012557233 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012557243 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012557248 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759802 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760240 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760270 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMarketingMediaImageResponse> ExecuteUploadMarketingMediaImageAsync(this WechatTenpayClient client, Models.UploadMarketingMediaImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToLower();

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "media", "image-upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadMarketingMediaImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
