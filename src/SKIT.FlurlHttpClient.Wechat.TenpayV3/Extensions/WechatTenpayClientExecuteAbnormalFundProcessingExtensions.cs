using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteAbnormalFundProcessingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /abnormal-fund-processing/receipts/{receipt_id}/transfer-instructions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015408022 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateAbnormalFundProcessingReceiptTransferInstructionResponse> ExecuteCreateAbnormalFundProcessingReceiptTransferInstructionAsync(this WechatTenpayClient client, Models.CreateAbnormalFundProcessingReceiptTransferInstructionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "abnormal-fund-processing", "receipts", request.ReceiptId, "transfer-instructions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateAbnormalFundProcessingReceiptTransferInstructionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /abnormal-fund-processing/receipts/{receipt_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015408031 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetAbnormalFundProcessingReceiptByReceiptIdResponse> ExecuteGetAbnormalFundProcessingReceiptByReceiptIdAsync(this WechatTenpayClient client, Models.GetAbnormalFundProcessingReceiptByReceiptIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "abnormal-fund-processing", "receipts", request.ReceiptId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetAbnormalFundProcessingReceiptByReceiptIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
