using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微工卡相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayrollCardExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/tokens 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "payroll-card", "tokens");

            return await client.SendRequestWithJsonAsync<Models.CreatePayrollCardTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payroll-card/relations/{openid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "payroll-card", "relations", request.OpenId);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.AppId != null)
                flurlReq.SetQueryParam("appid", request.AppId);

            if (request.SubAppId != null)
                flurlReq.SetQueryParam("sub_appid", request.SubAppId);

            return await client.SendRequestWithJsonAsync<Models.GetPayrollRelationByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Authentications
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/authentications/pre-order-with-auth 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_29.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PreOrderWithAuthPayrollCardAuthenticationResponse> ExecutePreOrderWithAuthPayrollCardAuthenticationAsync(this WechatTenpayClient client, Models.PreOrderWithAuthPayrollCardAuthenticationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payroll-card", "authentications", "pre-order-with-auth");

            return await client.SendRequestWithJsonAsync<Models.PreOrderWithAuthPayrollCardAuthenticationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payroll-card/authentications/{authenticate_number} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "payroll-card", "authentications", request.AuthenticateNumber);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayrollCardAuthenticationByAuthenticateNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payroll-card/authentications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "payroll-card", "authentications")
                .SetQueryParam("openid", request.OpenId);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.AppId != null)
                flurlReq.SetQueryParam("appid", request.AppId);

            if (request.SubAppId != null)
                flurlReq.SetQueryParam("sub_appid", request.SubAppId);

            if (request.AuthenticateDateString != null)
                flurlReq.SetQueryParam("authenticate_date", request.AuthenticateDateString);

            if (request.AuthenticateState != null)
                flurlReq.SetQueryParam("authenticate_state", request.AuthenticateState);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit);

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset);

            return await client.SendRequestWithJsonAsync<Models.QueryPayrollCardAuthenticationsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region TransferBatches
        /// <summary>
        /// <para>异步调用 [POST] /payroll-card/transfer-batches 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_1_6.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "payroll-card", "transfer-batches");

            return await client.SendRequestWithJsonAsync<Models.CreatePayrollCardTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
