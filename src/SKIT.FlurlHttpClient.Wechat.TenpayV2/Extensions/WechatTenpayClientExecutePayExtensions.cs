using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /pay/unifiedorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_10.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayUnifiedOrderResponse> ExecuteCreatePayUnifiedOrderAsync(this WechatTenpayClient client, Models.CreatePayUnifiedOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "unifiedorder");

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayUnifiedOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/micropay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_10 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_10 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/danpin.php?chapter=9_101 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayMicroPayResponse> ExecuteCreatePayMicroPayAsync(this WechatTenpayClient client, Models.CreatePayMicroPayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "micropay");

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/orderquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_02 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_02 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayOrderResponse> ExecuteGetPayOrderAsync(this WechatTenpayClient client, Models.GetPayOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "orderquery");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_11 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter3_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReversePayOrderResponse> ExecuteReversePayOrderAsync(this WechatTenpayClient client, Models.ReversePayOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "pay", "reverse");

            return await client.SendFlurlRequestAsXmlAsync<Models.ReversePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/closeorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter4_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_17.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ClosePayOrderResponse> ExecuteClosePayOrderAsync(this WechatTenpayClient client, Models.ClosePayOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "closeorder");

            return await client.SendFlurlRequestAsXmlAsync<Models.ClosePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/refund 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_13.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayRefundResponse> ExecuteCreatePayRefundAsync(this WechatTenpayClient client, Models.CreatePayRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "pay", "refund");

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/refundquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter4_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_14.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayRefundResponse> ExecuteGetPayRefundAsync(this WechatTenpayClient client, Models.GetPayRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "refundquery");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/refundv2 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/danpin.php?chapter=9_103 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayRefundV2Response> ExecuteCreatePayRefundV2Async(this WechatTenpayClient client, Models.CreatePayRefundV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "pay", "refundv2");

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/refundqueryv2 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/danpin.php?chapter=9_104 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayRefundV2Response> ExecuteGetPayRefundV2Async(this WechatTenpayClient client, Models.GetPayRefundV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "refundqueryv2");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Bill
        /// <summary>
        /// <para>异步调用 [POST] /pay/downloadbill 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_11.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=9_6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadPayBillResponse> ExecuteDownloadPayBillAsync(this WechatTenpayClient client, Models.DownloadPayBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "downloadbill");

            return await client.SendFlurlRequestAsXmlAsync<Models.DownloadPayBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/downloadfundflow 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_18 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_18 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_18 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_18 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_18 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_18 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadPayFundFlowResponse> ExecuteDownloadPayFundFlowAsync(this WechatTenpayClient client, Models.DownloadPayFundFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "downloadfundflow");

            return await client.SendFlurlRequestAsXmlAsync<Models.DownloadPayFundFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Settlement
        /// <summary>
        /// <para>异步调用 [POST] /pay/settlementquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPaySettlementResponse> ExecuteGetPaySettlementAsync(this WechatTenpayClient client, Models.GetPaySettlementRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "settlementquery");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPaySettlementResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ExchangeRate
        /// <summary>
        /// <para>异步调用 [POST] /pay/queryexchagerate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_10.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayExchangeRateResponse> ExecuteGetPayExchangeRateAsync(this WechatTenpayClient client, Models.GetPayExchangeRateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "queryexchagerate");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayExchangeRateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
