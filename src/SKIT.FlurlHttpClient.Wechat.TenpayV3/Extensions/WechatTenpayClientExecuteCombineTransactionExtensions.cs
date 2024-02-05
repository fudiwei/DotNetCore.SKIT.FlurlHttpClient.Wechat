using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteCombineTransactionExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/app 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/app-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/app-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/app-prepay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionAppResponse> ExecuteCreateCombineTransactionAppAsync(this WechatTenpayClient client, Models.CreateCombineTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId is null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "combine-transactions", "app");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateCombineTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/jsapi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/jsapi-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/mini-program-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/jsapi-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/mini-program-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/jsapi-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/mini-program-prepay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionJsapiResponse> ExecuteCreateCombineTransactionJsapiAsync(this WechatTenpayClient client, Models.CreateCombineTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId is null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "combine-transactions", "jsapi");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateCombineTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/h5 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/h5-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/h5-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/h5-prepay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionH5Response> ExecuteCreateCombineTransactionH5Async(this WechatTenpayClient client, Models.CreateCombineTransactionH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId is null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "combine-transactions", "h5");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateCombineTransactionH5Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/native 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/native-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/native-prepay.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/native-prepay.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionNativeResponse> ExecuteCreateCombineTransactionNativeAsync(this WechatTenpayClient client, Models.CreateCombineTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId is null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "combine-transactions", "native");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateCombineTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /combine-transactions/out-trade-no/{combine_out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/query-order.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/query-order.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/query-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetCombineTransactionByCombineOutTradeNumberResponse> ExecuteGetCombineTransactionByCombineOutTradeNumberAsync(this WechatTenpayClient client, Models.GetCombineTransactionByCombineOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "combine-transactions", "out-trade-no", request.CombineOutTradeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetCombineTransactionByCombineOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/out-trade-no/{combine_out_trade_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/close-order.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/close-order.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/close-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseCombineTransactionResponse> ExecuteCloseCombineTransactionAsync(this WechatTenpayClient client, Models.CloseCombineTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = client.Credentials.MerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "combine-transactions", "out-trade-no", request.CombineOutTradeNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.CloseCombineTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
