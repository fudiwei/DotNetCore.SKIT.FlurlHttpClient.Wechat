namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /security/echo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014551946 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015139289 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateSecurityEchoResponse> ExecuteCreateSecurityEchoAsync(this WechatTenpayClient client, Models.CreateSecurityEchoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "security", "echo");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateSecurityEchoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
