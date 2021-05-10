using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通补差相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteEcommerceSubsidiesExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/create 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceSubsidyResponse> ExecuteCreateEcommerceSubsidyAsync(this WechatTenpayClient client, Models.CreateEcommerceSubsidyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "subsidies", "create")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceSubsidyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/return 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceSubsidyReturnResponse> ExecuteCreateEcommerceSubsidyReturnAsync(this WechatTenpayClient client, Models.CreateEcommerceSubsidyReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "subsidies", "return")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceSubsidyReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_5_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelEcommerceSubsidyResponse> ExecuteCancelEcommerceSubsidyAsync(this WechatTenpayClient client, Models.CancelEcommerceSubsidyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "subsidies", "cancel")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CancelEcommerceSubsidyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
