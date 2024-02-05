using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayScoreExtensions
    {
        #region Permissions
        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-auth/apply-permissions.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "permissions");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPayScorePermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-auth/get-permissions-by-authorization-code.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-auth/terminate-permissions-by-code.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePayScorePermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/permissions/openid/{openid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-auth/get-permissions-by-open-id.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "permissions", "openid", request.OpenId!)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("service_id", request.ServiceId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/permissions/openid/{openid}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-auth/terminate-permissions-by-open-id.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "permissions", "openid", request.OpenId!, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePayScorePermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ServiceOrder
        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/direct-complete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder", "direct-complete");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScoreServiceOrderDirectCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/create-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScoreServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/get-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "serviceorder")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreServiceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/get-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "serviceorder")
                .SetQueryParam("query_id", request.QueryId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreServiceOrderByQueryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/cancel-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPayScoreServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/modify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/modify-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "modify");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyPayScoreServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/complete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/complete-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "complete");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScoreServiceOrderCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/collect-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "pay");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScoreServiceOrderPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/serviceorder/{out_order_no}/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/service-order/sync-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "serviceorder", request.OutOrderNumber, "sync");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScoreServiceOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
