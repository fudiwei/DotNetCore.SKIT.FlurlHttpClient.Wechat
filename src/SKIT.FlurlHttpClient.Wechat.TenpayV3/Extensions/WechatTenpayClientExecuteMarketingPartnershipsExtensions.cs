using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingPartnershipsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partnerships/build 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/commissioned-marketing/partnerships/build-partnerships.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/commissioned-marketing/partnerships/build-partnerships.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BuildMarketingPartnershipResponse> ExecuteBuildMarketingPartnershipAsync(this WechatTenpayClient client, Models.BuildMarketingPartnershipRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partnerships", "build")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendFlurlRequestAsJsonAsync<Models.BuildMarketingPartnershipResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partnerships/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/commissioned-marketing/partnerships/terminate-partnerships.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/commissioned-marketing/partnerships/terminate-partnerships.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateMarketingPartnershipResponse> ExecuteTerminateMarketingPartnershipAsync(this WechatTenpayClient client, Models.TerminateMarketingPartnershipRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partnerships", "terminate")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateMarketingPartnershipResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partnerships 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/commissioned-marketing/partnerships/list-partnerships.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/commissioned-marketing/partnerships/list-partnerships.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPartnershipsResponse> ExecuteQueryMarketingPartnershipsAsync(this WechatTenpayClient client, Models.QueryMarketingPartnershipsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partnerships")
                .SetQueryParam("partner", request.Partner is null ? null : client.JsonSerializer.Serialize(request.Partner))
                .SetQueryParam("authorized_data", request.AuthorizedData is null ? null : client.JsonSerializer.Serialize(request.AuthorizedData))
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPartnershipsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
