namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        #region KfAccount
        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_addkfaccount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_addkfaccount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_addkfaccount.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountAddResponse> ExecuteCustomServiceKfAccountAddAsync(this WechatApiClient client, Models.CustomServiceKfAccountAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfaccount", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_updatekfaccount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_updatekfaccount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_udpatekfaccount.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountUpdateResponse> ExecuteCustomServiceKfAccountUpdateAsync(this WechatApiClient client, Models.CustomServiceKfAccountUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfaccount", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/del 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_delkfaccount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_delkfaccount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_delkfaccount.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountDeleteResponse> ExecuteCustomServiceKfAccountDeleteAsync(this WechatApiClient client, Models.CustomServiceKfAccountDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfaccount", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfaccount/del 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountDeleteByOpenIdResponse> ExecuteCustomServiceKfAccountDeleteByOpenIdAsync(this WechatApiClient client, Models.CustomServiceKfAccountDeleteByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customservice", "kfaccount", "del")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_openid", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountDeleteByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/uploadheadimg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_uploadkfheadimg.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_uploadkfheadimg.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountUploadHeadImageResponse> ExecuteCustomServiceKfAccountUploadHeadImageAsync(this WechatApiClient client, Models.CustomServiceKfAccountUploadHeadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));
            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfaccount", "uploadheadimg")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_account", request.KfAccount);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.jpg", fileBytes: request.HeadImageFileBytes, fileContentType: "image/jpeg", formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.CustomServiceKfAccountUploadHeadImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfaccount/inviteworker 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_invitekfworker.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_invitekfworker.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountInviteWorkerResponse> ExecuteCustomServiceKfAccountInviteWorkerAsync(this WechatApiClient client, Models.CustomServiceKfAccountInviteWorkerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfaccount", "inviteworker")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountInviteWorkerResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfaccount/setadmin 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_setkfadmin.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountSetAdminByOpenIdResponse> ExecuteCustomServiceKfAccountSetAdminByOpenIdAsync(this WechatApiClient client, Models.CustomServiceKfAccountSetAdminByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customservice", "kfaccount", "setadmin")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_openid", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountSetAdminByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfaccount/canceladmin 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_cancelkfadmin.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfAccountCancelAdminByOpenIdResponse> ExecuteCustomServiceKfAccountCancelAdminByOpenIdAsync(this WechatApiClient client, Models.CustomServiceKfAccountCancelAdminByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customservice", "kfaccount", "canceladmin")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_openid", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfAccountCancelAdminByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region KfSession
        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfsession/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/messctrl/api_createkfsession.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/messctrl/api_createkfsession.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionCreateResponse> ExecuteCustomServiceKfSessionCreateAsync(this WechatApiClient client, Models.CustomServiceKfSessionCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfsession", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfSessionCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/kfsession/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/messctrl/api_closesession.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/messctrl/api_closesession.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionCloseResponse> ExecuteCustomServiceKfSessionCloseAsync(this WechatApiClient client, Models.CustomServiceKfSessionCloseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "kfsession", "close")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfSessionCloseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfsession/getsession 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/messctrl/api_getkfsession.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/messctrl/api_getkfsession.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionGetSessionResponse> ExecuteCustomServiceKfSessionGetSessionAsync(this WechatApiClient client, Models.CustomServiceKfSessionGetSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customservice", "kfsession", "getsession")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfSessionGetSessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfsession/getsessionlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/messctrl/api_getkfsessionlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/messctrl/api_getkfsessionlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionGetSessionListResponse> ExecuteCustomServiceKfSessionGetSessionListAsync(this WechatApiClient client, Models.CustomServiceKfSessionGetSessionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customservice", "kfsession", "getsessionlist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("kf_account", request.KfAccount);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfSessionGetSessionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /customservice/kfsession/getwaitcase 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/messctrl/api_getwaitcase.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/messctrl/api_getwaitcase.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceKfSessionGetWaitCaseResponse> ExecuteCustomServiceKfSessionGetWaitCaseAsync(this WechatApiClient client, Models.CustomServiceKfSessionGetWaitCaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "customservice", "kfsession", "getwaitcase")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceKfSessionGetWaitCaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MessageRecord
        /// <summary>
        /// <para>异步调用 [POST] /customservice/msgrecord/getmsglist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/message/api_getmsglist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/message/api_getmsglist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceMessageRecordGetMessageListResponse> ExecuteCustomServiceMessageRecordGetMessageListAsync(this WechatApiClient client, Models.CustomServiceMessageRecordGetMessageListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "msgrecord", "getmsglist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceMessageRecordGetMessageListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Work
        /// <summary>
        /// <para>异步调用 [POST] /customservice/work/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-work/api_getkfworkbound.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceWorkGetResponse> ExecuteCustomServiceWorkGetAsync(this WechatApiClient client, Models.CustomServiceWorkGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "work", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceWorkGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/work/bind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-work/api_bindkfwork.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceWorkBindResponse> ExecuteCustomServiceWorkBindAsync(this WechatApiClient client, Models.CustomServiceWorkBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "work", "bind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceWorkBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /customservice/work/unbind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-work/api_unbindkfwork.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomServiceWorkUnbindResponse> ExecuteCustomServiceWorkUnbindAsync(this WechatApiClient client, Models.CustomServiceWorkUnbindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "customservice", "work", "unbind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomServiceWorkUnbindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
