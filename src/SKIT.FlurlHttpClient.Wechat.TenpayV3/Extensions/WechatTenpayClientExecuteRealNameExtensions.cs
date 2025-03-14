using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteRealNameExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /realname/verify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013735179 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRealNameVerificationResponse> ExecuteGetRealNameVerificationAsync(this WechatTenpayClient client, Models.GetRealNameVerificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "realname", "verify")
                .SetQueryParam("credential_type", request.CredentialType)
                .SetQueryParam("encrypted_credential_id", request.CredentialId)
                .SetQueryParam("encrypted_name", request.CredentialName)
                .SetQueryParam("wxp_trade_no", request.TransactionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetRealNameVerificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
