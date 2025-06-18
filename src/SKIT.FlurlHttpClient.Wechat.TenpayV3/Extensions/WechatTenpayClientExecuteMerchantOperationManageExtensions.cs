using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantOperationManageExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /mch-operation-manage/merchant-limitations/sub-mchid/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012803072 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantOperationManageMerchantLimitationsBySubMerchantIdResponse> ExecuteGetMerchantOperationManageMerchantLimitationsBySubMerchantIdAsync(this WechatTenpayClient client, Models.GetMerchantOperationManageMerchantLimitationsBySubMerchantIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mch-operation-manage", "merchant-limitations", "sub-mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantOperationManageMerchantLimitationsBySubMerchantIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
