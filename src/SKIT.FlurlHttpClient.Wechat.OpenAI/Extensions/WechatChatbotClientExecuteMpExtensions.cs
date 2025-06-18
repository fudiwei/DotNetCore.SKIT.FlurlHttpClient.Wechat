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
    public static class WechatChatbotClientExecuteMpExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /getbindlink/{TOKEN} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/mp/getbindlink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-04-07 下线。")]
        public static async Task<Models.GetBindLinkResponse> ExecuteGetBindLinkAsync(this WechatChatbotClient client, Models.GetBindLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "getbindlink", client.Credentials.Token!);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBindLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /getbindlist/{TOKEN} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/mp/getbindlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-04-07 下线。")]
        public static async Task<Models.GetBindListResponse> ExecuteGetBindListAsync(this WechatChatbotClient client, Models.GetBindListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "getbindlist", client.Credentials.Token!);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBindListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /unbindmp/{TOKEN} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/mp/unbindmp.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-04-07 下线。")]
        public static async Task<Models.UnbindMpResponse> ExecuteUnbindMpAsync(this WechatChatbotClient client, Models.UnbindMpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "unbindmp", client.Credentials.Token!);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnbindMpResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /geth5link/{TOKEN} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/mp/getbindlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-04-07 下线。")]
        public static async Task<Models.GetH5LinkResponse> ExecuteGetH5LinkAsync(this WechatChatbotClient client, Models.GetH5LinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "geth5link", client.Credentials.Token!);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetH5LinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /assetsupload/{TOKEN} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/mp/assetsupload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2023-04-07 下线。")]
        public static async Task<Models.AssetsUploadResponse> ExecuteAssetsUploadAsync(this WechatChatbotClient client, Models.AssetsUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.FileContentType is null)
                request.FileContentType = "image/jpeg";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "assetsupload", client.Credentials.Token!);

            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var paramContent = new StringContent(
                Utilities.WxMsgCryptor.AESEncrypt(
                    plainText: Utilities.XmlHelper.ConvertFromJson(client.JsonSerializer.Serialize(request)),
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

            return await client.SendFlurlRequestAsync<Models.AssetsUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
