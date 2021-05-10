using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供证书相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteCertificatesExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /certificates 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay5_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCertificatesResponse> ExecuteQueryCertificatesAsync(this WechatTenpayClient client, Models.QueryCertificatesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "certificates");

            return await client.SendRequestAsync<Models.QueryCertificatesResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
