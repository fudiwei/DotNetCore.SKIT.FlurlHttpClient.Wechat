using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteMerchantCustomsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/mch/customs/customdeclareorder 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/external/declarecustom.php?chapter=18_1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantCustomsCustomDeclarationResponse> ExecuteCreateMerchantCustomsCustomDeclarationAsync(this WechatTenpayClient client, Models.CreateMerchantCustomsCustomDeclarationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "mch", "customs", "customdeclareorder");

            return await client.SendRequestWithXmlAsync<Models.CreateMerchantCustomsCustomDeclarationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/mch/customs/customdeclarequery 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/external/declarecustom.php?chapter=18_2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantCustomsCustomDeclarationResponse> ExecuteQueryMerchantCustomsCustomDeclarationAsync(this WechatTenpayClient client, Models.QueryMerchantCustomsCustomDeclarationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "mch", "customs", "customdeclarequery");

            return await client.SendRequestWithXmlAsync<Models.QueryMerchantCustomsCustomDeclarationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/mch/customs/customdeclareredeclare 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/external/declarecustom.php?chapter=18_4&amp;index=3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RedeclareMerchantCustomsCustomDeclarationResponse> ExecuteRedeclareMerchantCustomsCustomDeclarationAsync(this WechatTenpayClient client, Models.RedeclareMerchantCustomsCustomDeclarationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "mch", "customs", "customdeclareredeclare");

            return await client.SendRequestWithXmlAsync<Models.RedeclareMerchantCustomsCustomDeclarationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
