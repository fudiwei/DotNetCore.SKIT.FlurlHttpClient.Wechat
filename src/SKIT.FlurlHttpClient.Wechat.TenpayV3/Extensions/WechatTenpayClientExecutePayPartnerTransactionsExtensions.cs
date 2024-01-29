using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayPartnerTransactionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /pay/partner/transactions/app 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/partner-jsons/partner-app-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/app-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayPartnerTransactionAppResponse> ExecuteCreatePayPartnerTransactionAppAsync(this WechatTenpayClient client, Models.CreatePayPartnerTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "partner", "transactions", "app");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayPartnerTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/partner/transactions/jsapi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/partner-jsons/partner-jsapi-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/partner-mini-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/jsapi-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/mini-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayPartnerTransactionJsapiResponse> ExecuteCreatePayPartnerTransactionJsapiAsync(this WechatTenpayClient client, Models.CreatePayPartnerTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "partner", "transactions", "jsapi");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayPartnerTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/partner/transactions/h5 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/partner-jsons/partner-h5-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/h5-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayPartnerTransactionH5Response> ExecuteCreatePayPartnerTransactionH5Async(this WechatTenpayClient client, Models.CreatePayPartnerTransactionH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "partner", "transactions", "h5");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayPartnerTransactionH5Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/partner/transactions/native 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/partner-jsons/partner-native-prepay.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/native-prepay.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayPartnerTransactionNativeResponse> ExecuteCreatePayPartnerTransactionNativeAsync(this WechatTenpayClient client, Models.CreatePayPartnerTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "partner", "transactions", "native");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayPartnerTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay/partner/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/query-by-out-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/query-by-out-trade-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayPartnerTransactionByOutTradeNumberResponse> ExecuteGetPayPartnerTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetPayPartnerTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "pay", "partner", "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayPartnerTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay/partner/transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/query-by-wx-trade-no.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/query-by-wx-trade-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayPartnerTransactionByIdResponse> ExecuteGetPayPartnerTransactionByIdAsync(this WechatTenpayClient client, Models.GetPayPartnerTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "pay", "partner", "transactions", "id", request.TransactionId)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayPartnerTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/partner/transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/close-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/close-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePayPartnerTransactionResponse> ExecuteClosePayPartnerTransactionAsync(this WechatTenpayClient client, Models.ClosePayPartnerTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "partner", "transactions", "out-trade-no", request.OutTradeNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.ClosePayPartnerTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
