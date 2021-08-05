using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteComponentTcbExtensions
    {
        #region Environment
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/createenv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbCreateEnvironmentResponse> ExecuteComponentTcbCreateEnvironmentAsync(this WechatApiClient client, Models.ComponentTcbCreateEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbCreateEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/modifyenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/modifyenv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbModifyEnvironmentResponse> ExecuteComponentTcbModifyEnvironmentAsync(this WechatApiClient client, Models.ComponentTcbModifyEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "modifyenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbModifyEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describeenvs 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/describeenvs.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDescribeEnvironmentsResponse> ExecuteComponentTcbDescribeEnvironmentsAsync(this WechatApiClient client, Models.ComponentTcbDescribeEnvironmentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "describeenvs")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDescribeEnvironmentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchshareenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchshareenv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchShareEnvironmentResponse> ExecuteComponentTcbBatchShareEnvironmentAsync(this WechatApiClient client, Models.ComponentTcbBatchShareEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchshareenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchShareEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchgetenvid 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchgetenvid.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchGetEnvironmentIdResponse> ExecuteComponentTcbBatchGetEnvironmentIdAsync(this WechatApiClient client, Models.ComponentTcbBatchGetEnvironmentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchgetenvid")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchGetEnvironmentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
