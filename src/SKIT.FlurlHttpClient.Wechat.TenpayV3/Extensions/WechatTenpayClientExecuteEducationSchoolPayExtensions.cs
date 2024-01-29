using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteEducationSchoolPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /eduschoolpay/contracts/presign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignEducationSchoolPayContractResponse> ExecutePresignEducationSchoolPayContractAsync(this WechatTenpayClient client, Models.PresignEducationSchoolPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "eduschoolpay", "contracts", "presign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignEducationSchoolPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /eduschoolpay/contracts/{contract_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationSchoolPayContractByContractIdResponse> ExecuteGetEducationSchoolPayContractByContractIdAsync(this WechatTenpayClient client, Models.GetEducationSchoolPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "eduschoolpay", "contracts", request.ContractId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationSchoolPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /eduschoolpay/users/{openid}/contracts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryEducationSchoolPayUserContractsResponse> ExecuteQueryEducationSchoolPayUserContractsAsync(this WechatTenpayClient client, Models.QueryEducationSchoolPayUserContractsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "eduschoolpay", "users", request.OpenId, "contracts")
                .SetQueryParam("plan_id", request.PlanId)
                .SetQueryParam("contract_status", request.ContractStatus); ;

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryEducationSchoolPayUserContractsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /eduschoolpay/contracts/{contract_id}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateEducationSchoolPayContractResponse> ExecuteTerminateEducationSchoolPayContractAsync(this WechatTenpayClient client, Models.TerminateEducationSchoolPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "eduschoolpay", "contracts", request.ContractId, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateEducationSchoolPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /eduschoolpay/transactions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEducationSchoolPayTransactionResponse> ExecuteCreateEducationSchoolPayTransactionAsync(this WechatTenpayClient client, Models.CreateEducationSchoolPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "eduschoolpay", "transactions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEducationSchoolPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /eduschoolpay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationSchoolPayTransactionByOutTradeNumberResponse> ExecuteGetEducationSchoolPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetEducationSchoolPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "eduschoolpay", "transactions", "out-trade-no", request.OutTradeNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationSchoolPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /eduschoolpay/transactions/id/{transaction_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationSchoolPayTransactionByIdResponse> ExecuteGetEducationSchoolPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetEducationSchoolPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "eduschoolpay", "transactions", "id", request.TransactionId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationSchoolPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /eduschoolpay/users/{openid}/debt-state 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_3_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationSchoolPayUserDebtStateResponse> ExecuteGetEducationSchoolPayUserDebtStateAsync(this WechatTenpayClient client, Models.GetEducationSchoolPayUserDebtStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "eduschoolpay", "users", request.OpenId, "debt-state");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationSchoolPayUserDebtStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
