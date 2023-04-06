using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteHirePowerBankExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /hire-power-bank/insurance-orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/hire-power-bank-insurance/insurance-orders/create-insurance-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateHirePowerBankInsuranceOrderResponse> ExecuteCreateHirePowerBankInsuranceOrderAsync(this WechatTenpayClient client, Models.CreateHirePowerBankInsuranceOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "hire-power-bank", "insurance-orders");

            return await client.SendRequestWithJsonAsync<Models.CreateHirePowerBankInsuranceOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /hire-power-bank/insurance-orders/{out_order_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/hire-power-bank-insurance/insurance-orders/get-by-out-trade-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHirePowerBankInsuranceOrderByOutOrderNumberResponse> ExecuteGetHirePowerBankInsuranceOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetHirePowerBankInsuranceOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "hire-power-bank", "insurance-orders", request.OutOrderNumber);

            return await client.SendRequestWithJsonAsync<Models.GetHirePowerBankInsuranceOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /hire-power-bank/user-qualifications/{openid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/hire-power-bank-insurance/insurance-orders/get-qualification-by-open-id.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHirePowerBankUserQualificationByOpenIdResponse> ExecuteGetHirePowerBankUserQualificationByOpenIdAsync(this WechatTenpayClient client, Models.GetHirePowerBankUserQualificationByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "hire-power-bank", "user-qualifications", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.GetHirePowerBankUserQualificationByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
