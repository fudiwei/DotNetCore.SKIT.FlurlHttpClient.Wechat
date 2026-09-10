using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinDocDataExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/docdata/get_auth_user_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101873 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCgibinDocDataGetAuthUserListResponse> ExecuteCgibinCgibinDocDataGetAuthUserListAsync(this WechatWorkClient client, Models.CgibinCgibinDocDataGetAuthUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "docdata", "get_auth_user_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCgibinDocDataGetAuthUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false); ;
        }
    }
}
