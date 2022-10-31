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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCreateNewOrderResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCreateRenewOrderJobResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseListOrderResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetOrderResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseListOrderAccountResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseCancelOrderResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetAppLicenseInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region App
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseSetAutoActiveStatusResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetAutoActiveStatusResponse>(flurlReq, cancellationToken: cancellationToken);
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

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseSupportPolicyQueryResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
