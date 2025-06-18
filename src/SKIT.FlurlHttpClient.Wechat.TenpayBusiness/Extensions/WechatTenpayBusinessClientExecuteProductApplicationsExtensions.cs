using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteProductApplicationsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/product-applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://businesspay.qq.com/p/doc/mse/api/server.html#%E7%94%B3%E8%AF%B7%E5%85%A5%E9%A9%BB ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateProductApplicationResponse> ExecuteCreateProductApplicationAsync(this WechatTenpayBusinessClient client, Models.CreateProductApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mse-pay", "product-applications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateProductApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/product-applications/{request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E5%85%A5%E9%A9%BB%E7%BB%93%E6%9E%9C-%E5%86%85%E5%8D%95%E5%8F%B7 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProductApplicationByRequestNumberResponse> ExecuteGetProductApplicationByRequestNumberAsync(this WechatTenpayBusinessClient client, Models.GetProductApplicationByRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mse-pay", "product-applications", request.RequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProductApplicationByRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/product-applications/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E5%85%A5%E9%A9%BB%E7%BB%93%E6%9E%9C-%E5%A4%96%E5%8D%95%E5%8F%B7 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProductApplicationByOutRequestNumberResponse> ExecuteGetProductApplicationByOutRequestNumberAsync(this WechatTenpayBusinessClient client, Models.GetProductApplicationByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mse-pay", "product-applications", "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProductApplicationByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/product-applications/{request_no}/links 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://businesspay.qq.com/p/doc/mse/api/server.html#%E5%88%9B%E5%BB%BA%E5%85%A5%E9%A9%BB%E8%B7%B3%E8%BD%AC%E9%93%BE%E6%8E%A5 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateProductApplicationLinkResponse> ExecuteCreateProductApplicationLinkAsync(this WechatTenpayBusinessClient client, Models.CreateProductApplicationLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mse-pay", "product-applications", request.RequestNumber, "links");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateProductApplicationLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
