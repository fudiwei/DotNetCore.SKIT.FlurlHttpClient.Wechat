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
    public static class WechatOpenAIPlatformClientExecuteMpExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /getbindlink/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/getbindlink.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.GetBindLinkResponse> ExecuteGetBindLinkAsync(this WechatOpenAIPlatformClient client, Models.Platform.GetBindLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "getbindlink", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.GetBindLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /getbindlist/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/getbindlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.GetBindListResponse> ExecuteGetBindListAsync(this WechatOpenAIPlatformClient client, Models.Platform.GetBindListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "getbindlist", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.GetBindListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /unbindmp/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/unbindmp.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.UnbindMpResponse> ExecuteUnbindMpAsync(this WechatOpenAIPlatformClient client, Models.Platform.UnbindMpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "unbindmp", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.UnbindMpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /geth5link/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/getbindlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.GetH5LinkResponse> ExecuteGetH5LinkAsync(this WechatOpenAIPlatformClient client, Models.Platform.GetH5LinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "geth5link", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.GetH5LinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }


        /// <summary>
        /// <para>异步调用 [POST] /assetsupload/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/mp/assetsupload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.AssetsUploadResponse> ExecuteAssetsUploadAsync(this WechatOpenAIPlatformClient client, Models.Platform.AssetsUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.FileContentType == null)
                request.FileContentType = "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "assetsupload", client.Credentials.Token!);

            using var fileContent = new ByteArrayContent(request.FileBytes ?? new byte[0]);
            using var paramContent = new StringContent(
                Utilities.WxBizMsgCryptor.AESEncrypt(
                    plainText: Utilities.XmlUtility.Serialize(request),
                    encodingAESKey: client.Credentials.EncodingAESKey!,
                    appId: client.Credentials.AppId!
                ), 
                Encoding.UTF8
            );;
            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Add(paramContent, "\"encrypt\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.Platform.AssetsUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
