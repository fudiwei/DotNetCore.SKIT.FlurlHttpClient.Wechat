using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteEducationPAPPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /edu-papay/contracts/presign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignEducationPAPPayContractResponse> ExecutePresignEducationPAPPayContractAsync(this WechatTenpayClient client, Models.PresignEducationPAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "edu-papay", "contracts", "presign");

            return await client.SendRequestWithJsonAsync<Models.PresignEducationPAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/contracts/id/{contract_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationPAPPayContractByContractIdResponse> ExecuteGetEducationPAPPayContractByContractIdAsync(this WechatTenpayClient client, Models.GetEducationPAPPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "edu-papay", "contracts", "id", request.ContractId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetEducationPAPPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/user/{openid}/contracts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryEducationPAPPayUserContractsResponse> ExecuteQueryEducationPAPPayUserContractsAsync(this WechatTenpayClient client, Models.QueryEducationPAPPayUserContractsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "edu-papay", "user", request.OpenId, "contracts")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("plan_id", request.PlanId);

            if (request.ContractStatus != null)
                flurlReq.SetQueryParam("contract_status", request.ContractStatus);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            return await client.SendRequestWithJsonAsync<Models.QueryEducationPAPPayUserContractsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /edu-papay/contracts/{contract_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateEducationPAPPayContractResponse> ExecuteTerminateEducationPAPPayContractAsync(this WechatTenpayClient client, Models.TerminateEducationPAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Delete, "edu-papay", "contracts", request.ContractId);

            return await client.SendRequestWithJsonAsync<Models.TerminateEducationPAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /edu-papay/user-notifications/{contract_id}/send 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendEducationPAPPayContractNotificationResponse> ExecuteSendEducationPAPPayContractNotificationAsync(this WechatTenpayClient client, Models.SendEducationPAPPayContractNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "edu-papay", "user-notifications", request.ContractId, "send");

            return await client.SendRequestWithJsonAsync<Models.SendEducationPAPPayContractNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /edu-papay/transactions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEducationPAPPayTransactionResponse> ExecuteCreateEducationPAPPayTransactionAsync(this WechatTenpayClient client, Models.CreateEducationPAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "edu-papay", "transactions");

            return await client.SendRequestWithJsonAsync<Models.CreateEducationPAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationPAPPayTransactionByOutTradeNumberResponse> ExecuteGetEducationPAPPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetEducationPAPPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "edu-papay", "transactions", "out-trade-no", request.OutTradeNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEducationPAPPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter5_2_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationPAPPayTransactionByIdResponse> ExecuteGetEducationPAPPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetEducationPAPPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "edu-papay", "transactions", "id", request.TransactionId);

            return await client.SendRequestWithJsonAsync<Models.GetEducationPAPPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
