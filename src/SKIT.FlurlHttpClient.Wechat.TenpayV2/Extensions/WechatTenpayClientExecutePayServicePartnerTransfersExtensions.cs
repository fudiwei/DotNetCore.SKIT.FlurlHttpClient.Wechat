using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayServicePartnerTransfersExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mmpaysptrans/pay_bank 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/mch_pay_yhk.php?chapter=24_2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayServicePartnerTransfersPayToBankResponse> ExecuteCreatePayServicePartnerTransfersPayToBankAsync(this WechatTenpayClient client, Models.CreatePayServicePartnerTransfersPayToBankRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaysptrans", "pay_bank");

            return await client.SendRequestWithXmlAsync<Models.CreatePayServicePartnerTransfersPayToBankResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaysptrans/query_bank 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/mch_pay_yhk.php?chapter=24_3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayServicePartnerTransfersPayToBankInfoResponse> ExecuteGetPayServicePartnerTransfersPayToBankInfoAsync(this WechatTenpayClient client, Models.GetPayServicePartnerTransfersPayToBankInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaysptrans", "query_bank");

            return await client.SendRequestWithXmlAsync<Models.GetPayServicePartnerTransfersPayToBankInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
