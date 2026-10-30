namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        #region Environment
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createenv 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_createtcbenv.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "createenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBCreateEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/modifyenv 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_changetcbenv.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_changetcbenv.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "tcb", "modifyenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBModifyEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describeenvs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_gettcbenvlist.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "describeenvs")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDescribeEnvironmentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchshareenv 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_sharecloudbaseenv.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchshareenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchShareEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchgetenvid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_getsharecloudbaseenv.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchgetenvid")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchGetEnvironmentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/usecloudaccesstoken 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_setcloudaccesstoken.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "tcb", "usecloudaccesstoken")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBUseCloudAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SCF
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchuploadscf 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_batchuuloadcloudfunction.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchuploadscf")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchUploadSCFResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchuploadscfcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_uploadcloudfunctioncode.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchuploadscfcode")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchUploadSCFCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/updatescfconfig 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_uploadcloudfunctionconfig.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "updatescfconfig")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBUploadSCFConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/deletescf 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_deletecloudfunction.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "deletescf")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDeleteSCFConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getscflist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_getcloudfunctionlist.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "getscflist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBGetSCFListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/gettriggers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_gettriggers.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "gettriggers")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBGetTriggersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchupdatetriggers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_updatetriggers.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchupdatetriggers")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchUpdateTriggersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/invokecloudfunction 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_invokecloudfunction.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/scf-mgnt/api_invokecloudfunction.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "tcb", "invokecloudfunction")
                .SetQueryParam("access_token", request.ComponentAccessToken)
                .SetQueryParam("env", request.EnvironmentId)
                .SetQueryParam("name", request.FunctionName);

            using var httpContent = new StringContent(request.Data!, Encoding.UTF8);
            return await client.SendFlurlRequestAsync<Models.ComponentTCBInvokeCloudFunctionResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region COS
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/uploadfile 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/file-mgnt/api_getuploadfilelink.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "uploadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdownloadfile 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/file-mgnt/api_getdownloadfilelink.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchdownloadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchDownloadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/batchdeletefile 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/file-mgnt/api_deletetcbfile.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "batchdeletefile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBBatchDeleteFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/getbucket 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/file-mgnt/api_gettcbfile.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "getbucket")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBGetBucketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region StaticStore
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createstaticstore 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/staticstore-management/api_createstaticstore.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "createstaticstore")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBCreateStaticStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describestaticstore 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/staticstore-management/api_getstaticstore.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "describestaticstore")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDescribeStaticStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/staticfilelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/staticstore-management/api_getstaticstorefile.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "staticfilelist")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBStaticFileListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/staticuploadfile 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/staticstore-management/api_getuploadstaticstorefile.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "staticuploadfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBStaticUploadFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Database
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbcollection 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-common/db-management/api_dbcollectionmanage.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbcollection")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbCollectionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbrecord 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_dbrecordmanage.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbrecord")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbindex 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_dbindexmanage.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbindex")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbIndexResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbimport 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_dbimport.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbimport")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbImportResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbexport 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_dbexport.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbexport")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbExportResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbmigrationstate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_getmigrationstate.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbmigrationstate")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbMigrationStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbaggregate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_dbaggregate.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbaggregate")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbAggregateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbgetacl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_getpermission.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbgetacl")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbGetACLResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/dbmodifyacl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/db-mgnt/api_setpermission.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "dbmodifyacl")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDbModifyACLResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region CloudBaseEnvironment
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/describecloudbaserunenvs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudbase-batch/env-mgnt/api_gettcbenvlist.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "describecloudbaserunenvs")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDescribeCloudBaseRunEnvironmentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcloudbaserunenv 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudrun-batch/cloudenv-mgnt/api_createcloudbaseenv.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "createcloudbaserunenv")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBCreateCloudBaseRunEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region CloudBaseServer
        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/establishcloudbaserunserver 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudrun-batch/service-mgnt/api_createcloudbaseservice.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "establishcloudbaserunserver")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBEstablishCloudBaseRunServerResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/createcloudbaserunserverversion 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudrun-batch/service-mgnt/api_createcloudbaseserviceversion.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "createcloudbaserunserverversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBCreateCloudBaseRunServerVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/rollupdatecloudbaserunserverversion 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudrun-batch/service-mgnt/api_updatecloudbaseserviceversion.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "rollupdatecloudbaserunserverversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBRollUpdateCloudBaseRunServerVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/deletecloudbaserunserverversion 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudrun-batch/service-mgnt/api_deletecloudbaseserviceversion.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "deletecloudbaserunserverversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBDeleteCloudBaseRunServerVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /componenttcb/releasecloudbaserunversion 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/cloudrun-batch/service-mgnt/api_releasecloudbaseserviceversion.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "componenttcb", "releasecloudbaserunversion")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ComponentTCBReleaseCloudBaseRunVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
