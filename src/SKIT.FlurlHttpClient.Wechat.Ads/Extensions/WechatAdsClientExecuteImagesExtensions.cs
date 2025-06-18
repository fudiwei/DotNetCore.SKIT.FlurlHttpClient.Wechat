using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatAdsClientExecuteImagesExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /images/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImagesAddResponse> ExecuteImagesAddAsync(this WechatAdsClient client, Models.ImagesAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower();

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.MD5Utility.Hash(request.FileBytes ?? Array.Empty<byte>())).Value!;

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"file\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "images", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsync<Models.ImagesAddResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /images/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImagesGetResponse> ExecuteImagesGetAsync(this WechatAdsClient client, Models.ImagesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "images", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("image_id", request.ImageId)
                .SetQueryParam("filtering", request.Filters is null ? null : client.JsonSerializer.Serialize(request.Filters))
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page", request.Page);

            return await client.SendFlurlRequestAsJsonAsync<Models.ImagesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
