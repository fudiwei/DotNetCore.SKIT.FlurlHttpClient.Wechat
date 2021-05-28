using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteProductExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /product/img/upload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent/API/register/uploadimg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductImageUploadResponse> ExecuteProductImageUploadAsync(this WechatApiClient client, Models.ProductImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "product", "img", "upload")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (!string.IsNullOrEmpty(request.ImageUrl))
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendRequestWithJsonAsync<Models.ProductImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                string filename = "image.png";
                var httpContent = new MultipartFormDataContent(boundary);
                var fileContent = new ByteArrayContent(request.ImageFileBytes ?? new byte[0]);
                httpContent.Add(fileContent, "\"media\"", "\"" + filename + "\"");
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                fileContent.Headers.ContentLength = request.ImageFileBytes?.Length;
                httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
                return await client.SendRequestAsync<Models.ProductImageUploadResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
            }
        }
    }
}
