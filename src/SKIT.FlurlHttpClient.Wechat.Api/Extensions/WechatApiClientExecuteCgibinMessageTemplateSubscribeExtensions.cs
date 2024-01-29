using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinMessageTemplateSubscribeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/template/subscribe 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/One-time_subscription_info.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/One-time_subscription_info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageTemplateSubscribeResponse> ExecuteCgibinMessageTemplateSubscribeAsync(this WechatApiClient client, Models.CgibinMessageTemplateSubscribeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "message", "template", "subscribe")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMessageTemplateSubscribeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
