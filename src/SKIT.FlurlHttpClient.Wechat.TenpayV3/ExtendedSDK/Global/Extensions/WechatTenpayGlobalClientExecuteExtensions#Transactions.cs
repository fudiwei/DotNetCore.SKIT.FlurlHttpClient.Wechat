namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static partial class WechatTenpayGlobalClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /transactions/app 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356518 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransactionAppResponse> ExecuteCreateTransactionAppAsync(this WechatTenpayGlobalClient client, Models.CreateTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "app");

            return await client.ProxyClient.SendFlurlRequestAsJsonAsync<Models.CreateTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/mweb 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356554 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransactionMWebResponse> ExecuteCreateTransactionMWebAsync(this WechatTenpayGlobalClient client, Models.CreateTransactionMWebRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "mweb");

            return await client.ProxyClient.SendFlurlRequestAsJsonAsync<Models.CreateTransactionMWebResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/jsapi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356496 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356535 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransactionJsapiResponse> ExecuteCreateTransactionJsapiAsync(this WechatTenpayGlobalClient client, Models.CreateTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "jsapi");

            return await client.ProxyClient.SendFlurlRequestAsJsonAsync<Models.CreateTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/native 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356478 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransactionNativeResponse> ExecuteCreateTransactionNativeAsync(this WechatTenpayGlobalClient client, Models.CreateTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "native");

            return await client.ProxyClient.SendFlurlRequestAsJsonAsync<Models.CreateTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /micropay/transactions/pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356443 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransactionMicroPayResponse> ExecuteCreateTransactionMicroPayAsync(this WechatTenpayGlobalClient client, Models.CreateTransactionMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "micropay", "transactions", "pay");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateTransactionMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356445 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356479 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356497 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356519 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356536 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356555 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransactionByOutTradeNumberResponse> ExecuteGetTransactionByOutTradeNumberAsync(this WechatTenpayGlobalClient client, Models.GetTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutTradeNumber, "out_trade_no");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client.ProxyClient
                .CreateFlurlRequest(request, HttpMethod.Get, "transactions", "out-trade-no", request.OutTradeNumber!)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transactions/id/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356445 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356479 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356497 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356519 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356536 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356555 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransactionByIdResponse> ExecuteGetTransactionByIdAsync(this WechatTenpayGlobalClient client, Models.GetTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.TransactionId, "transaction_id");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client.ProxyClient
                .CreateFlurlRequest(request, HttpMethod.Get, "transactions", "id", request.TransactionId!)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356484 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356502 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356524 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356541 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356560 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseTransactionResponse> ExecuteCloseTransactionAsync(this WechatTenpayGlobalClient client, Models.CloseTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutTradeNumber, "out_trade_no");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client.ProxyClient
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber!, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.CloseTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transactions/out-trade-no/{out_trade_no}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356460 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseTransactionResponse> ExecuteReverseTransactionAsync(this WechatTenpayGlobalClient client, Models.ReverseTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutTradeNumber, "out_trade_no");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client.ProxyClient
                .CreateFlurlRequest(request, HttpMethod.Post, "transactions", "out-trade-no", request.OutTradeNumber!, "reverse")
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ReverseTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
