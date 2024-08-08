using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayScorePartnerExtensions
    {
        #region Permissions
        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/apply-partner-permissions.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "permissions");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPayScorePartnerPermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/apply-for-scene 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/scene-apply-partner-permissions.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPayScorePartnerPermissionsForSceneResponse> ExecuteApplyPayScorePartnerPermissionsForSceneAsync(this WechatTenpayClient client, Models.ApplyPayScorePartnerPermissionsForSceneRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "apply-for-scene");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPayScorePartnerPermissionsForSceneResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/get-partner-permissions-by-code.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "partner", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/terminate-partner-permissions-by-code.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePayScorePartnerPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/permissions/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/get-partner-permissions-by-open-id.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "partner", "permissions", "search")
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("sub_openid", request.SubOpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerPermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/terminate-partner-permissions-by-open-id.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePayScorePartnerPermissionsByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/permissions/assess-user-risk-level 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-auth/assess-partner-user-risk-level.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AssessPayScorePartnerPermissionsUserRiskLevelResponse> ExecuteAssessPayScorePartnerPermissionsUserRiskLevelAsync(this WechatTenpayClient client, Models.AssessPayScorePartnerPermissionsUserRiskLevelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "permissions", "assess-user-risk-level");

            return await client.SendFlurlRequestAsJsonAsync<Models.AssessPayScorePartnerPermissionsUserRiskLevelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Plan
        /// <summary>
        /// <para>异步调用 [POST] /payscore/plan/partner/payscore-plans 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-pay-score-plan/create-partner-pay-score-plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScorePartnerPlanResponse> ExecuteCreatePayScorePartnerPlanAsync(this WechatTenpayClient client, Models.CreatePayScorePartnerPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "plan", "partner", "payscore-plans");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScorePartnerPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/plan/partner/payscore-plans/merchant-plan-no/{merchant_plan_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-pay-score-plan/query-partner-pay-score-plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerPlanByOutPlanNumberResponse> ExecuteGetPayScorePartnerPlanByOutPlanNumberAsync(this WechatTenpayClient client, Models.GetPayScorePartnerPlanByOutPlanNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "plan", "partner", "payscore-plans", "merchant-plan-no", request.OutPlanNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerPlanByOutPlanNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/plan/partner/payscore-plans/merchant-plan-no/{merchant_plan_no}/stop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-pay-score-plan/stop-partner-pay-score-plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.StopPayScorePartnerPlanResponse> ExecuteStopPayScorePartnerPlanAsync(this WechatTenpayClient client, Models.StopPayScorePartnerPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "plan", "partner", "payscore-plans", "merchant-plan-no", request.OutPlanNumber, "stop");

            return await client.SendFlurlRequestAsJsonAsync<Models.StopPayScorePartnerPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ServiceOrder
        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/create-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScorePartnerServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/get-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "partner", "serviceorder")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerServiceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/get-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "partner", "serviceorder")
                .SetQueryParam("query_id", request.QueryId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerServiceOrderByQueryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/cancel-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPayScorePartnerServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/modify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/modify-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "modify");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyPayScorePartnerServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/complete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/complete-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "complete");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScorePartnerServiceOrderCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/payscore_partner/chapter3_6.shtml ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "pay");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScorePartnerServiceOrderPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/sync-partner-service-order.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "sync");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScorePartnerServiceOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/send-pendingmessage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/send-partner-order-pending-message.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayScorePartnerServiceOrderPendingMessageResponse> ExecuteSendPayScorePartnerServiceOrderPendingMessageAsync(this WechatTenpayClient client, Models.SendPayScorePartnerServiceOrderPendingMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "send-pendingmessage");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendPayScorePartnerServiceOrderPendingMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/partner/serviceorder/{out_order_no}/send-prepaidmessage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/partner-service-order/send-partner-order-prepaid-message.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayScorePartnerServiceOrderPrepaidMessageResponse> ExecuteSendPayScorePartnerServiceOrderPrepaidMessageAsync(this WechatTenpayClient client, Models.SendPayScorePartnerServiceOrderPrepaidMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "partner", "serviceorder", request.OutOrderNumber, "send-prepaidmessage");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendPayScorePartnerServiceOrderPrepaidMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ServiceQuota
        /// <summary>
        /// <para>异步调用 [GET] /payscore/partner/servicequotas/service-id/{service_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-weixin-pay-score/service-quota/get-partner-user-risk-level-quota.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerServiceQuotasByServiceIdResponse> ExecuteGetPayScorePartnerServiceQuotasByServiceIdAsync(this WechatTenpayClient client, Models.GetPayScorePartnerServiceQuotasByServiceIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "partner", "servicequotas", "service-id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("risk_level_version", request.RiskLevelVersion);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerServiceQuotasByServiceIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SignPlan
        /// <summary>
        /// <para>异步调用 [POST] /payscore/sign-plan/partner/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-service-order/create-partner-service-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScorePartnerSignPlanServiceOrderResponse> ExecuteCreatePayScorePartnerSignPlanServiceOrderAsync(this WechatTenpayClient client, Models.CreatePayScorePartnerSignPlanServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "sign-plan", "partner", "serviceorder");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScorePartnerSignPlanServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/sign-plan/partner/user-sign-plans 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-user-sign-plan/create-partner-user-sign-plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayScorePartnerSignPlanUserSignPlanResponse> ExecuteCreatePayScorePartnerSignPlanUserSignPlanAsync(this WechatTenpayClient client, Models.CreatePayScorePartnerSignPlanUserSignPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "sign-plan", "partner", "user-sign-plans");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScorePartnerSignPlanUserSignPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/sign-plan/partner/user-sign-plans/merchant-sign-plan-no/{merchant_sign_plan_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-user-sign-plan/query-partner-user-sign-plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScorePartnerSignPlanUserSignPlanByOutSignPlanNumberResponse> ExecuteGetPayScorePartnerSignPlanUserSignPlanByOutSignPlanNumberAsync(this WechatTenpayClient client, Models.GetPayScorePartnerSignPlanUserSignPlanByOutSignPlanNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "sign-plan", "partner", "user-sign-plans", "merchant-sign-plan-no", request.OutSignPlanNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScorePartnerSignPlanUserSignPlanByOutSignPlanNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/sign-plan/partner/user-sign-plans/merchant-sign-plan-no/{merchant_sign_plan_no}/stop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-payscore-plan/partner-user-sign-plan/stop-partner-user-sign-plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.StopPayScorePartnerSignPlanUserSignPlanResponse> ExecuteStopPayScorePartnerSignPlanUserSignPlanAsync(this WechatTenpayClient client, Models.StopPayScorePartnerSignPlanUserSignPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "sign-plan", "partner", "user-sign-plans", "merchant-sign-plan-no", request.OutSignPlanNumber, "stop");

            return await client.SendFlurlRequestAsJsonAsync<Models.StopPayScorePartnerSignPlanUserSignPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
