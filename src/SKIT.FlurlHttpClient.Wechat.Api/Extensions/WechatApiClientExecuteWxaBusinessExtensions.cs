using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteWxaBusinessExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getpayfororder 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/business.getPayForOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetPayForOrderResponse> ExecuteWxaBusinessGetPayForOrderAsync(this WechatApiClient client, Models.WxaBusinessGetPayForOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "getpayfororder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGetPayForOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/checkencryptedmsg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/user-info/auth.checkEncryptedData.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/user-info/auth.checkEncryptedData.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessCheckEncryptedMessageResponse> ExecuteWxaBusinessCheckEncryptedMessageAsync(this WechatApiClient client, Models.WxaBusinessCheckEncryptedMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "checkencryptedmsg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessCheckEncryptedMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getuserphonenumber 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/phonenumber/phonenumber.getPhoneNumber.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/phonenumber/phonenumber.getPhoneNumber.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetUserPhoneNumberResponse> ExecuteWxaBusinessGetUserPhoneNumberAsync(this WechatApiClient client, Models.WxaBusinessGetUserPhoneNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "getuserphonenumber")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGetUserPhoneNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region GameMatch
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/creatematchrule 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.createMatchRule.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGameMatchCreateMatchRuleResponse> ExecuteWxaBusinessGameMatchCreateMatchRuleAsync(this WechatApiClient client, Models.WxaBusinessGameMatchCreateMatchRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "creatematchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGameMatchCreateMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/deletematchrule 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.deleteMatchRule.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGameMatchDeleteMatchRuleResponse> ExecuteWxaBusinessGameMatchDeleteMatchRuleAsync(this WechatApiClient client, Models.WxaBusinessGameMatchDeleteMatchRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "deletematchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGameMatchDeleteMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/getallmatchrule 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.getAllMatchRule.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGameMatchGetAllMatchRuleResponse> ExecuteWxaBusinessGameMatchGetAllMatchRuleAsync(this WechatApiClient client, Models.WxaBusinessGameMatchGetAllMatchRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "getallmatchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGameMatchGetAllMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/setmatchopenstate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.setMatchIdOpenState.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGameMatchSetMatchOpenStateResponse> ExecuteWxaBusinessGameMatchSetMatchOpenStateAsync(this WechatApiClient client, Models.WxaBusinessGameMatchSetMatchOpenStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "setmatchopenstate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGameMatchSetMatchOpenStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/updatematchrule 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.updateMatchRule.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGameMatchUpdateMatchRuleResponse> ExecuteWxaBusinessGameMatchUpdateMatchRuleAsync(this WechatApiClient client, Models.WxaBusinessGameMatchUpdateMatchRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "updatematchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGameMatchUpdateMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region LiveBroadcast
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/applyliveinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/live-player/applyLivelnfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessApplyLiveInfoResponse> ExecuteWxaBusinessApplyLiveInfoAsync(this WechatApiClient client, Models.WxaBusinessApplyLiveInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "applyliveinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessApplyLiveInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getliveinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetLiveInfoResponse> ExecuteWxaBusinessGetLiveInfoAsync(this WechatApiClient client, Models.WxaBusinessGetLiveInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "getliveinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGetLiveInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getliveinfo?action=get_replay 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetLiveReplayResponse> ExecuteWxaBusinessGetLiveReplayAsync(this WechatApiClient client, Models.WxaBusinessGetLiveReplayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "get_replay";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "getliveinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGetLiveReplayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/get_wxa_followers 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/subscribe-api.html#_1-%E8%8E%B7%E5%8F%96%E9%95%BF%E6%9C%9F%E8%AE%A2%E9%98%85%E7%94%A8%E6%88%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetWxaFollowersResponse> ExecuteWxaBusinessGetWxaFollowersAsync(this WechatApiClient client, Models.WxaBusinessGetWxaFollowersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "get_wxa_followers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGetWxaFollowersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Runtime
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/runtime/adddevice 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Miniprogram_Frame/deviceId.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessRuntimeAddDeviceResponse> ExecuteWxaBusinessRuntimeAddDeviceAsync(this WechatApiClient client, Models.WxaBusinessRuntimeAddDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "runtime", "adddevice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessRuntimeAddDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Internet
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getuserencryptkey 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/internet/internet.getUserEncryptKey.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetUserEncryptKeyResponse> ExecuteWxaBusinessGetUserEncryptKeyAsync(this WechatApiClient client, Models.WxaBusinessGetUserEncryptKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "wxa", "business", "getuserencryptkey")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendRequestWithJsonAsync<Models.WxaBusinessGetUserEncryptKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
