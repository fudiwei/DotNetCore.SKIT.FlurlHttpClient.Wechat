using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBillExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /bill/tradebill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/native-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/bill-download/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/bill-download/trade-bill/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/bill-download/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/bill-download/trade-bill/get-trade-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-bill-download/get-trade-bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBillTradeBillResponse> ExecuteGetBillTradeBillAsync(this WechatTenpayClient client, Models.GetBillTradeBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bill", "tradebill")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("bill_type", request.BillType)
                .SetQueryParam("tar_type", request.TarType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBillTradeBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bill/fundflowbill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/native-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/bill-download/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/bill-download/fund-bill/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/bill-download/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/bill-download/fund-bill/get-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-bill-download/get-fund-bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBillFundflowBillResponse> ExecuteGetBillFundflowBillAsync(this WechatTenpayClient client, Models.GetBillFundflowBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bill", "fundflowbill")
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("tar_type", request.TarType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBillFundflowBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bill/sub-merchant-fundflowbill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/get-sub-mch-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/get-sub-mch-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/get-sub-mch-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/get-sub-mch-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/get-sub-mch-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/bill-download/get-sub-mch-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/bill-download/sub-mch-fund-flow-bill/get-sub-mch-fund-flow-bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBillSubMerchantFundflowBillResponse> ExecuteGetBillSubMerchantFundflowBillAsync(this WechatTenpayClient client, Models.GetBillSubMerchantFundflowBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "bill", "sub-merchant-fundflowbill")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("tar_type", request.TarType)
                .SetQueryParam("algorithm", request.Algorithm);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBillSubMerchantFundflowBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/h5-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/native-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/bill-download/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/bill-download/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/batch-transfer-to-balance/download-receipt.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-h5-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-native-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/bill-download/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/bill-download/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/bill-download/download-sub-merchant-fund-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/download-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/download-bill.html ]]>
        /// </para>
        /// <para><i>（请注意此接口不受构造 <see cref="WechatTenpayClient" /> 时指定的 <see cref="WechatTenpayClientOptions.Endpoint"/> 参数控制。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadBillFileResponse> ExecuteDownloadBillFileAsync(this WechatTenpayClient client, Models.DownloadBillFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl);

            return await client.SendFlurlRequestAsJsonAsync<Models.DownloadBillFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
