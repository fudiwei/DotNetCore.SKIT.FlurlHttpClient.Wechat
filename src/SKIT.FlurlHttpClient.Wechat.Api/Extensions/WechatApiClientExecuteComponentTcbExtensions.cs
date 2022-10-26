using System;
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
        /// <para>异步调用 [POST] /tcb/modifyenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/modifyEnv.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "tcb", "modifyenv")
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
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/cloudenv-mgnt/shareCloudbaseEnv.html </para>
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
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/cloudenv-mgnt/getShareCloudbaseEnv.html </para>
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

        #region SCF
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchuploadscf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchuploadscf.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchUploadSCFResponse> ExecuteComponentTcbBatchUploadSCFAsync(this WechatApiClient client, Models.ComponentTcbBatchUploadSCFRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchuploadscf")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchUploadSCFResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchuploadscfcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchUploadSCFCode.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchUploadSCFCodeResponse> ExecuteComponentTcbBatchUploadSCFCodeAsync(this WechatApiClient client, Models.ComponentTcbBatchUploadSCFCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchuploadscfcode")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchUploadSCFCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/updatescfconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/updatescfconfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbUploadSCFConfigResponse> ExecuteComponentTcbUploadSCFConfigAsync(this WechatApiClient client, Models.ComponentTcbUploadSCFConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "updatescfconfig")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbUploadSCFConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/deletescf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/deletescf.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDeleteSCFConfigResponse> ExecuteComponentTcbDeleteSCFConfigAsync(this WechatApiClient client, Models.ComponentTcbDeleteSCFConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "deletescf")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDeleteSCFConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getscflist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getscflist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbGetSCFListResponse> ExecuteComponentTcbGetSCFListAsync(this WechatApiClient client, Models.ComponentTcbGetSCFListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getscflist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbGetSCFListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/gettriggers 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getTriggers.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbGetTriggersResponse> ExecuteComponentTcbGetTriggersAsync(this WechatApiClient client, Models.ComponentTcbGetTriggersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "gettriggers")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbGetTriggersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchupdatetriggers 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchupdatetriggers.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchUpdateTriggersResponse> ExecuteComponentTcbBatchUpdateTriggersAsync(this WechatApiClient client, Models.ComponentTcbBatchUpdateTriggersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchupdatetriggers")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchUpdateTriggersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/invokecloudfunction 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/invokecloudfunction.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbInvokeCloudFunctionResponse> ExecuteComponentTcbInvokeCloudFunctionAsync(this WechatApiClient client, Models.ComponentTcbInvokeCloudFunctionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "invokecloudfunction")
                .SetQueryParam("access_token", request.ComponentAccessToken)
                .SetQueryParam("env", request.EnvironmentId)
                .SetQueryParam("name", request.FunctionName);

            using var httpContent = new StringContent(request.Data ?? string.Empty, Encoding.UTF8);
            return await client.SendRequestAsync<Models.ComponentTcbInvokeCloudFunctionResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region ContainerService
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/opencontainerservice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/opencontainerservice.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbOpenContainerServiceResponse> ExecuteComponentTcbOpenContainerServiceAsync(this WechatApiClient client, Models.ComponentTcbOpenContainerServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "opencontainerservice")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbOpenContainerServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/usecloudaccesstoken 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/usecloudaccesstoken.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbUseCloudAccessTokenResponse> ExecuteComponentTcbUseCloudAccessTokenAsync(this WechatApiClient client, Models.ComponentTcbUseCloudAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "usecloudaccesstoken")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbUseCloudAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcontainerservice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/createcontainerservice.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbCreateContainerServiceResponse> ExecuteComponentTcbCreateContainerServiceAsync(this WechatApiClient client, Models.ComponentTcbCreateContainerServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcontainerservice")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbCreateContainerServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getcslist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getcslist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbGetContainerServiceListResponse> ExecuteComponentTcbGetContainerServiceListAsync(this WechatApiClient client, Models.ComponentTcbGetContainerServiceListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getcslist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbGetContainerServiceListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/delcontainerservice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/delcontainerservice.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDeleteContainerServiceResponse> ExecuteComponentTcbDeleteContainerServiceAsync(this WechatApiClient client, Models.ComponentTcbDeleteContainerServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "delcontainerservice")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDeleteContainerServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/createcsversion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbCreateContainerServiceVersionResponse> ExecuteComponentTcbCreateContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTcbCreateContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbCreateContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchcreatecsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchcreatecsversion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchCreateContainerServiceVersionResponse> ExecuteComponentTcbBatchCreateContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTcbBatchCreateContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchcreatecsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchCreateContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/delcsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/delcsversion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDeleteContainerServiceVersionResponse> ExecuteComponentTcbDeleteContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTcbDeleteContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "delcsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDeleteContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdelcsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchDelCSVersion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchDeleteContainerServiceVersionResponse> ExecuteComponentTcbBatchDeleteContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTcbBatchDeleteContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchdelcsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchDeleteContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getcsversionlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getcsversionlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbGetContainerServiceVersionListResponse> ExecuteComponentTcbGetContainerServiceVersionListAsync(this WechatApiClient client, Models.ComponentTcbGetContainerServiceVersionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getcsversionlist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbGetContainerServiceVersionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getcsversiondetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getcsversiondetail.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbGetContainerServiceVersionDetailResponse> ExecuteComponentTcbGetContainerServiceVersionDetailAsync(this WechatApiClient client, Models.ComponentTcbGetContainerServiceVersionDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getcsversiondetail")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbGetContainerServiceVersionDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/setcsversionconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/setcsversionconfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbSetContainerServiceVersionConfigResponse> ExecuteComponentTcbSetContainerServiceVersionConfigAsync(this WechatApiClient client, Models.ComponentTcbSetContainerServiceVersionConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "setcsversionconfig")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbSetContainerServiceVersionConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/setcspropotion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/setcspropotion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbSetContainerServicePropotionResponse> ExecuteComponentTcbSetContainerServicePropotionAsync(this WechatApiClient client, Models.ComponentTcbSetContainerServicePropotionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "setcspropotion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbSetContainerServicePropotionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchsetcspropotion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchSetCSPropotion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchSetContainerServicePropotionResponse> ExecuteComponentTcbBatchSetContainerServicePropotionAsync(this WechatApiClient client, Models.ComponentTcbBatchSetContainerServicePropotionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchsetcspropotion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchSetContainerServicePropotionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region COS
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/uploadfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/uploadfile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbUploadFileResponse> ExecuteComponentTcbUploadFileAsync(this WechatApiClient client, Models.ComponentTcbUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "uploadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdownloadfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchdownloadfile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchDownloadFileResponse> ExecuteComponentTcbBatchDownloadFileAsync(this WechatApiClient client, Models.ComponentTcbBatchDownloadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchdownloadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchDownloadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdeletefile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchdeletefile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbBatchDeleteFileResponse> ExecuteComponentTcbBatchDeleteFileAsync(this WechatApiClient client, Models.ComponentTcbBatchDeleteFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchdeletefile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbBatchDeleteFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getbucket 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getbucket.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbGetBucketResponse> ExecuteComponentTcbGetBucketAsync(this WechatApiClient client, Models.ComponentTcbGetBucketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getbucket")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbGetBucketResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region StaticStore
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createstaticstore 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/CreateStaticStore.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbCreateStaticStoreResponse> ExecuteComponentTcbCreateStaticStoreAsync(this WechatApiClient client, Models.ComponentTcbCreateStaticStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createstaticstore")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbCreateStaticStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describestaticstore 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/DescribeStaticStore.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDescribeStaticStoreResponse> ExecuteComponentTcbDescribeStaticStoreAsync(this WechatApiClient client, Models.ComponentTcbDescribeStaticStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "describestaticstore")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDescribeStaticStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/staticfilelist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/staticFileList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbStaticFileListResponse> ExecuteComponentTcbStaticFileListAsync(this WechatApiClient client, Models.ComponentTcbStaticFileListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "staticfilelist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbStaticFileListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/staticuploadfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/staticUploadFile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbStaticUploadFileResponse> ExecuteComponentTcbStaticUploadFileAsync(this WechatApiClient client, Models.ComponentTcbStaticUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "staticuploadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbStaticUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Database
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbcollection 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbCollectionGet.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbCollectionAdd.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbCollectionDel.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbCollectionResponse> ExecuteComponentTcbDbCollectionAsync(this WechatApiClient client, Models.ComponentTcbDbCollectionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbcollection")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbCollectionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbrecord 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbRecordInsert.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbRecordDelete.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbRecordUpdate.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbRecordQuery.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbRecordResponse> ExecuteComponentTcbDbRecordAsync(this WechatApiClient client, Models.ComponentTcbDbRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbrecord")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbindex 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbIndexCreate.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbIndexDelete.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbIndexResponse> ExecuteComponentTcbDbIndexAsync(this WechatApiClient client, Models.ComponentTcbDbIndexRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbindex")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbIndexResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbimport 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbimport.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbImportResponse> ExecuteComponentTcbDbImportAsync(this WechatApiClient client, Models.ComponentTcbDbImportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbimport")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbImportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbexport 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbexport.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbExportResponse> ExecuteComponentTcbDbExportAsync(this WechatApiClient client, Models.ComponentTcbDbExportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbexport")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbExportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbmigrationstate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbmigrationstate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbMigrationStateResponse> ExecuteComponentTcbDbMigrationStateAsync(this WechatApiClient client, Models.ComponentTcbDbMigrationStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbmigrationstate")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbMigrationStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbaggregate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbaggregate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbAggregateResponse> ExecuteComponentTcbDbAggregateAsync(this WechatApiClient client, Models.ComponentTcbDbAggregateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbaggregate")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbAggregateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbgetacl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbGetACL.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbGetACLResponse> ExecuteComponentTcbDbGetACLAsync(this WechatApiClient client, Models.ComponentTcbDbGetACLRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbgetacl")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbGetACLResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbmodifyacl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/dbModifyACL.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTcbDbModifyACLResponse> ExecuteComponentTcbDbModifyACLAsync(this WechatApiClient client, Models.ComponentTcbDbModifyACLRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbmodifyacl")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTcbDbModifyACLResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
