using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteFundExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /fund/queryautowithdrawbydate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/xiaowei.php?chapter=21_1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAutoWithdrawByDateResponse> ExecuteGetFundAutoWithdrawByDateAsync(this WechatTenpayClient client, Models.GetFundAutoWithdrawByDateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "fund", "queryautowithdrawbydate");

            return await client.SendRequestWithXmlAsync<Models.GetFundAutoWithdrawByDateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
