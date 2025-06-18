using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinAdvancedApiExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_api/create_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100257 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedApiCreateOrderResponse> ExecuteCgibinAdvancedApiCreateOrderAsync(this WechatWorkClient client, Models.CgibinAdvancedApiCreateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_api", "create_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedApiCreateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_api/cancel_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100258 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedApiCancelOrderResponse> ExecuteCgibinAdvancedApiCancelOrderAsync(this WechatWorkClient client, Models.CgibinAdvancedApiCancelOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_api", "cancel_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedApiCancelOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_api/submit_pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100259 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedApiSubmitPayResponse> ExecuteCgibinAdvancedApiSubmitPayAsync(this WechatWorkClient client, Models.CgibinAdvancedApiSubmitPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_api", "submit_pay")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedApiSubmitPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_api/list_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100260 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedApiListOrderResponse> ExecuteCgibinAdvancedApiListOrderAsync(this WechatWorkClient client, Models.CgibinAdvancedApiListOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_api", "list_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedApiListOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_api/get_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100261 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedApiGetOrderResponse> ExecuteCgibinAdvancedApiGetOrderAsync(this WechatWorkClient client, Models.CgibinAdvancedApiGetOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_api", "get_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedApiGetOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_api/get_corp_buy_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100271 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedApiGetCorpBuyInfoResponse> ExecuteCgibinAdvancedApiGetCorpBuyInfoAsync(this WechatWorkClient client, Models.CgibinAdvancedApiGetCorpBuyInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_api", "get_corp_buy_info")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedApiGetCorpBuyInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
