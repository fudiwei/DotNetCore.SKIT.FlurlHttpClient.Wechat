using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinOpenHardwareExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/get_model_token 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95992 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareGetModelTokenResponse> ExecuteCgibinOpenHardwareGetModelTokenAsync(this WechatWorkClient client, Models.CgibinOpenHardwareGetModelTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ModelId == null)
                request.ModelId = client.Credentials.ModelId;

            if (request.ModelSecret == null)
                request.ModelSecret = client.Credentials.ModelSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "get_model_token");

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareGetModelTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/get_device_secret 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95993 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareGetDeviceSecretResponse> ExecuteCgibinOpenHardwareGetDeviceSecretAsync(this WechatWorkClient client, Models.CgibinOpenHardwareGetDeviceSecretRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "get_device_secret")
                .SetQueryParam("model_access_token", request.ModelAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareGetDeviceSecretResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/get_device_token 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96022 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareGetDeviceTokenResponse> ExecuteCgibinOpenHardwareGetDeviceTokenAsync(this WechatWorkClient client, Models.CgibinOpenHardwareGetDeviceTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "get_device_token")
                .SetQueryParam("model_access_token", request.ModelAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareGetDeviceTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Model
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/model/register_sn 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96022 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareModelRegisterSerialNumberResponse> ExecuteCgibinOpenHardwareModelRegisterSerialNumberAsync(this WechatWorkClient client, Models.CgibinOpenHardwareModelRegisterSerialNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "model", "register_sn")
                .SetQueryParam("model_access_token", request.ModelAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareModelRegisterSerialNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/model/unregister_sn 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95981 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareModelUnregisterSerialNumberResponse> ExecuteCgibinOpenHardwareModelUnregisterSerialNumberAsync(this WechatWorkClient client, Models.CgibinOpenHardwareModelUnregisterSerialNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "model", "unregister_sn")
                .SetQueryParam("model_access_token", request.ModelAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareModelUnregisterSerialNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Device
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/get_device_detail 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95982 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceGetDeviceDetailResponse> ExecuteCgibinOpenHardwareDeviceGetDeviceDetailAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceGetDeviceDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "get_device_detail")
                .SetQueryParam("model_access_token", request.ModelAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceGetDeviceDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_device_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95983 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportDeviceStatusResponse> ExecuteCgibinOpenHardwareDeviceReportDeviceStatusAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportDeviceStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_device_status")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportDeviceStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_firmware_upgrade_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95999 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportFirmwareUpgradeResultResponse> ExecuteCgibinOpenHardwareDeviceReportFirmwareUpgradeResultAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportFirmwareUpgradeResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_firmware_upgrade_result")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportFirmwareUpgradeResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_bio_info_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96000 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportBiometricInfoResultResponse> ExecuteCgibinOpenHardwareDeviceReportBiometricInfoResultAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportBiometricInfoResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_bio_info_result")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportBiometricInfoResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_remote_open_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96048 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportRemoteOpenResultResponse> ExecuteCgibinOpenHardwareDeviceReportRemoteOpenResultAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportRemoteOpenResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_remote_open_result")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportRemoteOpenResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/get_userinfo_by_page 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95999 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceGetUserInfoByPageResponse> ExecuteCgibinOpenHardwareDeviceGetUserInfoByPageAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceGetUserInfoByPageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "get_userinfo_by_page")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceGetUserInfoByPageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/get_userinfo_by_ids 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96037 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceGetUserInfoByIdsResponse> ExecuteCgibinOpenHardwareDeviceGetUserInfoByIdsAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceGetUserInfoByIdsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "get_userinfo_by_ids")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceGetUserInfoByIdsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region DeviceData
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_checkin_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95985 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportCheckinDataResponse> ExecuteCgibinOpenHardwareDeviceReportCheckinDataAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportCheckinDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_checkin_data")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportCheckinDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_temperature_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95986 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportTemperatureDataResponse> ExecuteCgibinOpenHardwareDeviceReportTemperatureDataAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportTemperatureDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_temperature_data")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportTemperatureDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openhw/device/report_access_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95997 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenHardwareDeviceReportAccessDataResponse> ExecuteCgibinOpenHardwareDeviceReportAccessDataAsync(this WechatWorkClient client, Models.CgibinOpenHardwareDeviceReportAccessDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "openhw", "device", "report_access_data")
                .SetQueryParam("device_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOpenHardwareDeviceReportAccessDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
