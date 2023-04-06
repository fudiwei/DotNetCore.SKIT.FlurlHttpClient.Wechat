using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteHKPartnerPAPPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/app-pre-entrust-sign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_17.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPartnerPAPPayContractEntrustAppResponse> ExecutePresignHKPartnerPAPPayContractEntrustAppAsync(this WechatTenpayClient client, Models.PresignHKPartnerPAPPayContractEntrustAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", "app-pre-entrust-sign");

            return await client.SendRequestWithJsonAsync<Models.PresignHKPartnerPAPPayContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/jsapi-pre-entrust-sign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_15.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPartnerPAPPayContractEntrustJsapiResponse> ExecutePresignHKPartnerPAPPayContractEntrustJsapiAsync(this WechatTenpayClient client, Models.PresignHKPartnerPAPPayContractEntrustJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", "jsapi-pre-entrust-sign");

            return await client.SendRequestWithJsonAsync<Models.PresignHKPartnerPAPPayContractEntrustJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/miniprogram-pre-entrust-sign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_1.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPartnerPAPPayContractEntrustMiniProgramResponse> ExecutePresignHKPartnerPAPPayContractEntrustMiniProgramAsync(this WechatTenpayClient client, Models.PresignHKPartnerPAPPayContractEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", "miniprogram-pre-entrust-sign");

            return await client.SendRequestWithJsonAsync<Models.PresignHKPartnerPAPPayContractEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/h5-pre-entrust-sign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_14.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPartnerPAPPayContractEntrustH5Response> ExecutePresignHKPartnerPAPPayContractEntrustH5Async(this WechatTenpayClient client, Models.PresignHKPartnerPAPPayContractEntrustH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", "h5-pre-entrust-sign");

            return await client.SendRequestWithJsonAsync<Models.PresignHKPartnerPAPPayContractEntrustH5Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/web-pre-entrust-sign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_14.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPartnerPAPPayContractEntrustWebResponse> ExecutePresignHKPartnerPAPPayContractEntrustWebAsync(this WechatTenpayClient client, Models.PresignHKPartnerPAPPayContractEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", "web-pre-entrust-sign");

            return await client.SendRequestWithJsonAsync<Models.PresignHKPartnerPAPPayContractEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_3.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPartnerPAPPayContractByOutContractCodeResponse> ExecuteGetHKPartnerPAPPayContractByOutContractCodeAsync(this WechatTenpayClient client, Models.GetHKPartnerPAPPayContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "contracts", "out-contract-code", request.OutContractCode)
                .SetQueryParam("sp_appid", request.AppId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("plan_id", request.PlanId);

            return await client.SendRequestWithJsonAsync<Models.GetHKPartnerPAPPayContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/{contract_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_2.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPartnerPAPPayContractByContractIdResponse> ExecuteGetHKPartnerPAPPayContractByContractIdAsync(this WechatTenpayClient client, Models.GetHKPartnerPAPPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "contracts", request.ContractId)
                .SetQueryParam("sp_appid", request.AppId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("sub_appid", request.SubAppId);

            return await client.SendRequestWithJsonAsync<Models.GetHKPartnerPAPPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_4.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateHKPartnerPAPPayContractResponse> ExecuteTerminateHKPartnerPAPPayContractAsync(this WechatTenpayClient client, Models.TerminateHKPartnerPAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminateHKPartnerPAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_6.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKPartnerPAPPayTransactionResponse> ExecuteCreateHKPartnerPAPPayTransactionAsync(this WechatTenpayClient client, Models.CreateHKPartnerPAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "transactions");

            return await client.SendRequestWithJsonAsync<Models.CreateHKPartnerPAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_8.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPartnerPAPPayTransactionByOutTradeNumberResponse> ExecuteGetHKPartnerPAPPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetHKPartnerPAPPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKPartnerPAPPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_8.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPartnerPAPPayTransactionByIdResponse> ExecuteGetHKPartnerPAPPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetHKPartnerPAPPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "papay", "transactions", request.TransactionId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetHKPartnerPAPPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_10.shtml </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseHKPartnerPAPPayTransactionResponse> ExecuteReverseHKPartnerPAPPayTransactionAsync(this WechatTenpayClient client, Models.ReverseHKPartnerPAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "transactions", "out-trade-no", request.OutTradeNumber, "reverse");

            return await client.SendRequestWithJsonAsync<Models.ReverseHKPartnerPAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
