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
        /// <para>异步调用 [POST] /pay/micropay 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_10&index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_10&index=1 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/danpin.php?chapter=9_101&index=1 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pay", "micropay");

            return await client.SendRequestWithXmlAsync<Models.CreatePayMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/orderquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_02 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_2&index=4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_2&index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_02 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_2&index=4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_2&index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_2 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pay", "orderquery");

            return await client.SendRequestWithXmlAsync<Models.GetPayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_11&index=3 </para>
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
                .CreateRequest(request, HttpMethod.Post, "secapi", "pay", "reverse");

            return await client.SendRequestWithXmlAsync<Models.ReversePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/closeorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_3&index=5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_3&index=3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_3&index=5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_3&index=3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_3 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pay", "closeorder");

            return await client.SendRequestWithXmlAsync<Models.ClosePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/refund 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_4&index=6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_4&index=4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_4&index=6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_4&index=4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_4 </para>
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
                .CreateRequest(request, HttpMethod.Post, "secapi", "pay", "refund");

            return await client.SendRequestWithXmlAsync<Models.CreatePayRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/refundquery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_5&index=7 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_5&index=5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_5&index=7 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_5&index=5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_5 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pay", "refundquery");

            return await client.SendRequestWithXmlAsync<Models.GetPayRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
