using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteTransactionBlockExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /transaction-block/transaction-block-records/sub-mchid/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940432 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryTransactionBlockRecordsResponse> ExecuteQueryTransactionBlockRecordsAsync(this WechatTenpayClient client, Models.QueryTransactionBlockRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "transaction-block", "transaction-block-records", "sub-mchid", request.SubMerchantId)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryTransactionBlockRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transaction-block/transaction-block-records/{block_record_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940435 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransactionBlockRecordResponse> ExecuteGetTransactionBlockRecordAsync(this WechatTenpayClient client, Models.GetTransactionBlockRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "transaction-block", "transaction-block-records", request.BlockRecordId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTransactionBlockRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transaction-block/transaction-block-submissions/sub-mchid/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940446 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTransactionBlockSubmissionResponse> ExecuteCreateTransactionBlockSubmissionAsync(this WechatTenpayClient client, Models.CreateTransactionBlockSubmissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transaction-block", "transaction-block-submissions", "sub-mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateTransactionBlockSubmissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /transaction-block/transaction-block-submissions/{block_submission_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940449 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransactionBlockSubmissionResponse> ExecuteGetTransactionBlockSubmissionAsync(this WechatTenpayClient client, Models.GetTransactionBlockSubmissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "transaction-block", "transaction-block-submissions", request.BlockSubmissionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetTransactionBlockSubmissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
