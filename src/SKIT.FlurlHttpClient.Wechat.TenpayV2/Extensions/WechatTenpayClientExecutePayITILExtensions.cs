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
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/401193996 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/401193522 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/401193718 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/401193993 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/401193942 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/401194165 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/401194168 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/401193665 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/401198926 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/401198411 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/401194135 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/401198440 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634924 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013634972 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635003 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013635266 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636502 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v2/zh/4013636622 ]]>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.SubmitPayITILReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
