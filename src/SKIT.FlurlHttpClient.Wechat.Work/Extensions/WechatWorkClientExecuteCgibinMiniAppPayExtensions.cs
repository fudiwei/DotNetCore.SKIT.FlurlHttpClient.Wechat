using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMiniAppPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/miniapppay/upload_image 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98972 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMiniAppPayUploadImageResponse> ExecuteCgibinMiniAppPayUploadImageAsync(this WechatWorkClient client, Models.CgibinMiniAppPayUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "miniapppay", "upload_image")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendRequestAsync<Models.CgibinMiniAppPayUploadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/miniapppay/apply_mch 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98973 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMiniAppPayApplyMechantResponse> ExecuteCgibinMiniAppPayApplyMechantAsync(this WechatWorkClient client, Models.CgibinMiniAppPayApplyMechantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "miniapppay", "apply_mch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMiniAppPayApplyMechantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/miniapppay/get_applyment_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98974 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMiniAppPayGetApplymentStatusResponse> ExecuteCgibinMiniAppPayGetApplymentStatusAsync(this WechatWorkClient client, Models.CgibinMiniAppPayGetApplymentStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "miniapppay", "get_applyment_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMiniAppPayGetApplymentStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
