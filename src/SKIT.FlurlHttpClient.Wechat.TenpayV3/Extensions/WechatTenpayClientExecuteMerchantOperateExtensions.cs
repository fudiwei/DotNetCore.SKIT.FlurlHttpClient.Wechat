using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通注销后提现相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantOperateExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mch_operate/risk/withdrawl-apply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/withdrawal-apply/withdrawal-apply/submit-apply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantOperateRiskWithdrawlApplyResponse> ExecuteCreateMerchantOperateRiskWithdrawlApplyAsync(this WechatTenpayClient client, Models.CreateMerchantOperateRiskWithdrawlApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mch_operate", "risk", "withdrawl-apply");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantOperateRiskWithdrawlApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mch_operate/risk/withdrawl-apply/out-request-no/{out_request_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/withdrawal-apply/withdrawal-apply/get-apply-by-out-request-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantOperateRiskWithdrawlApplyByOutRequestNumberResponse> ExecuteGetMerchantOperateRiskWithdrawlApplyByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetMerchantOperateRiskWithdrawlApplyByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mch_operate", "risk", "withdrawl-apply", "out-request-no", request.OutRequestNumber);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantOperateRiskWithdrawlApplyByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mch_operate/risk/withdrawl-apply/applyment-id/{applyment_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/withdrawal-apply/withdrawal-apply/get-apply-by-applyment-id.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantOperateRiskWithdrawlApplyByApplymentIdResponse> ExecuteGetMerchantOperateRiskWithdrawlApplyByApplymentIdAsync(this WechatTenpayClient client, Models.GetMerchantOperateRiskWithdrawlApplyByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mch_operate", "risk", "withdrawl-apply", "applyment-id", request.ApplymentId);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantOperateRiskWithdrawlApplyByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
