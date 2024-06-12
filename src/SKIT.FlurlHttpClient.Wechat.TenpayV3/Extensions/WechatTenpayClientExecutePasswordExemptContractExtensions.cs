using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePasswordExemptContractExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /password-exempt-contract/contracts/qs/pre-entrust-sign/mini-program 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-password-free-contract/sign/qs-mini-program-pre-entrust-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPasswordExemptContractQsEntrustMiniProgramResponse> ExecutePresignPasswordExemptContractQsEntrustMiniProgramAsync(this WechatTenpayClient client, Models.PresignPasswordExemptContractQsEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "password-exempt-contract", "contracts", "qs", "pre-entrust-sign", "mini-program");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPasswordExemptContractQsEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /password-exempt-contract/contracts/qs/pre-entrust-sign/pay-redirect-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-password-free-contract/sign/qs-pay-redirect-sign-pre-entrust-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPasswordExemptContractQsEntrustPayRedirectSignResponse> ExecutePresignPasswordExemptContractQsEntrustPayRedirectSignAsync(this WechatTenpayClient client, Models.PresignPasswordExemptContractQsEntrustPayRedirectSignRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "password-exempt-contract", "contracts", "qs", "pre-entrust-sign", "pay-redirect-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPasswordExemptContractQsEntrustPayRedirectSignResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /password-exempt-contract/contracts/service-provider/pre-entrust-sign/mini-program 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-password-free-contract/sign/sp-mini-program-pre-entrust-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPasswordExemptContractServiceProviderEntrustMiniProgramResponse> ExecutePresignPasswordExemptContractServiceProviderEntrustMiniProgramAsync(this WechatTenpayClient client, Models.PresignPasswordExemptContractServiceProviderEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "password-exempt-contract", "contracts", "service-provider", "pre-entrust-sign", "mini-program");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPasswordExemptContractServiceProviderEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /password-exempt-contract/contracts/service-provider/pre-entrust-sign/pay-redirect-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-password-free-contract/sign/sp-pay-redirect-sign-pre-entrust-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPasswordExemptContractServiceProviderEntrustPayRedirectSignResponse> ExecutePresignPasswordExemptContractServiceProviderEntrustPayRedirectSignAsync(this WechatTenpayClient client, Models.PresignPasswordExemptContractServiceProviderEntrustPayRedirectSignRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "password-exempt-contract", "contracts", "service-provider", "pre-entrust-sign", "pay-redirect-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPasswordExemptContractServiceProviderEntrustPayRedirectSignResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /password-exempt-contract/contracts/service-id/{service_id}/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-password-free-contract/contract/partner-get-by-code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPasswordExemptContractByOutContractCodeResponse> ExecuteGetPasswordExemptContractByOutContractCodeAsync(this WechatTenpayClient client, Models.GetPasswordExemptContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "password-exempt-contract", "contracts", "service-id", request.ServiceId, "out-contract-code", request.OutContractCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPasswordExemptContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /password-exempt-contract/contracts/service-id/{service_id}/out-contract-code/{out_contract_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-password-free-contract/contract/partner-terminate-by-code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePasswordExemptContractResponse> ExecuteTerminatePasswordExemptContractAsync(this WechatTenpayClient client, Models.TerminatePasswordExemptContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "password-exempt-contract", "contracts", "service-id", request.ServiceId, "out-contract-code", request.OutContractCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePasswordExemptContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
