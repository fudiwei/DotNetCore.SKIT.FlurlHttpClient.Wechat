using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinSyncExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/sync/contact_sync_success 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90584 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90808 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSyncContactSyncSuccessResponse> ExecuteCgibinSyncContactSyncSuccessAsync(this WechatWorkClient client, Models.CgibinSyncContactSyncSuccessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "sync", "contact_sync_success")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSyncContactSyncSuccessResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
