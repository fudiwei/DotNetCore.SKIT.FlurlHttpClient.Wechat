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

            if (request.FileName == null)
            {
                request.FileName = Guid.NewGuid().ToString("N").ToLower();
            }

            if (request.FileContentType == null)
            {
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";
            }

            if (request.FileHash == null)
            {
                request.FileHash = BitConverter.ToString(Utilities.MD5Utility.Hash(request.FileBytes ?? Array.Empty<byte>())).Replace("-", "");
            }

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"file\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "images", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.ImagesAddResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Get, "images", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageId != null)
                flurlReq.SetQueryParam("image_id", request.ImageId);

            if (request.Filters != null)
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            if (request.PageSize != null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.ImagesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
