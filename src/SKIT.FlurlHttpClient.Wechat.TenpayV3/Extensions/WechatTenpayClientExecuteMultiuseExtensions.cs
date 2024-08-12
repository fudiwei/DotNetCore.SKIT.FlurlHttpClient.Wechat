using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMultiuseExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /multiuse/stocks/{stock_id}/refund-flow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/multiuse-coupon/stock/refund-flow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMultiuseStockRefundFlowResponse> ExecuteGetMultiuseStockRefundFlowAsync(this WechatTenpayClient client, Models.GetMultiuseStockRefundFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "multiuse", "stocks", request.StockId, "refund-flow");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMultiuseStockRefundFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /multiuse/stocks/{stock_id}/send-flow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/multiuse-coupon/stock/send-flow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMultiuseStockSendFlowResponse> ExecuteGetMultiuseStockSendFlowAsync(this WechatTenpayClient client, Models.GetMultiuseStockSendFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "multiuse", "stocks", request.StockId, "send-flow");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMultiuseStockSendFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /multiuse/stocks/{stock_id}/use-flow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/multiuse-coupon/stock/use-flow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMultiuseStockUseFlowResponse> ExecuteGetMultiuseStockUseFlowAsync(this WechatTenpayClient client, Models.GetMultiuseStockUseFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "multiuse", "stocks", request.StockId, "use-flow");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMultiuseStockUseFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /multiuse/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/multiuse-coupon/multiuse-coupon/send-multiuse-coupon.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMultiuseUserCouponResponse> ExecuteSendMultiuseUserCouponAsync(this WechatTenpayClient client, Models.SendMultiuseUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "multiuse", "users", request.OpenId, "coupons");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMultiuseUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
