using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微信支付分相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayScoreExtensions
    {
        #region Permissions
        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPayScorePermissionsResponse> ExecuteApplyPayScorePermissionsAsync(this WechatTenpayClient client, Models.ApplyPayScorePermissionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "permissions");

            return await client.SendRequestWithJsonAsync<Models.ApplyPayScorePermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePermissionsByAuthorizationCodeResponse> ExecuteGetPayScorePermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.GetPayScorePermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePermissionsByAuthorizationCodeResponse> ExecuteTerminatePayScorePermissionsByAuthorizationCodeAsync(this WechatTenpayClient client, Models.TerminatePayScorePermissionsByAuthorizationCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/permissions/openid/{openid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePermissionsByOpenIdResponse> ExecuteGetPayScorePermissionsByOpenIdAsync(this WechatTenpayClient client, Models.GetPayScorePermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "permissions", "openid", request.OpenId!)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("service_id", request.ServiceId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScorePermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions/openid/{openid}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePayScorePermissionsByOpenIdResponse> ExecuteTerminatePayScorePermissionsByOpenIdAsync(this WechatTenpayClient client, Models.TerminatePayScorePermissionsByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "permissions", "openid", request.OpenId!, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminatePayScorePermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ServiceOrder
        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/direct-complete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScoreServiceOrderDirectCompleteResponse> ExecuteCreatePayScoreServiceOrderDirectCompleteAsync(this WechatTenpayClient client, Models.CreatePayScoreServiceOrderDirectCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder", "direct-complete");

            return await client.SendRequestWithJsonAsync<Models.CreatePayScoreServiceOrderDirectCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_14.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScoreServiceOrderResponse> ExecuteCreatePayScoreServiceOrderAsync(this WechatTenpayClient client, Models.CreatePayScoreServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder");

            return await client.SendRequestWithJsonAsync<Models.CreatePayScoreServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreServiceOrderByOutOrderNumberResponse> ExecuteGetPayScoreServiceOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetPayScoreServiceOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "serviceorder")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScoreServiceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/serviceorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreServiceOrderByQueryIdResponse> ExecuteGetPayScoreServiceOrderByQueryIdAsync(this WechatTenpayClient client, Models.GetPayScoreServiceOrderByQueryIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "payscore", "serviceorder")
                .SetQueryParam("query_id", request.QueryId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetPayScoreServiceOrderByQueryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_16.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelPayScoreServiceOrderResponse> ExecuteCancelPayScoreServiceOrderAsync(this WechatTenpayClient client, Models.CancelPayScoreServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "cancel");

            return await client.SendRequestWithJsonAsync<Models.CancelPayScoreServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/modify 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyPayScoreServiceOrderResponse> ExecuteModifyPayScoreServiceOrderAsync(this WechatTenpayClient client, Models.ModifyPayScoreServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "modify");

            return await client.SendRequestWithJsonAsync<Models.ModifyPayScoreServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/complete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_18.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScoreServiceOrderCompleteResponse> ExecuteSetPayScoreServiceOrderCompleteAsync(this WechatTenpayClient client, Models.SetPayScoreServiceOrderCompleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "complete");

            return await client.SendRequestWithJsonAsync<Models.SetPayScoreServiceOrderCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/pay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_19.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScoreServiceOrderPayResponse> ExecuteSetPayScoreServiceOrderPayAsync(this WechatTenpayClient client, Models.SetPayScoreServiceOrderPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "pay");

            return await client.SendRequestWithJsonAsync<Models.SetPayScoreServiceOrderPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/sync 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScoreServiceOrderSyncResponse> ExecuteSetPayScoreServiceOrderSyncAsync(this WechatTenpayClient client, Models.SetPayScoreServiceOrderSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "sync");

            return await client.SendRequestWithJsonAsync<Models.SetPayScoreServiceOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
