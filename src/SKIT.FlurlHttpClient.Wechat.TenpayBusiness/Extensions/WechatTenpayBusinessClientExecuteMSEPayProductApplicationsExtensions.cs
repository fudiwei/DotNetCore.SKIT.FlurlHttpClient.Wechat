using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteMSEPayProductApplicationsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/product-applications 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMSEPayProductApplicationResponse> ExecuteCreateMSEPayProductApplicationAsync(this WechatTenpayBusinessClient client, Models.CreateMSEPayProductApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "product-applications");

            return await client.SendRequestWithJsonAsync<Models.CreateMSEPayProductApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/product-applications/out-request-no/{out_request_no} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMSEPayProductApplicationByOutRequestNumberResponse> ExecuteGetMSEPayProductApplicationByOutRequestNumberAsync(this WechatTenpayBusinessClient client, Models.GetMSEPayProductApplicationByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "product-applications", "out-request-no", request.OutRequestNumber);

            return await client.SendRequestWithJsonAsync<Models.GetMSEPayProductApplicationByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/product-applications/{request_no} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMSEPayProductApplicationByRequestNumberResponse> ExecuteGetMSEPayProductApplicationByRequestNumberAsync(this WechatTenpayBusinessClient client, Models.GetMSEPayProductApplicationByRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "product-applications", request.RequestNumber);

            return await client.SendRequestWithJsonAsync<Models.GetMSEPayProductApplicationByRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/product-applications/{request_no}/links 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMSEPayProductApplicationLinkResponse> ExecuteCreateMSEPayProductApplicationLinkAsync(this WechatTenpayBusinessClient client, Models.CreateMSEPayProductApplicationLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "product-applications", request.RequestNumber, "links");

            return await client.SendRequestWithJsonAsync<Models.CreateMSEPayProductApplicationLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
