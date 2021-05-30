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
    public static class WechatWorkClientExecuteCgibinExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/gettoken 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91039 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetTokenResponse> ExecuteCgibinGetTokenAsync(this WechatWorkClient client, Models.CgibinGetTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "token")
                .SetOptions(request)
                .SetQueryParam("corpid", client.CorpId)
                .SetQueryParam("corpsecret", client.AgentSecret);

            return await client.SendRequestAsync<Models.CgibinGetTokenResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_api_domain_ip 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92520 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetApiDomainIpResponse> ExecuteCgibinGetApiDomainIpAsync(this WechatWorkClient client, Models.CgibinGetApiDomainIpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "get_api_domain_ip")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinGetApiDomainIpResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
