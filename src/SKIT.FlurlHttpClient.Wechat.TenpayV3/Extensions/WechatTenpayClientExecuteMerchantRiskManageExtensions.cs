using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantRiskManageExtensions
    {
        #region TradeRisk
        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/report-trade-union-information 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/risk-manage/trade-risk/report-trade-risk-information.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantRiskManageTradeUnionInformationReportResponse> ExecuteCreateMerchantRiskManageTradeUnionInformationReportAsync(this WechatTenpayClient client, Models.CreateMerchantRiskManageTradeUnionInformationReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-risk-manage", "report-trade-union-information");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantRiskManageTradeUnionInformationReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-risk-manage/trade-risk-information 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/risk-manage/trade-risk/query-trade-risk-information.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantRiskManageTradeRiskInformationResponse> ExecuteGetMerchantRiskManageTradeRiskInformationAsync(this WechatTenpayClient client, Models.GetMerchantRiskManageTradeRiskInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "merchant-risk-manage", "trade-risk-information")
                .SetQueryParam("out_trade_no", request.OutTradeNumber);

            if (request.MerchantId != null)
                flurlReq.SetQueryParam("sp_mchid", request.MerchantId);

            if (request.AcquiringBankId != null)
                flurlReq.SetQueryParam("acquiring_bank_id", request.AcquiringBankId);

            if (request.ChannelId != null)
                flurlReq.SetQueryParam("channel_id", request.ChannelId);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.ComplaintsInformation != null)
                flurlReq.SetQueryParam("complaints_information", request.ComplaintsInformation);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantRiskManageTradeRiskInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/trade-risk-result 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/risk-manage/trade-risk/report-trade-risk-information.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantRiskManageTradeRiskResultResponse> ExecuteCreateMerchantRiskManageTradeRiskResultAsync(this WechatTenpayClient client, Models.CreateMerchantRiskManageTradeRiskResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "merchant-risk-manage", "trade-risk-result");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantRiskManageTradeRiskResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ViolationNotification
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
        #endregion
    }
}
