using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteWeBusinessPayExtensions
    {
        #region Bill
        /// <summary>
        /// <para>异步调用 [POST] /webizpay/bill/trade-bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507142 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayBillTradeBillResponse> ExecuteGetWeBusinessPayBillTradeBillAsync(this WechatTenpayClient client, Models.GetWeBusinessPayBillTradeBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "bill", "trade-bill");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayBillTradeBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /webizpay/bill/proof 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507157 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayBillProofResponse> ExecuteGetWeBusinessPayBillProofAsync(this WechatTenpayClient client, Models.GetWeBusinessPayBillProofRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "bill", "proof");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayBillProofResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Employees
        /// <summary>
        /// <para>异步调用 [POST] /webizpay/employees/{employee_id}/quota-cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507148 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateWeBusinessPayEmployeeQuotaCardResponse> ExecuteCreateWeBusinessPayEmployeeQuotaCardAsync(this WechatTenpayClient client, Models.CreateWeBusinessPayEmployeeQuotaCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "employees", request.EmployeeId, "quota-cards");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateWeBusinessPayEmployeeQuotaCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /webizpay/employees/{employee_id}/out-quota-cards/{out_card_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015001625 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayEmployeeQuotaCardByOutCardNumberResponse> ExecuteGetWeBusinessPayEmployeeQuotaCardByOutCardNumberAsync(this WechatTenpayClient client, Models.GetWeBusinessPayEmployeeQuotaCardByOutCardNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "webizpay", "employees", request.EmployeeId, "out-quota-cards", request.OutCardNumber)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayEmployeeQuotaCardByOutCardNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /webizpay/employees/{employee_id}/quota-cards/{card_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507119 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayEmployeeQuotaCardByCardNumberResponse> ExecuteGetWeBusinessPayEmployeeQuotaCardByCardNumberAsync(this WechatTenpayClient client, Models.GetWeBusinessPayEmployeeQuotaCardByCardNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "webizpay", "employees", request.EmployeeId, "quota-cards", request.CardNumber)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayEmployeeQuotaCardByCardNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /webizpay/employees/{employee_id}/revoke 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507156 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RevokeGetWeBusinessPayEmployeeResponse> ExecuteRevokeGetWeBusinessPayEmployeeAsync(this WechatTenpayClient client, Models.RevokeGetWeBusinessPayEmployeeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "employees", request.EmployeeId, "revoke");

            return await client.SendFlurlRequestAsJsonAsync<Models.RevokeGetWeBusinessPayEmployeeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /webizpay/employees/{employee_id}/quota-cards/{card_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507127 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelWeBusinessPayEmployeeQuotaCardResponse> ExecuteCancelWeBusinessPayEmployeeQuotaCardAsync(this WechatTenpayClient client, Models.CancelWeBusinessPayEmployeeQuotaCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "employees", request.EmployeeId, "quota-cards", request.CardNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelWeBusinessPayEmployeeQuotaCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /webizpay/employees/{employee_id}/quota-cards/{card_no}/payment-url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507160 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayEmployeeQuotaCardPaymentUrlResponse> ExecuteGetWeBusinessPayEmployeeQuotaCardPaymentUrlAsync(this WechatTenpayClient client, Models.GetWeBusinessPayEmployeeQuotaCardPaymentUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "webizpay", "employees", request.EmployeeId, "quota-cards", request.CardNumber, "payment-url")
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("application_type", request.ApplicationType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayEmployeeQuotaCardPaymentUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Stores
        /// <summary>
        /// <para>异步调用 [POST] /webizpay/stores/entity-matches 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507136 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateWeBusinessPayStoreEntityMatchResponse> ExecuteCreateWeBusinessPayStoreEntityMatchAsync(this WechatTenpayClient client, Models.CreateWeBusinessPayStoreEntityMatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "stores", "entity-matches");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateWeBusinessPayStoreEntityMatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /webizpay/stores/entity-matches/{batch_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507133 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayStoreEntityMatchByBatchIdResponse> ExecuteGetWeBusinessPayStoreEntityMatchByBatchIdAsync(this WechatTenpayClient client, Models.GetWeBusinessPayStoreEntityMatchByBatchIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "webizpay", "stores", "entity-matches", request.BatchId)
                .SetQueryParam("sp_mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayStoreEntityMatchByBatchIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Users
        /// <summary>
        /// <para>异步调用 [GET] /webizpay/users/{user_id}/authorization-state 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507163 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayUserAuthorizationStateResponse> ExecuteGetWeBusinessPayUserAuthorizationStateAsync(this WechatTenpayClient client, Models.GetWeBusinessPayUserAuthorizationStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "webizpay", "users", request.UserId, "authorization-state")
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayUserAuthorizationStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /webizpay/users/{user_id}/authorization-url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014507153 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWeBusinessPayUserAuthorizationUrlResponse> ExecuteGetWeBusinessPayUserAuthorizationUrlAsync(this WechatTenpayClient client, Models.GetWeBusinessPayUserAuthorizationUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "webizpay", "users", request.UserId, "authorization-url");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWeBusinessPayUserAuthorizationUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
