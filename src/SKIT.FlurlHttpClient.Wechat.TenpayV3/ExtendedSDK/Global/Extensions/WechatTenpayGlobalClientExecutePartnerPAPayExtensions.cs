using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientExecutePartnerPAPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/app-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_17.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPartnerPAPayContractEntrustAppResponse> ExecutePresignPartnerPAPayContractEntrustAppAsync(this WechatTenpayGlobalClient client, Models.PresignPartnerPAPayContractEntrustAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "app-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPartnerPAPayContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/jsapi-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_15.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPartnerPAPayContractEntrustJsapiResponse> ExecutePresignPartnerPAPayContractEntrustJsapiAsync(this WechatTenpayGlobalClient client, Models.PresignPartnerPAPayContractEntrustJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "jsapi-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPartnerPAPayContractEntrustJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/miniprogram-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPartnerPAPayContractEntrustMiniProgramResponse> ExecutePresignPartnerPAPayContractEntrustMiniProgramAsync(this WechatTenpayGlobalClient client, Models.PresignPartnerPAPayContractEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "miniprogram-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPartnerPAPayContractEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/h5-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_14.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPartnerPAPayContractEntrustH5Response> ExecutePresignPartnerPAPayContractEntrustH5Async(this WechatTenpayGlobalClient client, Models.PresignPartnerPAPayContractEntrustH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "h5-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPartnerPAPayContractEntrustH5Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/web-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_14.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPartnerPAPayContractEntrustWebResponse> ExecutePresignPartnerPAPayContractEntrustWebAsync(this WechatTenpayGlobalClient client, Models.PresignPartnerPAPayContractEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "web-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPartnerPAPayContractEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerPAPayContractByOutContractCodeResponse> ExecuteGetPartnerPAPayContractByOutContractCodeAsync(this WechatTenpayGlobalClient client, Models.GetPartnerPAPayContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "contracts", "out-contract-code", request.OutContractCode)
                .SetQueryParam("sp_appid", request.AppId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("sub_appid", request.SubAppId)
                .SetQueryParam("plan_id", request.PlanId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerPAPayContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerPAPayContractByContractIdResponse> ExecuteGetPartnerPAPayContractByContractIdAsync(this WechatTenpayGlobalClient client, Models.GetPartnerPAPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "contracts", request.ContractId)
                .SetQueryParam("sp_appid", request.AppId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("sub_appid", request.SubAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerPAPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePartnerPAPayContractResponse> ExecuteTerminatePartnerPAPayContractAsync(this WechatTenpayGlobalClient client, Models.TerminatePartnerPAPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePartnerPAPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_6.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerPAPayTransactionResponse> ExecuteCreatePartnerPAPayTransactionAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerPAPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "transactions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePartnerPAPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_8.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerPAPayTransactionByOutTradeNumberResponse> ExecuteGetPartnerPAPayTransactionByOutTradeNumberAsync(this WechatTenpayGlobalClient client, Models.GetPartnerPAPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "transactions", "out-trade-no", request.OutTradeNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerPAPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_8.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerPAPayTransactionByIdResponse> ExecuteGetPartnerPAPayTransactionByIdAsync(this WechatTenpayGlobalClient client, Models.GetPartnerPAPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "transactions", request.TransactionId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerPAPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter5_1_10.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReversePartnerPAPayTransactionResponse> ExecuteReversePartnerPAPayTransactionAsync(this WechatTenpayGlobalClient client, Models.ReversePartnerPAPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "transactions", "out-trade-no", request.OutTradeNumber, "reverse");

            return await client.SendFlurlRequestAsJsonAsync<Models.ReversePartnerPAPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
