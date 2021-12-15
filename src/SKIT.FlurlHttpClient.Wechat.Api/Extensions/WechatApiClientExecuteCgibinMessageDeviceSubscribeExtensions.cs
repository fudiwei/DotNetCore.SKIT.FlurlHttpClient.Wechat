using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinMessageDeviceSubscribeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/message/device/subscribe/send 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/hardware-device/hardwareDevice.send.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMessageDeviceSubscribeSendResponse> ExecuteCgibinMessageDeviceSubscribeSendAsync(this WechatApiClient client, Models.CgibinMessageDeviceSubscribeSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "message", "device", "subscribe", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMessageDeviceSubscribeSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
