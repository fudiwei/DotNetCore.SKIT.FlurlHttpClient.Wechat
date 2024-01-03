using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteTransferExtensions
    {
        #region Batches
        /// <summary>
        /// <para>异步调用 [POST] /transfer/batches 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/transfer-batch/initiate-batch-transfer.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransferBatchResponse> ExecuteCreateTransferBatchAsync(this WechatTenpayClient client, Models.CreateTransferBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transfer", "batches");

            return await client.SendRequestWithJsonAsync<Models.CreateTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transfer/batches/out-batch-no/{out_batch_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/transfer-batch/get-transfer-batch-by-out-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransferBatchByOutBatchNumberResponse> ExecuteGetTransferBatchByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetTransferBatchByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transfer", "batches", "out-batch-no", request.OutBatchNumber)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail);

            if (request.DetailStatus != null)
                flurlReq.SetQueryParam("detail_status", request.DetailStatus);

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithJsonAsync<Models.GetTransferBatchByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transfer/batches/batch-id/{batch_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/transfer-batch/get-transfer-batch-by-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransferBatchByBatchIdResponse> ExecuteGetTransferBatchByBatchIdAsync(this WechatTenpayClient client, Models.GetTransferBatchByBatchIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transfer", "batches", "batch-id", request.BatchId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail);

            if (request.DetailStatus != null)
                flurlReq.SetQueryParam("detail_status", request.DetailStatus);

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendRequestWithJsonAsync<Models.GetTransferBatchByBatchIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/transfer-detail/get-transfer-detail-by-out-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransferBatchDetailByOutDetailNumberResponse> ExecuteGetTransferBatchDetailByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetTransferBatchDetailByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transfer", "batches", "out-batch-no", request.OutBatchNumber, "details", "out-detail-no", request.OutDetailNumber);

            return await client.SendRequestWithJsonAsync<Models.GetTransferBatchDetailByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/transfer-detail/get-transfer-detail-by-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransferBatchDetailByDetailIdResponse> ExecuteGetTransferBatchDetailByDetailIdAsync(this WechatTenpayClient client, Models.GetTransferBatchDetailByDetailIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transfer", "batches", "batch-id", request.BatchId, "details", "detail-id", request.DetailId);

            return await client.SendRequestWithJsonAsync<Models.GetTransferBatchDetailByDetailIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region BillReceipt
        /// <summary>
        /// <para>异步调用 [POST] /transfer/bill-receipt 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/electronic-signature/create-electronic-signature.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransferBillReceiptResponse> ExecuteCreateTransferBillReceiptAsync(this WechatTenpayClient client, Models.CreateTransferBillReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transfer", "bill-receipt");

            return await client.SendRequestWithJsonAsync<Models.CreateTransferBillReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transfer/bill-receipt/{out_batch_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/electronic-signature/get-electronic-signature-by-out-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransferBillReceiptByOutBatchNumberResponse> ExecuteGetTransferBillReceiptByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetTransferBillReceiptByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transfer", "bill-receipt", request.OutBatchNumber);

            return await client.SendRequestWithJsonAsync<Models.GetTransferBillReceiptByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region DetailReceipt
        /// <summary>
        /// <para>异步调用 [POST] /transfer-detail/electronic-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/electronic-receipt-api/create-electronic-receipt.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransferDetailElectronicReceiptResponse> ExecuteCreateTransferDetailElectronicReceiptAsync(this WechatTenpayClient client, Models.CreateTransferDetailElectronicReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "transfer-detail", "electronic-receipts");

            return await client.SendRequestWithJsonAsync<Models.CreateTransferDetailElectronicReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transfer-detail/electronic-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/electronic-receipt-api/query-electronic-receipt.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransferDetailElectronicReceiptByOutDetailNumberResponse> ExecuteGetTransferDetailElectronicReceiptByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetTransferDetailElectronicReceiptByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "transfer-detail", "electronic-receipts")
                .SetQueryParam("accept_type", request.AcceptType)
                .SetQueryParam("out_detail_no", request.OutDetailNumber);

            if (request.OutBatchNumber != null)
                flurlReq.SetQueryParam("out_batch_no", request.OutBatchNumber);

            return await client.SendRequestWithJsonAsync<Models.GetTransferDetailElectronicReceiptByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
