using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteTcbExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /tcb/adddelayedfunctiontask 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.addDelayedFunctionTask.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbAddDelayedFunctionTaskResponse> ExecuteTcbAddDelayedFunctionTaskAsync(this WechatApiClient client, Models.TcbAddDelayedFunctionTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "adddelayedfunctiontask")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbAddDelayedFunctionTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/createpressuretesttask 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.createPressureTest.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbCreatePressureTestTaskResponse> ExecuteTcbCreatePressureTestTaskAsync(this WechatApiClient client, Models.TcbCreatePressureTestTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "createpressuretesttask")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbCreatePressureTestTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/createsendsmstask 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.createSendSmsTask.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.createSendSmsTask.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbCreateSendSmsTaskResponse> ExecuteTcbCreateSendSmsTaskAsync(this WechatApiClient client, Models.TcbCreateSendSmsTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "createsendsmstask")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbCreateSendSmsTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/describeextensionuploadinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.describeExtensionUploadInfo.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.describeExtensionUploadInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbDescribeExtensionUploadInfoResponse> ExecuteTcbDescribeExtensionUploadInfoAsync(this WechatApiClient client, Models.TcbDescribeExtensionUploadInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "describeextensionuploadinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbDescribeExtensionUploadInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/describesmsrecords 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.describeSmsRecords.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.describeSmsRecords.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbDescribeSmsRecordsResponse> ExecuteTcbDescribeSmsRecordsAsync(this WechatApiClient client, Models.TcbDescribeSmsRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "describesmsrecords")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbDescribeSmsRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getopendata 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.getOpenData.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetOpenDataResponse> ExecuteTcbGetOpenDataAsync(this WechatApiClient client, Models.TcbGetOpenDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getopendata")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.TcbGetOpenDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getpressuretestreport 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.getPressureTestReport.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetPressureTestReportResponse> ExecuteTcbGetPressureTestReportAsync(this WechatApiClient client, Models.TcbGetPressureTestReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getpressuretestreport")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetPressureTestReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getpressureteststatus 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.getPressureTestStatus.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetPressureTestStatusResponse> ExecuteTcbGetPressureTestStatusAsync(this WechatApiClient client, Models.TcbGetPressureTestStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getpressureteststatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetPressureTestStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getstatistics 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.getStatistics.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.getStatistics.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetStatisticsResponse> ExecuteTcbGetStatisticsAsync(this WechatApiClient client, Models.TcbGetStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getstatistics")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getvoipsign 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.getVoIPSign.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetVoIPSignResponse> ExecuteTcbGetVoIPSignAsync(this WechatApiClient client, Models.TcbGetVoIPSignRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.Nonce))
                request.Nonce = Guid.NewGuid().ToString("N");

            if (!request.Timestamp.HasValue)
                request.Timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getvoipsign")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.TcbGetVoIPSignResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/cloudbasereport 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.report.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.report.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbCloudBaseReportResponse> ExecuteTcbCloudBaseReportAsync(this WechatApiClient client, Models.TcbCloudBaseReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "cloudbasereport")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbCloudBaseReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/sendsms 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.sendSms.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.sendSms.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbSendSmsResponse> ExecuteTcbSendSmsAsync(this WechatApiClient client, Models.TcbSendSmsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "sendsms")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbSendSmsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/sendsmsv2 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/cloudbase/cloudbase.sendSmsV2.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/cloudbase/cloudbase.sendSmsV2.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbSendSmsV2Response> ExecuteTcbSendSmsV2Async(this WechatApiClient client, Models.TcbSendSmsV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "sendsmsv2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbSendSmsV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ThirdPartyPlatforms
        /// <summary>
        /// <para>异步调用 [POST] /tcb/createclouduser 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/creatCloudUser.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbCreateCloudUserResponse> ExecuteTcbCreateCloudUserAsync(this WechatApiClient client, Models.TcbCreateCloudUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "createclouduser")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbCreateCloudUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getenvinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/getEnvInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetEnvironmentInfoResponse> ExecuteTcbGetEnvironmentInfoAsync(this WechatApiClient client, Models.TcbGetEnvironmentInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getenvinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetEnvironmentInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/createenvandresource 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/createEnvAndResource.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbCreateEnvironmentAndResourceResponse> ExecuteTcbCreateEnvironmentAndResourceAsync(this WechatApiClient client, Models.TcbCreateEnvironmentAndResourceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "createenvandresource")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbCreateEnvironmentAndResourceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/modifyenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/modifyEnv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbModifyEnvironmentResponse> ExecuteTcbModifyEnvironmentAsync(this WechatApiClient client, Models.TcbModifyEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "modifyenv")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbModifyEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/shareenv 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/shareenv.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbShareEnvironmentResponse> ExecuteTcbShareEnvironmentAsync(this WechatApiClient client, Models.TcbShareEnvironmentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "shareenv")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbShareEnvironmentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/usecloudaccesstoken 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/usecloudaccesstoken.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbUseCloudAccessTokenResponse> ExecuteTcbUseCloudAccessTokenAsync(this WechatApiClient client, Models.TcbUseCloudAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "usecloudaccesstoken")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbUseCloudAccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/uploadappconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/uploadAppConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbUploadAppConfigResponse> ExecuteTcbUploadAppConfigAsync(this WechatApiClient client, Models.TcbUploadAppConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "uploadappconfig")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbUploadAppConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getappconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/getAppConfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetAppConfigResponse> ExecuteTcbGetAppConfigAsync(this WechatApiClient client, Models.TcbGetAppConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getappconfig")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetAppConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/setcallbackconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/setcallbackconfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbSetCallbackConfigResponse> ExecuteTcbSetCallbackConfigAsync(this WechatApiClient client, Models.TcbSetCallbackConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "setcallbackconfig")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbSetCallbackConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getcallbackconfig 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/getcallbackconfig.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetCallbackConfigResponse> ExecuteTcbGetCallbackConfigAsync(this WechatApiClient client, Models.TcbGetCallbackConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getcallbackconfig")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetCallbackConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/getqcloudtoken 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/getqcloudtoken.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbGetQCloudTokenResponse> ExecuteTcbGetQCloudTokenAsync(this WechatApiClient client, Models.TcbGetQCloudTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "getqcloudtoken")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbGetQCloudTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/wxpaylist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/wxpaylist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbWxpayListResponse> ExecuteTcbWxpayListAsync(this WechatApiClient client, Models.TcbWxpayListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "wxpaylist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbWxpayListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /tcb/wxpayopenauth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/cloudbase/common/wxpayopenauth.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TcbWxpayOpenAuthResponse> ExecuteTcbWxpayOpenAuthAsync(this WechatApiClient client, Models.TcbWxpayOpenAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "tcb", "wxpayopenauth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.TcbWxpayOpenAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
