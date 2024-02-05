using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteVehicleExtensions
    {
        #region Parking
        /// <summary>
        /// <para>异步调用 [GET] /vehicle/parking/services/find 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/wexin-pay-score-parking/services/query-plate-service.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/wexin-pay-score-parking/services/query-plate-service.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehicleParkingServiceResponse> ExecuteGetVehicleParkingServiceAsync(this WechatTenpayClient client, Models.GetVehicleParkingServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "vehicle", "parking", "services", "find")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("plate_number", request.PlateNumber)
                .SetQueryParam("plate_color", request.PlateColor)
                .SetQueryParam("openid", request.OpenId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetVehicleParkingServiceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /vehicle/parking/parkings 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/wexin-pay-score-parking/parkings/create-parking.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/wexin-pay-score-parking/parkings/create-parking.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateVehicleParkingResponse> ExecuteCreateVehicleParkingAsync(this WechatTenpayClient client, Models.CreateVehicleParkingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "parking", "parkings");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateVehicleParkingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Transactions
        /// <summary>
        /// <para>异步调用 [POST] /vehicle/transactions/parking 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/wexin-pay-score-parking/transactions/create-transaction.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/wexin-pay-score-parking/transactions/create-transaction.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateVehicleTransactionParkingResponse> ExecuteCreateVehicleTransactionParkingAsync(this WechatTenpayClient client, Models.CreateVehicleTransactionParkingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "transactions", "parking");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateVehicleTransactionParkingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /vehicle/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/wexin-pay-score-parking/transactions/query-transaction.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/wexin-pay-score-parking/transactions/query-transaction.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehicleTransactionByOutTradeNumberResponse> ExecuteGetVehicleTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetVehicleTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "vehicle", "transactions", "out-trade-no", request.OutTradeNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetVehicleTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ETC
        /// <summary>
        /// <para>异步调用 [POST] /vehicle/etc/preopen 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PreopenVehicleETCResponse> ExecutePreopenVehicleETCAsync(this WechatTenpayClient client, Models.PreopenVehicleETCRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "etc", "preopen");

            return await client.SendFlurlRequestAsJsonAsync<Models.PreopenVehicleETCResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /vehicle/etc/transactions/highway 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_4_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateVehicleETCTransactionHighwayResponse> ExecuteCreateVehicleETCTransactionHighwayAsync(this WechatTenpayClient client, Models.CreateVehicleETCTransactionHighwayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "vehicle", "etc", "transactions", "highway");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateVehicleETCTransactionHighwayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /vehicle/etc/users/{openid}/contracts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_4_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehicleETCContractByOpenIdResponse> ExecuteGetVehicleETCContractByOpenIdAsync(this WechatTenpayClient client, Models.GetVehicleETCContractByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "vehicle", "etc", "users", request.OpenId, "contracts")
                .SetQueryParam("plan_id", request.PlanId)
                .SetQueryParam("plate_number", request.PlateNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetVehicleETCContractByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /vehicle/etc/contracts/{contract_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_4_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehicleETCContractByContractIdResponse> ExecuteGetVehicleETCContractByContractIdAsync(this WechatTenpayClient client, Models.GetVehicleETCContractByContractIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "vehicle", "etc", "contracts", request.ContractId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetVehicleETCContractByContractIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /vehicle/etc/transactions/out-trade-no/{out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_4_8.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehicleETCTransactionByOutTradeNumberResponse> ExecuteGetVehicleETCTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetVehicleETCTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "vehicle", "etc", "transactions", "out-trade-no", request.OutTradeNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetVehicleETCTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /vehicle/etc/transactions/id/{transaction_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter4_4_8.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetVehicleETCTransactionByTransactionIdResponse> ExecuteGetVehicleETCTransactionByTransactionIdAsync(this WechatTenpayClient client, Models.GetVehicleETCTransactionByTransactionIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "vehicle", "etc", "transactions", "id", request.TransactionId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetVehicleETCTransactionByTransactionIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
