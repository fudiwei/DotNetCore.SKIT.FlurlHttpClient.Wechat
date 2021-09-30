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
        /// <para>异步调用 [GET] /cgi-bin/kf/account/list 接口。</para>
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
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "kf", "account", "list")
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

        #region Servicer
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/servicer/add 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94646 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94695 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfServicerAddResponse> ExecuteCgibinKfServicerAddAsync(this WechatWorkClient client, Models.CgibinKfServicerAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "servicer", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfServicerAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/servicer/del 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94647 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94696 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfServicerDeleteResponse> ExecuteCgibinKfServicerDeleteAsync(this WechatWorkClient client, Models.CgibinKfServicerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "servicer", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfServicerDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/kf/servicer/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94645 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94697 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfServicerListResponse> ExecuteCgibinKfServicerListAsync(this WechatWorkClient client, Models.CgibinKfServicerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "kf", "servicer", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_kfid", request.OpenKfId);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfServicerListResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region ServiceState
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/service_state/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94669 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94698 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfServiceStateGetResponse> ExecuteCgibinKfServiceStateGetAsync(this WechatWorkClient client, Models.CgibinKfServiceStateGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "service_state", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfServiceStateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/kf/service_state/trans 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94669 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94698 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinKfServiceStateTransferResponse> ExecuteCgibinKfServiceStateTransferAsync(this WechatWorkClient client, Models.CgibinKfServiceStateTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "kf", "service_state", "trans")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinKfServiceStateTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
