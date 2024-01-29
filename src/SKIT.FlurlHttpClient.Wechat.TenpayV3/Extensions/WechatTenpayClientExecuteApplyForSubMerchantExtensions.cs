using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteApplyForSubMerchantExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /applyment4sub/applyment/ 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/applyment/submit.html </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_6_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateApplyForSubMerchantApplymentResponse> ExecuteCreateApplyForSubMerchantApplymentAsync(this WechatTenpayClient client, Models.CreateApplyForSubMerchantApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            // NOTICE: 注意本接口 URL 结尾的反斜杠不能删除
            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "applyment4sub", "applyment", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateApplyForSubMerchantApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /applyment4sub/applyment/business_code/{business_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/applyment/query-state.html </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_6_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubMerchantApplymentByBusinessCodeResponse> ExecuteGetApplyForSubMerchantApplymentByBusinessCodeAsync(this WechatTenpayClient client, Models.GetApplyForSubMerchantApplymentByBusinessCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "applyment4sub", "applyment", "business_code", request.BusinessCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubMerchantApplymentByBusinessCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /applyment4sub/applyment/applyment_id/{applyment_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/applyment/query-state-by-id.html </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_6_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubMerchantApplymentByApplymentIdResponse> ExecuteGetApplyForSubMerchantApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetApplyForSubMerchantApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "applyment4sub", "applyment", "applyment_id", request.ApplymentId.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubMerchantApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apply4sub/sub_merchants/{sub_mchid}/modify-settlement 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/modify-settlement.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/modify-settlement.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyApplyForSubMerchantSettlementResponse> ExecuteModifyApplyForSubMerchantSettlementAsync(this WechatTenpayClient client, Models.ModifyApplyForSubMerchantSettlementRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "apply4sub", "sub_merchants", request.SubMerchantId, "modify-settlement");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyApplyForSubMerchantSettlementResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4sub/sub_merchants/{sub_mchid}/settlement 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/get-settlement.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/get-settlement.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubMerchantSettlementResponse> ExecuteGetApplyForSubMerchantSettlementAsync(this WechatTenpayClient client, Models.GetApplyForSubMerchantSettlementRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apply4sub", "sub_merchants", request.SubMerchantId, "settlement");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubMerchantSettlementResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4sub/sub_merchants/{sub_mchid}/application/{application_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/get-application.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/contracted-merchant-application/get-application.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubMerchantSettlementByApplicationNumberResponse> ExecuteGetApplyForSubMerchantSettlementByApplicationNumberAsync(this WechatTenpayClient client, Models.GetApplyForSubMerchantSettlementByApplicationNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "apply4sub", "sub_merchants", request.SubMerchantId, "application", request.ApplicationNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubMerchantSettlementByApplicationNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
