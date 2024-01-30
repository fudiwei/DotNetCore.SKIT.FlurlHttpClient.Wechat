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
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_992 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "partnerpay", "notification");

            return await client.SendFlurlRequestAsXmlAsync<Models.NotifyVehiclePartnerPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /vehicle/partnerpay/payapply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_982 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "partnerpay", "payapply");

            return await client.SendFlurlRequestAsXmlAsync<Models.ApplyVehiclePartnerPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /vehicle/partnerpay/querystate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_93 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "partnerpay", "querystate");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetVehiclePartnerPayStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /transit/partnerpay/queryorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_96 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetTransitPartnerOrderResponse> ExecuteGetTransitPartnerOrderAsync(this WechatTenpayClient client, Models.GetTransitPartnerOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "transit", "partnerpay", "queryorder");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetTransitPartnerOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
