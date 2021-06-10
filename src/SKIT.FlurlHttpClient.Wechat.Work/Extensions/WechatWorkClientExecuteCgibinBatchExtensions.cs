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
    public static class WechatWorkClientExecuteCgibinBatchExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/invite 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90975 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91127 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/91159 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "batch", "invite")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinBatchInviteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/syncuser 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90980 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91130 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/91163 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "batch", "syncuser")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinBatchSyncUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/replaceuser 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90981 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91131 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/91164 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "batch", "replaceuser")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinBatchReplaceUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/batch/replaceparty 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90981 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91132 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/91165 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "batch", "replaceparty")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinBatchReplaceDepartmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/batch/getresult 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90983 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91133 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/91166 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "batch", "getresult")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("jobid", request.JobId);

            return await client.SendRequestAsync<Models.CgibinBatchGetResultResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
