using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePAPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_10.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPayContractNotificationResponse> ExecuteCreatePAPayContractNotificationAsync(this WechatTenpayClient client, Models.CreatePAPayContractNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId, "notify");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePAPayContractNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region PaySchedules
        /// <summary>
        /// <para>异步调用 [GET] /papay/pay/schedules/contract-id/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-query-deduct-schedule.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayPaySchedulesContractByContractIdResponse> ExecuteGetPAPayPaySchedulesContractByContractIdAsync(this WechatTenpayClient client, Models.GetPAPayPaySchedulesContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "pay", "schedules", "contract-id", request.ContractId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayPaySchedulesContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/pay/schedules/contract-id/{contract_id}/schedule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-schedule-deduction.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPayPaySchedulesContractScheduleResponse> ExecuteCreatePAPayPaySchedulesContractScheduleAsync(this WechatTenpayClient client, Models.CreatePAPayPaySchedulesContractScheduleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "pay", "schedules", "contract-id", request.ContractId, "schedule");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePAPayPaySchedulesContractScheduleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region PayTransactions
        /// <summary>
        /// <para>异步调用 [POST] /papay/pay/transactions/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-schedule-deduction.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPAPayPayTransactionResponse> ExecuteApplyPAPayPayTransactionAsync(this WechatTenpayClient client, Models.ApplyPAPayPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "pay", "transactions", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPAPayPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ScheduledDeductSign
        /// <summary>
        /// <para>异步调用 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/app 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-app-scheduled-deduct-pre-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayScheduledDeductSignContractEntrustAppResponse> ExecutePresignPAPayScheduledDeductSignContractEntrustAppAsync(this WechatTenpayClient client, Models.PresignPAPayScheduledDeductSignContractEntrustAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "scheduled-deduct-sign", "contracts", "pre-entrust-sign", "app");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayScheduledDeductSignContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/h5 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-h5-scheduled-deduct-pre-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayScheduledDeductSignContractEntrustH5Response> ExecutePresignPAPayScheduledDeductSignContractEntrustH5Async(this WechatTenpayClient client, Models.PresignPAPayScheduledDeductSignContractEntrustH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "scheduled-deduct-sign", "contracts", "pre-entrust-sign", "h5");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayScheduledDeductSignContractEntrustH5Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/jsapi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/jsapi-scheduled-deduct-pre-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayScheduledDeductSignContractEntrustJsapiResponse> ExecutePresignPAPayScheduledDeductSignContractEntrustJsapiAsync(this WechatTenpayClient client, Models.PresignPAPayScheduledDeductSignContractEntrustJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "scheduled-deduct-sign", "contracts", "pre-entrust-sign", "jsapi");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayScheduledDeductSignContractEntrustJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/scheduled-deduct-sign/contracts/pre-entrust-sign/mini-program 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/mini-program-scheduled-deduct-pre-sign.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayScheduledDeductSignContractEntrustMiniProgramResponse> ExecutePresignPAPayScheduledDeductSignContractEntrustMiniProgramAsync(this WechatTenpayClient client, Models.PresignPAPayScheduledDeductSignContractEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "scheduled-deduct-sign", "contracts", "pre-entrust-sign", "mini-program");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayScheduledDeductSignContractEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SignContracts
        /// <summary>
        /// <para>异步调用 [GET] /papay/sign/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-get-contract-by-code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPaySignContractByOutContractCodeResponse> ExecuteGetPAPaySignContractByOutContractCodeAsync(this WechatTenpayClient client, Models.GetPAPaySignContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "sign", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPaySignContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/sign/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/entrusted-payment/normal/normal-terminate-contract-by-code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePAPaySignContractResponse> ExecuteTerminatePAPaySignContractAsync(this WechatTenpayClient client, Models.TerminatePAPaySignContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "sign", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePAPaySignContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
