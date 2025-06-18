using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientExecutePartnerTransactionsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /transactions/app 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter6_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerTransactionAppResponse> ExecuteCreatePartnerTransactionAppAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "app");

            return await ((WechatTenpayClient)client).SendFlurlRequestAsJsonAsync<Models.CreatePartnerTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/mweb 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter3_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerTransactionMWebResponse> ExecuteCreatePartnerTransactionMWebAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerTransactionMWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "mweb");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePartnerTransactionMWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/jsapi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter5_4.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter7_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerTransactionJsapiResponse> ExecuteCreatePartnerTransactionJsapiAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "jsapi");

            return await ((WechatTenpayClient)client).SendFlurlRequestAsJsonAsync<Models.CreatePartnerTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/native 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter4_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerTransactionNativeResponse> ExecuteCreatePartnerTransactionNativeAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "native");

            return await ((WechatTenpayClient)client).SendFlurlRequestAsJsonAsync<Models.CreatePartnerTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /micropay/transactions/pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_1_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerTransactionMicroPayResponse> ExecuteCreatePartnerTransactionMicroPayAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerTransactionMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "micropay", "transactions", "pay");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePartnerTransactionMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerTransactionByOutTradeNumberResponse> ExecuteGetPartnerTransactionByOutTradeNumberAsync(this WechatTenpayGlobalClient client, Models.GetPartnerTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/id/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_1.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerTransactionByIdResponse> ExecuteGetPartnerTransactionByIdAsync(this WechatTenpayGlobalClient client, Models.GetPartnerTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "transactions", "id", request.TransactionId)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_6.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_6.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_6.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_6.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_6.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePartnerTransactionResponse> ExecuteClosePartnerTransactionAsync(this WechatTenpayGlobalClient client, Models.ClosePartnerTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.ClosePartnerTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter3_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReversePartnerTransactionResponse> ExecuteReversePartnerTransactionAsync(this WechatTenpayGlobalClient client, Models.ReversePartnerTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber, "reverse")
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ReversePartnerTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /statements 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_5.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_5.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_5.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_5.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_5.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_5.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadStatementsResponse> ExecuteDownloadStatementsAsync(this WechatTenpayGlobalClient client, Models.DownloadStatementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "statements")
                .SetQueryParam("mchid", request.SubMerchantId)
                .SetQueryParam("date", request.DateString);

            return await client.SendFlurlRequestAsJsonAsync<Models.DownloadStatementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /settle/settlements 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_12.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_12.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_12.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_12.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_12.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_12.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QuerySettlementsResponse> ExecuteQuerySettlementsAsync(this WechatTenpayGlobalClient client, Models.QuerySettlementsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "settle", "settlements")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("settle_state", request.SettleState)
                .SetQueryParam("settle_start_date", request.StartDateString)
                .SetQueryParam("settle_end_date", request.EndDateString)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QuerySettlementsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
