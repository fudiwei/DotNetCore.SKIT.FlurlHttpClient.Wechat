using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMiniProgramExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/miniprogram/transfer_session 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93403 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMiniProgramTransferSessionResponse> ExecuteCgibinMiniProgramTransferSessionAsync(this WechatWorkClient client, Models.CgibinMiniProgramTransferSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "miniprogram", "transfer_session")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMiniProgramTransferSessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
