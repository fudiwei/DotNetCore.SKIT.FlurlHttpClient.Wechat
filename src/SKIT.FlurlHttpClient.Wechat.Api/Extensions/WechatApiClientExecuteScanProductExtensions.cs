using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteScanProductV2Extensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /scan/product/v2/add 接口。</para>
        /// <para>REF: https://mp.weixin.qq.com/cgi-bin/announce?action=getannouncement&key=11533749572M9ODP&platform=2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ScanProductAddV2Response> ExecuteScanProductAddV2Async(this WechatApiClient client, Models.ScanProductAddV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "scan", "product", "v2", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ScanProductAddV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /scan/product/v2/status 接口。</para>
        /// <para>REF: https://mp.weixin.qq.com/cgi-bin/announce?action=getannouncement&key=11533749572M9ODP&platform=2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ScanProductStatusV2Response> ExecuteScanProductStatusV2Async(this WechatApiClient client, Models.ScanProductStatusV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "scan", "product", "v2", "status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ScanProductStatusV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /scan/product/v2/getinfo 接口。</para>
        /// <para>REF: https://mp.weixin.qq.com/cgi-bin/announce?action=getannouncement&key=11533749572M9ODP&platform=2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ScanProductGetInfoV2Response> ExecuteScanProductGetInfoV2Async(this WechatApiClient client, Models.ScanProductGetInfoV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "scan", "product", "v2", "getinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ScanProductGetInfoV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /scan/product/v2/getinfobypage 接口。</para>
        /// <para>REF: https://mp.weixin.qq.com/cgi-bin/announce?action=getannouncement&key=11533749572M9ODP&platform=2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ScanProductGetInfoByPageV2Response> ExecuteScanProductGetInfoByPageV2Async(this WechatApiClient client, Models.ScanProductGetInfoByPageV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "scan", "product", "v2", "getinfobypage")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ScanProductGetInfoByPageV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
