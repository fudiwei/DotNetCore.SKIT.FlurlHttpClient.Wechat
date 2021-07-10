using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Get_users_basic_information_UnionID.html#UinonId </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserInfoResponse> ExecuteCgibinUserInfoAsync(this WechatApiClient client, Models.CgibinUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("lang", request.Language);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/info/batchget 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Get_users_basic_information_UnionID.html#UinonId </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserInfoBatchGetResponse> ExecuteCgibinUserInfoBatchGetAsync(this WechatApiClient client, Models.CgibinUserInfoBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "info", "batchget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserInfoBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/info/updateremark 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Configuring_user_notes.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserInfoUpdateRemarkResponse> ExecuteCgibinUserInfoUpdateRemarkAsync(this WechatApiClient client, Models.CgibinUserInfoUpdateRemarkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "info", "updateremark")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserInfoUpdateRemarkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Getting_a_User_List.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetResponse> ExecuteCgibinUserGetAsync(this WechatApiClient client, Models.CgibinUserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.NextOpenId))
                flurlReq.SetQueryParam("next_openid", request.NextOpenId);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
