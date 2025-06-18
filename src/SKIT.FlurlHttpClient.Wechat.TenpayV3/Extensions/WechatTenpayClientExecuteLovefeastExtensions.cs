using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteLovefeastExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /lovefeast/brands/{brand_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/lovefeast/brands/get-brand.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetLovefeastBrandByBrandIdResponse> ExecuteGetLovefeastBrandByBrandIdAsync(this WechatTenpayClient client, Models.GetLovefeastBrandByBrandIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "lovefeast", "brands", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetLovefeastBrandByBrandIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
