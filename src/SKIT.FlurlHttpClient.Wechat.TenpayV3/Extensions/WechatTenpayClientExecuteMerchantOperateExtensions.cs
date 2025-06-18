using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantOperateExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mch_operate/risk/withdrawl-apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012488950 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "mch_operate", "risk", "withdrawl-apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantOperateRiskWithdrawlApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mch_operate/risk/withdrawl-apply/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012476164 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "mch_operate", "risk", "withdrawl-apply", "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantOperateRiskWithdrawlApplyByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mch_operate/risk/withdrawl-apply/applyment-id/{applyment_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012778400 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "mch_operate", "risk", "withdrawl-apply", "applyment-id", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantOperateRiskWithdrawlApplyByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
