using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMedicalInsuranceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /med-ins/orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4016781466 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012503131 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4018300080 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMedicalInsuranceOrderResponse> ExecuteCreateMedicalInsuranceOrderAsync(this WechatTenpayClient client, Models.CreateMedicalInsuranceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "med-ins", "orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMedicalInsuranceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /med-ins/orders/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4016781490 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012503286 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4018300082 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMedicalInsuranceOrderByOutTradeNumberResponse> ExecuteGetMedicalInsuranceOrderByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetMedicalInsuranceOrderByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "med-ins", "orders", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMedicalInsuranceOrderByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /med-ins/orders/mix-trade-no/{mix_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4016781479 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012503155 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4018300081 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMedicalInsuranceOrderByMixTradeNumberResponse> ExecuteGetMedicalInsuranceOrderByMixTradeNumberAsync(this WechatTenpayClient client, Models.GetMedicalInsuranceOrderByMixTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "med-ins", "orders", "mix-trade-no", request.MixTradeNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMedicalInsuranceOrderByMixTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /med-ins/refunds/notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4016781561 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012166534 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4018300085 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMedicalInsuranceRefundNotificationResponse> ExecuteCreateMedicalInsuranceRefundNotificationAsync(this WechatTenpayClient client, Models.CreateMedicalInsuranceRefundNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "med-ins", "refunds", "notify")
                .SetQueryParam("mix_trade_no", request.MixTradeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMedicalInsuranceRefundNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
