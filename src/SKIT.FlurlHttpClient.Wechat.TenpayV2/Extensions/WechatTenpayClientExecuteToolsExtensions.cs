using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteToolsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /tools/authcodetoopenid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011940944 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941724 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ToolsAuthCodeToOpenIdResponse> ExecuteToolsAuthCodeToOpenIdAsync(this WechatTenpayClient client, Models.ToolsAuthCodeToOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tools", "authcodetoopenid");

            return await client.SendFlurlRequestAsXmlAsync<Models.ToolsAuthCodeToOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tools/shorturl 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937195 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989264 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634974 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ToolsShortUrlResponse> ExecuteToolsShortUrlAsync(this WechatTenpayClient client, Models.ToolsShortUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "tools", "shorturl");

            return await client.SendFlurlRequestAsXmlAsync<Models.ToolsShortUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
