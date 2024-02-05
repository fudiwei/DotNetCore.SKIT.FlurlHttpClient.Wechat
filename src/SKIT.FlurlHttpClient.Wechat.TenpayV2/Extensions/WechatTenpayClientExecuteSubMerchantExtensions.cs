using System;
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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_24_2 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_24_3 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/xiaowei.php?chapter=20_2 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/xiaowei.php?chapter=20_3 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "mch", "addsubdevconfig");

            return await client.SendFlurlRequestAsXmlAsync<Models.AddSubMerchantDevelopConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/querysubdevconfig 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_25 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/xiaowei.php?chapter=20_4 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "mch", "querysubdevconfig");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetSubMerchantDevelopConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/mkt/addrecommendconf 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/xiaowei.php?chapter=20_0 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddSubMerchantMarketingRecommendConfigResponse> ExecuteAddSubMerchantMarketingRecommendConfigAsync(this WechatTenpayClient client, Models.AddSubMerchantMarketingRecommendConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "mkt", "addrecommendconf");

            return await client.SendFlurlRequestAsXmlAsync<Models.AddSubMerchantMarketingRecommendConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
