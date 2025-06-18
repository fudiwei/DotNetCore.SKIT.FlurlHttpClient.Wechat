using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteXDCExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /xdc/apiv2getsignkey/sign/getsignkey 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011984810 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSandboxSignKeyResponse> ExecuteGetSandboxSignKeyAsync(this WechatTenpayClient client, Models.GetSandboxSignKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "xdc", "apiv2getsignkey", "sign", "getsignkey");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetSandboxSignKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
