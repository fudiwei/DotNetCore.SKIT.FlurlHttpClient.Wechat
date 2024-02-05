using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteHKPAPPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/app-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_17.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPAPPayContractEntrustAppResponse> ExecutePresignHKPAPPayContractEntrustAppAsync(this WechatTenpayClient client, Models.PresignHKPAPPayContractEntrustAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "app-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignHKPAPPayContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/jsapi-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_15.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPAPPayContractEntrustJsapiResponse> ExecutePresignHKPAPPayContractEntrustJsapiAsync(this WechatTenpayClient client, Models.PresignHKPAPPayContractEntrustJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "jsapi-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignHKPAPPayContractEntrustJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/miniprogram-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_1.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPAPPayContractEntrustMiniProgramResponse> ExecutePresignHKPAPPayContractEntrustMiniProgramAsync(this WechatTenpayClient client, Models.PresignHKPAPPayContractEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "miniprogram-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignHKPAPPayContractEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/h5-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_14.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPAPPayContractEntrustH5Response> ExecutePresignHKPAPPayContractEntrustH5Async(this WechatTenpayClient client, Models.PresignHKPAPPayContractEntrustH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "h5-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignHKPAPPayContractEntrustH5Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/web-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_16.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignHKPAPPayContractEntrustWebResponse> ExecutePresignHKPAPPayContractEntrustWebAsync(this WechatTenpayClient client, Models.PresignHKPAPPayContractEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "web-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignHKPAPPayContractEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_3.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPAPPayContractByOutContractCodeResponse> ExecuteGetHKPAPPayContractByOutContractCodeAsync(this WechatTenpayClient client, Models.GetHKPAPPayContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "contracts", "out-contract-code", request.OutContractCode)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("plan_id", request.PlanId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetHKPAPPayContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_2.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPAPPayContractByContractIdResponse> ExecuteGetHKPAPPayContractByContractIdAsync(this WechatTenpayClient client, Models.GetHKPAPPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "contracts", request.ContractId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetHKPAPPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_4.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateHKPAPPayContractResponse> ExecuteTerminateHKPAPPayContractAsync(this WechatTenpayClient client, Models.TerminateHKPAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateHKPAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_6.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHKPAPPayTransactionResponse> ExecuteCreateHKPAPPayTransactionAsync(this WechatTenpayClient client, Models.CreateHKPAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "transactions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateHKPAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_8.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPAPPayTransactionByOutTradeNumberResponse> ExecuteGetHKPAPPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetHKPAPPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "transactions", "out-trade-no", request.OutTradeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetHKPAPPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_8.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHKPAPPayTransactionByIdResponse> ExecuteGetHKPAPPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetHKPAPPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "transactions", request.TransactionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetHKPAPPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_10.shtml ]]>
        /// </para>
        /// <para><i>（请注意此接口专为境外支付设计，调用时需在构造 <see cref="WechatTenpayClient" /> 时指定单独的 <see cref="WechatTenpayClientOptions.Endpoint"/>。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseHKPAPPayTransactionResponse> ExecuteReverseHKPAPPayTransactionAsync(this WechatTenpayClient client, Models.ReverseHKPAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "transactions", "out-trade-no", request.OutTradeNumber, "reverse");

            return await client.SendFlurlRequestAsJsonAsync<Models.ReverseHKPAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
