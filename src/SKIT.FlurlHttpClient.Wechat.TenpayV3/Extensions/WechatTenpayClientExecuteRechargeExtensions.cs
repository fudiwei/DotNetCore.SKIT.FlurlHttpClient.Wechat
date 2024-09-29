using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteRechargeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /recharge/bank-transfer-recharges/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/mch-recharge/bank-recharge/bank-transfer-recharge-apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyBankTransferRechargeResponse> ExecuteApplyBankTransferRechargeAsync(this WechatTenpayClient client, Models.ApplyBankTransferRechargeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "recharge", "bank-transfer-recharges", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyBankTransferRechargeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /recharge/bank-transfer-recharges/out-recharge-no/{out_recharge_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/mch-recharge/bank-recharge/bank-transfer-recharge-get-by-out-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankTransferRechargeByOutRechargeNumberResponse> ExecuteGetBankTransferRechargeByOutRechargeNumberAsync(this WechatTenpayClient client, Models.GetBankTransferRechargeByOutRechargeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "recharge", "bank-transfer-recharges", "out-recharge-no", request.OutRechargeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankTransferRechargeByOutRechargeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
