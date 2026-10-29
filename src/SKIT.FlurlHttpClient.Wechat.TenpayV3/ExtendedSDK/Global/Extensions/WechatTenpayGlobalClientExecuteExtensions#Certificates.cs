namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static partial class WechatTenpayGlobalClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /certificates 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356462 ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCertificatesResponse> ExecuteQueryCertificatesAsync(this WechatTenpayGlobalClient client, Models.QueryCertificatesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client.ProxyClient
                .CreateFlurlRequest(request, HttpMethod.Get, "certificates");

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryCertificatesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
