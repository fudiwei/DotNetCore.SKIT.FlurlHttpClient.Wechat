﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供扣款服务（直连商户）相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecutePAPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /papay/contracts/{contract_id}/notify 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_10.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotifyPAPPayContractsResponse> ExecuteNotifyPAPPayContractsAsync(this WechatTenpayClient client, Models.NotifyPAPPayContractsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "papay", "contracts", request.ContractId, "notify");

            return await client.SendRequestWithJsonAsync<Models.NotifyPAPPayContractsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
