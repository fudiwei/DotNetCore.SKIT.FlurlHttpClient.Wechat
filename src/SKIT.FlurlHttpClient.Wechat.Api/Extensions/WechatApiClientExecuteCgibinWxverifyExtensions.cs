using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinWxverifyExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wxverify/checkwxverifynickname 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Mini_Program_Basic_Info/wxverify_checknickname.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWxverifyCheckWxverifyNicknameResponse> ExecuteCgibinWxverifyCheckWxverifyNicknameAsync(this WechatApiClient client, Models.CgibinWxverifyCheckWxverifyNicknameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wxverify", "checkwxverifynickname")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWxverifyCheckWxverifyNicknameResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
