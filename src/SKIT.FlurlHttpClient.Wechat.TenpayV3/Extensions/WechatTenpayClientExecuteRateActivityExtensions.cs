using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteRateActivityExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /rate-activity/applications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_7_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRateActivityApplicationResponse> ExecuteCreateRateActivityApplicationAsync(this WechatTenpayClient client, Models.CreateRateActivityApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "rate-activity", "applications");

            return await client.SendRequestWithJsonAsync<Models.CreateRateActivityApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rate-activity/applications/id/{application_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_7_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRateActivityApplicationByApplicationIdResponse> ExecuteGetRateActivityApplicationByApplicationIdAsync(this WechatTenpayClient client, Models.GetRateActivityApplicationByApplicationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "rate-activity", "applications", "id", request.ApplicationId);

            return await client.SendRequestWithJsonAsync<Models.GetRateActivityApplicationByApplicationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /rate-activity/applications/id/{application_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_7_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateRateActivityApplicationResponse> ExecuteUpdateRateActivityApplicationAsync(this WechatTenpayClient client, Models.UpdateRateActivityApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, new HttpMethod("PATCH"), "rate-activity", "applications", "id", request.ApplicationId);

            return await client.SendRequestWithJsonAsync<Models.UpdateRateActivityApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
