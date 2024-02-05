using System;
using System.Net.Http;
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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90205 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90341 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90824 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "department", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinDepartmentCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/department/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90206 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90342 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90825 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "department", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinDepartmentUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/department/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90206 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90343 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90826 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "department", "delete")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.DepartmentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinDepartmentDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/department/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90208 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90344 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90827 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "department", "list")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ParentDepartmentId is not null)
                flurlReq.SetQueryParam("id", request.ParentDepartmentId.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinDepartmentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/department/simplelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95350 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95406 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDepartmentSimpleListResponse> ExecuteCgibinDepartmentSimpleListAsync(this WechatWorkClient client, Models.CgibinDepartmentSimpleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "department", "simplelist")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ParentDepartmentId is not null)
                flurlReq.SetQueryParam("id", request.ParentDepartmentId.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinDepartmentSimpleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/department/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95351 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95407 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDepartmentGetResponse> ExecuteCgibinDepartmentGetAsync(this WechatWorkClient client, Models.CgibinDepartmentGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "department", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.DepartmentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinDepartmentGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
