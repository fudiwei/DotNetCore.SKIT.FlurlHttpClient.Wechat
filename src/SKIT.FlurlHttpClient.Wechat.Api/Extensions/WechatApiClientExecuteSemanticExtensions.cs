using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteSemanticExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /semantic/semproxy/search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/Natural_Language_Processing.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/WeChat_Smart_APIs/Semantic_Understanding.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Website_App/WeChat_Smart_APIs/Semantic_Understanding.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SemanticSemproxySearchResponse<TDetail>> ExecuteSemanticSemproxySearchAsync<TDetail>(this WechatApiClient client, Models.SemanticSemproxySearchRequest request, CancellationToken cancellationToken = default)
            where TDetail : Models.SemanticSemproxySearchResponse.Types.IDetail
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "semantic", "semproxy", "search")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.SemanticSemproxySearchResponse<TDetail>>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
