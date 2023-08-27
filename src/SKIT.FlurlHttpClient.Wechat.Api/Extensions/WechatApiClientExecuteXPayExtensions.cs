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
            if (client == null) throw new ArgumentNullException(nameof(request));
            if (request == null) throw new ArgumentNullException(nameof(request));

            string? tmpRawData = null; // 用于缓存待签名数据中的请求正文部分，避免序列化多次浪费性能

            if (request.Signature == null && request.SessionKey != null)
            {
                tmpRawData = tmpRawData ?? client.JsonSerializer.Serialize(request);

                string msgText = tmpRawData;
                request.Signature = Utilities.HMACUtility.HashWithSHA256(request.SessionKey, msgText).ToLower();
            }

            if (request.PaySign == null)
            {
                tmpRawData = tmpRawData ?? client.JsonSerializer.Serialize(request);

                string msgText = $"{request.GetRequestPath()}&{tmpRawData}";
                request.PaySign = Utilities.HMACUtility.HashWithSHA256(client.Credentials.VirtualPaymentAppKey ?? string.Empty, msgText).ToLower();
            }

            return request;
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_user_balance 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "query_user_balance")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayQueryUserBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/currency_pay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "currency_pay")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayCurrencyPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/cancel_currency_pay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "cancel_currency_pay")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayCancelCurrencyPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/notify_provide_goods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "notify_provide_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayNotifyProvideGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/present_currency 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "present_currency")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayPresentCurrencyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/download_bill 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "download_bill")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayDownloadBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "query_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayQueryOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/refund_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                    .CreateRequest(request, HttpMethod.Post, "xpay", "refund_order")
                    .SetQueryParam("access_token", request.AccessToken)
                    .SetQueryParam("pay_sig", request.PaySign);

                return await client.SendRequestWithJsonAsync<Models.XPayRefundOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/create_withdraw_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "create_withdraw_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayCreateWithdrawOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_withdraw_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "query_withdraw_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayQueryWithdrawOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/start_upload_goods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "start_upload_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayStartUploadGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_upload_goods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "query_upload_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayQueryUploadGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/start_publish_goods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "start_publish_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayStartPublishGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /xpay/query_publish_goods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html#_2-3-%E6%9C%8D%E5%8A%A1%E5%99%A8API </para>
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
                .CreateRequest(request, HttpMethod.Post, "xpay", "query_publish_goods")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("pay_sig", request.PaySign);

            return await client.SendRequestWithJsonAsync<Models.XPayQueryPublishGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
