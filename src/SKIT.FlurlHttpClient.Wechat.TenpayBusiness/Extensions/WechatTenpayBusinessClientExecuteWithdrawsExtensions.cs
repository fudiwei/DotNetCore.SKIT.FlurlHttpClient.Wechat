using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteWithdrawsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/withdraws 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://businesspay.qq.com/p/doc/mse/api/server.html#%E9%80%80%E6%AC%BE%E7%94%B3%E8%AF%B7 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateWithdrawResponse> ExecuteCreateWithdrawAsync(this WechatTenpayBusinessClient client, Models.CreateWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.EnterpriseId is null)
                request.EnterpriseId = client.Credentials.EnterpriseId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mse-pay", "withdraws");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/withdraws/{withdraw_id} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWithdrawByWithdrawIdResponse> ExecuteGetWithdrawByWithdrawIdAsync(this WechatTenpayBusinessClient client, Models.GetWithdrawByWithdrawIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mse-pay", "withdraws", request.WithdrawId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWithdrawByWithdrawIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/withdraws/out-withdraw-id/{out_withdraw_id} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetWithdrawByOutWithdrawIdResponse> ExecuteGetWithdrawByOutWithdrawIdAsync(this WechatTenpayBusinessClient client, Models.GetWithdrawByOutWithdrawIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mse-pay", "withdraws", "out-withdraw-id", request.OutWithdrawId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetWithdrawByOutWithdrawIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
