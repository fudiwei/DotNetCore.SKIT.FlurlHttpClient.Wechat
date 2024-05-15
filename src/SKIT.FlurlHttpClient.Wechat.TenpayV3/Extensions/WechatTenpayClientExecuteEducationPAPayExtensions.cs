using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteEducationPAPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /edu-papay/contracts/presign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/contracts/pre-sign.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/contracts/pre-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignEducationPAPayContractResponse> ExecutePresignEducationPAPayContractAsync(this WechatTenpayClient client, Models.PresignEducationPAPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "edu-papay", "contracts", "presign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignEducationPAPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/contracts/id/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/contracts/query-contract.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/contracts/query-contract.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationPAPayContractByContractIdResponse> ExecuteGetEducationPAPayContractByContractIdAsync(this WechatTenpayClient client, Models.GetEducationPAPayContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "edu-papay", "contracts", "id", request.ContractId)
                .SetQueryParam("appid", request.AppId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.SubAppId is not null)
                flurlReq.SetQueryParam("sub_appid", request.SubAppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationPAPayContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/user/{openid}/contracts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/contracts/list-user-contracts.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/contracts/list-user-contracts.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryEducationPAPayUserContractsResponse> ExecuteQueryEducationPAPayUserContractsAsync(this WechatTenpayClient client, Models.QueryEducationPAPayUserContractsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "edu-papay", "user", request.OpenId, "contracts")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("plan_id", request.PlanId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.SubAppId is not null)
                flurlReq.SetQueryParam("sub_appid", request.SubAppId);

            if (request.SubOpenId is not null)
                flurlReq.SetQueryParam("sub_openid", request.SubOpenId);

            if (request.ContractStatus is not null)
                flurlReq.SetQueryParam("contract_status", request.ContractStatus);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryEducationPAPayUserContractsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /edu-papay/contracts/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/contracts/delete-contract.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/contracts/list-user-contracts.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateEducationPAPayContractResponse> ExecuteTerminateEducationPAPayContractAsync(this WechatTenpayClient client, Models.TerminateEducationPAPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "edu-papay", "contracts", request.ContractId);

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateEducationPAPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /edu-papay/user-notifications/{contract_id}/send 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/user-notifications/send-user-notification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/user-notifications/send-user-notification.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendEducationPAPayContractNotificationResponse> ExecuteSendEducationPAPayContractNotificationAsync(this WechatTenpayClient client, Models.SendEducationPAPayContractNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "edu-papay", "user-notifications", request.ContractId, "send");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendEducationPAPayContractNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /edu-papay/transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/transactions/create-transaction.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/transactions/create-transaction.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEducationPAPayTransactionResponse> ExecuteCreateEducationPAPayTransactionAsync(this WechatTenpayClient client, Models.CreateEducationPAPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "edu-papay", "transactions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEducationPAPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/transactions/query-transaction-by-out-trade-no.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/transactions/query-transaction-by-out-trade-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationPAPayTransactionByOutTradeNumberResponse> ExecuteGetEducationPAPayTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetEducationPAPayTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "edu-papay", "transactions", "out-trade-no", request.OutTradeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationPAPayTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /edu-papay/transactions/id/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/education-fee-payment/transactions/query-transaction-by-id.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/education-fee-payment/transactions/query-transaction-by-id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEducationPAPayTransactionByIdResponse> ExecuteGetEducationPAPayTransactionByIdAsync(this WechatTenpayClient client, Models.GetEducationPAPayTransactionByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "edu-papay", "transactions", "id", request.TransactionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEducationPAPayTransactionByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
