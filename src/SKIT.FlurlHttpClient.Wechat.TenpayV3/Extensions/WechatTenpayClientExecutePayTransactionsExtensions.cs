using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供基础支付（直连商户）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePayTransactionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/app 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionAppResponse> ExecuteCreatePayTransactionAppAsync(this WechatTenpayClient client, Models.CreatePayTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId))
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "pay", "transactions", "app")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/jsapi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionJsapiResponse> ExecuteCreatePayTransactionJsapiAsync(this WechatTenpayClient client, Models.CreatePayTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId))
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "pay", "transactions", "jsapi")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/h5 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionH5Response> ExecuteCreatePayTransactionH5Async(this WechatTenpayClient client, Models.CreatePayTransactionH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId)) 
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "pay", "transactions", "h5")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionH5Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/native 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayTransactionNativeResponse > ExecuteCreatePayTransactionNativeAsync(this WechatTenpayClient client, Models.CreatePayTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId)) 
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "pay", "transactions", "native")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreatePayTransactionNativeResponse >(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayTransactionByOutTradeNumberResponse> ExecuteGetPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId)) 
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "pay", "transactions", "out-trade-no", request.OutTradeNumber)
                .SetOptions(request)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestAsync<Models.GetPayTransactionByOutTradeNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay/transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayTransactionByIdResponse> ExecuteGetPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId))
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "pay", "transactions", "id", request.TransactionId)
                .SetOptions(request)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestAsync<Models.GetPayTransactionByIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePayTransactionResponse> ExecuteClosePayTransactionAsync(this WechatTenpayClient client, Models.ClosePayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId)) 
                request.MerchantId = client.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "pay", "transactions", "out-trade-no", request.OutTradeNumber, "close")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.ClosePayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
