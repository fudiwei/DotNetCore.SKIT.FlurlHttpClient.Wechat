using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供合单支付相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteCombineTransactionExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/app 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionAppResponse> ExecuteCreateCombineTransactionAppAsync(this WechatTenpayClient client, Models.CreateCombineTransactionAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.CombineMerchantId)) 
                request.CombineMerchantId = client.WechatMerchantId;

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (string.IsNullOrEmpty(subOrder.MerchantId))
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "combine-transactions", "app")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateCombineTransactionAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/jsapi 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionJsapiResponse> ExecuteCreateCombineTransactionJsapiAsync(this WechatTenpayClient client, Models.CreateCombineTransactionJsapiRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.CombineMerchantId))
                request.CombineMerchantId = client.WechatMerchantId;

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (string.IsNullOrEmpty(subOrder.MerchantId))
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "combine-transactions", "jsapi")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateCombineTransactionJsapiResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/h5 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionH5Response> ExecuteCreateCombineTransactionH5Async(this WechatTenpayClient client, Models.CreateCombineTransactionH5Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.CombineMerchantId))
                request.CombineMerchantId = client.WechatMerchantId;

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (string.IsNullOrEmpty(subOrder.MerchantId))
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "combine-transactions", "h5")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateCombineTransactionH5Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/native 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateCombineTransactionNativeResponse> ExecuteCreateCombineTransactionNativeAsync(this WechatTenpayClient client, Models.CreateCombineTransactionNativeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.CombineMerchantId))
                request.CombineMerchantId = client.WechatMerchantId;

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (string.IsNullOrEmpty(subOrder.MerchantId))
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "combine-transactions", "native")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateCombineTransactionNativeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /combine-transactions/out-trade-no/{combine_out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_11.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_11.shtml </para>
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
                .CreateRequest(HttpMethod.Get, "combine-transactions", "out-trade-no", request.CombineOutTradeNumber)
                .SetOptions(request);

            return await client.SendRequestAsync<Models.GetCombineTransactionByCombineOutTradeNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /combine-transactions/out-trade-no/{combine_out_trade_no}/close 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_12.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseCombineTransactionResponse> ExecuteCloseCombineTransactionAsync(this WechatTenpayClient client, Models.CloseCombineTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (string.IsNullOrEmpty(subOrder.MerchantId))
                        subOrder.MerchantId = client.WechatMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "combine-transactions", "out-trade-no", request.CombineOutTradeNumber, "close")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CloseCombineTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
