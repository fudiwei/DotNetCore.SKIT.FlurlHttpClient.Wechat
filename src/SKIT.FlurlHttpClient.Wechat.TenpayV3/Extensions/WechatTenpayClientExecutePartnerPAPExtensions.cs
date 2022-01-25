using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供扣款服务（服务商）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePartnerPAPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /partner-papay/contracts/{contract_id}/notify 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_15.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotifyPartnerPAPPayContractsResponse> ExecuteNotifyPartnerPAPPayContractsAsync(this WechatTenpayClient client, Models.NotifyPartnerPAPPayContractsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "partner-papay", "contracts", request.ContractId, "notify");

            return await client.SendRequestWithJsonAsync<Models.NotifyPartnerPAPPayContractsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
