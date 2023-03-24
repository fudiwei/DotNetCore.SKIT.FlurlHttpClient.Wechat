using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteVehiclePartnerExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /vehicle/partnerpay/notification 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_992&amp;index=1&amp;p=202 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotifyVehiclePartnerPayResponse> ExecuteNotifyVehiclePartnerPayAsync(this WechatTenpayClient client, Models.NotifyVehiclePartnerPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "vehicle", "partnerpay", "notification");

            return await client.SendRequestWithXmlAsync<Models.NotifyVehiclePartnerPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /vehicle/partnerpay/payapply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_982&amp;index=2&amp;p=202 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyVehiclePartnerPayResponse> ExecuteApplyVehiclePartnerPayAsync(this WechatTenpayClient client, Models.ApplyVehiclePartnerPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "vehicle", "partnerpay", "payapply");

            return await client.SendRequestWithXmlAsync<Models.ApplyVehiclePartnerPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /vehicle/partnerpay/querystate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_93&amp;index=9&amp;p=202 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehiclePartnerPayStateResponse> ExecuteGetVehiclePartnerPayStateAsync(this WechatTenpayClient client, Models.GetVehiclePartnerPayStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "vehicle", "partnerpay", "querystate");

            return await client.SendRequestWithXmlAsync<Models.GetVehiclePartnerPayStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
