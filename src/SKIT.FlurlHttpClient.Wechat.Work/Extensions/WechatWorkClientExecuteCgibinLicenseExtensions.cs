using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinLicenseExtensions
    {
        #region Account
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/active_account 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95553 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseActiveAccountResponse> ExecuteCgibinLicenseActiveAccountAsync(this WechatWorkClient client, Models.CgibinLicenseActiveAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "active_account")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseActiveAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/batch_active_account 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95553 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseBatchActiveAccountResponse> ExecuteCgibinLicenseBatchActiveAccountAsync(this WechatWorkClient client, Models.CgibinLicenseBatchActiveAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "batch_active_account")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseBatchActiveAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/get_active_info_by_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95552 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseGetActiveInfoByCodeResponse> ExecuteCgibinLicenseGetActiveInfoByCodeAsync(this WechatWorkClient client, Models.CgibinLicenseGetActiveInfoByCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "get_active_info_by_code")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetActiveInfoByCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/batch_get_active_info_by_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95552 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseBatchGetActiveInfoByCodeResponse> ExecuteCgibinLicenseBatchGetActiveInfoByCodeAsync(this WechatWorkClient client, Models.CgibinLicenseBatchGetActiveInfoByCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "batch_get_active_info_by_code")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseBatchGetActiveInfoByCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/list_actived_account 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95544 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseListActivedAccountResponse> ExecuteCgibinLicenseListActivedAccountAsync(this WechatWorkClient client, Models.CgibinLicenseListActivedAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "list_actived_account")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseListActivedAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/get_active_info_by_user 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95555 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseGetActiveInfoByUserResponse> ExecuteCgibinLicenseGetActiveInfoByUserAsync(this WechatWorkClient client, Models.CgibinLicenseGetActiveInfoByUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "get_active_info_by_user")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetActiveInfoByUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/batch_transfer_license 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95673 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseBatchTransferLicenseResponse> ExecuteCgibinLicenseBatchTransferLicenseAsync(this WechatWorkClient client, Models.CgibinLicenseBatchTransferLicenseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "batch_transfer_license")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseBatchTransferLicenseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/batch_share_active_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96059 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseBatchShareActiveCodeResponse> ExecuteCgibinLicenseBatchShareActiveCodeAsync(this WechatWorkClient client, Models.CgibinLicenseBatchShareActiveCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "batch_share_active_code")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseBatchShareActiveCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region App
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/get_app_license_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95844 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseGetAppLicenseInfoResponse> ExecuteCgibinLicenseGetAppLicenseInfoAsync(this WechatWorkClient client, Models.CgibinLicenseGetAppLicenseInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.SuiteId == null)
                request.SuiteId = client.Credentials.SuiteId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "get_app_license_info")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetAppLicenseInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region AutoActive
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/set_auto_active_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95873 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseSetAutoActiveStatusResponse> ExecuteCgibinLicenseSetAutoActiveStatusAsync(this WechatWorkClient client, Models.CgibinLicenseSetAutoActiveStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "set_auto_active_status")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseSetAutoActiveStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/get_auto_active_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95874 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseGetAutoActiveStatusResponse> ExecuteCgibinLicenseGetAutoActiveStatusAsync(this WechatWorkClient client, Models.CgibinLicenseGetAutoActiveStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "get_auto_active_status")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetAutoActiveStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/create_new_order 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95644 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseCreateNewOrderResponse> ExecuteCgibinLicenseCreateNewOrderAsync(this WechatWorkClient client, Models.CgibinLicenseCreateNewOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "create_new_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCreateNewOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/create_renew_order_job 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95646 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseCreateRenewOrderJobResponse> ExecuteCgibinLicenseCreateRenewOrderJobAsync(this WechatWorkClient client, Models.CgibinLicenseCreateRenewOrderJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "create_renew_order_job")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCreateRenewOrderJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/list_order 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95647 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseListOrderResponse> ExecuteCgibinLicenseListOrderAsync(this WechatWorkClient client, Models.CgibinLicenseListOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "list_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseListOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/get_order 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95648 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseGetOrderResponse> ExecuteCgibinLicenseGetOrderAsync(this WechatWorkClient client, Models.CgibinLicenseGetOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "get_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/list_order_account 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95649 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseListOrderAccountResponse> ExecuteCgibinLicenseListOrderAccountAsync(this WechatWorkClient client, Models.CgibinLicenseListOrderAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "list_order_account")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseListOrderAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/cancel_order 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96106 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseCancelOrderResponse> ExecuteCgibinLicenseCancelOrderAsync(this WechatWorkClient client, Models.CgibinLicenseCancelOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "cancel_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCancelOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region OrderJob
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/create_new_order_job 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98892 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseCreateNewOrderJobResponse> ExecuteCgibinLicenseCreateNewOrderJobAsync(this WechatWorkClient client, Models.CgibinLicenseCreateNewOrderJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "create_new_order_job")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCreateNewOrderJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/submit_new_order_job 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98892 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseSubmitNewOrderJobResponse> ExecuteCgibinLicenseSubmitNewOrderJobAsync(this WechatWorkClient client, Models.CgibinLicenseSubmitNewOrderJobRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "submit_new_order_job")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseSubmitNewOrderJobResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/new_order_job_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98892 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseNewOrderJobResultResponse> ExecuteCgibinLicenseNewOrderJobResultAsync(this WechatWorkClient client, Models.CgibinLicenseNewOrderJobResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "new_order_job_result")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseNewOrderJobResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/get_union_order 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98893 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseGetUnionOrderResponse> ExecuteCgibinLicenseGetUnionOrderAsync(this WechatWorkClient client, Models.CgibinLicenseGetUnionOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "get_union_order")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetUnionOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/license/support_policy_query 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96515 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLicenseSupportPolicyQueryResponse> ExecuteCgibinLicenseSupportPolicyQueryAsync(this WechatWorkClient client, Models.CgibinLicenseSupportPolicyQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "license", "support_policy_query")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseSupportPolicyQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
