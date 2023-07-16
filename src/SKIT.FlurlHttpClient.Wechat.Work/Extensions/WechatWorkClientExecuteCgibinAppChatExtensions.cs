using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinAppChatExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/appchat/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90245 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAppChatCreateResponse> ExecuteCgibinAppChatCreateAsync(this WechatWorkClient client, Models.CgibinAppChatCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "appchat", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAppChatCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/appchat/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90246 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAppChatUpdateResponse> ExecuteCgibinAppChatUpdateAsync(this WechatWorkClient client, Models.CgibinAppChatUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "appchat", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAppChatUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/appchat/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90247 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAppChatGetResponse> ExecuteCgibinAppChatGetAsync(this WechatWorkClient client, Models.CgibinAppChatGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "appchat", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("chatid", request.ChatId);

            return await client.SendRequestWithJsonAsync<Models.CgibinAppChatGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/appchat/send 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90248 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAppChatSendResponse> ExecuteCgibinAppChatSendAsync(this WechatWorkClient client, Models.CgibinAppChatSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "appchat", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAppChatSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
