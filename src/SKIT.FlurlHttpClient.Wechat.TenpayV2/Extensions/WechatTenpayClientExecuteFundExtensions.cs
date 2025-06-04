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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014115346 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "fund", "queryautowithdrawbydate");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetFundAutoWithdrawByDateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
