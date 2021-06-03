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
    public static class WechatWorkClientExecuteCgibinPSTNCCExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/pstncc/call 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91627 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPSTNCCCallResponse> ExecuteCgibinPSTNCCCallAsync(this WechatWorkClient client, Models.CgibinPSTNCCCallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "pstncc", "call")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinPSTNCCCallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/pstncc/getstates 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91628 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinPSTNCCGetStatesResponse> ExecuteCgibinPSTNCCGetStatesAsync(this WechatWorkClient client, Models.CgibinPSTNCCGetStatesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "pstncc", "getstates")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinPSTNCCGetStatesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
