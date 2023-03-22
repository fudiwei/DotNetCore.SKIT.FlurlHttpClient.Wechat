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
    public static class WechatTenpayClientExecuteHKPartnerTransactionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /transactions/app 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter6_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKPartnerTransactionAppResponse> ExecuteCreateHKPartnerTransactionAppAsync(this WechatTenpayClient client, Models.CreateHKPartnerTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "app");

            return await client.SendRequestWithJsonAsync<Models.CreateHKPartnerTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/mweb 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter3_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKPartnerTransactionMWebResponse> ExecuteCreateHKPartnerTransactionMWebAsync(this WechatTenpayClient client, Models.CreateHKPartnerTransactionMWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "mweb");

            return await client.SendRequestWithJsonAsync<Models.CreateHKPartnerTransactionMWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/jsapi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter5_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter7_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKPartnerTransactionJsapiResponse> ExecuteCreateHKPartnerTransactionJsapiAsync(this WechatTenpayClient client, Models.CreateHKPartnerTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "jsapi");

            return await client.SendRequestWithJsonAsync<Models.CreateHKPartnerTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/native 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter4_3.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKPartnerTransactionNativeResponse> ExecuteCreateHKPartnerTransactionNativeAsync(this WechatTenpayClient client, Models.CreateHKPartnerTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "native");

            return await client.SendRequestWithJsonAsync<Models.CreateHKPartnerTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_1.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPartnerTransactionByOutTradeNumberResponse> ExecuteGetHKPartnerTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetHKPartnerTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKPartnerTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_1.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPartnerTransactionByIdResponse> ExecuteGetHKPartnerTransactionByIdAsync(this WechatTenpayClient client, Models.GetHKPartnerTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transactions", "id", request.TransactionId)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKPartnerTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_6.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseHKPartnerTransactionResponse> ExecuteCloseHKPartnerTransactionAsync(this WechatTenpayClient client, Models.CloseHKPartnerTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber, "close");

            return await client.SendRequestWithJsonAsync<Models.CloseHKPartnerTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter3_4.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseHKPartnerTransactionResponse> ExecuteReverseHKPartnerTransactionAsync(this WechatTenpayClient client, Models.ReverseHKPartnerTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber, "reverse")
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.ReverseHKPartnerTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /statements 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_5.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadHKStatementsResponse> ExecuteDownloadHKStatementsAsync(this WechatTenpayClient client, Models.DownloadHKStatementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "statements")
                .SetQueryParam("date", request.DateString);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.DownloadHKStatementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /settle/settlements 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_12.shtml </para>
        /// <para><i>（请注意调用此接口需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryHKSettlementsResponse> ExecuteQueryHKSettlementsAsync(this WechatTenpayClient client, Models.QueryHKSettlementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "settle", "settlements")
                .SetQueryParam("settle_state", request.SettleState)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.StartDateString != null)
                flurlReq.SetQueryParam("settle_start_date", request.StartDateString);

            if (request.EndDateString != null)
                flurlReq.SetQueryParam("settle_end_date", request.EndDateString);

            return await client.SendRequestWithJsonAsync<Models.QueryHKSettlementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
