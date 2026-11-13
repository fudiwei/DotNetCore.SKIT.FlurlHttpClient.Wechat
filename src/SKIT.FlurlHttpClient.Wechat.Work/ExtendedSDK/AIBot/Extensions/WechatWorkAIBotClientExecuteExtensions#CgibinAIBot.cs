namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    public static partial class WechatWorkAIBotClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/aibot/get_token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101910 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAIBotGetTokenResponse> ExecuteCgibinAIBotGetTokenAsync(this WechatWorkAIBotClient client, Models.CgibinAIBotGetTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.BotId is null)
            {
                request.BotId = client.Credentials.BotId;
            }

            if (request.Timestamp is null)
            {
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();
            }

            if (request.Nonce is null)
            {
                request.Nonce = Guid.NewGuid().ToString("N");
            }

            if (request.Signature is null)
            {
                string stringToSign = $"{client.Credentials.BotSecret}{request.BotId}{request.Timestamp}{request.Nonce}";
                request.Signature = Utilities.SHA256Utility.Hash(stringToSign).Value!.ToLower();
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "aibot", "get_token");

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAIBotGetTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
