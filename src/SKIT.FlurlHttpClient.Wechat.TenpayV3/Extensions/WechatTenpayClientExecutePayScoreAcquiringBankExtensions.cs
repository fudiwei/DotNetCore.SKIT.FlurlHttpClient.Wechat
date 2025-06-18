using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayScoreAcquiringBankExtensions
    {
        #region Permissions
        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/permissions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691489 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "permissions");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPayScoreAcquiringBankPermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/permissions/authorization-code/{authorization_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012461004 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "permissions", "authorization-code", request.AuthorizationCode)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreAcquiringBankPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/permissions/authorization-code/{authorization_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012461012 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "permissions", "authorization-code", request.AuthorizationCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePayScoreAcquiringBankPermissionsByAuthorizationCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ServiceOrder
        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691326 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayScoreAcquiringBankServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691343 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "serviceorder")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("channel_id", request.ChannelId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreAcquiringBankServiceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/serviceorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691343 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "serviceorder")
                .SetQueryParam("query_id", request.QueryId)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("channel_id", request.ChannelId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreAcquiringBankServiceOrderByQueryIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012458146 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPayScoreAcquiringBankServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/modify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012458146 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyPayScoreAcquiringBankServiceOrderResponse> ExecuteModifyPayScoreAcquiringBankServiceOrderAsync(this WechatTenpayClient client, Models.ModifyPayScoreAcquiringBankServiceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "modify");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyPayScoreAcquiringBankServiceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/complete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460791 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "complete");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScoreAcquiringBankServiceOrderCompleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012691378 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetPayScoreAcquiringBankServiceOrderSyncResponse> ExecuteSetPayScoreAcquiringBankServiceOrderSyncAsync(this WechatTenpayClient client, Models.SetPayScoreAcquiringBankServiceOrderSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "sync");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetPayScoreAcquiringBankServiceOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/registerdeductinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012458414 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "payscore", "acquiringbank", "serviceorder", request.OutOrderNumber, "registerdeductinfo");

            return await client.SendFlurlRequestAsJsonAsync<Models.RegisterPayScoreAcquiringBankServiceOrderDeductionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /payscore/acquiringbank/serviceorder/deduction 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012458665 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "acquiringbank", "serviceorder", "deduction")
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("service_id", request.ServiceId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("channel_id", request.ChannelId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreAcquiringBankServiceOrderDeductionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
