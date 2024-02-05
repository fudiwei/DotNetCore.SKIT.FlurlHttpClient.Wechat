using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingMemberCardOpenExtensions
    {
        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingMemberCardOpenCardResponse> ExecuteCreateMarketingMemberCardOpenCardAsync(this WechatTenpayClient client, Models.CreateMarketingMemberCardOpenCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/upgrade 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_6.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpgradeMarketingMemberCardOpenCardResponse> ExecuteUpgradeMarketingMemberCardOpenCardAsync(this WechatTenpayClient client, Models.UpgradeMarketingMemberCardOpenCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "upgrade");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpgradeMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingMemberCardOpenCardsResponse> ExecuteQueryMarketingMemberCardOpenCardsAsync(this WechatTenpayClient client, Models.QueryMarketingMemberCardOpenCardsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "cards")
                .SetQueryParam("appid", request.AppId);

            if (request.BrandId is not null)
                flurlReq.SetQueryParam("brand_id", request.BrandId);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingMemberCardOpenCardsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/cards/{card_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingMemberCardOpenCardByCardIdResponse> ExecuteGetMarketingMemberCardOpenCardByCardIdAsync(this WechatTenpayClient client, Models.GetMarketingMemberCardOpenCardByCardIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "cards", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingMemberCardOpenCardByCardIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/membercard-open/cards/{card_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingMemberCardOpenCardResponse> ExecuteUpdateMarketingMemberCardOpenCardAsync(this WechatTenpayClient client, Models.UpdateMarketingMemberCardOpenCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "membercard-open", "cards", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /marketing/membercard-open/cards/{card_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_11.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMarketingMemberCardOpenCardResponse> ExecuteDeleteMarketingMemberCardOpenCardAsync(this WechatTenpayClient client, Models.DeleteMarketingMemberCardOpenCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "marketing", "membercard-open", "cards", request.CardId);

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Code
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/codes/deposit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_7.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DepositMarketingMemberCardOpenCardCodesResponse> ExecuteDepositMarketingMemberCardOpenCardCodesAsync(this WechatTenpayClient client, Models.DepositMarketingMemberCardOpenCardCodesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "codes", "deposit");

            return await client.SendFlurlRequestAsJsonAsync<Models.DepositMarketingMemberCardOpenCardCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/users/import 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_13.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImportMarketingMemberCardOpenCardUserResponse> ExecuteImportMarketingMemberCardOpenCardUserAsync(this WechatTenpayClient client, Models.ImportMarketingMemberCardOpenCardUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "users", "import");

            return await client.SendFlurlRequestAsJsonAsync<Models.ImportMarketingMemberCardOpenCardUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/phone-membercard/import 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_14.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ImportMarketingMemberCardOpenCardPhoneResponse> ExecuteImportMarketingMemberCardOpenCardPhoneAsync(this WechatTenpayClient client, Models.ImportMarketingMemberCardOpenCardPhoneRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "phone-membercard", "import");

            return await client.SendFlurlRequestAsJsonAsync<Models.ImportMarketingMemberCardOpenCardPhoneResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/unavailable 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_12.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetMarketingMemberCardOpenCardCodeUnavailableResponse> ExecuteSetMarketingMemberCardOpenCardCodeUnavailableAsync(this WechatTenpayClient client, Models.SetMarketingMemberCardOpenCardCodeUnavailableRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code, "unavailable");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetMarketingMemberCardOpenCardCodeUnavailableResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/cards/{card_id}/codes/{code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingMemberCardOpenCardCodeByCardIdAndCodeResponse> ExecuteGetMarketingMemberCardOpenCardCodeByCardIdAndCodeAsync(this WechatTenpayClient client, Models.GetMarketingMemberCardOpenCardCodeByCardIdAndCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingMemberCardOpenCardCodeByCardIdAndCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/user/cards 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_5.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingMemberCardOpenUserCardsResponse> ExecuteQueryMarketingMemberCardOpenUserCardsAsync(this WechatTenpayClient client, Models.QueryMarketingMemberCardOpenUserCardsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "user", "cards")
                .SetQueryParam("openid", request.OpenId);

            if (request.AppId is not null)
                flurlReq.SetQueryParam("appid", request.AppId);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingMemberCardOpenUserCardsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/membercard-open/cards/{card_id}/codes/{code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_8.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingMemberCardOpenCardCodeResponse> ExecuteUpdateMarketingMemberCardOpenCardCodeAsync(this WechatTenpayClient client, Models.UpdateMarketingMemberCardOpenCardCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingMemberCardOpenCardCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Callback
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/callback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter6_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingMemberCardOpenCallbackResponse> ExecuteUpdateMarketingMemberCardOpenCallbackAsync(this WechatTenpayClient client, Models.UpdateMarketingMemberCardOpenCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "callback");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingMemberCardOpenCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/callback 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter6_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingMemberCardOpenCallbackResponse> ExecuteGetMarketingMemberCardOpenCallbackAsync(this WechatTenpayClient client, Models.GetMarketingMemberCardOpenCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "callback");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingMemberCardOpenCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Activation
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter4_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingMemberCardOpenCardQrcodeResponse> ExecuteCreateMarketingMemberCardOpenCardQrcodeAsync(this WechatTenpayClient client, Models.CreateMarketingMemberCardOpenCardQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "qrcode");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingMemberCardOpenCardQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/permission-tokens 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter4_7.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingMemberCardOpenCardPermissionTokenResponse> ExecuteCreateMarketingMemberCardOpenCardPermissionTokenAsync(this WechatTenpayClient client, Models.CreateMarketingMemberCardOpenCardPermissionTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "permission-tokens");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingMemberCardOpenCardPermissionTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/cards/{card_id}/decrypt-code 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter4_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DecryptMarketingMemberCardOpenCardCodeResponse> ExecuteDecryptMarketingMemberCardOpenCardCodeAsync(this WechatTenpayClient client, Models.DecryptMarketingMemberCardOpenCardCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "cards", request.CardId, "decrypt-code")
                .SetQueryParam("card_id", request.CardId)
                .SetQueryParam("encrypt_code", request.EncryptedCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.DecryptMarketingMemberCardOpenCardCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/activate-informations/{activate_ticket} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter4_5.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingMemberCardOpenActivateInformationResponse> ExecuteGetMarketingMemberCardOpenActivateInformationAsync(this WechatTenpayClient client, Models.GetMarketingMemberCardOpenActivateInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-open", "activate-informations", request.ActivateTicket);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingMemberCardOpenActivateInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/activate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_10.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ActivateMarketingMemberCardOpenCardCodeResponse> ExecuteActivateMarketingMemberCardOpenCardCodeAsync(this WechatTenpayClient client, Models.ActivateMarketingMemberCardOpenCardCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code, "activate");

            return await client.SendFlurlRequestAsJsonAsync<Models.ActivateMarketingMemberCardOpenCardCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Activation
        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/membercard-open/cards/{card_id}/rights 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter5_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingMemberCardOpenCardRightsResponse> ExecuteUpdateMarketingMemberCardOpenCardRightsAsync(this WechatTenpayClient client, Models.UpdateMarketingMemberCardOpenCardRightsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "membercard-open", "cards", request.CardId, "rights");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingMemberCardOpenCardRightsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/membercard-open/cards/{card_id}/codes/{code}/rights 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter5_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingMemberCardOpenCardCodeRightsResponse> ExecuteUpdateMarketingMemberCardOpenCardCodeRightsAsync(this WechatTenpayClient client, Models.UpdateMarketingMemberCardOpenCardCodeRightsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code, "rights");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingMemberCardOpenCardCodeRightsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/bonus/prepare 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter10_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PrepareMarketingMemberCardOpenCardCodeBonusResponse> ExecutePrepareMarketingMemberCardOpenCardCodeBonusAsync(this WechatTenpayClient client, Models.PrepareMarketingMemberCardOpenCardCodeBonusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code, "bonus", "prepare");

            return await client.SendFlurlRequestAsJsonAsync<Models.PrepareMarketingMemberCardOpenCardCodeBonusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/bonus/commit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter10_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CommitMarketingMemberCardOpenCardCodeBonusResponse> ExecuteCommitMarketingMemberCardOpenCardCodeBonusAsync(this WechatTenpayClient client, Models.CommitMarketingMemberCardOpenCardCodeBonusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "codes", request.Code, "bonus", "commit");

            return await client.SendFlurlRequestAsJsonAsync<Models.CommitMarketingMemberCardOpenCardCodeBonusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
