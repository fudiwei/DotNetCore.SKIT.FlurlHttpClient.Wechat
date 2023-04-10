using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecutePaymentsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/payments/h5-pay 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#h5%E6%94%AF%E4%BB%98 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePaymentH5PayResponse> ExecuteCreatePaymentH5PayAsync(this WechatTenpayBusinessClient client, Models.CreatePaymentH5PayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "payments", "h5-pay");

            return await client.SendRequestWithJsonAsync<Models.CreatePaymentH5PayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/payments/out-payment-id/{out_payment_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%A4%96%E5%8D%95%E5%8F%B7 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%A4%96%E5%8D%95%E5%8F%B7-2 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%A4%96%E5%8D%95%E5%8F%B7-3 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%A4%96%E5%8D%95%E5%8F%B7-4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPaymentByOutPaymentIdResponse> ExecuteGetPaymentByOutPaymentIdAsync(this WechatTenpayBusinessClient client, Models.GetPaymentByOutPaymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "payments", "out-payment-id", request.OutPaymentId);

            return await client.SendRequestWithJsonAsync<Models.GetPaymentByOutPaymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/payments/{payment_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%86%85%E5%8D%95%E5%8F%B7 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%86%85%E5%8D%95%E5%8F%B7-2 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%86%85%E5%8D%95%E5%8F%B7-3 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E6%98%8E%E7%BB%86-%E5%86%85%E5%8D%95%E5%8F%B7-4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPaymentByPaymentIdResponse> ExecuteGetPaymentByPaymentIdAsync(this WechatTenpayBusinessClient client, Models.GetPaymentByPaymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "payments", request.PaymentId);

            return await client.SendRequestWithJsonAsync<Models.GetPaymentByPaymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/payments/{payment_id}/close 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%94%AF%E4%BB%98%E5%85%B3%E5%8D%95 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%94%AF%E4%BB%98%E5%85%B3%E5%8D%95-2 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%94%AF%E4%BB%98%E5%85%B3%E5%8D%95-3 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%94%AF%E4%BB%98%E5%85%B3%E5%8D%95-4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePaymentResponse> ExecuteClosePaymentAsync(this WechatTenpayBusinessClient client, Models.ClosePaymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "payments", request.PaymentId, "close");

            return await client.SendRequestWithJsonAsync<Models.ClosePaymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/redirects 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%8E%B7%E5%8F%96%E8%B7%B3%E8%BD%AC%E5%AF%B9%E8%B1%A1%E4%BF%A1%E6%81%AF </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%8E%B7%E5%8F%96%E8%B7%B3%E8%BD%AC%E5%AF%B9%E8%B1%A1%E4%BF%A1%E6%81%AF-2 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%8E%B7%E5%8F%96%E8%B7%B3%E8%BD%AC%E5%AF%B9%E8%B1%A1%E4%BF%A1%E6%81%AF-3 </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%8E%B7%E5%8F%96%E8%B7%B3%E8%BD%AC%E5%AF%B9%E8%B1%A1%E4%BF%A1%E6%81%AF-4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePaymentRedirectLinkResponse> ExecuteCreatePaymentRedirectLinkAsync(this WechatTenpayBusinessClient client, Models.CreatePaymentRedirectLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "redirects");

            return await client.SendRequestWithJsonAsync<Models.CreatePaymentRedirectLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
