using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteIoTManageExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /iotmanage/devices 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/wxfacepay/develop/point/iotmanage-devices.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryIoTManageDevicesResponse> ExecuteQueryIoTManageDevicesAsync(this WechatTenpayClient client, Models.QueryIoTManageDevicesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "iotmanage", "devices");

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryIoTManageDevicesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
