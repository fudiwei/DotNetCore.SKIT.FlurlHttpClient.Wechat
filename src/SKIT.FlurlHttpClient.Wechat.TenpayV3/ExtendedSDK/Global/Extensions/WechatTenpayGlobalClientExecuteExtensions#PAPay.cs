namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static partial class WechatTenpayGlobalClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/app-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356578 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayContractEntrustAppResponse> ExecutePresignPAPayContractEntrustAppAsync(this WechatTenpayGlobalClient client, Models.PresignPAPayContractEntrustAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "app-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/jsapi-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356576 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayContractEntrustJsapiResponse> ExecutePresignPAPayContractEntrustJsapiAsync(this WechatTenpayGlobalClient client, Models.PresignPAPayContractEntrustJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "jsapi-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayContractEntrustJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/miniprogram-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356572 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayContractEntrustMiniProgramResponse> ExecutePresignPAPayContractEntrustMiniProgramAsync(this WechatTenpayGlobalClient client, Models.PresignPAPayContractEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "miniprogram-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayContractEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/h5-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356574 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayContractEntrustH5Response> ExecutePresignPAPayContractEntrustH5Async(this WechatTenpayGlobalClient client, Models.PresignPAPayContractEntrustH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "h5-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayContractEntrustH5Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/web-pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356577 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayContractEntrustWebResponse> ExecutePresignPAPayContractEntrustWebAsync(this WechatTenpayGlobalClient client, Models.PresignPAPayContractEntrustWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", "web-pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayContractEntrustWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356585 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayContractByOutContractCodeResponse> ExecuteGetPAPayContractByOutContractCodeAsync(this WechatTenpayGlobalClient client, Models.GetPAPayContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutContractCode, "out_contract_code");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "contracts", "out-contract-code", request.OutContractCode!)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("plan_id", request.PlanId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/contracts/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356579 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayContractByContractIdResponse> ExecuteGetPAPayContractByContractIdAsync(this WechatTenpayGlobalClient client, Models.GetPAPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.ContractId, "contract_id");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "contracts", request.ContractId!)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356587 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePAPayContractResponse> ExecuteTerminatePAPayContractAsync(this WechatTenpayGlobalClient client, Models.TerminatePAPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.ContractId, "contract_id");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId!, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePAPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356618 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPayTransactionResponse> ExecuteCreatePAPayTransactionAsync(this WechatTenpayGlobalClient client, Models.CreatePAPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "transactions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePAPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356622 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayTransactionByOutTradeNumberResponse> ExecuteGetPAPayTransactionByOutTradeNumberAsync(this WechatTenpayGlobalClient client, Models.GetPAPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutTradeNumber, "out_trade_no");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "transactions", "out-trade-no", request.OutTradeNumber!);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/transactions/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356622 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayTransactionByIdResponse> ExecuteGetPAPayTransactionByIdAsync(this WechatTenpayGlobalClient client, Models.GetPAPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.TransactionId, "transaction_id");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "transactions", request.TransactionId!);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356623 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReversePAPayTransactionResponse> ExecuteReversePAPayTransactionAsync(this WechatTenpayGlobalClient client, Models.ReversePAPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutTradeNumber, "out_trade_no");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "transactions", "out-trade-no", request.OutTradeNumber!, "reverse");

            return await client.SendFlurlRequestAsJsonAsync<Models.ReversePAPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
