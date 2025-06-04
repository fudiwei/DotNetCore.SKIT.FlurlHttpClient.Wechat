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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935214 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936530 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936987 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937163 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011940985 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011936644 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989255 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941377 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011939925 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983228 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983265 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634944 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634982 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635193 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635476 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636595 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayUnifiedOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/micropay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937125 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012382179 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983208 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634893 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayMicroPayResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/orderquery 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937320 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935215 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936582 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937343 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937309 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011941128 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011987538 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011985194 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4012202507 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011936645 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989256 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941754 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011939979 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983277 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989909 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988210 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988377 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014113946 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634899 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634947 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634994 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635198 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636476 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636597 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937361 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4012218602 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634900 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.ReversePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/closeorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935216 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936618 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937627 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937390 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011941206 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011987803 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011936646 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989257 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011960250 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011940962 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011984036 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988383 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634951 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634995 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635199 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636477 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636602 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.ClosePayOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/refund 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937624 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935217 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936911 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939427 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937424 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011941262 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011987741 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011985095 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941447 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011936647 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989258 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011973419 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011973419 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941178 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011984092 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989907 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988208 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988381 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634906 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634956 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634996 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635201 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636484 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636606 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/refundquery 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939577 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935218 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936961 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939583 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937471 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011941316 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011987766 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011985140 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941513 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011936648 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989259 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011981589 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941264 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011984212 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989908 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988209 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988382 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634907 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634959 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634997 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635267 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636487 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636607 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/pay/refundv2 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983308 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/refundqueryv2 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011984122 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayRefundV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Bill
        /// <summary>
        /// <para>异步调用 [POST] /pay/downloadbill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939627 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935219 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011936993 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939651 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937545 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011941399 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011987833 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011985040 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011985427 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941628 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011936649 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989260 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983298 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941283 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011984262 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011989905 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988206 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988384 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634911 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634960 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634998 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635218 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636490 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636609 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.DownloadPayBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pay/downloadfundflow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939779 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011935220 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937075 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011939788 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011941526 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4012181559 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014314653 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014314700 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014314705 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014314708 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014314714 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4014314714 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.DownloadPayFundFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Settlement
        /// <summary>
        /// <para>异步调用 [POST] /pay/settlementquery 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634920 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634970 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635002 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635261 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636497 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636618 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPaySettlementResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ExchangeRate
        /// <summary>
        /// <para>异步调用 [POST] /pay/queryexchagerate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634922 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634972 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635003 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635266 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636500 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636620 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayExchangeRateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
