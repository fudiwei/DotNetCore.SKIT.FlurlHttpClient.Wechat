namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        #region Broadcast
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_createroom.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomCreateResponse> ExecuteWxaApiBroadcastRoomCreateAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/deleteroom 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_deleteroom.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomDeleteRoomResponse> ExecuteWxaApiBroadcastRoomDeleteRoomAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomDeleteRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "deleteroom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomDeleteRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/editroom 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_editroom.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomEditRoomResponse> ExecuteWxaApiBroadcastRoomEditRoomAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomEditRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "editroom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomEditRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getpushurl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_getpushurl.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetPushUrlResponse> ExecuteWxaApiBroadcastRoomGetPushUrlAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetPushUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getpushurl")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomGetPushUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getsharedcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_getsharedcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetSharedCodeResponse> ExecuteWxaApiBroadcastRoomGetSharedCodeAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetSharedCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getsharedcode")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId)
                .SetQueryParam("params", request.CustomParameter);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomGetSharedCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatefeedpublic 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_updatefeedpublic.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateFeedPublicResponse> ExecuteWxaApiBroadcastRoomUpdateFeedPublicAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateFeedPublicRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatefeedpublic")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomUpdateFeedPublicResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatereplay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_updatereplay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateReplayResponse> ExecuteWxaApiBroadcastRoomUpdateReplayAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateReplayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatereplay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomUpdateReplayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatekf 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_updatekf.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateKfResponse> ExecuteWxaApiBroadcastRoomUpdateKfAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateKfRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatekf")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomUpdateKfResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/updatecomment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_updatecomment.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomUpdateCommentResponse> ExecuteWxaApiBroadcastRoomUpdateCommentAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomUpdateCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "updatecomment")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomUpdateCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Broadcast/Goods
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_addgoods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsAddResponse> ExecuteWxaApiBroadcastGoodsAddAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/resetaudit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_resetaudit.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsResetAuditResponse> ExecuteWxaApiBroadcastGoodsResetAuditAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsResetAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "resetaudit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsResetAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/audit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_resubmitaudit.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsAuditResponse> ExecuteWxaApiBroadcastGoodsAuditAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "audit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_deletegoodsinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsDeleteResponse> ExecuteWxaApiBroadcastGoodsDeleteAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_updategoodsinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsUpdateResponse> ExecuteWxaApiBroadcastGoodsUpdateAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getgoodswarehouse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_getgoodsauditinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetGoodsWarehouseResponse> ExecuteWxaBusinessGetGoodsWarehouseAsync(this WechatApiClient client, Models.WxaBusinessGetGoodsWarehouseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getgoodswarehouse")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetGoodsWarehouseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/goods/getapproved 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/commodity-management/api_getgoodsinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsGetApprovedResponse> ExecuteWxaApiBroadcastGoodsGetApprovedAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsGetApprovedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "goods", "getapproved")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("status", request.AuditStatus);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsGetApprovedResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Broadcast/Role
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/role/addrole 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/role-management/api_getrolelistdw.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoleAddRoleResponse> ExecuteWxaApiBroadcastRoleAddRoleAsync(this WechatApiClient client, Models.WxaApiBroadcastRoleAddRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "role", "addrole")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoleAddRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/role/deleterole 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/role-management/api_deleterole.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoleDeleteRoleResponse> ExecuteWxaApiBroadcastRoleDeleteRoleAsync(this WechatApiClient client, Models.WxaApiBroadcastRoleDeleteRoleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "role", "deleterole")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoleDeleteRoleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/role/getrolelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/role-management/api_getrolelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoleGetRoleListResponse> ExecuteWxaApiBroadcastRoleGetRoleListAsync(this WechatApiClient client, Models.WxaApiBroadcastRoleGetRoleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "role", "getrolelist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("keyword", request.Keyword)
                .SetQueryParam("role", request.Role)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoleGetRoleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Broadcast/RoomAnchor
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/addsubanchor 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_addsubanchor.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomAddSubAnchorResponse> ExecuteWxaApiBroadcastRoomAddSubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomAddSubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "addsubanchor")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomAddSubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/modifysubanchor 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_modifysubanchor.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomModifySubAnchorResponse> ExecuteWxaApiBroadcastRoomModifySubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomModifySubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "modifysubanchor")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomModifySubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/deletesubanchor 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_deletesubanchor.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomDeleteSubAnchorResponse> ExecuteWxaApiBroadcastRoomDeleteSubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomDeleteSubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "deletesubanchor")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomDeleteSubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getsubanchor 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_getsubanchor.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetSubAnchorResponse> ExecuteWxaApiBroadcastRoomGetSubAnchorAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetSubAnchorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getsubanchor")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomGetSubAnchorResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Broadcast/RoomAssistant
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/addassistant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_addveassistant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomAddAssistantResponse> ExecuteWxaApiBroadcastRoomAddAssistantAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomAddAssistantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "addassistant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomAddAssistantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/modifyassistant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_modifyassistant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomModifyAssistantResponse> ExecuteWxaApiBroadcastRoomModifyAssistantAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomModifyAssistantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "modifyassistant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomModifyAssistantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/removeassistant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_removeassistant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomRemoveAssistantResponse> ExecuteWxaApiBroadcastRoomRemoveAssistantAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomRemoveAssistantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "removeassistant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomRemoveAssistantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/broadcast/room/getassistantlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_getassistantlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomGetAssistantListResponse> ExecuteWxaApiBroadcastRoomGetAssistantListAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomGetAssistantListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "broadcast", "room", "getassistantlist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("roomId", request.RoomId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomGetAssistantListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Broadcast/RoomGoods
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/room/addgoods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_importgoods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastRoomAddGoodsResponse> ExecuteWxaApiBroadcastRoomAddGoodsAsync(this WechatApiClient client, Models.WxaApiBroadcastRoomAddGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "room", "addgoods")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastRoomAddGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/onsale 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_salegoods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsOnSaleResponse> ExecuteWxaApiBroadcastGoodsOnSaleAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsOnSaleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "onsale")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsOnSaleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/deleteInRoom 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_deletedoods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsDeleteInRoomResponse> ExecuteWxaApiBroadcastGoodsDeleteInRoomAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsDeleteInRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "deleteInRoom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsDeleteInRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/push 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_pushgoods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsPushResponse> ExecuteWxaApiBroadcastGoodsPushAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsPushRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "push")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsPushResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/sort 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_sortgoods.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsSortResponse> ExecuteWxaApiBroadcastGoodsSortAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsSortRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "sort")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsSortResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/broadcast/goods/getVideo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/livebroadcast/studio-management/api_downloadgoodsvideo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiBroadcastGoodsGetVideoResponse> ExecuteWxaApiBroadcastGoodsGetVideoAsync(this WechatApiClient client, Models.WxaApiBroadcastGoodsGetVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "broadcast", "goods", "getVideo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiBroadcastGoodsGetVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region Comment
        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/comment/mpcommentlist/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_getccommentlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentMpCommentListGetResponse> ExecuteWxaApiCommentMpCommentListGetAsync(this WechatApiClient client, Models.WxaApiCommentMpCommentListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "comment", "mpcommentlist", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("startTime", request.StartTimestamp)
                .SetQueryParam("endTime", request.EndTimestamp)
                .SetQueryParam("filterType", request.FilterType)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentMpCommentListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/comment/replyandcommentreplylist/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_getcommentreplylist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentReplyAndCommentReplyListGetResponse> ExecuteWxaApiCommentReplyAndCommentReplyListGetAsync(this WechatApiClient client, Models.WxaApiCommentReplyAndCommentReplyListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "comment", "replyandcommentreplylist", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("commentId", request.CommentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentReplyAndCommentReplyListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/comment/commentinfo/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_getcommentinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentInfoGetResponse> ExecuteWxaApiCommentInfoGetAsync(this WechatApiClient client, Models.WxaApiCommentInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "comment", "commentinfo", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("commentId", request.CommentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/comment/commentreply/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_addcommentreply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentReplyAddResponse> ExecuteWxaApiCommentReplyAddAsync(this WechatApiClient client, Models.WxaApiCommentReplyAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "comment", "commentreply", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentReplyAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/comment/commentreply/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_deletecommentreply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentReplyDeleteResponse> ExecuteWxaApiCommentReplyDeleteAsync(this WechatApiClient client, Models.WxaApiCommentReplyDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "comment", "commentreply", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentReplyDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/comment/apikfquota/reset 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_resetapikfquota.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentApiKfQuotaResetResponse> ExecuteWxaApiCommentApiKfQuotaResetAsync(this WechatApiClient client, Models.WxaApiCommentApiKfQuotaResetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "comment", "apikfquota", "reset")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentApiKfQuotaResetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/comment/confirmcompromise 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/comment/api_confirmcompromise.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiCommentConfirmCompromiseResponse> ExecuteWxaApiCommentConfirmCompromiseAsync(this WechatApiClient client, Models.WxaApiCommentConfirmCompromiseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "comment", "confirmcompromise")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiCommentConfirmCompromiseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region NewTemplate
        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/newtmpl/addtemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_addwxanewtemplate.html ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateAddTemplateResponse> ExecuteWxaApiNewTemplateAddTemplateAsync(this WechatApiClient client, Models.WxaApiNewTemplateAddTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "newtmpl", "addtemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiNewTemplateAddTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/newtmpl/deltemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_delwxanewtemplate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateDeleteTemplateResponse> ExecuteWxaApiNewTemplateDeleteTemplateAsync(this WechatApiClient client, Models.WxaApiNewTemplateDeleteTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "newtmpl", "deltemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiNewTemplateDeleteTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/getcategory 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_getcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetCategoryResponse> ExecuteWxaApiNewTemplateGetCategoryAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "getcategory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiNewTemplateGetCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/getpubtemplatekeywords 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_getpubnewtemplatekeywords.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetPublicTemplateKeywordsResponse> ExecuteWxaApiNewTemplateGetPublicTemplateKeywordsAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetPublicTemplateKeywordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "getpubtemplatekeywords")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tid", request.TemplateTitleId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiNewTemplateGetPublicTemplateKeywordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/getpubtemplatetitles 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_getpubnewtemplatetitles.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetPublicTemplateTitlesResponse> ExecuteWxaApiNewTemplateGetPublicTemplateTitlesAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetPublicTemplateTitlesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "getpubtemplatetitles")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("ids", request.CategoryIdList is null ? null : string.Join(",", request.CategoryIdList))
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiNewTemplateGetPublicTemplateTitlesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/newtmpl/gettemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_getwxapubnewtemplate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiNewTemplateGetTemplateResponse> ExecuteWxaApiNewTemplateGetTemplateAsync(this WechatApiClient client, Models.WxaApiNewTemplateGetTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "newtmpl", "gettemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiNewTemplateGetTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Opertaion
        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/feedback/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getfeedback.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiFeedbackListResponse> ExecuteWxaApiFeedbackListAsync(this WechatApiClient client, Models.WxaApiFeedbackListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "feedback", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("num", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiFeedbackListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/log/jserr_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getjserrdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogJsErrorDetailResponse> ExecuteWxaApiLogJsErrorDetailAsync(this WechatApiClient client, Models.WxaApiLogJsErrorDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "log", "jserr_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiLogJsErrorDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/log/jserr_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getjserrlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogJsErrorListResponse> ExecuteWxaApiLogJsErrorListAsync(this WechatApiClient client, Models.WxaApiLogJsErrorListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "log", "jserr_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiLogJsErrorListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/log/get_performance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getperformance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogGetPerformanceResponse> ExecuteWxaApiLogGetPerformanceAsync(this WechatApiClient client, Models.WxaApiLogGetPerformanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "log", "get_performance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiLogGetPerformanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/log/get_scene 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getscenelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogGetSceneResponse> ExecuteWxaApiLogGetSceneAsync(this WechatApiClient client, Models.WxaApiLogGetSceneRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "log", "get_scene")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiLogGetSceneResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/log/get_client_version 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getversionlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiLogGetClientVersionResponse> ExecuteWxaApiLogGetClientVersionAsync(this WechatApiClient client, Models.WxaApiLogGetClientVersionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "log", "get_client_version")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiLogGetClientVersionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/userlog/userlog_search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_realtimelogsearch.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiUserLogSearchResponse> ExecuteWxaApiUserLogSearchAsync(this WechatApiClient client, Models.WxaApiUserLogSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "userlog", "userlog_search")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("begintime", request.BeginTimestamp)
                .SetQueryParam("endtime", request.EndTimestamp)
                .SetQueryParam("traceId", request)
                .SetQueryParam("url", request)
                .SetQueryParam("id", request)
                .SetQueryParam("filterMsg", request)
                .SetQueryParam("level", request.LogLevel)
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiUserLogSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MiniShop
        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/minishop/complaintOrderDetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/guarantee/complaint.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiMiniShopComplaintOrderDetailResponse> ExecuteWxaApiMiniShopComplaintOrderDetailAsync(this WechatApiClient client, Models.WxaApiMiniShopComplaintOrderDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "minishop", "complaintOrderDetail")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("complaintOrderId", request.ComplaintOrderId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiMiniShopComplaintOrderDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/minishop/bussiRespondComplaint 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/guarantee/complaint.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiMiniShopBusinessRespondComplaintResponse> ExecuteWxaApiMiniShopBusinessRespondComplaintAsync(this WechatApiClient client, Models.WxaApiMiniShopBusinessRespondComplaintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "minishop", "bussiRespondComplaint")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiMiniShopBusinessRespondComplaintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/minishop/bussiSupplyProof 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/guarantee/complaint.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiMiniShopBusinessSupplyProofResponse> ExecuteWxaApiMiniShopBusinessSupplyProofAsync(this WechatApiClient client, Models.WxaApiMiniShopBusinessSupplyProofRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "minishop", "bussiSupplyProof")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiMiniShopBusinessSupplyProofResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/minishop/bussiSupplyRefund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/guarantee/complaint.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiMiniShopBusinessSupplyRefundResponse> ExecuteWxaApiMiniShopBusinessSupplyRefundAsync(this WechatApiClient client, Models.WxaApiMiniShopBusinessSupplyRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "minishop", "bussiSupplyRefund")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiMiniShopBusinessSupplyRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/minishop/busiAppeal 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/guarantee/complaint.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiMiniShopBusinessAppealResponse> ExecuteWxaApiMiniShopBusinessAppealAsync(this WechatApiClient client, Models.WxaApiMiniShopBusinessAppealRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "minishop", "busiAppeal")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiMiniShopBusinessAppealResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WxaEmbedded
        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/wxaembedded/get_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/miniprogram-management/embedded-management/api_getembeddedlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaEmbeddedGetListResponse> ExecuteWxaApiWxaEmbeddedGetListAsync(this WechatApiClient client, Models.WxaApiWxaEmbeddedGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "wxaembedded", "get_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("num", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaEmbeddedGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/wxaembedded/get_own_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/miniprogram-management/embedded-management/api_getownlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaEmbeddedGetOwnListResponse> ExecuteWxaApiWxaEmbeddedGetOwnListAsync(this WechatApiClient client, Models.WxaApiWxaEmbeddedGetOwnListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "wxaembedded", "get_own_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("start", request.Offset)
                .SetQueryParam("num", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaEmbeddedGetOwnListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/wxaembedded/add_embedded 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/miniprogram-management/embedded-management/api_addembedded.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaEmbeddedAddEmbeddedResponse> ExecuteWxaApiWxaEmbeddedAddEmbeddedAsync(this WechatApiClient client, Models.WxaApiWxaEmbeddedAddEmbeddedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "wxaembedded", "add_embedded")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaEmbeddedAddEmbeddedResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/wxaembedded/del_embedded 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/miniprogram-management/embedded-management/api_deleteembedded.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaEmbeddedDeleteEmbeddedResponse> ExecuteWxaApiWxaEmbeddedDeleteEmbeddedAsync(this WechatApiClient client, Models.WxaApiWxaEmbeddedDeleteEmbeddedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "wxaembedded", "del_embedded")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaEmbeddedDeleteEmbeddedResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/wxaembedded/del_authorize 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/miniprogram-management/embedded-management/api_deleteauthorizedembedded.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaEmbeddedDeleteAuthorizeResponse> ExecuteWxaApiWxaEmbeddedDeleteAuthorizeAsync(this WechatApiClient client, Models.WxaApiWxaEmbeddedDeleteAuthorizeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "wxaembedded", "del_authorize")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaEmbeddedDeleteAuthorizeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxaapi/wxaembedded/set_authorize 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/miniprogram-management/embedded-management/api_setauthorizedembedded.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaEmbeddedSetAuthorizeResponse> ExecuteWxaApiWxaEmbeddedSetAuthorizeAsync(this WechatApiClient client, Models.WxaApiWxaEmbeddedSetAuthorizeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxaapi", "wxaembedded", "set_authorize")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaEmbeddedSetAuthorizeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WxaMpTrade
        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/wxamptrade/get_guarantee_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/basic/api_getguaranteestatus.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaMpTradeGetGuaranteeStatusResponse> ExecuteWxaApiWxaMpTradeGetGuaranteeStatusAsync(this WechatApiClient client, Models.WxaApiWxaMpTradeGetGuaranteeStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "wxamptrade", "get_guarantee_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaMpTradeGetGuaranteeStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxaapi/wxamptrade/get_penalty_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/transaction-guarantee/basic/api_getpenaltylist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApiWxaMpTradeGetPenaltyListResponse> ExecuteWxaApiWxaMpTradeGetPenaltyListAsync(this WechatApiClient client, Models.WxaApiWxaMpTradeGetPenaltyListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxaapi", "wxamptrade", "get_penalty_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApiWxaMpTradeGetPenaltyListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
