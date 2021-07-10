using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinLivingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/create 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93637 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93717 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingCreateResponse> ExecuteCgibinLivingCreateAsync(this WechatWorkClient client, Models.CgibinLivingCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/modify 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93640 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93720 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingModifyResponse> ExecuteCgibinLivingModifyAsync(this WechatWorkClient client, Models.CgibinLivingModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "modify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/cancel 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93638 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93718 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingCancelResponse> ExecuteCgibinLivingCancelAsync(this WechatWorkClient client, Models.CgibinLivingCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/delete_replay_data 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93874 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93719 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93743 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93860 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingDeleteReplayDataResponse> ExecuteCgibinLivingDeleteReplayDataAsync(this WechatWorkClient client, Models.CgibinLivingDeleteReplayDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "delete_replay_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingDeleteReplayDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/living/get_living_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93635 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93715 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingGetLivingInfoResponse> ExecuteCgibinLivingGetLivingInfoAsync(this WechatWorkClient client, Models.CgibinLivingGetLivingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "living", "get_living_info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("livingid", request.LivingId);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingGetLivingInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/get_living_code 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93641 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93721 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingGetLivingCodeResponse> ExecuteCgibinLivingGetLivingCodeAsync(this WechatWorkClient client, Models.CgibinLivingGetLivingCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "get_living_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingGetLivingCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/get_living_share_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94442 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94578 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingGetLivingShareInfoResponse> ExecuteCgibinLivingGetLivingShareInfoAsync(this WechatWorkClient client, Models.CgibinLivingGetLivingShareInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "get_living_share_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingGetLivingShareInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/get_user_all_livingid 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93634 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93714 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93739 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93856 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingGetUserAllLivingIdResponse> ExecuteCgibinLivingGetUserAllLivingIdAsync(this WechatWorkClient client, Models.CgibinLivingGetUserAllLivingIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "get_user_all_livingid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingGetUserAllLivingIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/living/get_watch_stat 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93636 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93716 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLivingGetWatchStatisticsResponse> ExecuteCgibinLivingGetWatchStatisticsAsync(this WechatWorkClient client, Models.CgibinLivingGetWatchStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "living", "get_watch_stat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLivingGetWatchStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
