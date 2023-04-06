using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供境外支付融合钱包（For HK）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteHKTransactionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /transactions/app 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter6_3.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKTransactionAppResponse> ExecuteCreateHKTransactionAppAsync(this WechatTenpayClient client, Models.CreateHKTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "app");

            return await client.SendRequestWithJsonAsync<Models.CreateHKTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/mweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter3_3.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKTransactionMWebResponse> ExecuteCreateHKTransactionMWebAsync(this WechatTenpayClient client, Models.CreateHKTransactionMWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "mweb");

            return await client.SendRequestWithJsonAsync<Models.CreateHKTransactionMWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/jsapi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter5_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter7_3.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKTransactionJsapiResponse> ExecuteCreateHKTransactionJsapiAsync(this WechatTenpayClient client, Models.CreateHKTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "jsapi");

            return await client.SendRequestWithJsonAsync<Models.CreateHKTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/native 接口。</para>
        /// <para>REF: https://https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter4_3.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKTransactionNativeResponse> ExecuteCreateHKTransactionNativeAsync(this WechatTenpayClient client, Models.CreateHKTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "native");

            return await client.SendRequestWithJsonAsync<Models.CreateHKTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /micropay/transactions/pay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_1_1.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKTransactionMicroPayResponse> ExecuteCreateHKTransactionMicroPayAsync(this WechatTenpayClient client, Models.CreateHKTransactionMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "micropay", "transactions", "pay");

            return await client.SendRequestWithJsonAsync<Models.CreateHKTransactionMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_1.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKTransactionByOutTradeNumberResponse> ExecuteGetHKTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetHKTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_1.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKTransactionByIdResponse> ExecuteGetHKTransactionByIdAsync(this WechatTenpayClient client, Models.GetHKTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transactions", "id", request.TransactionId)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_6.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseHKTransactionResponse> ExecuteCloseHKTransactionAsync(this WechatTenpayClient client, Models.CloseHKTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber, "close");

            return await client.SendRequestWithJsonAsync<Models.CloseHKTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter3_4.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseHKTransactionResponse> ExecuteReverseHKTransactionAsync(this WechatTenpayClient client, Models.ReverseHKTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber, "reverse")
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.ReverseHKTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
