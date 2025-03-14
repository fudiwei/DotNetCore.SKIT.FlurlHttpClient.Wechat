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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012556692 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791866 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791887 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791907 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012810606 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013070395 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071227 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012739068 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759683 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759737 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760132 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760228 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760667 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080242 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080595 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012556748 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791867 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791888 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791908 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012810609 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013070400 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071235 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012739125 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759690 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012759741 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760136 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760229 ]]><br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760672 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080243 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080596 ]]> 
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012760249 ]]>
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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012085923 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012269010 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012289690 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791868 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791889 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791909 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012810615 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013070401 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071238 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012075366 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012076073 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012085421 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012085682 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012085803 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012085877 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012124894 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012231933 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080230 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080597 ]]>
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
