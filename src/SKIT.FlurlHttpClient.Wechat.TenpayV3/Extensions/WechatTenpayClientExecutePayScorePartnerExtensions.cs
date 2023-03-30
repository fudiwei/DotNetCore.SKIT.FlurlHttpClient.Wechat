using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微信支付分服务商相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayScorePartnerExtensions
    {
        #region Permissions
        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPayScorePartnerPermissionsResponse> ExecuteApplyPayScorePartnerPermissionsAsync(this WechatTenpayClient client, Models.ApplyPayScorePartnerPermissionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "permissions");

            return await client.SendRequestWithJsonAsync<Models.ApplyPayScorePartnerPermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerPermissionsByAuthorizationCodeResponse> ExecuteGetPayScorePartnerPermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.GetPayScorePartnerPermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "partner", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePartnerPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeResponse> ExecuteTerminatePayScorePartnerPermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/permissions/search 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerPermissionsByOpenIdResponse> ExecuteGetPayScorePartnerPermissionsByOpenIdAsync(this WechatTenpayClient client, Models.GetPayScorePartnerPermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "partner", "permissions", "search")
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("sub_appid", request.SubAppId);

            if (request.OpenId != null)
                flurlReq.SetQueryParam("openid", request.OpenId);

            if (request.SubOpenId != null)
                flurlReq.SetQueryParam("sub_openid", request.SubOpenId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePartnerPermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter5_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePartnerPermissionsByOpenIdResponse> ExecuteTerminatePayScorePartnerPermissionsByOpenIdAsync(this WechatTenpayClient client, Models.TerminatePayScorePartnerPermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePartnerPermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ServiceOrder
        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScorePartnerServiceOrderResponse> ExecuteCreatePayScorePartnerServiceOrderAsync(this WechatTenpayClient client, Models.CreatePayScorePartnerServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder");

            return await client.SendRequestWithJsonAsync<Models.CreatePayScorePartnerServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerServiceOrderByOutOrderNumberResponse> ExecuteGetPayScorePartnerServiceOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetPayScorePartnerServiceOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "partner", "serviceorder")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePartnerServiceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerServiceOrderByQueryIdResponse> ExecuteGetPayScorePartnerServiceOrderByQueryIdAsync(this WechatTenpayClient client, Models.GetPayScorePartnerServiceOrderByQueryIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "partner", "serviceorder")
                .SetQueryParam("query_id", request.QueryId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePartnerServiceOrderByQueryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelPayScorePartnerServiceOrderResponse> ExecuteCancelPayScorePartnerServiceOrderAsync(this WechatTenpayClient client, Models.CancelPayScorePartnerServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "cancel");

            return await client.SendRequestWithJsonAsync<Models.CancelPayScorePartnerServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/modify 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyPayScorePartnerServiceOrderResponse> ExecuteModifyPayScorePartnerServiceOrderAsync(this WechatTenpayClient client, Models.ModifyPayScorePartnerServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "modify");

            return await client.SendRequestWithJsonAsync<Models.ModifyPayScorePartnerServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/complete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScorePartnerServiceOrderCompleteResponse> ExecuteSetPayScorePartnerServiceOrderCompleteAsync(this WechatTenpayClient client, Models.SetPayScorePartnerServiceOrderCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "complete");

            return await client.SendRequestWithJsonAsync<Models.SetPayScorePartnerServiceOrderCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/pay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScorePartnerServiceOrderPayResponse> ExecuteSetPayScorePartnerServiceOrderPayAsync(this WechatTenpayClient client, Models.SetPayScorePartnerServiceOrderPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "pay");

            return await client.SendRequestWithJsonAsync<Models.SetPayScorePartnerServiceOrderPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/sync 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScorePartnerServiceOrderSyncResponse> ExecuteSetPayScorePartnerServiceOrderSyncAsync(this WechatTenpayClient client, Models.SetPayScorePartnerServiceOrderSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "sync");

            return await client.SendRequestWithJsonAsync<Models.SetPayScorePartnerServiceOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #endregion
    }
}
