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
    public static class WechatWorkClientExecuteCgibinMessageAuditExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/msgaudit/get_robot_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91774 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageAuditGetRobotInfoResponse> ExecuteCgibinMessageAuditGetRobotInfoAsync(this WechatWorkClient client, Models.CgibinMessageAuditGetRobotInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "msgaudit", "get_robot_info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("robot_id", request.RobotId);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageAuditGetRobotInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/msgaudit/get_permit_user_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91614 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageAuditGetPermitUserListResponse> ExecuteCgibinMessageAuditGetPermitUserListAsync(this WechatWorkClient client, Models.CgibinMessageAuditGetPermitUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "msgaudit", "get_permit_user_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageAuditGetPermitUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/msgaudit/check_single_agree 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91782 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageAuditCheckSingleAgreeResponse> ExecuteCgibinMessageAuditCheckSingleAgreeAsync(this WechatWorkClient client, Models.CgibinMessageAuditCheckSingleAgreeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "msgaudit", "check_single_agree")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageAuditCheckSingleAgreeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/msgaudit/check_room_agree 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91782 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageAuditCheckRoomAgreeResponse> ExecuteCgibinMessageAuditCheckRoomAgreeAsync(this WechatWorkClient client, Models.CgibinMessageAuditCheckRoomAgreeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "msgaudit", "check_room_agree")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageAuditCheckRoomAgreeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/msgaudit/groupchat/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92951 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageAuditGroupChatGetResponse> ExecuteCgibinMessageAuditGroupChatGetAsync(this WechatWorkClient client, Models.CgibinMessageAuditGroupChatGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "msgaudit", "groupchat", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageAuditGroupChatGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
