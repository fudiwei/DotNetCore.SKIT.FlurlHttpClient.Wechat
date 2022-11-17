using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/auth/getuserinfo 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91023 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91437 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAuthGetUserInfoResponse> ExecuteCgibinAuthGetUserInfoAsync(this WechatWorkClient client, Models.CgibinAuthGetUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "auth", "getuserinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.CgibinAuthGetUserInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/auth/getuserdetail 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95833 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAuthGetUserDetailResponse> ExecuteCgibinAuthGetUserDetailAsync(this WechatWorkClient client, Models.CgibinAuthGetUserDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "auth", "getuserdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinAuthGetUserDetailResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
