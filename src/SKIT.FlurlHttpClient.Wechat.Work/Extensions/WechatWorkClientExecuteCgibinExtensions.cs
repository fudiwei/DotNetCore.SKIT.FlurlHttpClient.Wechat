using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/gettoken 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91039 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetTokenResponse> ExecuteCgibinGetTokenAsync(this WechatWorkClient client, Models.CgibinGetTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "gettoken")
                .SetQueryParam("corpid", client.Credentials.CorpId)
                .SetQueryParam("corpsecret", client.Credentials.AgentSecret);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/getcallbackip 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90930 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91116 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91148 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetCallbackIpResponse> ExecuteCgibinGetCallbackIpAsync(this WechatWorkClient client, Models.CgibinGetCallbackIpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "getcallbackip")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetCallbackIpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_api_domain_ip 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92520 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetApiDomainIpResponse> ExecuteCgibinGetApiDomainIpAsync(this WechatWorkClient client, Models.CgibinGetApiDomainIpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "get_api_domain_ip")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetApiDomainIpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_jsapi_ticket 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90506 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90539 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetJsapiTicketResponse> ExecuteCgibinGetJsapiTicketAsync(this WechatWorkClient client, Models.CgibinGetJsapiTicketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "get_jsapi_ticket")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetJsapiTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/ticket/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90506 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90539 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTicketGetResponse> ExecuteCgibinTicketGetAsync(this WechatWorkClient client, Models.CgibinTicketGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "ticket", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTicketGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
