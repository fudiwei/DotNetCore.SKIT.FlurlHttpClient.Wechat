using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteOpenApiMpExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /openapi/getbindlink/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/getbindlink.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiGetBindLinkResponse> ExecuteOpenApiGetBindLinkAsync(this WechatOpenAIClient client, Models.OpenApiGetBindLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "getbindlink", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiGetBindLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/getbindlist/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/getbindlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiGetBindListResponse> ExecuteOpenApiGetBindListAsync(this WechatOpenAIClient client, Models.OpenApiGetBindListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "getbindlist", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiGetBindListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/unbindmp/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/unbindmp.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiUnbindMpResponse> ExecuteOpenApiUnbindMpAsync(this WechatOpenAIClient client, Models.OpenApiUnbindMpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "unbindmp", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiUnbindMpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/geth5link/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/getbindlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiGetH5LinkResponse> ExecuteOpenApiGetH5LinkAsync(this WechatOpenAIClient client, Models.OpenApiGetH5LinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "geth5link", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiGetH5LinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }


        /// <summary>
        /// <para>异步调用 [POST] /openapi/assetsupload/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/assetsupload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiAssetsUploadResponse> ExecuteFileUploadAsync(this WechatOpenAIClient client, Models.FileUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".csv";

            if (request.FileContentType == null)
                request.FileContentType = "text/csv";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "assetsupload", client.Credentials.PushToken!);

            using var fileContent = new ByteArrayContent(request.FileBytes ?? new byte[0]);
            using var paramContent = new StringContent(
                Utilities.WxBizMsgCryptor.AESEncrypt(
                    plainText: Utilities.XmlUtility.Serialize(request),
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    appId: client.Credentials.AppId!
                ), 
                Encoding.UTF8
            );;
            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Add(paramContent, "\"encrypt\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.OpenApiAssetsUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
