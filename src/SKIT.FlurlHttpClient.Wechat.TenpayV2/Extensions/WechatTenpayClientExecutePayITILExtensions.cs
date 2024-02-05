using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayITILExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /payitil/report 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_14 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_14 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_8 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/QuickPay/chapter8_8.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/NativePay/chapter8_8.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/MiniProgramPay/chapter8_8.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/OfficialPayMent/chapter8_8.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/In-AppPay/chapter8_8.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pay/H5Payment/chapter8_8.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SubmitPayITILReportResponse> ExecuteSubmitPayITILReportAsync(this WechatTenpayClient client, Models.SubmitPayITILReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "payitil", "report");

            return await client.SendFlurlRequestAsXmlAsync<Models.SubmitPayITILReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
