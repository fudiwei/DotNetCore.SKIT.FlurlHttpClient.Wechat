using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteIntpRealNameExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /intp/realname/getauthurl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Non_tax_pay/API_document.html#9.2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IntpRealNameGetAuthUrlResponse> ExecuteIntpRealNameGetAuthUrlAsync(this WechatApiClient client, Models.IntpRealNameGetAuthUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "intp", "realname", "getauthurl")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IntpRealNameGetAuthUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /intp/realname/checkrealnameinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/cityservice/cityservice-checkrealnameinfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.IntpRealNameCheckRealNameInfoResponse> ExecuteIntpRealNameCheckRealNameInfoAsync(this WechatApiClient client, Models.IntpRealNameCheckRealNameInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "intp", "realname", "checkrealnameinfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.IntpRealNameCheckRealNameInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
