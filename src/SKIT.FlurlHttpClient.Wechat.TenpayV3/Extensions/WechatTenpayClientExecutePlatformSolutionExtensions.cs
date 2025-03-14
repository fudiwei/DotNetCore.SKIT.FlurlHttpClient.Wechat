using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePlatformSolutionExtensions
    {
        #region EcommerceInsuranceCompensationContracts
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/insurance-compensation-contracts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012781476 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionEcommerceInsuranceCompensationContractResponse> ExecuteApplyPlatformSolutionEcommerceInsuranceCompensationContractAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionEcommerceInsuranceCompensationContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "insurance-compensation-contracts");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionEcommerceInsuranceCompensationContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/insurance-compensation-contracts/sub-mchid/{sub_mchid}/check-opened 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012781480 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantIdResponse> ExecuteGetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "insurance-compensation-contracts", "sub-mchid", request.SubMerchantId, "check-opened")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceMerchantTransferCompensateBill
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/compensate-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504175 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensateBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferCompensateBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferCompensateBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "compensate-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensateBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/compensate-bills/pre-transfer 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504176 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensateBillPreTransferResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferCompensateBillPreTransferAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferCompensateBillPreTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "pre-transfer");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensateBillPreTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/compensate-bills/out-bill-no/{out_bill_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504177 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelPlatformSolutionEcommerceMerchantTransferCompensateBillResponse> ExecuteCancelPlatformSolutionEcommerceMerchantTransferCompensateBillAsync(this WechatTenpayClient client, Models.CancelPlatformSolutionEcommerceMerchantTransferCompensateBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "out-bill-no", request.OutBillNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPlatformSolutionEcommerceMerchantTransferCompensateBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/compensate-bills/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504178 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferCompensateBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferCompensateBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferCompensateBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "out-bill-no", request.OutBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferCompensateBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/compensate-bills/bill-id/{bill_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504179 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferCompensateBillByBillIdResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferCompensateBillByBillIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferCompensateBillByBillIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "bill-id", request.BillId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferCompensateBillByBillIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceMerchantTransferInsuranceClaimBill
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/insurance-claim-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504184 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "insurance-claim-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/insurance-claim-bills/pre-transfer 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504185 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillPreTransferResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillPreTransferAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillPreTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "insurance-claim-bills", "pre-transfer");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillPreTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/insurance-claim-bills/out-bill-no/{out_bill_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504186 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillResponse> ExecuteCancelPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillAsync(this WechatTenpayClient client, Models.CancelPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "insurance-claim-bills", "out-bill-no", request.OutBillNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/insurance-claim-bills/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504187 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "insurance-claim-bills", "out-bill-no", request.OutBillNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/insurance-claim-bills/bill-id/{bill_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504188 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByBillIdResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByBillIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByBillIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "insurance-claim-bills", "bill-id", request.BillId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByBillIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceRecharges
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/recharges/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012762860 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionEcommerceRechargeResponse> ExecuteApplyPlatformSolutionEcommerceRechargeAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionEcommerceRechargeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "recharges", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionEcommerceRechargeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/recharges/out-recharge-no/{out_recharge_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012762874 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceRechargeByOutRechargeNumberResponse> ExecuteGetPlatformSolutionEcommerceRechargeByOutRechargeNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceRechargeByOutRechargeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "recharges", "out-recharge-no", request.OutRechargeNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceRechargeByOutRechargeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/recharges/out-recharge-no/{out_recharge_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012762895 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePlatformSolutionEcommerceRechargeResponse> ExecuteClosePlatformSolutionEcommerceRechargeAsync(this WechatTenpayClient client, Models.ClosePlatformSolutionEcommerceRechargeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "recharges", "out-recharge-no", request.OutRechargeNumber, "close")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ClosePlatformSolutionEcommerceRechargeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/bank-transfer-recharges/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012763053 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionEcommerceBankTransferRechargeResponse> ExecuteApplyPlatformSolutionEcommerceBankTransferRechargeAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionEcommerceBankTransferRechargeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "bank-transfer-recharges", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionEcommerceBankTransferRechargeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/bank-transfer-recharges/out-recharge-no/{out_recharge_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012763057 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceBankTransferRechargeByOutRechargeNumberResponse> ExecuteGetPlatformSolutionEcommerceBankTransferRechargeByOutRechargeNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceBankTransferRechargeByOutRechargeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "bank-transfer-recharges", "out-recharge-no", request.OutRechargeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceBankTransferRechargeByOutRechargeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceRechargeEmployees
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/recharge-employees 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013521743 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddPlatformSolutionEcommerceRechargeEmployeeResponse> ExecuteAddPlatformSolutionEcommerceRechargeEmployeeAsync(this WechatTenpayClient client, Models.AddPlatformSolutionEcommerceRechargeEmployeeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "recharge-employees");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddPlatformSolutionEcommerceRechargeEmployeeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/recharge-employees/sub-mchid/{sub_mchid}/sp-openid/{sp_openid}/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013521753 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeletePlatformSolutionEcommerceRechargeEmployeeResponse> ExecuteDeletePlatformSolutionEcommerceRechargeEmployeeAsync(this WechatTenpayClient client, Models.DeletePlatformSolutionEcommerceRechargeEmployeeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "recharge-employees", "sub-mchid", request.SubMerchantId, "sp-openid", request.OpenId, "delete");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeletePlatformSolutionEcommerceRechargeEmployeeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/recharge-employees/sub-mchid/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013521757 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryPlatformSolutionEcommerceRechargeEmployeesResponse> ExecuteQueryPlatformSolutionEcommerceRechargeEmployeesAsync(this WechatTenpayClient client, Models.QueryPlatformSolutionEcommerceRechargeEmployeesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "recharge-employees", "sub-mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryPlatformSolutionEcommerceRechargeEmployeesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MerchantTransfer
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/mch-transfer/batches/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-batch/transfer-batch-apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionMerchantTransferBatchResponse> ExecuteApplyPlatformSolutionMerchantTransferBatchAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionMerchantTransferBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "mch-transfer", "batches", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionMerchantTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/mch-transfer/batches/out-batch-no/{out_batch_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-batch/transfer-batch-get-by-out-code.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionMerchantTransferBatchByOutBatchNumberResponse> ExecuteGetPlatformSolutionMerchantTransferBatchByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionMerchantTransferBatchByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "mch-transfer", "batches", "out-batch-no", request.OutBatchNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail ? "true" : "false")
                .SetQueryParam("detail_state", request.DetailState)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionMerchantTransferBatchByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/mch-transfer/batches/batch-id/{batch_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-batch/transfer-batch-get-by-id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionMerchantTransferBatchByBatchIdResponse> ExecuteGetPlatformSolutionMerchantTransferBatchByBatchIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionMerchantTransferBatchByBatchIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "mch-transfer", "batches", "batch-id", request.BatchId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail ? "true" : "false")
                .SetQueryParam("detail_state", request.DetailState)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionMerchantTransferBatchByBatchIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/mch-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-batch/transfer-batch-get-detail-by-out-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionMerchantTransferBatchDetailByOutDetailNumberResponse> ExecuteGetPlatformSolutionMerchantTransferBatchDetailByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionMerchantTransferBatchDetailByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "mch-transfer", "batches", "out-batch-no", request.OutBatchNumber, "details", "out-detail-no", request.OutDetailNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionMerchantTransferBatchDetailByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/mch-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-batch/get-transfer-detail-by-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionMerchantTransferBatchDetailByDetailIdResponse> ExecuteGetPlatformSolutionMerchantTransferBatchDetailByDetailIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionMerchantTransferBatchDetailByDetailIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "mch-transfer", "batches", "out-batch-no", request.BatchId, "details", "detail-id", request.DetailId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionMerchantTransferBatchDetailByDetailIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/mch-transfer/reservation/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-reservation/transfer-reservation-apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionMerchantTransferReservationResponse> ExecuteApplyPlatformSolutionMerchantTransferReservationAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionMerchantTransferReservationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "mch-transfer", "reservation", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionMerchantTransferReservationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/mch-transfer/reservation/out-reservation-no/{out_reservation_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-reservation/transfer-reservation-get-by-out-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionMerchantTransferReservationByOutReservationNumberResponse> ExecuteGetPlatformSolutionMerchantTransferReservationByOutReservationNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionMerchantTransferReservationByOutReservationNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "mch-transfer", "reservation", "out-reservation-no", request.OutReservationNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionMerchantTransferReservationByOutReservationNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/mch-transfer/reservation/reservation-id/{reservation_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-reservation/transfer-reservation-get-by-id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionMerchantTransferReservationByReservationIdResponse> ExecuteGetPlatformSolutionMerchantTransferReservationByReservationIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionMerchantTransferReservationByReservationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "mch-transfer", "reservation", "reservation-id", request.ReservationId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionMerchantTransferReservationByReservationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/mch-transfer/reservation/out-reservation-no/{out_reservation_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/platsolution-mch-transfer/transfer-reservation/transfer-reservation-close.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePlatformSolutionMerchantTransferReservationResponse> ExecuteClosePlatformSolutionMerchantTransferReservationAsync(this WechatTenpayClient client, Models.ClosePlatformSolutionMerchantTransferReservationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "mch-transfer", "reservation", "out-reservation-no", request.OutReservationNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.ClosePlatformSolutionMerchantTransferReservationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
