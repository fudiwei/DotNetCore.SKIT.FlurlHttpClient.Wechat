using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantSettlementExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant-settlement/merchant-settle-rule-applications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter3_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantSettlementSettleRuleApplymentResponse> ExecuteCreateMerchantSettlementSettleRuleApplymentAsync(this WechatTenpayClient client, Models.CreateMerchantSettlementSettleRuleApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-settlement", "merchant-settle-rule-applications");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantSettlementSettleRuleApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-settlement/merchant-settle-rule-applications/{application_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter3_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantSettlementSettleRuleApplicationByApplymentIdResponse> ExecuteGetMerchantSettlementSettleRuleApplicationByApplymentIdAsync(this WechatTenpayClient client, Models.GetMerchantSettlementSettleRuleApplicationByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "merchant-settlement", "merchant-settle-rule-applications", request.ApplymentId);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantSettlementSettleRuleApplicationByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
