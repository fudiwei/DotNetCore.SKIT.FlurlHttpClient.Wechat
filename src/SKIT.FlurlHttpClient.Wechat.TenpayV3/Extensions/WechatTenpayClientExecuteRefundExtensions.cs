using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteRefundExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /refund/domestic/refunds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012556524 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012557131 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012557161 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012587971 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791862 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791883 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791903 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012810597 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013070371 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071036 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012739034 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759673 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759727 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760121 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760207 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760545 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080238 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080625 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRefundDomesticRefundResponse> ExecuteCreateRefundDomesticRefundAsync(this WechatTenpayClient client, Models.CreateRefundDomesticRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "refund", "domestic", "refunds");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateRefundDomesticRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refund/domestic/refunds/{out_refund_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012556587 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012587973 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791863 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791884 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791904 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012810601 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013070374 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071041 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012739043 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759680 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759733 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760128 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760554 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080239 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080625 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080626 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRefundDomesticRefundByOutRefundNumberResponse> ExecuteGetRefundDomesticRefundByOutRefundNumberAsync(this WechatTenpayClient client, Models.GetRefundDomesticRefundByOutRefundNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "refund", "domestic", "refunds", request.OutRefundNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetRefundDomesticRefundByOutRefundNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /refund/domestic/refunds/{refund_id}/apply-abnormal-refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071193 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080627 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRefundDomesticAbnormalRefundApplyResponse> ExecuteCreateRefundDomesticAbnormalRefundApplyAsync(this WechatTenpayClient client, Models.CreateRefundDomesticAbnormalRefundApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "refund", "domestic", "refunds", request.RefundId, "apply-abnormal-refund");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateRefundDomesticAbnormalRefundApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
