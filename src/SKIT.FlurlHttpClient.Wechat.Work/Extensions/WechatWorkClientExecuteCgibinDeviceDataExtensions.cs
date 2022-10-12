using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinDeviceDataExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/get_auth_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96097 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataGetAuthInfoResponse> ExecuteCgibinDeviceDataGetAuthInfoAsync(this WechatWorkClient client, Models.CgibinDeviceDataGetAuthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "get_auth_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataGetAuthInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/get_checkin_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96027 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataGetCheckinDataResponse> ExecuteCgibinDeviceDataGetCheckinDataAsync(this WechatWorkClient client, Models.CgibinDeviceDataGetCheckinDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "get_checkin_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataGetCheckinDataResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/get_temperature_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96028 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataGetTemperatureDataResponse> ExecuteCgibinDeviceDataGetTemperatureDataAsync(this WechatWorkClient client, Models.CgibinDeviceDataGetTemperatureDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "get_temperature_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataGetTemperatureDataResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/get_accesscontrol_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96029 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataGetAccessControlDataResponse> ExecuteCgibinDeviceDataGetAccessControlDataAsync(this WechatWorkClient client, Models.CgibinDeviceDataGetAccessControlDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "get_accesscontrol_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataGetAccessControlDataResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        #region AccessControlRule
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/get_accesscontrol_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96030 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataGetAccessControlRuleResponse> ExecuteCgibinDeviceDataGetAccessControlRuleAsync(this WechatWorkClient client, Models.CgibinDeviceDataGetAccessControlRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "get_accesscontrol_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataGetAccessControlRuleResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/add_accesscontrol_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96031 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataAddAccessControlRuleResponse> ExecuteCgibinDeviceDataAddAccessControlRuleAsync(this WechatWorkClient client, Models.CgibinDeviceDataAddAccessControlRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "add_accesscontrol_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataAddAccessControlRuleResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/mod_accesscontrol_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96221 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataModifyAccessControlRuleResponse> ExecuteCgibinDeviceDataModifyAccessControlRuleAsync(this WechatWorkClient client, Models.CgibinDeviceDataModifyAccessControlRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "mod_accesscontrol_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataModifyAccessControlRuleResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/devicedata/del_accesscontrol_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96227 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDeviceDataDeleteAccessControlRuleResponse> ExecuteCgibinDeviceDataDeleteAccessControlRuleAsync(this WechatWorkClient client, Models.CgibinDeviceDataDeleteAccessControlRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "devicedata", "del_accesscontrol_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDeviceDataDeleteAccessControlRuleResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
