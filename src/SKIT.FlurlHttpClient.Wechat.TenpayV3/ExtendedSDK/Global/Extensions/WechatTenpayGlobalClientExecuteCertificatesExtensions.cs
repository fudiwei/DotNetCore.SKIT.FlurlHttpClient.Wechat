using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientExecuteCertificatesExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /certificates 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_1_8.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/QuickPay/chapter8_7.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/In-AppPay/chapter8_7.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/H5Payment/chapter8_7.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/OfficialPayMent/chapter8_7.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/MiniProgramPay/chapter8_7.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/fusion_wallet/NativePay/chapter8_7.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCertificatesResponse> ExecuteQueryCertificatesAsync(this WechatTenpayGlobalClient client, Models.QueryCertificatesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "certificates");

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryCertificatesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
