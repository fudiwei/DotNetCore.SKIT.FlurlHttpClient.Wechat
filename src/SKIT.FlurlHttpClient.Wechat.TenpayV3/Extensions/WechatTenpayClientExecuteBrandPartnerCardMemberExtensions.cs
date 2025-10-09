using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBrandPartnerCardMemberExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/pre-auth-tokens 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336986 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandPartnerCardMemberPreauthTokenResponse> ExecuteCreateBrandPartnerCardMemberPreauthTokenAsync(this WechatTenpayClient client, Models.CreateBrandPartnerCardMemberPreauthTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "pre-auth-tokens");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandPartnerCardMemberPreauthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Cards
        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336970 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandPartnerCardMemberCardResponse> ExecuteCreateBrandPartnerCardMemberCardAsync(this WechatTenpayClient client, Models.CreateBrandPartnerCardMemberCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "cards");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandPartnerCardMemberCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/partner/card-member/cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336976 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryBrandPartnerCardMemberCardsResponse> ExecuteQueryBrandPartnerCardMemberCardsAsync(this WechatTenpayClient client, Models.QueryBrandPartnerCardMemberCardsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "partner", "card-member", "cards")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("state", request.State)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryBrandPartnerCardMemberCardsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/partner/card-member/cards/{card_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336974 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandPartnerCardMemberCardByCardIdResponse> ExecuteGetBrandPartnerCardMemberCardByCardIdAsync(this WechatTenpayClient client, Models.GetBrandPartnerCardMemberCardByCardIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "partner", "card-member", "cards", request.CardId)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandPartnerCardMemberCardByCardIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /brand/partner/card-member/cards/{card_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336977 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateBrandPartnerCardMemberCardResponse> ExecuteUpdateBrandPartnerCardMemberCardAsync(this WechatTenpayClient client, Models.UpdateBrandPartnerCardMemberCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "brand", "partner", "card-member", "cards", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateBrandPartnerCardMemberCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/cards/{card_id}/invalidate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336972 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.InvalidateBrandPartnerCardMemberCardResponse> ExecuteInvalidateBrandPartnerCardMemberCardAsync(this WechatTenpayClient client, Models.InvalidateBrandPartnerCardMemberCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "cards", request.CardId, "invalidate");

            return await client.SendFlurlRequestAsJsonAsync<Models.InvalidateBrandPartnerCardMemberCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UserCards
        /// <summary>
        /// <para>异步调用 [GET] /brand/partner/card-member/user-cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336984 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryBrandPartnerCardMemberUserCardsResponse> ExecuteQueryBrandPartnerCardMemberUserCardsAsync(this WechatTenpayClient client, Models.QueryBrandPartnerCardMemberUserCardsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "partner", "card-member", "user-cards")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("user_card_state", request.State)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryBrandPartnerCardMemberUserCardsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/partner/card-member/user-cards/{user_card_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336980 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandPartnerCardMemberUserCardByUserCardCodeResponse> ExecuteGetBrandPartnerCardMemberUserCardByUserCardCodeAsync(this WechatTenpayClient client, Models.GetBrandPartnerCardMemberUserCardByUserCardCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "partner", "card-member", "user-cards", request.UserCardCode)
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("card_id", request.CardId)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandPartnerCardMemberUserCardByUserCardCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /brand/partner/card-member/user-cards/{user_card_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336985 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateBrandPartnerCardMemberUserCardResponse> ExecuteUpdateBrandPartnerCardMemberUserCardAsync(this WechatTenpayClient client, Models.UpdateBrandPartnerCardMemberUserCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "brand", "partner", "card-member", "user-cards", request.UserCardCode)
                .SetQueryParam("card_id", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateBrandPartnerCardMemberUserCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/user-cards/{user_card_code}/invalidate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336983 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.InvalidateBrandPartnerCardMemberUserCardResponse> ExecuteInvalidateBrandPartnerCardMemberUserCardAsync(this WechatTenpayClient client, Models.InvalidateBrandPartnerCardMemberUserCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "user-cards", request.UserCardCode, "invalidate")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("card_id", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.InvalidateBrandPartnerCardMemberUserCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/user-cards/import-by-openid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336981 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImportBrandPartnerCardMemberUserCardByOpenIdResponse> ExecuteImportBrandPartnerCardMemberUserCardByOpenIdAsync(this WechatTenpayClient client, Models.ImportBrandPartnerCardMemberUserCardByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "user-cards", "import-by-openid");

            return await client.SendFlurlRequestAsJsonAsync<Models.ImportBrandPartnerCardMemberUserCardByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/user-cards/{user_card_code}/confirm 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336979 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ConfirmBrandPartnerCardMemberUserCardResponse> ExecuteConfirmBrandPartnerCardMemberUserCardAsync(this WechatTenpayClient client, Models.ConfirmBrandPartnerCardMemberUserCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "user-cards", request.UserCardCode, "confirm")
                .SetQueryParam("card_id", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ConfirmBrandPartnerCardMemberUserCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UserFeeds
        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/user-feeds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015336987 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandPartnerCardMemberUserFeedResponse> ExecuteCreateBrandPartnerCardMemberUserFeedAsync(this WechatTenpayClient client, Models.CreateBrandPartnerCardMemberUserFeedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "user-feeds");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandPartnerCardMemberUserFeedResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UserFeeds
        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/user-points/sync 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015897280 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SyncBrandPartnerCardMemberUserPointResponse> ExecuteSyncBrandPartnerCardMemberUserPointAsync(this WechatTenpayClient client, Models.SyncBrandPartnerCardMemberUserPointRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "user-points", "sync");

            return await client.SendFlurlRequestAsJsonAsync<Models.SyncBrandPartnerCardMemberUserPointResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/card-member/user-points/exchange-coupon/confirm 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015897268 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ConfirmBrandPartnerCardMemberUserPointExchangeCouponResponse> ExecuteConfirmBrandPartnerCardMemberUserPointExchangeCouponAsync(this WechatTenpayClient client, Models.ConfirmBrandPartnerCardMemberUserPointExchangeCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "card-member", "user-points", "exchange-coupon", "confirm");

            return await client.SendFlurlRequestAsJsonAsync<Models.ConfirmBrandPartnerCardMemberUserPointExchangeCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
