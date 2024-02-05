using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteWxaDramaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /wxadrama/setplayerdramarecmdswitch 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/videoplayer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDramaSetPlayerDramaRecommendSwitchResponse> ExecuteWxaDramaSetPlayerDramaRecommendSwitchAsync(this WechatApiClient client, Models.WxaDramaSetPlayerDramaRecommendSwitchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxadrama", "setplayerdramarecmdswitch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDramaSetPlayerDramaRecommendSwitchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
