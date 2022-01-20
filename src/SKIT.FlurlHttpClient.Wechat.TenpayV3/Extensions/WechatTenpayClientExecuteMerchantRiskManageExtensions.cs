using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供商户平台处置通知相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantRiskManageExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantRiskManageViolationNotificationResponse> ExecuteCreateMerchantRiskManageViolationNotificationAsync(this WechatTenpayClient client, Models.CreateMerchantRiskManageViolationNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-risk-manage", "violation-notifications");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantRiskManageViolationNotificationResponse> ExecuteGetMerchantRiskManageViolationNotificationAsync(this WechatTenpayClient client, Models.GetMerchantRiskManageViolationNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "merchant-risk-manage", "violation-notifications");

            return await client.SendRequestWithJsonAsync<Models.GetMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMerchantRiskManageViolationNotificationResponse> ExecuteUpdateMerchantRiskManageViolationNotificationAsync(this WechatTenpayClient client, Models.UpdateMerchantRiskManageViolationNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, "merchant-risk-manage", "violation-notifications");

            return await client.SendRequestWithJsonAsync<Models.UpdateMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMerchantRiskManageViolationNotificationResponse> ExecuteDeleteMerchantRiskManageViolationNotificationAsync(this WechatTenpayClient client, Models.DeleteMerchantRiskManageViolationNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Delete, "merchant-risk-manage", "violation-notifications");

            return await client.SendRequestWithJsonAsync<Models.DeleteMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
