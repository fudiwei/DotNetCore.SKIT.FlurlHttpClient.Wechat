using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteDiscountCardExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /discount-card/cards 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PrepareDiscountCardResponse> ExecutePrepareDiscountCardAsync(this WechatTenpayClient client, Models.PrepareDiscountCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "discount-card", "cards")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.PrepareDiscountCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /discount-card/cards/{out_card_code}/add-user-records 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddDiscountCardUserRecordResponse> ExecuteAddDiscountCardUserRecordAsync(this WechatTenpayClient client, Models.AddDiscountCardUserRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "discount-card", "cards", request.OutCardCode, "add-user-records")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.AddDiscountCardUserRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /discount-card/cards/{out_card_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetDiscountCardByOutCardCodeResponse> ExecuteGetDiscountCardByOutCardCodeAsync(this WechatTenpayClient client, Models.GetDiscountCardByOutCardCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "discount-card", "cards", request.OutCardCode)
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.GetDiscountCardByOutCardCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
