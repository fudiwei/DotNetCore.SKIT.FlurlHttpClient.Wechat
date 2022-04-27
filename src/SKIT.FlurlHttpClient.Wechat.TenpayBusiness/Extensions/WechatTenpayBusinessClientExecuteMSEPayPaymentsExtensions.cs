using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteMSEPayPaymentsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/payments/h5-pay 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMSEPayPaymentH5PayResponse> ExecuteCreateMSEPayPaymentH5PayAsync(this WechatTenpayBusinessClient client, Models.CreateMSEPayPaymentH5PayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "payments", "h5-pay");

            return await client.SendRequestWithJsonAsync<Models.CreateMSEPayPaymentH5PayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/payments/out-payment-id/{out_payment_id} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMSEPayPaymentByOutPaymentIdResponse> ExecuteGetMSEPayPaymentByOutPaymentIdAsync(this WechatTenpayBusinessClient client, Models.GetMSEPayPaymentByOutPaymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "payments", "out-payment-id", request.OutPaymentId);

            return await client.SendRequestWithJsonAsync<Models.GetMSEPayPaymentByOutPaymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/payments/{payment_id} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMSEPayPaymentByPaymentIdResponse> ExecuteGetMSEPayPaymentByPaymentIdAsync(this WechatTenpayBusinessClient client, Models.GetMSEPayPaymentByPaymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "payments", request.PaymentId);

            return await client.SendRequestWithJsonAsync<Models.GetMSEPayPaymentByPaymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/payments/{payment_id}/close 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseMSEPayPaymentResponse> ExecuteCloseMSEPayPaymentAsync(this WechatTenpayBusinessClient client, Models.CloseMSEPayPaymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "payments", request.PaymentId, "close");

            return await client.SendRequestWithJsonAsync<Models.CloseMSEPayPaymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
