using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteComplianceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /compliance/inactive-merchant-identity-verification/merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/inactive-merchant-identity-verification/inactive-mch-identity-verification/create-inactive-merchant-identity-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateComplianceInactiveMerchantIdentityVerificationResponse> ExecuteCreateComplianceInactiveMerchantIdentityVerificationAsync(this WechatTenpayClient client, Models.CreateComplianceInactiveMerchantIdentityVerificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "compliance", "inactive-merchant-identity-verification", "merchants");

            return await client.SendRequestWithJsonAsync<Models.CreateComplianceInactiveMerchantIdentityVerificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /compliance/inactive-merchant-identity-verification/merchants/{sub_mchid}/verifications/{verification_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/inactive-merchant-identity-verification/inactive-mch-identity-verification/query-inactive-merchant-identity-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetComplianceInactiveMerchantIdentityVerificationByVerificationIdResponse> ExecuteGetComplianceInactiveMerchantIdentityVerificationByVerificationIdAsync(this WechatTenpayClient client, Models.GetComplianceInactiveMerchantIdentityVerificationByVerificationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "compliance", "inactive-merchant-identity-verification", "merchants", request.SubMerchantId, "verifications", request.VerificationId);

            return await client.SendRequestWithJsonAsync<Models.GetComplianceInactiveMerchantIdentityVerificationByVerificationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
