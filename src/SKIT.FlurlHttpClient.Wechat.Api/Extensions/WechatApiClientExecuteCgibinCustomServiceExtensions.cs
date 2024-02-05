using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinCustomServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/customservice/getkflist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Service_Center_messages.html#5 ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#0 ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E8%8E%B7%E5%8F%96%E5%AE%A2%E6%9C%8D%E5%9F%BA%E6%9C%AC%E4%BF%A1%E6%81%AF ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCustomServiceGetKfListResponse> ExecuteCgibinCustomServiceGetKfListAsync(this WechatApiClient client, Models.CgibinCustomServiceGetKfListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "customservice", "getkflist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCustomServiceGetKfListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/customservice/getonlinekflist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#0 ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E8%8E%B7%E5%8F%96%E5%9C%A8%E7%BA%BF%E5%AE%A2%E6%9C%8D%E5%88%97%E8%A1%A8 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCustomServiceGetOnlineKfListResponse> ExecuteCgibinCustomServiceGetOnlineKfListAsync(this WechatApiClient client, Models.CgibinCustomServiceGetOnlineKfListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "customservice", "getonlinekflist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCustomServiceGetOnlineKfListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
