using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayMarketingTransfersExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/promotion/transfers 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/mch_pay.php?chapter=14_2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayMarketingTransfersPromotionTransferResponse> ExecuteCreatePayMarketingTransfersPromotionTransferAsync(this WechatTenpayClient client, Models.CreatePayMarketingTransfersPromotionTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaymkttransfers", "promotion", "transfers");

            return await client.SendRequestWithXmlAsync<Models.CreatePayMarketingTransfersPromotionTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/gettransferinfo 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/mch_pay.php?chapter=14_3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayMarketingTransfersTransferInfoResponse> ExecuteGetPayMarketingTransfersTransferInfoAsync(this WechatTenpayClient client, Models.GetPayMarketingTransfersTransferInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaymkttransfers", "gettransferinfo");

            return await client.SendRequestWithXmlAsync<Models.GetPayMarketingTransfersTransferInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
