using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinBatchExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/invite 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90975 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91127 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91159 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinBatchInviteResponse> ExecuteCgibinBatchInviteAsync(this WechatWorkClient client, Models.CgibinBatchInviteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "batch", "invite")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinBatchInviteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/syncuser 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90980 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91130 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91163 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinBatchSyncUserResponse> ExecuteCgibinBatchSyncUserAsync(this WechatWorkClient client, Models.CgibinBatchSyncUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "batch", "syncuser")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinBatchSyncUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/replaceuser 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90981 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91131 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91164 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinBatchReplaceUserResponse> ExecuteCgibinBatchReplaceUserAsync(this WechatWorkClient client, Models.CgibinBatchReplaceUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "batch", "replaceuser")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinBatchReplaceUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/replaceparty 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90981 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91132 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91165 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinBatchReplaceDepartmentResponse> ExecuteCgibinBatchReplaceDepartmentAsync(this WechatWorkClient client, Models.CgibinBatchReplaceDepartmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "batch", "replaceparty")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinBatchReplaceDepartmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/batch/getresult 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90983 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91133 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91166 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinBatchGetResultResponse> ExecuteCgibinBatchGetResultAsync(this WechatWorkClient client, Models.CgibinBatchGetResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "batch", "getresult")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("jobid", request.JobId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinBatchGetResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/userid_to_openuserid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95435 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinBatchUserIdToOpenUserIdResponse> ExecuteCgibinBatchUserIdToOpenUserIdAsync(this WechatWorkClient client, Models.CgibinBatchUserIdToOpenUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "batch", "userid_to_openuserid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinBatchUserIdToOpenUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
