using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMiniProgramExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/miniprogram/transfer_session 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93403 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMiniProgramTransferSessionResponse> ExecuteCgibinMiniProgramTransferSessionAsync(this WechatWorkClient client, Models.CgibinMiniProgramTransferSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "miniprogram", "transfer_session")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMiniProgramTransferSessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/miniprogram/jscode2session 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91507 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMiniProgramJsCode2SessionResponse> ExecuteCgibinMiniProgramJsCode2SessionAsync(this WechatWorkClient client, Models.CgibinMiniProgramJsCode2SessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "miniprogram", "jscode2session")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("js_code", request.JsCode)
                .SetQueryParam("grant_type", request.GrantType);

            return await client.SendRequestWithJsonAsync<Models.CgibinMiniProgramJsCode2SessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
