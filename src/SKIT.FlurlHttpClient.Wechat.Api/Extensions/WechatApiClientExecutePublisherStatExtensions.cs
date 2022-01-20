using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecutePublisherStatExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /publisher/stat?action=publisher_adpos_general 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Ad_Analysis.html#%E4%B8%80%E3%80%81%E8%8E%B7%E5%8F%96%E5%85%AC%E4%BC%97%E5%8F%B7%E5%88%86%E5%B9%BF%E5%91%8A%E4%BD%8D%E6%95%B0%E6%8D%AE%EF%BC%88publisher-adpos-general%EF%BC%89 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublisherStatAdposGeneralResponse> ExecutePublisherStatAdposGeneralAsync(this WechatApiClient client, Models.PublisherStatAdposGeneralRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "publisher", "stat")
                .SetQueryParam("action", "publisher_adpos_general")
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.Limit)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString);

            if (request.AdSlotName != null)
                flurlReq.SetQueryParam("ad_slot", request.AdSlotName);

            return await client.SendRequestWithJsonAsync<Models.PublisherStatAdposGeneralResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /publisher/stat?action=publisher_cps_general 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Ad_Analysis.html#%E4%BA%8C%E3%80%81%E8%8E%B7%E5%8F%96%E5%85%AC%E4%BC%97%E5%8F%B7%E8%BF%94%E4%BD%A3%E5%95%86%E5%93%81%E6%95%B0%E6%8D%AE%EF%BC%88publisher-cps-general%EF%BC%89 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublisherStatCpsGeneralResponse> ExecutePublisherStatCpsGeneralAsync(this WechatApiClient client, Models.PublisherStatCpsGeneralRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "publisher", "stat")
                .SetQueryParam("action", "publisher_cps_general")
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.Limit)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.PublisherStatCpsGeneralResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /publisher/stat?action=publisher_settlement 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Ad_Analysis.html#%E4%B8%89%E3%80%81%E8%8E%B7%E5%8F%96%E5%85%AC%E4%BC%97%E5%8F%B7%E7%BB%93%E7%AE%97%E6%94%B6%E5%85%A5%E6%95%B0%E6%8D%AE%E5%8F%8A%E7%BB%93%E7%AE%97%E4%B8%BB%E4%BD%93%E4%BF%A1%E6%81%AF%EF%BC%88publisher-settlement%EF%BC%89 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublisherStatSettlementResponse> ExecutePublisherStatSettlementAsync(this WechatApiClient client, Models.PublisherStatSettlementRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "publisher", "stat")
                .SetQueryParam("action", "publisher_settlement")
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.Limit)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.PublisherStatSettlementResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
