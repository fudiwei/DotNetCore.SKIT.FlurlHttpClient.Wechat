using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePlatformSolutionExtensions
    {
        #region EcommerceInsuranceCompensation
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

        #region EcommerceMerchantTransferCompensation
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
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensationBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferCompensationBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferCompensationBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "compensate-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensationBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensationBillPreTransferResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferCompensationBillPreTransferAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferCompensationBillPreTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "pre-transfer");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferCompensationBillPreTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.CancelPlatformSolutionEcommerceMerchantTransferCompensationBillResponse> ExecuteCancelPlatformSolutionEcommerceMerchantTransferCompensationBillAsync(this WechatTenpayClient client, Models.CancelPlatformSolutionEcommerceMerchantTransferCompensationBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "out-bill-no", request.OutBillNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPlatformSolutionEcommerceMerchantTransferCompensationBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferCompensationBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferCompensationBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferCompensationBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "out-bill-no", request.OutBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferCompensationBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferCompensationBillByBillIdResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferCompensationBillByBillIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferCompensationBillByBillIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "compensate-bills", "bill-id", request.BillId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferCompensationBillByBillIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceMerchantTransferDepositAfterSalesCompensation
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/deposit-after-sales-compensation-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504195 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "deposit-after-sales-compensation-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/deposit-after-sales-compensation-bills/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504195 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "deposit-after-sales-compensation-bills", "out-bill-no", request.OutBillNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/deposit-after-sales-compensation-bills/bill-id/{bill_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504196 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByBillIdResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByBillIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByBillIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "deposit-after-sales-compensation-bills", "bill-id", request.BillId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillByBillIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceMerchantTransferInsuranceClaim
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

        #region EcommerceMerchantTransfer
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/transfer-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504198 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "transfer-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/transfer-bills/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504199 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "transfer-bills", "out-bill-no", request.OutBillNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("business_type", request.BusinessType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/transfer-bills/bill-id/{bill_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504200 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferBillByBillIdResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferBillByBillIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferBillByBillIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "transfer-bills", "bill-id", request.BillId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("business_type", request.BusinessType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferBillByBillIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/deposit-shipping-cost-compensation-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504202 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "deposit-shipping-cost-compensation-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/deposit-shipping-cost-compensation-bills/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504203 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "deposit-shipping-cost-compensation-bills", "out-bill-no", request.OutBillNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferDepositShippingCostCompensationBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/mch-transfer/deposit-insurance-premiums-compensation-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014010905 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillResponse> ExecuteCreatePlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "mch-transfer", "deposit-insurance-premiums-compensation-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/mch-transfer/deposit-insurance-premiums-compensation-bills/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014010920 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillByOutBillNumberResponse> ExecuteGetPlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "mch-transfer", "deposit-insurance-premiums-compensation-bills", request.OutBillNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceMerchantTransferDepositInsurancePremiumsCompensationBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region EcommerceRecharge
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
        
        #region EcommerceRecharge/Employee
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
        #endregion

        #region EcommerceSettle
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/settle/prepay-settle-orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012649847 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePlatformSolutionEcommerceSettlePrepaySettleOrderResponse> ExecuteCreatePlatformSolutionEcommerceSettlePrepaySettleOrderAsync(this WechatTenpayClient client, Models.CreatePlatformSolutionEcommerceSettlePrepaySettleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "settle", "prepay-settle-orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePlatformSolutionEcommerceSettlePrepaySettleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/ecommerce/settle/prepay-settle-orders/{settle_batch_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012650326 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionEcommerceSettlePrepaySettleOrderBySettleBatchNumberResponse> ExecuteGetPlatformSolutionEcommerceSettlePrepaySettleOrderBySettleBatchNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionEcommerceSettlePrepaySettleOrderBySettleBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "ecommerce", "settle", "prepay-settle-orders", request.SettleBatchNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionEcommerceSettlePrepaySettleOrderBySettleBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/ecommerce/settle/prepay-settle-orders/{settle_batch_no}/apply-abnormal-settle 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015198012 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionEcommerceSettlePrepaySettleOrderAbnormalSettleResponse> ExecuteApplyPlatformSolutionEcommerceSettlePrepaySettleOrderAbnormalSettleAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionEcommerceSettlePrepaySettleOrderAbnormalSettleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "ecommerce", "settle", "prepay-settle-orders", request.SettleBatchNumber, "apply-abnormal-settle");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionEcommerceSettlePrepaySettleOrderAbnormalSettleResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region InsuranceMerchantTransfer
        /// <summary>
        /// <para>异步调用 [POST] /platsolution/insurance/mch-transfer/batches/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504220 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionInsuranceMerchantTransferBatchResponse> ExecuteApplyPlatformSolutionInsuranceMerchantTransferBatchAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionInsuranceMerchantTransferBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "insurance", "mch-transfer", "batches", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionInsuranceMerchantTransferBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/insurance/mch-transfer/batches/out-batch-no/{out_batch_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504221 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionInsuranceMerchantTransferBatchByOutBatchNumberResponse> ExecuteGetPlatformSolutionInsuranceMerchantTransferBatchByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionInsuranceMerchantTransferBatchByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "insurance", "mch-transfer", "batches", "out-batch-no", request.OutBatchNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail ? "true" : "false")
                .SetQueryParam("detail_state", request.DetailState)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionInsuranceMerchantTransferBatchByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/insurance/mch-transfer/batches/batch-id/{batch_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504223 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionInsuranceMerchantTransferBatchByBatchIdResponse> ExecuteGetPlatformSolutionInsuranceMerchantTransferBatchByBatchIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionInsuranceMerchantTransferBatchByBatchIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "insurance", "mch-transfer", "batches", "batch-id", request.BatchId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail ? "true" : "false")
                .SetQueryParam("detail_state", request.DetailState)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionInsuranceMerchantTransferBatchByBatchIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/insurance/mch-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504222 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumberResponse> ExecuteGetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "insurance", "mch-transfer", "batches", "out-batch-no", request.OutBatchNumber, "details", "out-detail-no", request.OutDetailNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/insurance/mch-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504224 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionInsuranceMerchantTransferBatchDetailByDetailIdResponse> ExecuteGetPlatformSolutionInsuranceMerchantTransferBatchDetailByDetailIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionInsuranceMerchantTransferBatchDetailByDetailIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "insurance", "mch-transfer", "batches", "out-batch-no", request.BatchId, "details", "detail-id", request.DetailId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionInsuranceMerchantTransferBatchDetailByDetailIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/insurance/mch-transfer/reservation/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504216 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyPlatformSolutionInsuranceMerchantTransferReservationResponse> ExecuteApplyPlatformSolutionInsuranceMerchantTransferReservationAsync(this WechatTenpayClient client, Models.ApplyPlatformSolutionInsuranceMerchantTransferReservationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "insurance", "mch-transfer", "reservation", "apply");

            return await client.SendFlurlRequestAsJsonAsync<Models.ApplyPlatformSolutionInsuranceMerchantTransferReservationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/insurance/mch-transfer/reservation/out-reservation-no/{out_reservation_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504218 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionInsuranceMerchantTransferReservationByOutReservationNumberResponse> ExecuteGetPlatformSolutionInsuranceMerchantTransferReservationByOutReservationNumberAsync(this WechatTenpayClient client, Models.GetPlatformSolutionInsuranceMerchantTransferReservationByOutReservationNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "insurance", "mch-transfer", "reservation", "out-reservation-no", request.OutReservationNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionInsuranceMerchantTransferReservationByOutReservationNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /platsolution/insurance/mch-transfer/reservation/reservation-id/{reservation_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504217 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPlatformSolutionInsuranceMerchantTransferReservationByReservationIdResponse> ExecuteGetPlatformSolutionInsuranceMerchantTransferReservationByReservationIdAsync(this WechatTenpayClient client, Models.GetPlatformSolutionInsuranceMerchantTransferReservationByReservationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "platsolution", "insurance", "mch-transfer", "reservation", "reservation-id", request.ReservationId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPlatformSolutionInsuranceMerchantTransferReservationByReservationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /platsolution/insurance/mch-transfer/reservation/out-reservation-no/{out_reservation_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013504219 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePlatformSolutionInsuranceMerchantTransferReservationResponse> ExecuteClosePlatformSolutionInsuranceMerchantTransferReservationAsync(this WechatTenpayClient client, Models.ClosePlatformSolutionInsuranceMerchantTransferReservationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "platsolution", "insurance", "mch-transfer", "reservation", "out-reservation-no", request.OutReservationNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.ClosePlatformSolutionInsuranceMerchantTransferReservationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
