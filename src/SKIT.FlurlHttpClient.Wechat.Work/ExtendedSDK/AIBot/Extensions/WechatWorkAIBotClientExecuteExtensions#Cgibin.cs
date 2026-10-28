namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    public static partial class WechatWorkAIBotClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/aibot/response 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101138 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAIBotResponseResponse> ExecuteCgibinAIBotResponseAsync(this WechatWorkAIBotClient client, Models.CgibinAIBotResponseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyUrl(request.ResponseUrl);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "aibot", "response")
                .WithUrl(request.ResponseUrl!);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAIBotResponseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
