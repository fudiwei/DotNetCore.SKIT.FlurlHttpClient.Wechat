namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /redpacketcover/wxapp/cover_url/get_by_token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/red-packet-cover/api_getredpacketcoverurl.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RedPacketCoverWxAppCoverUrlGetByTokenResponse> ExecuteRedPacketCoverWxAppCoverUrlGetByTokenAsync(this WechatApiClient client, Models.RedPacketCoverWxAppCoverUrlGetByTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "redpacketcover", "wxapp", "cover_url", "get_by_token")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.RedPacketCoverWxAppCoverUrlGetByTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
