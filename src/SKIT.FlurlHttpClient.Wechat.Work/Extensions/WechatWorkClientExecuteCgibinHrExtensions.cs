using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinHrExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/hr/get_fields 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99131 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHrGetFieldsResponse> ExecuteCgibinHrGetFieldsAsync(this WechatWorkClient client, Models.CgibinHrGetFieldsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "hr", "get_fields")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHrGetFieldsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/hr/get_staff_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99132 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHrGetStaffInfoResponse> ExecuteCgibinHrGetStaffInfoAsync(this WechatWorkClient client, Models.CgibinHrGetStaffInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "hr", "get_staff_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHrGetStaffInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/hr/update_staff_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99133 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHrUpdateStaffInfoResponse> ExecuteCgibinHrUpdateStaffInfoAsync(this WechatWorkClient client, Models.CgibinHrUpdateStaffInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "hr", "update_staff_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHrUpdateStaffInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
