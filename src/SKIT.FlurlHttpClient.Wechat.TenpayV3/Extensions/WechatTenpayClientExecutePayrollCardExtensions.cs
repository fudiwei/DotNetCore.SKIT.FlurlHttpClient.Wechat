using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayrollCardExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/tokens 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayrollCardTokenResponse> ExecuteCreatePayrollCardTokenAsync(this WechatTenpayClient client, Models.CreatePayrollCardTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payroll-card", "tokens");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayrollCardTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payroll-card/relations/{openid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayrollRelationByOpenIdResponse> ExecuteGetPayrollRelationByOpenIdAsync(this WechatTenpayClient client, Models.GetPayrollRelationByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payroll-card", "relations", request.OpenId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.AppId is not null)
                flurlReq.SetQueryParam("appid", request.AppId);

            if (request.SubAppId is not null)
                flurlReq.SetQueryParam("sub_appid", request.SubAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayrollRelationByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Authentications
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/authentications/pre-order-with-auth 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_29.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PreorderPayrollCardAuthenticationResponse> ExecutePreorderPayrollCardAuthenticationAsync(this WechatTenpayClient client, Models.PreorderPayrollCardAuthenticationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payroll-card", "authentications", "pre-order-with-auth");

            return await client.SendFlurlRequestAsJsonAsync<Models.PreorderPayrollCardAuthenticationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payroll-card/authentications/{authenticate_number} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayrollCardAuthenticationByAuthenticateNumberResponse> ExecuteGetPayrollCardAuthenticationByAuthenticateNumberAsync(this WechatTenpayClient client, Models.GetPayrollCardAuthenticationByAuthenticateNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payroll-card", "authentications", request.AuthenticateNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayrollCardAuthenticationByAuthenticateNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payroll-card/authentications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_5.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryPayrollCardAuthenticationsResponse> ExecuteQueryPayrollCardAuthenticationsAsync(this WechatTenpayClient client, Models.QueryPayrollCardAuthenticationsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payroll-card", "authentications")
                .SetQueryParam("openid", request.OpenId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.AppId is not null)
                flurlReq.SetQueryParam("appid", request.AppId);

            if (request.SubAppId is not null)
                flurlReq.SetQueryParam("sub_appid", request.SubAppId);

            if (request.AuthenticateDateString is not null)
                flurlReq.SetQueryParam("authenticate_date", request.AuthenticateDateString);

            if (request.AuthenticateState is not null)
                flurlReq.SetQueryParam("authenticate_state", request.AuthenticateState);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryPayrollCardAuthenticationsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region TransferBatches
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/transfer-batches 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_6.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayrollCardTransferBatchResponse> ExecuteCreatePayrollCardTransferBatchAsync(this WechatTenpayClient client, Models.CreatePayrollCardTransferBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payroll-card", "transfer-batches");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayrollCardTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Wesure
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/wesure/insurance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_32.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayrollCardWesureInsuranceResponse> ExecuteCreatePayrollCardWesureInsuranceAsync(this WechatTenpayClient client, Models.CreatePayrollCardWesureInsuranceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payroll-card", "wesure", "insurance");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayrollCardWesureInsuranceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/wesure/token-validations 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_31.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayrollCardWesureTokenValidationResponse> ExecuteGetPayrollCardWesureTokenValidationAsync(this WechatTenpayClient client, Models.GetPayrollCardWesureTokenValidationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payroll-card", "wesure", "token-validations");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayrollCardWesureTokenValidationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
