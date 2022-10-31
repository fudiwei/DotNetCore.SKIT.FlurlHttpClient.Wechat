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
                .SetQueryParam("access_token", request.ProviderAccessToken);

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
                .SetQueryParam("access_token", request.ProviderAccessToken);

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
                .SetQueryParam("access_token", request.ProviderAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLicenseGetAutoActiveStatusResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
