using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinAdvancedFeatureExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_feature/set_approval_detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99880 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedFeatureSetApprovalDetailResponse> ExecuteCgibinAdvancedFeatureSetApprovalDetailAsync(this WechatWorkClient client, Models.CgibinAdvancedFeatureSetApprovalDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_feature", "set_approval_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedFeatureSetApprovalDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_feature/get_apply_id_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99883 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedFeatureGetApplyIdListResponse> ExecuteCgibinAdvancedFeatureGetApplyIdListAsync(this WechatWorkClient client, Models.CgibinAdvancedFeatureGetApplyIdListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_feature", "get_apply_id_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedFeatureGetApplyIdListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/advanced_feature/get_approval_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99885 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAdvancedFeatureGetApprovalInfoResponse> ExecuteCgibinAdvancedFeatureGetApprovalInfoAsync(this WechatWorkClient client, Models.CgibinAdvancedFeatureGetApprovalInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "advanced_feature", "get_approval_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAdvancedFeatureGetApprovalInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
