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
    public static class WechatWorkClientExecuteCgibinDepartmentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/department/create 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90205 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90341 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDepartmentCreateResponse> ExecuteCgibinDepartmentCreateAsync(this WechatWorkClient client, Models.CgibinDepartmentCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "department", "create")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDepartmentCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/department/update 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90206 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90342 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDepartmentUpdateResponse> ExecuteCgibinDepartmentUpdateAsync(this WechatWorkClient client, Models.CgibinDepartmentUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "department", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDepartmentUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/department/delete 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90206 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90343 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDepartmentDeleteResponse> ExecuteCgibinDepartmentDeleteAsync(this WechatWorkClient client, Models.CgibinDepartmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "department", "delete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.DepartmentId);

            return await client.SendRequestAsync<Models.CgibinDepartmentDeleteResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/department/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90208 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90344 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDepartmentListResponse> ExecuteCgibinDepartmentListAsync(this WechatWorkClient client, Models.CgibinDepartmentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "department", "list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ParentDepartmentId.HasValue)
                flurlReq.SetQueryParam("id", request.ParentDepartmentId.Value);

            return await client.SendRequestAsync<Models.CgibinDepartmentListResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
