namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /express/users/{openid}/transform 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012069852 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TransformExpressUserOpenIdResponse> ExecuteTransformExpressUserOpenIdAsync(this WechatTenpayClient client, Models.TransformExpressUserOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OpenId, "openid");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "express", "users", request.OpenId!, "transform");

            return await client.SendFlurlRequestAsJsonAsync<Models.TransformExpressUserOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
