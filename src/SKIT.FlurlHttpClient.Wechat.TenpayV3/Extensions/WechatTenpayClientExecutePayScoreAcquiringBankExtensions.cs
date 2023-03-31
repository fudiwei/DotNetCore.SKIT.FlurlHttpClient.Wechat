using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微信支付分从业机构相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayScoreAcquiringBankExtensions
    {
        #region Permissions
        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/permissions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/acquiringbank/apis/acquiringbank-institution-weixin-pay-score/acquiring-bank-service-auth/apply-acquiring-bank-permissions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPayScoreAcquiringBankPermissionsResponse> ExecuteApplyPayScoreAcquiringBankPermissionsAsync(this WechatTenpayClient client, Models.ApplyPayScoreAcquiringBankPermissionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "permissions");

            return await client.SendRequestWithJsonAsync<Models.ApplyPayScoreAcquiringBankPermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/acquiringbank/apis/acquiringbank-institution-weixin-pay-score/acquiring-bank-service-auth/get-acquiring-bank-permissions-by-code.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreAcquiringBankPermissionsByAuthorizationCodeResponse> ExecuteGetPayScoreAcquiringBankPermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.GetPayScoreAcquiringBankPermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScoreAcquiringBankPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/acquiringbank/apis/acquiringbank-institution-weixin-pay-score/acquiring-bank-service-auth/terminate-acquiring-bank-permissions-by-code.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScoreAcquiringBankPermissionsByAuthorizationCodeResponse> ExecuteTerminatePayScoreAcquiringBankPermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.TerminatePayScoreAcquiringBankPermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScoreAcquiringBankPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ServiceOrder
        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/acquiringbank/apis/acquiringbank-institution-weixin-pay-score/acquiring-bank-service-order/create-acquiring-bank-service-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScoreAcquiringBankServiceOrderResponse> ExecuteCreatePayScoreAcquiringBankServiceOrderAsync(this WechatTenpayClient client, Models.CreatePayScoreAcquiringBankServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder");

            return await client.SendRequestWithJsonAsync<Models.CreatePayScoreAcquiringBankServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_acquiringbank/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreAcquiringBankServiceOrderByOutOrderNumberResponse> ExecuteGetPayScoreAcquiringBankServiceOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetPayScoreAcquiringBankServiceOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "serviceorder")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("channel_id", request.ChannelId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScoreAcquiringBankServiceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/acquiringbank/apis/acquiringbank-institution-weixin-pay-score/acquiring-bank-service-order/get-acquiring-bank-service-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreAcquiringBankServiceOrderByQueryIdResponse> ExecuteGetPayScoreAcquiringBankServiceOrderByQueryIdAsync(this WechatTenpayClient client, Models.GetPayScoreAcquiringBankServiceOrderByQueryIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "serviceorder")
                .SetQueryParam("query_id", request.QueryId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("channel_id", request.ChannelId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScoreAcquiringBankServiceOrderByQueryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-institution-weixin-pay-score/acquiring-bank-service-order/cancel-acquiring-bank-service-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelPayScoreAcquiringBankServiceOrderResponse> ExecuteCancelPayScoreAcquiringBankServiceOrderAsync(this WechatTenpayClient client, Models.CancelPayScoreAcquiringBankServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "cancel");

            return await client.SendRequestWithJsonAsync<Models.CancelPayScoreAcquiringBankServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/complete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_acquiringbank/chapter3_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScoreAcquiringBankServiceOrderCompleteResponse> ExecuteSetPayScoreAcquiringBankServiceOrderCompleteAsync(this WechatTenpayClient client, Models.SetPayScoreAcquiringBankServiceOrderCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "complete");

            return await client.SendRequestWithJsonAsync<Models.SetPayScoreAcquiringBankServiceOrderCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/registerdeductinfo 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-institution-weixin-pay-score/acquiring-bank-service-order/register-deduct-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RegisterPayScoreAcquiringBankServiceOrderDeductionResponse> ExecuteRegisterPayScoreAcquiringBankServiceOrderDeductionAsync(this WechatTenpayClient client, Models.RegisterPayScoreAcquiringBankServiceOrderDeductionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "registerdeductinfo");

            return await client.SendRequestWithJsonAsync<Models.RegisterPayScoreAcquiringBankServiceOrderDeductionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/serviceorder/deduction 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-institution-weixin-pay-score/acquiring-bank-service-order/get-acquiring-bank-deduct-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreAcquiringBankServiceOrderDeductionResponse> ExecuteGetPayScoreAcquiringBankServiceOrderDeductionAsync(this WechatTenpayClient client, Models.GetPayScoreAcquiringBankServiceOrderDeductionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "serviceorder", "deduction")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("channel_id", request.ChannelId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScoreAcquiringBankServiceOrderDeductionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
