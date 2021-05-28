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
    public static class WechatApiClientExecuteCgibinGuideExtensions
    {
        #region Account
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguideacct 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.addGuideAcct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuideAccountResponse> ExecuteCgibinGuideAddGuideAccountAsync(this WechatApiClient client, Models.CgibinGuideAddGuideAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguideacct")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuideAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/guide/getguideacct 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGuideAcct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideAccountResponse> ExecuteCgibinGuideGetGuideAccountAsync(this WechatApiClient client, Models.CgibinGuideGetGuideAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "guide", "getguideacct")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.GuideAccount))
                flurlReq.SetQueryParam("guide_account", request.GuideAccount);
            else if (!string.IsNullOrEmpty(request.GuideOpenId))
                flurlReq.SetQueryParam("guide_openid", request.GuideOpenId);

            return await client.SendRequestAsync<Models.CgibinGuideGetGuideAccountResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/updateguideacct 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.updateGuideAcct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideUpdateGuideAccountResponse> ExecuteCgibinGuideUpdateGuideAccountAsync(this WechatApiClient client, Models.CgibinGuideUpdateGuideAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "updateguideacct")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideUpdateGuideAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguideacct 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.delGuideAcct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideAccountResponse> ExecuteCgibinGuideDeleteGuideAccountAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguideacct")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Qrcode
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/guidecreateqrcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.guideCreateQrCode.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideCreateQrcodeResponse> ExecuteCgibinGuideCreateQrcodeAsync(this WechatApiClient client, Models.CgibinGuideCreateQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "guidecreateqrcode")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideCreateQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Config
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/setguideconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.setGuideConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideSetGuideConfigResponse> ExecuteCgibinGuideSetGuideConfigAsync(this WechatApiClient client, Models.CgibinGuideSetGuideConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "setguideconfig")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideSetGuideConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguideconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGuideConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideConfigResponse> ExecuteCgibinGuideGetGuideConfigAsync(this WechatApiClient client, Models.CgibinGuideGetGuideConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguideconfig")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/setguideacctconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.setGuideAcctConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideSetGuideAccountConfigResponse> ExecuteCgibinGuideSetGuideAccountConfigAsync(this WechatApiClient client, Models.CgibinGuideSetGuideAccountConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "setguideacctconfig")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideSetGuideAccountConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguideacctconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGuideAcctConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideAccountConfigResponse> ExecuteCgibinGuideGetGuideAccountConfigAsync(this WechatApiClient client, Models.CgibinGuideGetGuideAccountConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguideacctconfig")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideAccountConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Group
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/newguidegroup 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.newGuideGroup.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideNewGuideGroupResponse> ExecuteCgibinGuideNewGuideGroupAsync(this WechatApiClient client, Models.CgibinGuideNewGuideGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "newguidegroup")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideNewGuideGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidegrouplist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGuideGroupList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideGroupListResponse> ExecuteCgibinGuideGetGuideGroupListAsync(this WechatApiClient client, Models.CgibinGuideGetGuideGroupListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidegrouplist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideGroupListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getgroupinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGroupInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGroupInfoResponse> ExecuteCgibinGuideGetGroupInfoAsync(this WechatApiClient client, Models.CgibinGuideGetGroupInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getgroupinfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGroupInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguide2guidegroup 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.addGuide2GuideGroup.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuide2GuideGroupResponse> ExecuteCgibinGuideAddGuide2GuideGroupAsync(this WechatApiClient client, Models.CgibinGuideAddGuide2GuideGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguide2guidegroup")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuide2GuideGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguide2guidegroup 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.delGuide2GuideGroup.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuide2GuideGroupResponse> ExecuteCgibinGuideDeleteGuide2GuideGroupAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuide2GuideGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguide2guidegroup")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuide2GuideGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getgroupbyguide 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGroupByGuide.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGroupByGuideResponse> ExecuteCgibinGuideGetGroupByGuideAsync(this WechatApiClient client, Models.CgibinGuideGetGroupByGuideRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getgroupbyguide")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGroupByGuideResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguidegroup 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.delGuideGroup.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideGroupResponse> ExecuteCgibinGuideDeleteGuideGroupAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguidegroup")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region BuyerRelation
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguidebuyerrelation 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.addGuideBuyerRelation.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuideBuyerRelationResponse> ExecuteCgibinGuideAddGuideBuyerRelationAsync(this WechatApiClient client, Models.CgibinGuideAddGuideBuyerRelationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguidebuyerrelation")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuideBuyerRelationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguidebuyerrelation 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.delGuideBuyerRelation.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideBuyerRelationResponse> ExecuteCgibinGuideDeleteGuideBuyerRelationAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideBuyerRelationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguidebuyerrelation")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideBuyerRelationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidebuyerrelationlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.getGuideBuyerRelationList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideBuyerRelationListResponse> ExecuteCgibinGuideGetGuideBuyerRelationListAsync(this WechatApiClient client, Models.CgibinGuideGetGuideBuyerRelationListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidebuyerrelationlist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideBuyerRelationListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/rebindguideacctforbuyer 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.rebindGuideAcctForBuyer.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideRebindGuideAccountForBuyerResponse> ExecuteCgibinGuideRebindGuideAccountForBuyerAsync(this WechatApiClient client, Models.CgibinGuideRebindGuideAccountForBuyerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "rebindguideacctforbuyer")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideRebindGuideAccountForBuyerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/updateguidebuyerrelation 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.updateGuideBuyerRelation.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideUpdateGuideBuyerRelationResponse> ExecuteCgibinGuideUpdateGuideBuyerRelationAsync(this WechatApiClient client, Models.CgibinGuideUpdateGuideBuyerRelationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "updateguidebuyerrelation")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideUpdateGuideBuyerRelationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidebuyerrelationbybuyer 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.getGuideBuyerRelationByBuyer.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideBuyerRelationByBuyerResponse> ExecuteCgibinGuideGetGuideBuyerRelationByBuyerAsync(this WechatApiClient client, Models.CgibinGuideGetGuideBuyerRelationByBuyerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidebuyerrelationbybuyer")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideBuyerRelationByBuyerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidebuyerrelation 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/buyer-account/shopping-guide.getGuideBuyerRelation.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideBuyerRelationResponse> ExecuteCgibinGuideGetGuideBuyerRelationAsync(this WechatApiClient client, Models.CgibinGuideGetGuideBuyerRelationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidebuyerrelation")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideBuyerRelationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region BuyerChatRecord
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidebuyerchatrecord 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.getGuideBuyerChatRecord.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideBuyerChatRecordResponse> ExecuteCgibinGuideGetGuideBuyerChatRecordAsync(this WechatApiClient client, Models.CgibinGuideGetGuideBuyerChatRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidebuyerchatrecord")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideBuyerChatRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Tag
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/newguidetagoption 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.newGuideTagOption.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideNewGuideTagOptionResponse> ExecuteCgibinGuideNewGuideTagOptionAsync(this WechatApiClient client, Models.CgibinGuideNewGuideTagOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "newguidetagoption")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideNewGuideTagOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguidetagoption 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.delguidetagoption.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideTagOptionResponse> ExecuteCgibinGuideDeleteGuideTagOptionAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideTagOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguidetagoption")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideTagOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguidetagoption 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.addGuideTagOption.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuideTagOptionResponse> ExecuteCgibinGuideAddGuideTagOptionAsync(this WechatApiClient client, Models.CgibinGuideAddGuideTagOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguidetagoption")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuideTagOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidetagoption 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.getGuideTagOption.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideTagOptionResponse> ExecuteCgibinGuideGetGuideTagOptionAsync(this WechatApiClient client, Models.CgibinGuideGetGuideTagOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidetagoption")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideTagOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguidebuyertag 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.addGuideBuyerTag.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuideBuyerTagResponse> ExecuteCgibinGuideAddGuideBuyerTagAsync(this WechatApiClient client, Models.CgibinGuideAddGuideBuyerTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguidebuyertag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuideBuyerTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidebuyertag 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.getGuideBuyerTag.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideBuyerTagResponse> ExecuteCgibinGuideGetGuideBuyerTagAsync(this WechatApiClient client, Models.CgibinGuideGetGuideBuyerTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidebuyertag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideBuyerTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/queryguidebuyerbytag 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.queryGuideBuyerByTag.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideQueryGuideBuyerByTagResponse> ExecuteCgibinGuideQueryGuideBuyerByTagAsync(this WechatApiClient client, Models.CgibinGuideQueryGuideBuyerByTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "queryguidebuyerbytag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideQueryGuideBuyerByTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguidebuyertag 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.delGuideBuyerTag.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideBuyerTagResponse> ExecuteCgibinGuideDeleteGuideBuyerTagAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideBuyerTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguidebuyertag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideBuyerTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguidebuyerdisplaytag 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.addGuideBuyerDisplayTag.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuideBuyerDisplayTagResponse> ExecuteCgibinGuideAddGuideBuyerDisplayTagAsync(this WechatApiClient client, Models.CgibinGuideAddGuideBuyerDisplayTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguidebuyerdisplaytag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuideBuyerDisplayTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidebuyerdisplaytag 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/tag-account/shopping-guide.getGuideBuyerDisplayTag.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideBuyerDisplayTagResponse> ExecuteCgibinGuideGetGuideBuyerDisplayTagAsync(this WechatApiClient client, Models.CgibinGuideGetGuideBuyerDisplayTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidebuyerdisplaytag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideBuyerDisplayTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Material
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/setguidecardmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.setGuideCardMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideSetGuideCardMaterialResponse> ExecuteCgibinGuideSetGuideCardMaterialAsync(this WechatApiClient client, Models.CgibinGuideSetGuideCardMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "setguidecardmaterial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideSetGuideCardMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidecardmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.getGuideCardMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideCardMaterialResponse> ExecuteCgibinGuideGetGuideCardMaterialAsync(this WechatApiClient client, Models.CgibinGuideGetGuideCardMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidecardmaterial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideCardMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguidecardmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.delGuideCardMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideCardMaterialResponse> ExecuteCgibinGuideDeleteGuideCardMaterialAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideCardMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguidecardmaterial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideCardMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/setguideimagematerial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.setGuideImageMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideSetGuideImageMaterialResponse> ExecuteCgibinGuideSetGuideImageMaterialAsync(this WechatApiClient client, Models.CgibinGuideSetGuideImageMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "setguideimagematerial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideSetGuideImageMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguideimagematerial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.getGuideImageMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideImageMaterialResponse> ExecuteCgibinGuideGetGuideImageMaterialAsync(this WechatApiClient client, Models.CgibinGuideGetGuideImageMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguideimagematerial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideImageMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguideimagematerial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.delGuideImageMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideImageMaterialResponse> ExecuteCgibinGuideDeleteGuideImageMaterialAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideImageMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguideimagematerial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideImageMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/setguidewordmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.setGuideWordMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideSetGuideWordMaterialResponse> ExecuteCgibinGuideSetGuideWordMaterialAsync(this WechatApiClient client, Models.CgibinGuideSetGuideWordMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "setguidewordmaterial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideSetGuideWordMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidewordmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.getGuideWordMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideWordMaterialResponse> ExecuteCgibinGuideGetGuideWordMaterialAsync(this WechatApiClient client, Models.CgibinGuideGetGuideWordMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidewordmaterial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideWordMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/delguidewordmaterial 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/model-account/shopping-guide.delGuideWordMaterial.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideDeleteGuideWordMaterialResponse> ExecuteCgibinGuideDeleteGuideWordMaterialAsync(this WechatApiClient client, Models.CgibinGuideDeleteGuideWordMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "delguidewordmaterial")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideDeleteGuideWordMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MassSendJob
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/addguidemassendjob 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/task-account/shopping-guide.addGuideMassendJob.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideAddGuideMassSendJobResponse> ExecuteCgibinGuideAddGuideMassSendJobAsync(this WechatApiClient client, Models.CgibinGuideAddGuideMassSendJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "addguidemassendjob")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideAddGuideMassSendJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidemassendjoblist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/task-account/shopping-guide.getGuideMassendJobList.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideMassSendJobListResponse> ExecuteCgibinGuideGetGuideMassSendJobListAsync(this WechatApiClient client, Models.CgibinGuideGetGuideMassSendJobListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidemassendjoblist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideMassSendJobListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/getguidemassendjob 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/task-account/shopping-guide.getGuideMassendJob.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideGetGuideMassSendJobResponse> ExecuteCgibinGuideGetGuideMassSendJobAsync(this WechatApiClient client, Models.CgibinGuideGetGuideMassSendJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "getguidemassendjob")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideGetGuideMassSendJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/updateguidemassendjob 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/task-account/shopping-guide.updateGuideMassendJob.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideUpdateGuideMassSendJobResponse> ExecuteCgibinGuideUpdateGuideMassSendJobAsync(this WechatApiClient client, Models.CgibinGuideUpdateGuideMassSendJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "updateguidemassendjob")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideUpdateGuideMassSendJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/guide/cancelguidemassendjob 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/task-account/shopping-guide.cancelGuideMassendJob.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGuideCancelGuideMassSendJobResponse> ExecuteCgibinGuideCancelGuideMassSendJobAsync(this WechatApiClient client, Models.CgibinGuideCancelGuideMassSendJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "guide", "cancelguidemassendjob")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinGuideCancelGuideMassSendJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
