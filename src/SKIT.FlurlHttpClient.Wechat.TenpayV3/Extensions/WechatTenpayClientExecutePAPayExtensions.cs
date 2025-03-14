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

        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/fail-notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_11.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPayContractFailedNotificationResponse> ExecuteCreatePAPayContractFailedNotificationAsync(this WechatTenpayClient client, Models.CreatePAPayContractFailedNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId, "fail-notify");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePAPayContractFailedNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region InsurancePayPolicyPeriods
        /// <summary>
        /// <para>异步调用 [GET] /papay/insurance-pay/policy-periods/contract-id/{contract_id}/policy-period-id/{policy_period_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012471229 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdResponse> ExecuteGetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdAsync(this WechatTenpayClient client, Models.GetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "insurance-pay", "policy-periods", "contract-id", request.ContractId, "policy-period-id", request.PolicyPeriodId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-pay/policy-periods/contract-id/{contract_id}/policy-period-id/{policy_period_id}/schedule 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012471270 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePAPayInsurancePayPolicyPeriodScheduleResponse> ExecuteCreatePAPayInsurancePayPolicyPeriodScheduleAsync(this WechatTenpayClient client, Models.CreatePAPayInsurancePayPolicyPeriodScheduleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-pay", "policy-periods", "contract-id", request.ContractId, "policy-period-id", request.PolicyPeriodId, "schedule");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePAPayInsurancePayPolicyPeriodScheduleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region InsuranceSign
        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-sign/contracts/pre-entrust-sign/jsapi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012528600 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayInsuranceSignContractEntrustJsapiResponse> ExecutePresignPAPayInsuranceSignContractEntrustJsapiAsync(this WechatTenpayClient client, Models.PresignPAPayInsuranceSignContractEntrustJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-sign", "contracts", "pre-entrust-sign", "jsapi");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayInsuranceSignContractEntrustJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-sign/contracts/pre-entrust-sign/mini-program 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012528950 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayInsuranceSignContractEntrustMiniProgramResponse> ExecutePresignPAPayInsuranceSignContractEntrustMiniProgramAsync(this WechatTenpayClient client, Models.PresignPAPayInsuranceSignContractEntrustMiniProgramRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-sign", "contracts", "pre-entrust-sign", "mini-program");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayInsuranceSignContractEntrustMiniProgramResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-sign/contracts/pre-entrust-sign/h5 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012529050 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignPAPayInsuranceSignContractEntrustH5Response> ExecutePresignPAPayInsuranceSignContractEntrustH5Async(this WechatTenpayClient client, Models.PresignPAPayInsuranceSignContractEntrustH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-sign", "contracts", "pre-entrust-sign", "h5");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignPAPayInsuranceSignContractEntrustH5Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region InsuranceSignContracts
        /// <summary>
        /// <para>异步调用 [GET] /papay/insurance-sign/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012472641 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPAPayInsuranceSignContractByOutContractCodeResponse> ExecuteGetPAPayInsuranceSignContractByOutContractCodeAsync(this WechatTenpayClient client, Models.GetPAPayInsuranceSignContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "insurance-sign", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPAPayInsuranceSignContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-sign/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012472767 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminatePAPayInsuranceSignContractResponse> ExecuteTerminatePAPayInsuranceSignContractAsync(this WechatTenpayClient client, Models.TerminatePAPayInsuranceSignContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-sign", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminatePAPayInsuranceSignContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /papay/insurance-sign/policy_periods/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012489530 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryPAPayInsuranceSignPolicyPeriodsResponse> ExecuteQueryPAPayInsuranceSignPolicyPeriodsAsync(this WechatTenpayClient client, Models.QueryPAPayInsuranceSignPolicyPeriodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "papay", "insurance-sign", "policy_periods", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryPAPayInsuranceSignPolicyPeriodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-sign/contracts/plan-id/{plan_id}/contract-id/{contract_id}/renew 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012489588 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RenewPAPayInsuranceSignContractResponse> ExecuteRenewPAPayInsuranceSignContractAsync(this WechatTenpayClient client, Models.RenewPAPayInsuranceSignContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-sign", "contracts", "plan-id", request.PlanId, "contract-id", request.ContractId, "renew");

            return await client.SendFlurlRequestAsJsonAsync<Models.RenewPAPayInsuranceSignContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region InsurancePayTransactions
        /// <summary>
        /// <para>异步调用 [POST] /papay/insurance-pay/transactions/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012471158 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPAPayInsurancePayTransactionResponse> ExecuteApplyPAPayInsurancePayTransactionAsync(this WechatTenpayClient client, Models.ApplyPAPayInsurancePayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "papay", "insurance-pay", "transactions", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPAPayInsurancePayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region PaySchedules
        /// <summary>
        /// <para>异步调用 [GET] /papay/pay/schedules/contract-id/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012466997 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467036 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012467036 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012524934 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012489208 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012525133 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012525209 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012489245 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012489295 ]]>
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
