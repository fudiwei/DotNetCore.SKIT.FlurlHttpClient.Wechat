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
        /// <para>异步调用 [POST] /wxa/business/checkencryptedmsg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/user-info/auth.checkEncryptedData.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/user-info/auth.checkEncryptedData.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "checkencryptedmsg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessCheckEncryptedMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getuserphonenumber 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/phonenumber/phonenumber.getPhoneNumber.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/phonenumber/phonenumber.getPhoneNumber.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getuserphonenumber")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetUserPhoneNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region B2BStore
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getretailinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/B2b_store_assistant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetRetailInfoResponse> ExecuteWxaBusinessGetRetailInfoAsync(this WechatApiClient client, Models.WxaBusinessGetRetailInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getretailinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetRetailInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/batchcreateretail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/B2b_store_assistant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessBatchCreateRetailResponse> ExecuteWxaBusinessBatchCreateRetailAsync(this WechatApiClient client, Models.WxaBusinessBatchCreateRetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "batchcreateretail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessBatchCreateRetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/retailnotifybusiness 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/B2b_store_assistant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessRetailNotifyBusinessResponse> ExecuteWxaBusinessRetailNotifyBusinessAsync(this WechatApiClient client, Models.WxaBusinessRetailNotifyBusinessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "retailnotifybusiness")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessRetailNotifyBusinessResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region B2CAuth
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/unbinduserb2cauthinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/laboruse/api_unbinduserb2cauthinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessUnbindUserB2CAuthInfoResponse> ExecuteWxaBusinessUnbindUserB2CAuthInfoAsync(this WechatApiClient client, Models.WxaBusinessUnbindUserB2CAuthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "unbinduserb2cauthinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessUnbindUserB2CAuthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region GameMatch
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/creatematchrule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.createMatchRule.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "creatematchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGameMatchCreateMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/deletematchrule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.deleteMatchRule.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "deletematchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGameMatchDeleteMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/getallmatchrule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.getAllMatchRule.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "getallmatchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGameMatchGetAllMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/setmatchopenstate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.setMatchIdOpenState.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "setmatchopenstate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGameMatchSetMatchOpenStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/gamematch/updatematchrule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/gamematch/gamematch.updateMatchRule.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "gamematch", "updatematchrule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGameMatchUpdateMatchRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Group
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/group/createid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/createIotGroupId.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGroupCreateIdResponse> ExecuteWxaBusinessGroupCreateIdAsync(this WechatApiClient client, Models.WxaBusinessGroupCreateIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "group", "createid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGroupCreateIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/group/adddevice 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/addIotGroupDevice.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGroupAddDeviceResponse> ExecuteWxaBusinessGroupAddDeviceAsync(this WechatApiClient client, Models.WxaBusinessGroupAddDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "group", "adddevice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGroupAddDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/group/removedevice 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/removeIotGroupDevice.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGroupRemoveDeviceResponse> ExecuteWxaBusinessGroupRemoveDeviceAsync(this WechatApiClient client, Models.WxaBusinessGroupRemoveDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "group", "removedevice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGroupRemoveDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/group/getinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/getIotGroupInfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGroupGetInfoResponse> ExecuteWxaBusinessGroupGetInfoAsync(this WechatApiClient client, Models.WxaBusinessGroupGetInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "group", "getinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGroupGetInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region InsuranceFreight
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/open 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightOpenResponse> ExecuteWxaBusinessInsuranceFreightOpenAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightOpenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "open")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightOpenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/query_open 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightQueryOpenResponse> ExecuteWxaBusinessInsuranceFreightQueryOpenAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightQueryOpenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "query_open")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightQueryOpenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/createorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightCreateOrderResponse> ExecuteWxaBusinessInsuranceFreightCreateOrderAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightCreateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "createorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightCreateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/claim 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightClaimResponse> ExecuteWxaBusinessInsuranceFreightClaimAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightClaimRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "claim")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightClaimResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/createchargeid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightCreateChargeIdResponse> ExecuteWxaBusinessInsuranceFreightCreateChargeIdAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightCreateChargeIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "createchargeid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightCreateChargeIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/applypay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightApplyPayResponse> ExecuteWxaBusinessInsuranceFreightApplyPayAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightApplyPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "applypay")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightApplyPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/getpayorderlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightGetPayOrderListResponse> ExecuteWxaBusinessInsuranceFreightGetPayOrderListAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightGetPayOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "getpayorderlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightGetPayOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightRefundResponse> ExecuteWxaBusinessInsuranceFreightRefundAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "refund")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/getsummary 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightGetSummaryResponse> ExecuteWxaBusinessInsuranceFreightGetSummaryAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightGetSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "getsummary")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightGetSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/getorderlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightGetOrderListResponse> ExecuteWxaBusinessInsuranceFreightGetOrderListAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightGetOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "getorderlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightGetOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/insurance_freight/update_notify_funds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/business/freight_insurance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessInsuranceFreightUpdateNotifyFundsResponse> ExecuteWxaBusinessInsuranceFreightUpdateNotifyFundsAsync(this WechatApiClient client, Models.WxaBusinessInsuranceFreightUpdateNotifyFundsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "insurance_freight", "update_notify_funds")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessInsuranceFreightUpdateNotifyFundsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Internet
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getuserencryptkey 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/internet/internet.getUserEncryptKey.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getuserencryptkey")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetUserEncryptKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region License
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/license/activedevice 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/activeLicenseDevice.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessLicenseActiveDeviceResponse> ExecuteWxaBusinessLicenseActiveDeviceAsync(this WechatApiClient client, Models.WxaBusinessLicenseActiveDeviceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "license", "activedevice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessLicenseActiveDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/license/getdeviceinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/getLicenseDeviceInfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessLicenseGetDeviceInfoResponse> ExecuteWxaBusinessLicenseGetDeviceInfoAsync(this WechatApiClient client, Models.WxaBusinessLicenseGetDeviceInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "license", "getdeviceinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessLicenseGetDeviceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/license/getpkglist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/hardware-device/getLicensePkgList.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessLicenseGetPackageListResponse> ExecuteWxaBusinessLicenseGetPackageListAsync(this WechatApiClient client, Models.WxaBusinessLicenseGetPackageListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "license", "getpkglist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessLicenseGetPackageListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region LiveBroadcast
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/applyliveinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/live-player/applyLivelnfo.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "applyliveinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessApplyLiveInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getliveinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#2 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getliveinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetLiveInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getliveinfo?action=get_replay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/studio-api.html#3 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getliveinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetLiveReplayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/get_wxa_followers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/framework/liveplayer/subscribe-api.html#_1-%E8%8E%B7%E5%8F%96%E9%95%BF%E6%9C%9F%E8%AE%A2%E9%98%85%E7%94%A8%E6%88%B7 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "get_wxa_followers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetWxaFollowersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/push_message 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/livebroadcast/subscribe-management/pushMessage.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessPushMessageResponse> ExecuteWxaBusinessPushMessageAsync(this WechatApiClient client, Models.WxaBusinessPushMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "push_message")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessPushMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Midas
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/getpayfororder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/midas-payment/business.getPayForOrder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessGetPayForOrderResponse> ExecuteWxaBusinessGetPayForOrderAsync(this WechatApiClient client, Models.WxaBusinessGetPayForOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "getpayfororder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessGetPayForOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region NovelReader
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/novelreader/setpreviewsetting 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/novel-api.html#%E9%A2%84%E8%A7%88%E8%AE%BE%E7%BD%AE%E4%BF%AE%E6%94%B9 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessNovelReaderSetPreviewSettingsResponse> ExecuteWxaBusinessNovelReaderSetPreviewSettingsAsync(this WechatApiClient client, Models.WxaBusinessNovelReaderSetPreviewSettingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "novelreader", "setpreviewsetting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessNovelReaderSetPreviewSettingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/novelreader/getpreviewsetting 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/novel-api.html#%E9%A2%84%E8%A7%88%E8%AE%BE%E7%BD%AE%E8%8E%B7%E5%8F%96 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessNovelReaderGetPreviewSettingsResponse> ExecuteWxaBusinessNovelReaderGetPreviewSettingsAsync(this WechatApiClient client, Models.WxaBusinessNovelReaderGetPreviewSettingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "novelreader", "getpreviewsetting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessNovelReaderGetPreviewSettingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/novelreader/setrecmdnovel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/novel-api.html#%E8%AF%BB%E5%90%8E%E6%8E%A8%E8%8D%90 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessNovelReaderSetRecommendNovelResponse> ExecuteWxaBusinessNovelReaderSetRecommendNovelAsync(this WechatApiClient client, Models.WxaBusinessNovelReaderSetRecommendNovelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "novelreader", "setrecmdnovel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessNovelReaderSetRecommendNovelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Runtime
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/runtime/adddevice 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/Miniprogram_Frame/api/backend/addDevice.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "runtime", "adddevice")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessRuntimeAddDeviceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/runtime/pushappmsg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/Miniprogram_Frame/api/backend/pushAppMsg.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessRuntimePushAppMessageResponse> ExecuteWxaBusinessRuntimePushAppMessageAsync(this WechatApiClient client, Models.WxaBusinessRuntimePushAppMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "runtime", "pushappmsg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessRuntimePushAppMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
