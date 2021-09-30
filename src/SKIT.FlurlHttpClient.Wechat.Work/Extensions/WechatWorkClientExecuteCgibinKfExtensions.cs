using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinKfExtensions
    {
        #region Account
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/account/add 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94662 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94688 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfAccountAddResponse> ExecuteCgibinKfAccountAddAsync(this WechatWorkClient client, Models.CgibinKfAccountAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "account", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfAccountAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/account/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94661 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94691 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfAccountListResponse> ExecuteCgibinKfAccountListAsync(this WechatWorkClient client, Models.CgibinKfAccountListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "account", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfAccountListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/account/update 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94664 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94690 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfAccountUpdateResponse> ExecuteCgibinKfAccountUpdateAsync(this WechatWorkClient client, Models.CgibinKfAccountUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "account", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfAccountUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/account/del 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94663 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94689 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfAccountDeleteResponse> ExecuteCgibinKfAccountDeleteAsync(this WechatWorkClient client, Models.CgibinKfAccountDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "account", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfAccountDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/add_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94665 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94692 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfAddContactWayResponse> ExecuteCgibinKfAddContactWayAsync(this WechatWorkClient client, Models.CgibinKfAddContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "add_contact_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfAddContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
