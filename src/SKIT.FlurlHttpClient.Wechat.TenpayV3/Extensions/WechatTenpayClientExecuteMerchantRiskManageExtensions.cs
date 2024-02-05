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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/risk-manage/trade-risk/report-trade-risk-information.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "report-trade-union-information");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantRiskManageTradeUnionInformationReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-risk-manage/trade-risk-information 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/risk-manage/trade-risk/query-trade-risk-information.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-risk-manage", "trade-risk-information")
                .SetQueryParam("out_trade_no", request.OutTradeNumber);

            if (request.MerchantId is not null)
                flurlReq.SetQueryParam("sp_mchid", request.MerchantId);

            if (request.AcquiringBankId is not null)
                flurlReq.SetQueryParam("acquiring_bank_id", request.AcquiringBankId);

            if (request.ChannelId is not null)
                flurlReq.SetQueryParam("channel_id", request.ChannelId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.ComplaintsInformation is not null)
                flurlReq.SetQueryParam("complaints_information", request.ComplaintsInformation);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantRiskManageTradeRiskInformationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/trade-risk-result 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/risk-manage/trade-risk/report-trade-risk-information.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "trade-risk-result");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantRiskManageTradeRiskResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ViolationNotification
        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/violation-notice/violation-notifications/create-violation-notification.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "violation-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/violation-notice/violation-notifications/query-violation-notification.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-risk-manage", "violation-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/violation-notice/violation-notifications/update-violation-notification.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Put, "merchant-risk-manage", "violation-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /merchant-risk-manage/violation-notifications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/violation-notice/violation-notifications/delete-violation-notification.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Delete, "merchant-risk-manage", "violation-notifications");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteMerchantRiskManageViolationNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
