using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayMarketingTransfersRedPackExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendredpack 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_4&index=3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=13_4&index=3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayMarketingTransfersRedPackResponse> ExecuteSendPayMarketingTransfersRedPackAsync(this WechatTenpayClient client, Models.SendPayMarketingTransfersRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaymkttransfers", "sendredpack");

            return await client.SendRequestWithXmlAsync<Models.SendPayMarketingTransfersRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendgroupredpack 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_5&index=4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=13_5&index=4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayMarketingTransfersGroupRedPackResponse> ExecuteSendPayMarketingTransfersGroupRedPackAsync(this WechatTenpayClient client, Models.SendPayMarketingTransfersGroupRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaymkttransfers", "sendgroupredpack");

            return await client.SendRequestWithXmlAsync<Models.SendPayMarketingTransfersGroupRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/gethbinfo 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_6&index=5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=13_6&index=5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayMarketingTransfersRedPackInfoResponse> ExecuteGetPayMarketingTransfersRedPackInfoAsync(this WechatTenpayClient client, Models.GetPayMarketingTransfersRedPackInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mmpaymkttransfers", "gethbinfo");

            return await client.SendRequestWithXmlAsync<Models.GetPayMarketingTransfersRedPackInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
