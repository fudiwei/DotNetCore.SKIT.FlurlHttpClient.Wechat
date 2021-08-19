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
    public static class WechatWorkClientExecuteCgibinExportExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/export/simple_user 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94849 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94950 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExportSimpleUserResponse> ExecuteCgibinExportSimpleUserAsync(this WechatWorkClient client, Models.CgibinExportSimpleUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "export", "simple_user")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExportSimpleUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);;
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/export/user 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94851 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94951 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExportUserResponse> ExecuteCgibinExportUserAsync(this WechatWorkClient client, Models.CgibinExportUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "export", "user")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExportUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/export/department 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94852 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94952 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExportDepartmentResponse> ExecuteCgibinExportDepartmentAsync(this WechatWorkClient client, Models.CgibinExportDepartmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "export", "department")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExportDepartmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/export/taguser 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94853 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94953 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExportTagUserResponse> ExecuteCgibinExportTagUserAsync(this WechatWorkClient client, Models.CgibinExportTagUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "export", "taguser")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExportTagUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/export/get_result 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94854 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94954 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExportGetResultResponse> ExecuteCgibinExportGetResultAsync(this WechatWorkClient client, Models.CgibinExportGetResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "export", "get_result")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("jobid", request.JobId);

            return await client.SendRequestWithJsonAsync<Models.CgibinExportGetResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
