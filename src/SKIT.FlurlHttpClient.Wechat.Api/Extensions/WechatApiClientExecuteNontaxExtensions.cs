using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteNontaxExtensions
    {
        #region Bill
        /// <summary>
        /// <para>异步调用 [POST] /nontax/getbillauthurl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#2.2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxGetBillAuthUrlResponse> ExecuteNontaxGetBillAuthUrlAsync(this WechatApiClient client, Models.NontaxGetBillAuthUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Timestamp == null)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "getbillauthurl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxGetBillAuthUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/createbillcard 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxCreateBillCardResponse> ExecuteNontaxCreateBillCardAsync(this WechatApiClient client, Models.NontaxCreateBillCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "createbillcard")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxCreateBillCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/insertbill 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxInsertBillResponse> ExecuteNontaxInsertBillAsync(this WechatApiClient client, Models.NontaxInsertBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "insertbill")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxInsertBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [POST] /nontax/queryfee 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxQueryFeeResponse> ExecuteNontaxQueryFeeAsync(this WechatApiClient client, Models.NontaxQueryFeeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "queryfee")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxQueryFeeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/unifiedorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxUnifiedOrderResponse> ExecuteNontaxUnifiedOrderAsync(this WechatApiClient client, Models.NontaxUnifiedOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "unifiedorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxUnifiedOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/getorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxGetOrderResponse> ExecuteNontaxGetOrderAsync(this WechatApiClient client, Models.NontaxGetOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "getorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxGetOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/refund 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxRefundResponse> ExecuteNontaxRefundAsync(this WechatApiClient client, Models.NontaxRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "refund")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/downloadbill 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxDownloadBillResponse> ExecuteNontaxDownloadBillAsync(this WechatApiClient client, Models.NontaxDownloadBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "downloadbill")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxDownloadBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/notifyinconsistentorder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxNotifyInconsistentOrderResponse> ExecuteNontaxNotifyInconsistentOrderAsync(this WechatApiClient client, Models.NontaxNotifyInconsistentOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "notifyinconsistentorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxNotifyInconsistentOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/mocknotification 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxMockNotificationResponse> ExecuteNontaxMockNotificationAsync(this WechatApiClient client, Models.NontaxMockNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "mocknotification")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxMockNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/mockqueryfee 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxMockQueryFeeResponse> ExecuteNontaxMockQueryFeeAsync(this WechatApiClient client, Models.NontaxMockQueryFeeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "mockqueryfee")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxMockQueryFeeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/micropay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.9 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxMicroPayResponse> ExecuteNontaxMicroPayAsync(this WechatApiClient client, Models.NontaxMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "micropay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/getorderlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#6.1.9 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxGetOrderListResponse> ExecuteNontaxGetOrderListAsync(this WechatApiClient client, Models.NontaxGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "getorderlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/getrealname 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#9.3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxGetRealNameResponse> ExecuteNontaxGetRealNameAsync(this WechatApiClient client, Models.NontaxGetRealNameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "getrealname")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxGetRealNameResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Vehicle
        /// <summary>
        /// <para>异步调用 [POST] /nontax/vehicle/querystate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/Non-tax_driver_platform.html#2.1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxVehicleQueryStateResponse> ExecuteNontaxVehicleQueryStateAsync(this WechatApiClient client, Models.NontaxVehicleQueryStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "vehicle", "querystate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxVehicleQueryStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/vehicle/entrancenotify 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/Non-tax_driver_platform.html#2.2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxVehicleEntranceNotifyResponse> ExecuteNontaxVehicleEntranceNotifyAsync(this WechatApiClient client, Models.NontaxVehicleEntranceNotifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "vehicle", "entrancenotify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxVehicleEntranceNotifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nontax/vehicle/payapply 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/Non-tax_driver_platform.html#2.3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NontaxVehiclePayApplyResponse> ExecuteNontaxVehiclePayApplyAsync(this WechatApiClient client, Models.NontaxVehiclePayApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nontax", "vehicle", "payapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.NontaxVehiclePayApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
