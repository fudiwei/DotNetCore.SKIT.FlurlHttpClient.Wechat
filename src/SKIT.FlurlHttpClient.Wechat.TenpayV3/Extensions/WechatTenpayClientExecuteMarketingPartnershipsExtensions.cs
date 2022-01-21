using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供委托营销相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMarketingPartnershipsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partnerships/build 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_5_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_5_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "partnerships", "build")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendRequestWithJsonAsync<Models.BuildMarketingPartnershipResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partnerships/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_5_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_5_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "partnerships", "terminate")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendRequestWithJsonAsync<Models.TerminateMarketingPartnershipResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partnerships 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_5_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_5_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "partnerships");

            if (request.Partner != null)
                flurlReq.SetQueryParam("partner", client.JsonSerializer.Serialize(request.Partner));

            if (request.AuthorizedData != null)
                flurlReq.SetQueryParam("authorized_data", client.JsonSerializer.Serialize(request.AuthorizedData));

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingPartnershipsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
