﻿using System;
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
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_14&index=8 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_8&index=9 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_8&index=9 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_8&index=10 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5.php?chapter=9_8&index=9 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_8&index=9 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay_sl.php?chapter=9_14&index=7 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=9_8 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/native_sl.php?chapter=9_8 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_8&index=10 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/H5_sl.php?chapter=9_8&index=9 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=9_8&index=9 </para>
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
                .CreateRequest(request, HttpMethod.Post, "payitil", "report");

            return await client.SendRequestWithXmlAsync<Models.SubmitPayITILReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
