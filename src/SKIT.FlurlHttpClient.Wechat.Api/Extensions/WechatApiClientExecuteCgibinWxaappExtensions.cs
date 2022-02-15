using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinWxaappExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxaapp/createwxaqrcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.createQRCode.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/qr-code/wxacode.createQRCode.html </para>
        /// <para>REF: https://api.weixin.qq.com/cgi-bin/wxaapp/createwxaqrcode?access_token=ACCESS_TOKEN </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxaappCreateWxaQrcodeResponse> ExecuteCgibinWxaappCreateWxaQrcodeAsync(this WechatApiClient client, Models.CgibinWxaappCreateWxaQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wxaapp", "createwxaqrcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWxaappCreateWxaQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
