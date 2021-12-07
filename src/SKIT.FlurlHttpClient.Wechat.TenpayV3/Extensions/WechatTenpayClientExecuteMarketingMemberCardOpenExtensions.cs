using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供会员卡开放相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMarketingMemberCardOpenExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards");

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/upgrade 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_6.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "upgrade");

            return await client.SendRequestWithJsonAsync<Models.UpgradeMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-open/cards/{card_id}/codes/deposit 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_7.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "membercard-open", "cards", request.CardId, "codes", "deposit");

            return await client.SendRequestWithJsonAsync<Models.DepositMarketingMemberCardOpenCardCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/cards 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "membercard-open", "cards")
                .SetQueryParam("appid", request.AppId);

            if (request.BrandId != null)
                flurlReq.SetQueryParam("brand_id", request.BrandId);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingMemberCardOpenCardsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-open/cards/{card_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "membercard-open", "cards", request.CardId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingMemberCardOpenCardByCardIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/membercard-open/cards/{card_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_2.shtml </para>
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
                .CreateRequest(request, new HttpMethod("PATCH"), "marketing", "membercard-open", "cards", request.CardId);

            return await client.SendRequestWithJsonAsync<Models.UpdateMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [DELETE] /marketing/membercard-open/cards/{card_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter3_11.shtml </para>
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
                .CreateRequest(request, HttpMethod.Delete, "marketing", "membercard-open", "cards", request.CardId);

            return await client.SendRequestWithJsonAsync<Models.DeleteMarketingMemberCardOpenCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
