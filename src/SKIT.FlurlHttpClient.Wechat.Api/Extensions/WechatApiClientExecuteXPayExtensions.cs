using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteXPayExtensions
    {
        private static T PreprocessRequest<T>(WechatApiClient client, ref T request)
            where T : Models.XPayRequestBase, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(request));
            if (request is null) throw new ArgumentNullException(nameof(request));

            string? tmpRawData = null; // 用于缓存待签名数据中的请求正文部分，避免序列化多次浪费性能

            if (request.Signature is null && request.SessionKey is not null)
            {
                tmpRawData = tmpRawData ?? client.JsonSerializer.Serialize(request);

                string msgText = tmpRawData;
                request.Signature = Utilities.HMACUtility.HashWithSHA256(request.SessionKey, msgText).Value!.ToLower();
            }

            if (request.PaySign is null)
            {
                tmpRawData = tmpRawData ?? client.JsonSerializer.Serialize(request);

                string msgText = $"{request.GetRequestPath()}&{tmpRawData}";
                request.PaySign = Utilities.HMACUtility.HashWithSHA256(client.Credentials.VirtualPaymentAppKey ?? string.Empty, msgText).Value!.ToLower();
            }

            return request;
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_user_balance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_user_balance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryUserBalanceResponse> ExecuteXPayQueryUserBalanceAsync(this WechatApiClient client, Models.XPayQueryUserBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_user_balance")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryUserBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/currency_pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_currency_pay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayCurrencyPayResponse> ExecuteXPayCurrencyPayAsync(this WechatApiClient client, Models.XPayCurrencyPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "currency_pay")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayCurrencyPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/cancel_currency_pay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_cancel_currency_pay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayCancelCurrencyPayResponse> ExecuteXPayCancelCurrencyPayAsync(this WechatApiClient client, Models.XPayCancelCurrencyPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "cancel_currency_pay")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayCancelCurrencyPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/notify_provide_goods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_notify_provide_goods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayNotifyProvideGoodsResponse> ExecuteXPayNotifyProvideGoodsAsync(this WechatApiClient client, Models.XPayNotifyProvideGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "notify_provide_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayNotifyProvideGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/present_currency 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_present_currency.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayPresentCurrencyResponse> ExecuteXPayPresentCurrencyAsync(this WechatApiClient client, Models.XPayPresentCurrencyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "present_currency")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayPresentCurrencyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/download_bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_download_bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayDownloadBillResponse> ExecuteXPayDownloadBillAsync(this WechatApiClient client, Models.XPayDownloadBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "download_bill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayDownloadBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryOrderResponse> ExecuteXPayQueryOrderAsync(this WechatApiClient client, Models.XPayQueryOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/refund_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_refund_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayRefundOrderResponse> ExecuteXPayRefundOrderAsync(this WechatApiClient client, Models.XPayRefundOrderRequest request, CancellationToken cancellationToken = default)
            {
                if (client is null) throw new ArgumentNullException(nameof(client));
                if (request is null) throw new ArgumentNullException(nameof(request));

                PreprocessRequest(client, ref request);

                IFlurlRequest flurlReq = client
                    .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "refund_order")
                    .SetQueryParam("access_token", request.AccessToken)
                    .SetQueryParam("pay_sig", request.PaySign);

                return await client.SendFlurlRequestAsJsonAsync<Models.XPayRefundOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/create_withdraw_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_create_withdraw_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayCreateWithdrawOrderResponse> ExecuteXPayCreateWithdrawOrderAsync(this WechatApiClient client, Models.XPayCreateWithdrawOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "create_withdraw_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayCreateWithdrawOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_withdraw_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_withdraw_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryWithdrawOrderResponse> ExecuteXPayQueryWithdrawOrderAsync(this WechatApiClient client, Models.XPayQueryWithdrawOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_withdraw_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryWithdrawOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/start_upload_goods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_start_upload_goods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayStartUploadGoodsResponse> ExecuteXPayStartUploadGoodsAsync(this WechatApiClient client, Models.XPayStartUploadGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "start_upload_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayStartUploadGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_upload_goods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_upload_goods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryUploadGoodsResponse> ExecuteXPayQueryUploadGoodsAsync(this WechatApiClient client, Models.XPayQueryUploadGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_upload_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryUploadGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/start_publish_goods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_start_publish_goods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayStartPublishGoodsResponse> ExecuteXPayStartPublishGoodsAsync(this WechatApiClient client, Models.XPayStartPublishGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "start_publish_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayStartPublishGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_publish_goods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_publish_goods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryPublishGoodsResponse> ExecuteXPayQueryPublishGoodsAsync(this WechatApiClient client, Models.XPayQueryPublishGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_publish_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryPublishGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_biz_balance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_biz_balance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryBusinessBalanceResponse> ExecuteXPayQueryBusinessBalanceAsync(this WechatApiClient client, Models.XPayQueryBusinessBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_biz_balance")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryBusinessBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_transfer_account 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_transfer_account.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryTransferAccountResponse> ExecuteXPayQueryTransferAccountAsync(this WechatApiClient client, Models.XPayQueryTransferAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_transfer_account")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryTransferAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_adver_funds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_adver_funds.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryAdverFundsResponse> ExecuteXPayQueryAdverFundsAsync(this WechatApiClient client, Models.XPayQueryAdverFundsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_adver_funds")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryAdverFundsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/create_funds_bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_create_funds_bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayCreateFundsBillResponse> ExecuteXPayCreateFundsBillAsync(this WechatApiClient client, Models.XPayCreateFundsBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "create_funds_bill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayCreateFundsBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/bind_transfer_accout 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_bind_transfer_accout.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayBindTransferAccountResponse> ExecuteXPayBindTransferAccountAsync(this WechatApiClient client, Models.XPayBindTransferAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "bind_transfer_accout")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayBindTransferAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_funds_bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_funds_bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryFundsListResponse> ExecuteXPayQueryFundsListAsync(this WechatApiClient client, Models.XPayQueryFundsListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_funds_bill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryFundsListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_recover_bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_recover_bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryRecoverListResponse> ExecuteXPayQueryRecoverListAsync(this WechatApiClient client, Models.XPayQueryRecoverListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_recover_bill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryRecoverListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/download_adverfunds_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_download_adverfunds_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayDownloadAdverFundsOrderResponse> ExecuteXPayDownloadAdverFundsOrderAsync(this WechatApiClient client, Models.XPayDownloadAdverFundsOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "download_adverfunds_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayDownloadAdverFundsOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/upload_vp_file 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_upload_vp_file.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayUploadVirtualPaymentFileResponse> ExecuteXPayUploadVirtualPaymentFileAsync(this WechatApiClient client, Models.XPayUploadVirtualPaymentFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "upload_vp_file")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayUploadVirtualPaymentFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_subscribe_contract 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_subscribe_contract.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQuerySubscribeContractResponse> ExecuteXPayQuerySubscribeContractAsync(this WechatApiClient client, Models.XPayQuerySubscribeContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_subscribe_contract")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQuerySubscribeContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/send_subscribe_pre_payment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_send_subscribe_pre_payment.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPaySendSubscribePrepaymentResponse> ExecuteXPaySendSubscribePrepaymentAsync(this WechatApiClient client, Models.XPaySendSubscribePrepaymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "send_subscribe_pre_payment")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPaySendSubscribePrepaymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/submit_subscribe_pay_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_submit_subscribe_pay_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPaySubmitSubscribePayOrderResponse> ExecuteXPaySubmitSubscribePayOrderAsync(this WechatApiClient client, Models.XPaySubmitSubscribePayOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            if (request.OfferId is null)
                request.OfferId = client.Credentials.MidasOfferIdV2!;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "submit_subscribe_pay_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPaySubmitSubscribePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/cancel_subscribe_contract 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_cancel_subscribe_contract.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayCancelSubscribeContractResponse> ExecuteXPayCancelSubscribeContractAsync(this WechatApiClient client, Models.XPayCancelSubscribeContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "cancel_subscribe_contract")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayCancelSubscribeContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/start_download_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_start_download_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayStartDownloadOrderResponse> ExecuteXPayStartDownloadOrderAsync(this WechatApiClient client, Models.XPayStartDownloadOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "start_download_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayStartDownloadOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_download_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_query_download_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayQueryDownloadOrderResponse> ExecuteXPayQueryDownloadOrderAsync(this WechatApiClient client, Models.XPayQueryDownloadOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "query_download_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayQueryDownloadOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/download_ios_settlement_bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/VirtualPayment/api_download_ios_settlement_bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.XPayDownloadIOSSettlementBillResponse> ExecuteXPayDownloadIOSSettlementBillAsync(this WechatApiClient client, Models.XPayDownloadIOSSettlementBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            PreprocessRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xpay", "download_ios_settlement_bill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendFlurlRequestAsJsonAsync<Models.XPayDownloadIOSSettlementBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
