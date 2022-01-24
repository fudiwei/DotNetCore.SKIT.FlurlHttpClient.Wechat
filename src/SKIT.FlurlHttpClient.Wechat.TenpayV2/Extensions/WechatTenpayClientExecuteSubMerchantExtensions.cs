﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteSubMerchantExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/addsubdevconfig 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_24_2&index=1&p=901 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_24_3&index=2&p=901 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddSubMerchantDevelopConfigResponse> ExecuteAddSubMerchantDevelopConfigAsync(this WechatTenpayClient client, Models.AddSubMerchantDevelopConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "secapi", "mch", "addsubdevconfig");

            return await client.SendRequestWithXmlAsync<Models.AddSubMerchantDevelopConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/querysubdevconfig 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_25&index=3&p=901 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSubMerchantDevelopConfigResponse> ExecuteGetSubMerchantDevelopConfigAsync(this WechatTenpayClient client, Models.GetSubMerchantDevelopConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "secapi", "mch", "querysubdevconfig");

            return await client.SendRequestWithXmlAsync<Models.GetSubMerchantDevelopConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
