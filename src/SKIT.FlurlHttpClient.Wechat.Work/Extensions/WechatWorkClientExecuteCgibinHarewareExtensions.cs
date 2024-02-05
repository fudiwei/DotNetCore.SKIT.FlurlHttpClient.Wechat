using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinHarewareExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/hardware/get_device_feature 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92739 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHardwareGetDeviceFeatureResponse> ExecuteCgibinHardwareGetDeviceFeatureAsync(this WechatWorkClient client, Models.CgibinHardwareGetDeviceFeatureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "hardware", "get_device_feature")
                .SetQueryParam("provider_access_token", request.ProviderAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinHardwareGetDeviceFeatureResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/hardware/get_hardware_checkin_data 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/94126 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95176 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHardwareGetHardwareCheckinDataResponse> ExecuteCgibinHardwareGetHardwareCheckinDataAsync(this WechatWorkClient client, Models.CgibinHardwareGetHardwareCheckinDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "hardware", "get_hardware_checkin_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinHardwareGetHardwareCheckinDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
