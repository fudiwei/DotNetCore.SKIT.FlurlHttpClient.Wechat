using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteProfitAllocationsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/profit-allocations 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E5%88%86%E8%B4%A6%E7%94%B3%E8%AF%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateProfitAllocationResponse> ExecuteCreateProfitAllocationAsync(this WechatTenpayBusinessClient client, Models.CreateProfitAllocationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.EnterpriseId == null)
                request.EnterpriseId = client.Credentials.EnterpriseId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "profit-allocations");

            return await client.SendRequestWithJsonAsync<Models.CreateProfitAllocationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/profit-allocations/finish 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E8%A7%A3%E5%86%BB%E5%89%A9%E4%BD%99%E8%B5%84%E9%87%91 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetProfitAllocationFinishedResponse> ExecuteSetProfitAllocationFinishedAsync(this WechatTenpayBusinessClient client, Models.SetProfitAllocationFinishedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.EnterpriseId == null)
                request.EnterpriseId = client.Credentials.EnterpriseId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "profit-allocations", "finish");

            return await client.SendRequestWithJsonAsync<Models.SetProfitAllocationFinishedResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/profit-allocations/{allocation_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E5%88%86%E8%B4%A6%E6%9F%A5%E8%AF%A2-%E5%86%85%E5%8D%95%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitAllocationByAllocationIdResponse> ExecuteGetProfitAllocationByAllocationIdAsync(this WechatTenpayBusinessClient client, Models.GetProfitAllocationByAllocationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "profit-allocations", request.AllocationId);

            return await client.SendRequestWithJsonAsync<Models.GetProfitAllocationByAllocationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/profit-allocations/out-allocation-id/{out_allocation_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E5%88%86%E8%B4%A6%E6%9F%A5%E8%AF%A2-%E5%A4%96%E5%8D%95%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitAllocationByOutAllocationIdResponse> ExecuteGetProfitAllocationByOutAllocationIdAsync(this WechatTenpayBusinessClient client, Models.GetProfitAllocationByOutAllocationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "profit-allocations", "out-allocation-id", request.OutAllocationId);

            return await client.SendRequestWithJsonAsync<Models.GetProfitAllocationByOutAllocationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/profit-allocations/{payment_id}/amounts 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E8%AE%A2%E5%8D%95%E5%89%A9%E4%BD%99%E5%BE%85%E5%88%86%E9%87%91%E9%A2%9D </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitAllocationAmountByPaymentIdResponse> ExecuteGetProfitAllocationAmountByPaymentIdAsync(this WechatTenpayBusinessClient client, Models.GetProfitAllocationAmountByPaymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "profit-allocations", request.PaymentId, "amounts");

            return await client.SendRequestWithJsonAsync<Models.GetProfitAllocationAmountByPaymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ReceiverAccount
        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/profit-allocations/receiver-accounts 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E5%88%86%E8%B4%A6%E6%8E%A5%E6%94%B6%E6%96%B9%E8%B4%A6%E6%88%B7%E6%9F%A5%E8%AF%A2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryProfitAllocationReceiverAccountsResponse> ExecuteQueryProfitAllocationReceiverAccountsAsync(this WechatTenpayBusinessClient client, Models.QueryProfitAllocationReceiverAccountsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.EnterpriseId == null)
                request.EnterpriseId = client.Credentials.EnterpriseId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "profit-allocations", "receiver-accounts")
                .SetQueryParam("ent_id", request.EnterpriseId);

            if (request.UnifiedSocialCreditCode != null)
                flurlReq.SetQueryParam("unified_social_credit_code", request.UnifiedSocialCreditCode);


            return await client.SendRequestWithJsonAsync<Models.QueryProfitAllocationReceiverAccountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/profit-allocations/receiver-accounts-applications 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%B7%BB%E5%8A%A0%E5%88%86%E8%B4%A6%E6%8E%A5%E6%94%B6%E6%96%B9%E8%B4%A6%E6%88%B7%E7%94%B3%E8%AF%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateProfitAllocationReceiverAccountApplicationResponse> ExecuteCreateProfitAllocationReceiverAccountApplicationAsync(this WechatTenpayBusinessClient client, Models.CreateProfitAllocationReceiverAccountApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.EnterpriseId == null)
                request.EnterpriseId = client.Credentials.EnterpriseId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "profit-allocations", "receiver-accounts-applications");

            return await client.SendRequestWithJsonAsync<Models.CreateProfitAllocationReceiverAccountApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/profit-allocations/receiver-accounts-applications/{application_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E6%B7%BB%E5%8A%A0%E5%88%86%E8%B4%A6%E6%8E%A5%E6%94%B6%E6%96%B9%E8%B4%A6%E6%88%B7%E7%94%B3%E8%AF%B7%E7%BB%93%E6%9E%9C-%E5%86%85%E5%8D%95%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitAllocationReceiverAccountApplicationByApplicationIdResponse> ExecuteGetProfitAllocationReceiverAccountApplicationByApplicationIdAsync(this WechatTenpayBusinessClient client, Models.GetProfitAllocationReceiverAccountApplicationByApplicationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "profit-allocations", "receiver-accounts-applications", request.ApplicationId);

            return await client.SendRequestWithJsonAsync<Models.GetProfitAllocationReceiverAccountApplicationByApplicationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/profit-allocations/receiver-accounts-applications/out_application_id/{out_application_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%9F%A5%E8%AF%A2%E6%B7%BB%E5%8A%A0%E5%88%86%E8%B4%A6%E6%8E%A5%E6%94%B6%E6%96%B9%E8%B4%A6%E6%88%B7%E7%94%B3%E8%AF%B7%E7%BB%93%E6%9E%9C-%E5%A4%96%E5%8D%95%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitAllocationReceiverAccountApplicationByOutApplicationIdResponse> ExecuteGetProfitAllocationReceiverAccountApplicationByOutApplicationIdAsync(this WechatTenpayBusinessClient client, Models.GetProfitAllocationReceiverAccountApplicationByOutApplicationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "profit-allocations", "receiver-accounts-applications", "out_application_id", request.OutApplicationId);

            return await client.SendRequestWithJsonAsync<Models.GetProfitAllocationReceiverAccountApplicationByOutApplicationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
