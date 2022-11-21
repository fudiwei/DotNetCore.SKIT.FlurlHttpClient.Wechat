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
    public static class WechatOpenAIClientExecuteMpExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /getbindlink/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/mp/getbindlink.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBindLinkResponse> ExecuteGetBindLinkAsync(this WechatOpenAIClient client, Models.GetBindLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "getbindlink", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.GetBindLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /getbindlist/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/mp/getbindlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBindListResponse> ExecuteGetBindListAsync(this WechatOpenAIClient client, Models.GetBindListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "getbindlist", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.GetBindListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /unbindmp/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/mp/unbindmp.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnbindMpResponse> ExecuteUnbindMpAsync(this WechatOpenAIClient client, Models.UnbindMpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "unbindmp", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.UnbindMpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /geth5link/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/mp/getbindlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetH5LinkResponse> ExecuteGetH5LinkAsync(this WechatOpenAIClient client, Models.GetH5LinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "geth5link", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.GetH5LinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /assetsupload/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/mp/assetsupload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AssetsUploadResponse> ExecuteAssetsUploadAsync(this WechatOpenAIClient client, Models.AssetsUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.FileContentType == null)
                request.FileContentType = "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "assetsupload", client.Credentials.Token!);

            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var paramContent = new StringContent(
                Utilities.WxMsgCryptor.AESEncrypt(
                    plainText: Utilities.XmlUtility.ConvertFromJson(client.JsonSerializer.Serialize(request)),
                    encodingAESKey: client.Credentials.EncodingAESKey!,
                    appId: client.Credentials.AppId!
                ),
                Encoding.UTF8
            ); ;
            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Add(paramContent, "\"encrypt\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.AssetsUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
