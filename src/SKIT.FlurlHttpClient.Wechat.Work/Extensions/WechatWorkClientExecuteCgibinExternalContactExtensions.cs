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
    public static class WechatWorkClientExecuteCgibinExternalContactExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_follow_user_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92571 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetFollowUserListResponse> ExecuteCgibinExternalContactGetFollowUserListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetFollowUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "externalcontact", "get_follow_user_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinExternalContactGetFollowUserListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/close_temp_chat 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCloseTempChatResponse> ExecuteCgibinExternalContactCloseTempChatAsync(this WechatWorkClient client, Models.CgibinExternalContactCloseTempChatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "close_temp_chat")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactCloseTempChatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ContactWay
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddContactWayResponse> ExecuteCgibinExternalContactAddContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactAddContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "add_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactAddContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetContactWayResponse> ExecuteCgibinExternalContactGetContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactGetContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/update_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactUpdateContactWayResponse> ExecuteCgibinExternalContactUpdateContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactUpdateContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "update_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactUpdateContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactDeleteContactWayResponse> ExecuteCgibinExternalContactDeleteContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactDeleteContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "del_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactDeleteContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
