namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/customservice/getkflist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_getkflist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_getkflist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_getkflist.html ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCustomServiceGetKfListResponse> ExecuteCgibinCustomServiceGetKfListAsync(this WechatApiClient client, Models.CgibinCustomServiceGetKfListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "customservice", "getkflist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCustomServiceGetKfListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/customservice/getonlinekflist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/customer/servicermanage/api_getonlinekflist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/customer/servicermanage/api_getonlinekflist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/kf-mgnt/kf-message/api_getonlinekflist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCustomServiceGetOnlineKfListResponse> ExecuteCgibinCustomServiceGetOnlineKfListAsync(this WechatApiClient client, Models.CgibinCustomServiceGetOnlineKfListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "customservice", "getonlinekflist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCustomServiceGetOnlineKfListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
