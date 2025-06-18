using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayDevicesExtensions
    {
        #region Printers
        /// <summary>
        /// <para>异步调用 [POST] /pay-devices/printers/{device_id}/print-orders 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayDevicePrinterPrintOrderResponse> ExecuteCreatePayDevicePrinterPrintOrderAsync(this WechatTenpayClient client, Models.CreatePayDevicePrinterPrintOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay-devices", "printers", request.DeviceId, "print-orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayDevicePrinterPrintOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /pay-devices/printers/{device_id}/print-orders/{print_order_no} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayDevicePrinterPrintOrderByPrintOrderNumberResponse> ExecuteGetPayDevicePrinterPrintOrderByPrintOrderNumberAsync(this WechatTenpayClient client, Models.GetPayDevicePrinterPrintOrderByPrintOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "pay-devices", "printers", request.DeviceId, "print-orders", request.PrintOrderNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayDevicePrinterPrintOrderByPrintOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
