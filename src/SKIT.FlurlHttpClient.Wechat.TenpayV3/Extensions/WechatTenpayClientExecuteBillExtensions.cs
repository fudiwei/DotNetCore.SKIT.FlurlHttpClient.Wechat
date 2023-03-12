using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供账单相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteBillExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /bill/tradebill 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_17.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_17.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_9_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "bill", "tradebill")
                .SetQueryParam("bill_date", request.BillDateString);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.BillType != null)
                flurlReq.SetQueryParam("bill_type", request.BillType);

            if (request.TarType != null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendRequestWithJsonAsync<Models.GetBillTradeBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bill/fundflowbill 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_18.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_18.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_9_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "bill", "fundflowbill")
                .SetQueryParam("bill_date", request.BillDateString);

            if (request.AccountType != null)
                flurlReq.SetQueryParam("account_type", request.AccountType);

            if (request.TarType != null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendRequestWithJsonAsync<Models.GetBillFundflowBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /bill/sub-merchant-fundflowbill 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_20.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "bill", "sub-merchant-fundflowbill")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("algorithm", request.Algorithm);

            if (request.AccountType != null)
                flurlReq.SetQueryParam("account_type", request.AccountType);

            if (request.TarType != null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendRequestWithJsonAsync<Models.GetBillSubMerchantFundflowBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_19.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_19.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_9_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer/chapter4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter4_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl);

            return await client.SendRequestWithJsonAsync<Models.DownloadBillFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
