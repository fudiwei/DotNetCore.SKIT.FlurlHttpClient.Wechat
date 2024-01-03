using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayTransactionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/app 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/direct-jsons/app-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionAppResponse> ExecuteCreatePayTransactionAppAsync(this WechatTenpayClient client, Models.CreatePayTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "transactions", "app");

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/jsapi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/direct-jsons/jsapi-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/mini-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionJsapiResponse> ExecuteCreatePayTransactionJsapiAsync(this WechatTenpayClient client, Models.CreatePayTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "transactions", "jsapi");

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/h5 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/direct-jsons/h5-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionH5Response> ExecuteCreatePayTransactionH5Async(this WechatTenpayClient client, Models.CreatePayTransactionH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "transactions", "h5");

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionH5Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/native 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/native-payment/direct-jsons/native-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionNativeResponse> ExecuteCreatePayTransactionNativeAsync(this WechatTenpayClient client, Models.CreatePayTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "transactions", "native");

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/native-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/query-by-out-trade-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayTransactionByOutTradeNumberResponse> ExecuteGetPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "pay", "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay/transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/native-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/query-by-wx-trade-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayTransactionByIdResponse> ExecuteGetPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "pay", "transactions", "id", request.TransactionId)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/native-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/close-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePayTransactionResponse> ExecuteClosePayTransactionAsync(this WechatTenpayClient client, Models.ClosePayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "pay", "transactions", "out-trade-no", request.OutTradeNumber, "close");

            return await client.SendRequestWithJsonAsync<Models.ClosePayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
