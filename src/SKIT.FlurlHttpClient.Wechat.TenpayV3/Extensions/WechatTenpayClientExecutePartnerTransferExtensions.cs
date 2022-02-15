using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供服务商转账相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePartnerTransferExtensions
    {
        #region Batches
        /// <summary>
        /// <para>异步调用 [POST] /partner-transfer/batches 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerTransferBatchResponse> ExecuteCreatePartnerTransferBatchAsync(this WechatTenpayClient client, Models.CreatePartnerTransferBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "partner-transfer", "batches");

            return await client.SendRequestWithJsonAsync<Models.CreatePartnerTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
       
        /// <summary>
        /// <para>异步调用 [GET] /partner-transfer/batches/batch-id/{batch_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerTransferBatchByBatchIdResponse> ExecuteGetPartnerTransferBatchByBatchIdAsync(this WechatTenpayClient client, Models.GetPartnerTransferBatchByBatchIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "partner-transfer", "batches", "batch-id", request.BatchId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail);

            if (request.DetailStatus != null)
                flurlReq.SetQueryParam("detail_status", request.DetailStatus);

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithJsonAsync<Models.GetPartnerTransferBatchByBatchIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /partner-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerTransferBatchDetailByDetailIdResponse> ExecuteGetPartnerTransferBatchDetailByDetailIdAsync(this WechatTenpayClient client, Models.GetPartnerTransferBatchDetailByDetailIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "partner-transfer", "batches", "batch-id", request.BatchId, "details", "detail-id", request.DetailId);

            return await client.SendRequestWithJsonAsync<Models.GetPartnerTransferBatchDetailByDetailIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /partner-transfer/batches/out-batch-no/{out_batch_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerTransferBatchByOutBatchNumberResponse> ExecuteGetPartnerTransferBatchByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetPartnerTransferBatchByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "partner-transfer", "batches", "out-batch-no", request.OutBatchNumber)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail);

            if (request.DetailStatus != null)
                flurlReq.SetQueryParam("detail_status", request.DetailStatus);

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithJsonAsync<Models.GetPartnerTransferBatchByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /partner-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerTransferBatchDetailByOutDetailNumberResponse> ExecuteGetPartnerTransferBatchDetailByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetPartnerTransferBatchDetailByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "partner-transfer", "batches", "out-batch-no", request.OutBatchNumber, "details", "out-detail-no", request.OutDetailNumber);

            return await client.SendRequestWithJsonAsync<Models.GetPartnerTransferBatchDetailByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
