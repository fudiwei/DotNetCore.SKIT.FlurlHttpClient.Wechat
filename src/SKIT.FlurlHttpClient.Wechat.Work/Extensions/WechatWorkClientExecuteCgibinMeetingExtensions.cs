using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMeetingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93627 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93706 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingCreateResponse> ExecuteCgibinMeetingCreateAsync(this WechatWorkClient client, Models.CgibinMeetingCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93631 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93710 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingUpdateResponse> ExecuteCgibinMeetingUpdateAsync(this WechatWorkClient client, Models.CgibinMeetingUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/cancel 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93630 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93709 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingCancelResponse> ExecuteCgibinMeetingCancelAsync(this WechatWorkClient client, Models.CgibinMeetingCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93629 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93708 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetInfoResponse> ExecuteCgibinMeetingGetInfoAsync(this WechatWorkClient client, Models.CgibinMeetingGetInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_user_meetingid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93628 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93707 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetUserMeetingIdResponse> ExecuteCgibinMeetingGetUserMeetingIdAsync(this WechatWorkClient client, Models.CgibinMeetingGetUserMeetingIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_user_meetingid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetUserMeetingIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
