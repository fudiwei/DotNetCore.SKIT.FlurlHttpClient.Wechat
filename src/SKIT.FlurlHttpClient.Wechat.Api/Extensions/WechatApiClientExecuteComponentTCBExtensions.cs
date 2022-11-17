using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteComponentTCBExtensions
    {
        #region Environment
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/env-mgnt/createTcbEnv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateEnvironmentResponse> ExecuteComponentTCBCreateEnvironmentAsync(this WechatApiClient client, Models.ComponentTCBCreateEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/modifyenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/env-mgnt/changeTcbEnv.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-common/env-management/changeTcbEnv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBModifyEnvironmentResponse> ExecuteComponentTCBModifyEnvironmentAsync(this WechatApiClient client, Models.ComponentTCBModifyEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "modifyenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBModifyEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describeenvs 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/env-mgnt/getTcbEnvList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDescribeEnvironmentsResponse> ExecuteComponentTCBDescribeEnvironmentsAsync(this WechatApiClient client, Models.ComponentTCBDescribeEnvironmentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "describeenvs")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDescribeEnvironmentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchshareenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/env-mgnt/shareCloudbaseEnv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchShareEnvironmentResponse> ExecuteComponentTCBBatchShareEnvironmentAsync(this WechatApiClient client, Models.ComponentTCBBatchShareEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchshareenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchShareEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchgetenvid 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/env-mgnt/getShareCloudbaseEnv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchGetEnvironmentIdResponse> ExecuteComponentTCBBatchGetEnvironmentIdAsync(this WechatApiClient client, Models.ComponentTCBBatchGetEnvironmentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchgetenvid")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchGetEnvironmentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SCF
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchuploadscf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/batchuUloadCloudFunction.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchUploadSCFResponse> ExecuteComponentTCBBatchUploadSCFAsync(this WechatApiClient client, Models.ComponentTCBBatchUploadSCFRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchuploadscf")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchUploadSCFResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchuploadscfcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/uploadCloudFunctionCode.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchUploadSCFCodeResponse> ExecuteComponentTCBBatchUploadSCFCodeAsync(this WechatApiClient client, Models.ComponentTCBBatchUploadSCFCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchuploadscfcode")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchUploadSCFCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/updatescfconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/uploadCloudFunctionConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBUploadSCFConfigResponse> ExecuteComponentTCBUploadSCFConfigAsync(this WechatApiClient client, Models.ComponentTCBUploadSCFConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "updatescfconfig")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBUploadSCFConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/deletescf 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/deleteCloudFunction.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDeleteSCFConfigResponse> ExecuteComponentTCBDeleteSCFConfigAsync(this WechatApiClient client, Models.ComponentTCBDeleteSCFConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "deletescf")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDeleteSCFConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getscflist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/getCloudFunctionList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBGetSCFListResponse> ExecuteComponentTCBGetSCFListAsync(this WechatApiClient client, Models.ComponentTCBGetSCFListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getscflist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBGetSCFListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/gettriggers 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/getTriggers.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBGetTriggersResponse> ExecuteComponentTCBGetTriggersAsync(this WechatApiClient client, Models.ComponentTCBGetTriggersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "gettriggers")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBGetTriggersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchupdatetriggers 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/updateTriggers.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchUpdateTriggersResponse> ExecuteComponentTCBBatchUpdateTriggersAsync(this WechatApiClient client, Models.ComponentTCBBatchUpdateTriggersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchupdatetriggers")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchUpdateTriggersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/invokecloudfunction 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/scf-mgnt/invokeCloudFunction.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-common/scf-management/invokeCloudFunction.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBInvokeCloudFunctionResponse> ExecuteComponentTCBInvokeCloudFunctionAsync(this WechatApiClient client, Models.ComponentTCBInvokeCloudFunctionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "invokecloudfunction")
                .SetQueryParam("access_token", request.ComponentAccessToken)
                .SetQueryParam("env", request.EnvironmentId)
                .SetQueryParam("name", request.FunctionName);

            using var httpContent = new StringContent(request.Data ?? string.Empty, Encoding.UTF8);
            return await client.SendRequestAsync<Models.ComponentTCBInvokeCloudFunctionResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
        public static async Task<Models.ComponentTCBOpenContainerServiceResponse> ExecuteComponentTCBOpenContainerServiceAsync(this WechatApiClient client, Models.ComponentTCBOpenContainerServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "opencontainerservice")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBOpenContainerServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/usecloudaccesstoken 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-common/admin-management/setCloudAccessToken.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBUseCloudAccessTokenResponse> ExecuteComponentTCBUseCloudAccessTokenAsync(this WechatApiClient client, Models.ComponentTCBUseCloudAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "usecloudaccesstoken")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBUseCloudAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcontainerservice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/createcontainerservice.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateContainerServiceResponse> ExecuteComponentTCBCreateContainerServiceAsync(this WechatApiClient client, Models.ComponentTCBCreateContainerServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcontainerservice")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateContainerServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getcslist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getcslist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBGetContainerServiceListResponse> ExecuteComponentTCBGetContainerServiceListAsync(this WechatApiClient client, Models.ComponentTCBGetContainerServiceListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getcslist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBGetContainerServiceListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/delcontainerservice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/delcontainerservice.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDeleteContainerServiceResponse> ExecuteComponentTCBDeleteContainerServiceAsync(this WechatApiClient client, Models.ComponentTCBDeleteContainerServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "delcontainerservice")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDeleteContainerServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/createcsversion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateContainerServiceVersionResponse> ExecuteComponentTCBCreateContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTCBCreateContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchcreatecsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchcreatecsversion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchCreateContainerServiceVersionResponse> ExecuteComponentTCBBatchCreateContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTCBBatchCreateContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchcreatecsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchCreateContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/delcsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/delcsversion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDeleteContainerServiceVersionResponse> ExecuteComponentTCBDeleteContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTCBDeleteContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "delcsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDeleteContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdelcsversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchDelCSVersion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchDeleteContainerServiceVersionResponse> ExecuteComponentTCBBatchDeleteContainerServiceVersionAsync(this WechatApiClient client, Models.ComponentTCBBatchDeleteContainerServiceVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchdelcsversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchDeleteContainerServiceVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getcsversionlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getcsversionlist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBGetContainerServiceVersionListResponse> ExecuteComponentTCBGetContainerServiceVersionListAsync(this WechatApiClient client, Models.ComponentTCBGetContainerServiceVersionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getcsversionlist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBGetContainerServiceVersionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getcsversiondetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/getcsversiondetail.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBGetContainerServiceVersionDetailResponse> ExecuteComponentTCBGetContainerServiceVersionDetailAsync(this WechatApiClient client, Models.ComponentTCBGetContainerServiceVersionDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getcsversiondetail")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBGetContainerServiceVersionDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/setcsversionconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/setcsversionconfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBSetContainerServiceVersionConfigResponse> ExecuteComponentTCBSetContainerServiceVersionConfigAsync(this WechatApiClient client, Models.ComponentTCBSetContainerServiceVersionConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "setcsversionconfig")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBSetContainerServiceVersionConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/setcspropotion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/setcspropotion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBSetContainerServicePropotionResponse> ExecuteComponentTCBSetContainerServicePropotionAsync(this WechatApiClient client, Models.ComponentTCBSetContainerServicePropotionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "setcspropotion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBSetContainerServicePropotionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchsetcspropotion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/batch/batchSetCSPropotion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchSetContainerServicePropotionResponse> ExecuteComponentTCBBatchSetContainerServicePropotionAsync(this WechatApiClient client, Models.ComponentTCBBatchSetContainerServicePropotionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchsetcspropotion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchSetContainerServicePropotionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region COS
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/uploadfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/file-mgnt/getUploadFileLink.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBUploadFileResponse> ExecuteComponentTCBUploadFileAsync(this WechatApiClient client, Models.ComponentTCBUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "uploadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdownloadfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/file-mgnt/getDownloadFileLink.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchDownloadFileResponse> ExecuteComponentTCBBatchDownloadFileAsync(this WechatApiClient client, Models.ComponentTCBBatchDownloadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchdownloadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchDownloadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdeletefile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/file-mgnt/deleteTcbFile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBBatchDeleteFileResponse> ExecuteComponentTCBBatchDeleteFileAsync(this WechatApiClient client, Models.ComponentTCBBatchDeleteFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "batchdeletefile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBBatchDeleteFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getbucket 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/file-mgnt/getTcbFile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBGetBucketResponse> ExecuteComponentTCBGetBucketAsync(this WechatApiClient client, Models.ComponentTCBGetBucketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "getbucket")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBGetBucketResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region StaticStore
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createstaticstore 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/staticstore-management/createStaticStore.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateStaticStoreResponse> ExecuteComponentTCBCreateStaticStoreAsync(this WechatApiClient client, Models.ComponentTCBCreateStaticStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createstaticstore")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateStaticStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describestaticstore 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/staticstore-management/getStaticStore.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDescribeStaticStoreResponse> ExecuteComponentTCBDescribeStaticStoreAsync(this WechatApiClient client, Models.ComponentTCBDescribeStaticStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "describestaticstore")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDescribeStaticStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/staticfilelist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/staticstore-management/getStaticStoreFile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBStaticFileListResponse> ExecuteComponentTCBStaticFileListAsync(this WechatApiClient client, Models.ComponentTCBStaticFileListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "staticfilelist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBStaticFileListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/staticuploadfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/staticstore-management/getUploadStaticStoreFile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBStaticUploadFileResponse> ExecuteComponentTCBStaticUploadFileAsync(this WechatApiClient client, Models.ComponentTCBStaticUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "staticuploadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBStaticUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Database
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbcollection 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-common/db-management/dbcollectionManage.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbCollectionResponse> ExecuteComponentTCBDbCollectionAsync(this WechatApiClient client, Models.ComponentTCBDbCollectionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbcollection")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbCollectionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbrecord 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/dbrecordManage.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbRecordResponse> ExecuteComponentTCBDbRecordAsync(this WechatApiClient client, Models.ComponentTCBDbRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbrecord")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbindex 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/dbindexManage.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbIndexResponse> ExecuteComponentTCBDbIndexAsync(this WechatApiClient client, Models.ComponentTCBDbIndexRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbindex")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbIndexResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbimport 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/dbImport.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbImportResponse> ExecuteComponentTCBDbImportAsync(this WechatApiClient client, Models.ComponentTCBDbImportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbimport")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbImportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbexport 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/dbExport.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbExportResponse> ExecuteComponentTCBDbExportAsync(this WechatApiClient client, Models.ComponentTCBDbExportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbexport")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbExportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbmigrationstate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/getMigrationState.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbMigrationStateResponse> ExecuteComponentTCBDbMigrationStateAsync(this WechatApiClient client, Models.ComponentTCBDbMigrationStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbmigrationstate")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbMigrationStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbaggregate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/dbAggregate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbAggregateResponse> ExecuteComponentTCBDbAggregateAsync(this WechatApiClient client, Models.ComponentTCBDbAggregateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbaggregate")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbAggregateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbgetacl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/getPermission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbGetACLResponse> ExecuteComponentTCBDbGetACLAsync(this WechatApiClient client, Models.ComponentTCBDbGetACLRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbgetacl")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbGetACLResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbmodifyacl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudbase-batch/db-mgnt/setPermission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDbModifyACLResponse> ExecuteComponentTCBDbModifyACLAsync(this WechatApiClient client, Models.ComponentTCBDbModifyACLRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "dbmodifyacl")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDbModifyACLResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CloudBaseEnvironment
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describecloudbaserunenvs 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/cloudenv-mgnt/getWxCloudBaseRunEnvs.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDescribeCloudBaseRunEnvironmentsResponse> ExecuteComponentTCBDescribeCloudBaseRunEnvironmentsAsync(this WechatApiClient client, Models.ComponentTCBDescribeCloudBaseRunEnvironmentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "describecloudbaserunenvs")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDescribeCloudBaseRunEnvironmentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcloudbaserunenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/cloudenv-mgnt/createCloudbaseEnv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateCloudBaseRunEnvironmentResponse> ExecuteComponentTCBCreateCloudBaseRunEnvironmentAsync(this WechatApiClient client, Models.ComponentTCBCreateCloudBaseRunEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcloudbaserunenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateCloudBaseRunEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CloudBaseServer
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/establishcloudbaserunserver 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/service-mgnt/createCloudbaseService.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBEstablishCloudBaseRunServerResponse> ExecuteComponentTCBEstablishCloudBaseRunServerAsync(this WechatApiClient client, Models.ComponentTCBEstablishCloudBaseRunServerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "establishcloudbaserunserver")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBEstablishCloudBaseRunServerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcloudbaserunserverversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/service-mgnt/createCloudbaseServiceVersion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateCloudBaseRunServerVersionResponse> ExecuteComponentTCBCreateCloudBaseRunServerVersionAsync(this WechatApiClient client, Models.ComponentTCBCreateCloudBaseRunServerVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcloudbaserunserverversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateCloudBaseRunServerVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/rollupdatecloudbaserunserverversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/service-mgnt/updateCloudbaseServiceVersion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBRollUpdateCloudBaseRunServerVersionResponse> ExecuteComponentTCBRollUpdateCloudBaseRunServerVersionAsync(this WechatApiClient client, Models.ComponentTCBRollUpdateCloudBaseRunServerVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "rollupdatecloudbaserunserverversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBRollUpdateCloudBaseRunServerVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/deletecloudbaserunserverversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/service-mgnt/deleteCloudbaseServiceVersion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBDeleteCloudBaseRunServerVersionResponse> ExecuteComponentTCBDeleteCloudBaseRunServerVersionAsync(this WechatApiClient client, Models.ComponentTCBDeleteCloudBaseRunServerVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "deletecloudbaserunserverversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBDeleteCloudBaseRunServerVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/releasecloudbaserunversion 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/service-mgnt/releaseCloudbaseServiceVersion.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBReleaseCloudBaseRunVersionResponse> ExecuteComponentTCBReleaseCloudBaseRunVersionAsync(this WechatApiClient client, Models.ComponentTCBReleaseCloudBaseRunVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "releasecloudbaserunversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBReleaseCloudBaseRunVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcloudbaserunresauth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/cloudrun-batch/service-mgnt/createCloudbaseMicrservice.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ComponentTCBCreateCloudBaseRunResauthResponse> ExecuteComponentTCBCreateCloudBaseRunResauthAsync(this WechatApiClient client, Models.ComponentTCBCreateCloudBaseRunResauthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "componenttcb", "createcloudbaserunresauth")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.ComponentTCBCreateCloudBaseRunResauthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
