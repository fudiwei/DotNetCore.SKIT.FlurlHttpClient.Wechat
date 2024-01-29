using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteBillExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/bill-downloads 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%8E%B7%E5%8F%96%E8%B5%84%E9%87%91%E8%B4%A6%E5%8D%95%E4%B8%8B%E8%BD%BD%E9%93%BE%E6%8E%A5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBillResponse> ExecuteGetBillAsync(this WechatTenpayBusinessClient client, Models.GetBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mse-pay", "bill-downloads");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/bill-downloads/trans 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%8E%B7%E5%8F%96%E4%BA%A4%E6%98%93%E8%B4%A6%E5%8D%95%E4%B8%8B%E8%BD%BD%E9%93%BE%E6%8E%A5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBillTransactionResponse> ExecuteGetBillTransactionAsync(this WechatTenpayBusinessClient client, Models.GetBillTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mse-pay", "bill-downloads", "trans");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBillTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%B5%84%E9%87%91%E8%B4%A6%E5%8D%95%E4%B8%8B%E8%BD%BD </para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E4%BA%A4%E6%98%93%E8%B4%A6%E5%8D%95%E4%B8%8B%E8%BD%BD </para>
        /// <para><i>（请注意此接口不受构造 <see cref="WechatTenpayBusinessClient" /> 时指定的 <see cref="WechatTenpayBusinessClientOptions.Endpoint"/> 参数控制。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadBillFileResponse> ExecuteDownloadBillFileAsync(this WechatTenpayBusinessClient client, Models.DownloadBillFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl);

            return await client.SendFlurlRequestAsJsonAsync<Models.DownloadBillFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
