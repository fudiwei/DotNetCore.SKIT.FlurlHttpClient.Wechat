using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBankTransferExtensions
    {
        #region Batches
        /// <summary>
        /// <para>异步调用 [POST] /bank-transfer/batches 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_2_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBankTransferBatchResponse> ExecuteCreateBankTransferBatchAsync(this WechatTenpayClient client, Models.CreateBankTransferBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "bank-transfer", "batches");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBankTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bank-transfer/batches/out-batch-no/{out_batch_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankTransferBatchByOutBatchNumberResponse> ExecuteGetBankTransferBatchByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetBankTransferBatchByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bank-transfer", "batches", "out-batch-no", request.OutBatchNumber)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail);

            if (request.DetailStatus is not null)
                flurlReq.SetQueryParam("detail_status", request.DetailStatus);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankTransferBatchByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bank-transfer/batches/batch-id/{batch_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_2_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankTransferBatchByBatchIdResponse> ExecuteGetBankTransferBatchByBatchIdAsync(this WechatTenpayClient client, Models.GetBankTransferBatchByBatchIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bank-transfer", "batches", "batch-id", request.BatchId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail);

            if (request.DetailStatus is not null)
                flurlReq.SetQueryParam("detail_state", request.DetailStatus);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankTransferBatchByBatchIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bank-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankTransferBatchDetailByOutDetailNumberResponse> ExecuteGetBankTransferBatchDetailByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetBankTransferBatchDetailByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bank-transfer", "batches", "out-batch-no", request.OutBatchNumber, "details", "out-detail-no", request.OutDetailNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankTransferBatchDetailByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bank-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankTransferBatchDetailByDetailIdResponse> ExecuteGetBankTransferBatchDetailByDetailIdAsync(this WechatTenpayClient client, Models.GetBankTransferBatchDetailByDetailIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bank-transfer", "batches", "batch-id", request.BatchId, "details", "detail-id", request.DetailId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankTransferBatchDetailByDetailIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Receipt
        /// <summary>
        /// <para>异步调用 [POST] /bank-batch-transfer/receipt/summary-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_2_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBankBatchTransferSummaryReceiptResponse> ExecuteCreateBankBatchTransferSummaryReceiptAsync(this WechatTenpayClient client, Models.CreateBankBatchTransferSummaryReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "bank-batch-transfer", "receipt", "summary-receipts");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBankBatchTransferSummaryReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bank-batch-transfer/receipt/summary-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_2_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankBatchTransferSummaryReceiptByOutBatchNumberResponse> ExecuteGetBankBatchTransferSummaryReceiptByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetBankBatchTransferSummaryReceiptByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bank-batch-transfer", "receipt", "summary-receipts")
                .SetQueryParam("out_batch_no", request.OutBatchNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankBatchTransferSummaryReceiptByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /bank-batch-transfer/receipt/detail-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_2_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBankBatchTransferDetailReceiptResponse> ExecuteCreateBankBatchTransferDetailReceiptAsync(this WechatTenpayClient client, Models.CreateBankBatchTransferDetailReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "bank-batch-transfer", "receipt", "detail-receipts");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBankBatchTransferDetailReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bank-batch-transfer/receipt/detail-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_2_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBankBatchTransferDetailReceiptByOutDetailNumberResponse> ExecuteGetBankBatchTransferDetailReceiptByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetBankBatchTransferDetailReceiptByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bank-batch-transfer", "receipt", "detail-receipts")
                .SetQueryParam("out_batch_no", request.OutBatchNumber)
                .SetQueryParam("out_detail_no", request.OutDetailNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBankBatchTransferDetailReceiptByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
