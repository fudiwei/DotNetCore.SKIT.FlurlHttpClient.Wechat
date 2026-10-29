namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /industry-coupon/tokens 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012553563 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012715654 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateIndustryCouponTokenResponse> ExecuteCreateIndustryCouponTokenAsync(this WechatTenpayClient client, Models.CreateIndustryCouponTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "industry-coupon", "tokens");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateIndustryCouponTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
