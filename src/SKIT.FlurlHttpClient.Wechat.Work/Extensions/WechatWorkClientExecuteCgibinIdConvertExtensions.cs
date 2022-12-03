using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinIdConvertExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/unionid_to_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95926 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertUnionIdToExternalUserIdResponse> ExecuteCgibinIdConvertUnionIdToExternalUserIdAsync(this WechatWorkClient client, Models.CgibinIdConvertUnionIdToExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "unionid_to_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinIdConvertUnionIdToExternalUserIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/batch/external_userid_to_pending_id 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95926 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95900 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertBatchExternalUserIdToPendingIdResponse> ExecuteCgibinIdConvertBatchExternalUserIdToPendingIdAsync(this WechatWorkClient client, Models.CgibinIdConvertBatchExternalUserIdToPendingIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "batch", "external_userid_to_pending_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinIdConvertBatchExternalUserIdToPendingIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/external_tagid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95926 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96169 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertExternalTagIdResponse> ExecuteCgibinIdConvertExternalTagIdAsync(this WechatWorkClient client, Models.CgibinIdConvertExternalTagIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "external_tagid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinIdConvertExternalTagIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/idconvert/open_kfid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97064 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96169 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinIdConvertOpenKfIdResponse> ExecuteCgibinIdConvertOpenKfIdAsync(this WechatWorkClient client, Models.CgibinIdConvertOpenKfIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "idconvert", "open_kfid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinIdConvertOpenKfIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
