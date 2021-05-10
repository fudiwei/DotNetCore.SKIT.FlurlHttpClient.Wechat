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
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通退款相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteEcommerceRefundsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/refunds/apply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceRefundResponse> ExecuteCreateEcommerceRefundAsync(this WechatTenpayClient client, Models.CreateEcommerceRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "refunds", "apply")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/out-refund-no/{out_refund_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceRefundByOutRefundNumberResponse> ExecuteGetEcommerceRefundByOutRefundNumberAsync(this WechatTenpayClient client, Models.GetEcommerceRefundByOutRefundNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "refunds", "out-refund-no", request.OutRefundNumber)
                .SetOptions(request)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestAsync<Models.GetEcommerceRefundByOutRefundNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/id/{refund_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceRefundByRefundIdResponse> ExecuteGetEcommerceRefundByRefundIdAsync(this WechatTenpayClient client, Models.GetEcommerceRefundByRefundIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "refunds", "id", request.RefundId)
                .SetOptions(request)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestAsync<Models.GetEcommerceRefundByRefundIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/refunds/{refund_id}/return-advance 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceRefundReturnAdvanceResponse> ExecuteCreateEcommerceRefundReturnAdvanceAsync(this WechatTenpayClient client, Models.CreateEcommerceRefundReturnAdvanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "refunds", request.RefundId, "return-advance")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceRefundReturnAdvanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/{refund_id}/return-advance 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceRefundReturnAdvanceResponse> ExecuteGetEcommerceRefundReturnAdvanceAsync(this WechatTenpayClient client, Models.GetEcommerceRefundReturnAdvanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "refunds", request.RefundId, "return-advance")
                .SetOptions(request)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestAsync<Models.GetEcommerceRefundReturnAdvanceResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
